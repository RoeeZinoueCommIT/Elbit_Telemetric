#define TLM_MANAGE_PARAMS_C

/*DESCRIPTION--------------------------------------
|CSC Name: TLM
|Implements the Tlm_manage_params under uCOS and Windows.
-----------------------------------------------------*/

/* ----------------- */
/* Include file list */
/* ----------------- */

#include "stdafx.h"
#include "Tlm_manage_params.h"
#include "TLM_framer.h"

/* ------------------ */
/* Internal Constants */
/* ------------------ */


/* --------------- */
/* Internal Macros */
/* --------------- */

/* ------------------------------- */
/* Internal Data type declarations */
/* ------------------------------- */

/* ----------------------- */
/* Internal data variables */
/* ----------------------- */

extern unsigned short	g_TLM_timer;
extern DT_TLM_db		g_TLM_db;

char					g_TLM_temp_data[C_TLM_PACKET_SIZE];
unsigned char			g_TLM_temp_flags[C_TLM_NUM_FLAGS_BYTES];
			
unsigned short			g_TLM_flash_idx_wr = 0;					/* Flash write (bytes) counter */
unsigned int			g_TLM_flash_header_counter = 0;

unsigned short			g_TLM_current_idx_wr = 0;					/* Flash write (bytes) counter */
unsigned short			g_TLM_current_header_counter = 0;
/* --------------------------- */
/* Internal Methods prototypes */
/* --------------------------- */

static bool p_TLM_pack(DT_TLM_param_info* xi_param_info);
static bool p_TLM_store_at_flash(unsigned int xi_data_bytes);
static void p_TLM_compress_packet(void);
static bool p_TLM_update_current(unsigned int xi_packet_indx);

/* ---------------------- */
/* Methods implementation */
/* ---------------------- */

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall refresh TLM DB parameters.
\return         bool: true - function operation ok, otherwise false.
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
bool p_TLM_update_params(void)
{
	bool			ret = false;
	unsigned int	param_idx = 0;

	for (; param_idx < C_TLM_NUM_OF_PARAMS; param_idx++)
	{
		/* Check if parameter is exist and valid - If not skip. */
		if (g_TLM_db.tlm_info[param_idx].param_exist == TLM_PARMAM_EXIST_YES)
		{
			ret = p_TLM_pack(&g_TLM_db.tlm_info[param_idx]);

			if (true == ret)
			{
				if ((g_TLM_timer % g_TLM_db.tlm_info[param_idx].rate_level) == 0)
				{
					/* Check if we need to store the packet to Flash */
					if (g_TLM_db.tlm_info[param_idx].flash_store == TLM_FLASH_STORE_YES)
					{
						ret = p_TLM_store_at_flash(param_idx);
					}

					/* Check if the packet need to be in current value */
					if (g_TLM_db.tlm_info[param_idx].visuality == TLM_VISUAL_YES)
					{
						/* Get latest parameter value for each one */
						ret = p_TLM_update_current(param_idx);
					}
				}
			}
			if (ret == false)
			{
				break;
			}
		}
	}
	return (true);
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall get packed data and store it to current list.
				Store shape: [byte 0 - 2: 3 configuration bytes][bytes 3 - n: compress data]
\return         bool: true - function operation ok, otherwise false.
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
bool p_TLM_store_at_flash(unsigned int xi_packet_indx)
{
	bool ret = true;

	unsigned short num_real_byte = 0x0, new_packet_size = 0x0, shift_bytes_cnt = 0x0;
	unsigned int byte_idx = 0x0;

	num_real_byte = p_TLM_get_data(&g_TLM_temp_flags[2], TLM_BIT_FIELD_C_DATA_BYTE_IDX, TLM_BIT_FIELD_C_DATA_BYTE_LEN);
	new_packet_size = num_real_byte + C_TLM_NUM_FLAGS_BYTES;

	/* A. Check if there is room for new packet in FLASH queue, if no: push out most old packet from flash queue */
	if (new_packet_size < C_TLM_FLASH_MAX_DATA_BYTES)
	{
		if (new_packet_size >(C_TLM_FLASH_MAX_DATA_BYTES - g_TLM_flash_idx_wr))
		{
			/* Find old packets to remove to make space for new packet */
			do
			{
				shift_bytes_cnt += p_TLM_get_data(&g_TLM_db.tlm_flash_data_wr[shift_bytes_cnt + C_TLM_NUM_FLAGS_BYTES - 1], TLM_BIT_FIELD_C_DATA_BYTE_IDX, TLM_BIT_FIELD_C_DATA_BYTE_LEN);
				shift_bytes_cnt += C_TLM_NUM_FLAGS_BYTES;

				/* Update packet counter that we remove packet from Flash queue */
				g_TLM_flash_header_counter--;

			} while (shift_bytes_cnt < new_packet_size);

			for (; byte_idx < C_TLM_FLASH_MAX_DATA_BYTES - shift_bytes_cnt; byte_idx++)
			{
				g_TLM_db.tlm_flash_data_wr[byte_idx] = g_TLM_db.tlm_flash_data_wr[byte_idx + shift_bytes_cnt];
			}

			// Fill space till end of flash queue
			for (byte_idx = g_TLM_flash_idx_wr - shift_bytes_cnt; byte_idx < C_TLM_FLASH_MAX_DATA_BYTES; byte_idx++)
			{
				g_TLM_db.tlm_flash_data_wr[byte_idx] = NULL;
			}

			/* Update position of flash wr counter */
			g_TLM_flash_idx_wr -= (shift_bytes_cnt);


		}

		/* B. Write configuration bytes */
		memcpy(g_TLM_db.tlm_flash_data_wr + g_TLM_flash_idx_wr, g_TLM_temp_flags, C_TLM_NUM_FLAGS_BYTES * sizeof(char));


		/* C. Write data bytes to FLASH queue */
		memcpy(g_TLM_db.tlm_flash_data_wr + C_TLM_NUM_FLAGS_BYTES + g_TLM_flash_idx_wr, g_TLM_temp_data, num_real_byte * sizeof(char));

		/* D. Update flash header bytes (update number of bytes in flash) */
		g_TLM_flash_header_counter++;
		memcpy(g_TLM_db.tlm_flash_data_wr + C_TLM_FLASH_MAX_DATA_BYTES, &g_TLM_flash_header_counter, sizeof(g_TLM_flash_header_counter));

		/* E. update flash write counter */
		g_TLM_flash_idx_wr += new_packet_size;
	}
	else
	{
		ret = false;
	}

	return (ret);

}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall get packed data and store it to current list.
				Store shape: [byte 0 - 2: 3 configuration bytes][bytes 3 - n: compress data]
\return         bool: true - function operation ok, otherwise false.
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
bool p_TLM_update_current(unsigned int xi_packet_indx)
{
	bool ret = true;

	unsigned short num_real_byte = 0x0, new_packet_size = 0x0, shift_bytes_cnt = 0x0;
	unsigned int byte_idx = 0x0;

	num_real_byte = p_TLM_get_data(&g_TLM_temp_flags[2], TLM_BIT_FIELD_C_DATA_BYTE_IDX, TLM_BIT_FIELD_C_DATA_BYTE_LEN);
	new_packet_size = num_real_byte + C_TLM_NUM_FLAGS_BYTES;

	/* A. Check if there is room for new packet in Current data queue, if no: push out most old packet from Current data queue */
	if (new_packet_size < C_TLM_CURRENT_MAX_DATA_BYTES)
	{
		if (new_packet_size >(C_TLM_CURRENT_MAX_DATA_BYTES - g_TLM_current_idx_wr))
		{
			/* Find old packets to remove to make space for new packet */
			do
			{
				shift_bytes_cnt += p_TLM_get_data(&g_TLM_db.tlm_current_data[C_TLM_PACKET_HEADER_BYTES + shift_bytes_cnt + C_TLM_NUM_FLAGS_BYTES - 1], TLM_BIT_FIELD_C_DATA_BYTE_IDX, TLM_BIT_FIELD_C_DATA_BYTE_LEN);
				shift_bytes_cnt += C_TLM_NUM_FLAGS_BYTES;

				/* Update packet counter that we remove packet from Current data queue */
				g_TLM_current_header_counter--;

			} while (shift_bytes_cnt < new_packet_size);

			for (; byte_idx < C_TLM_CURRENT_MAX_DATA_BYTES - shift_bytes_cnt; byte_idx++)
			{
				g_TLM_db.tlm_current_data[C_TLM_PACKET_HEADER_BYTES + byte_idx] = g_TLM_db.tlm_current_data[C_TLM_PACKET_HEADER_BYTES + byte_idx + shift_bytes_cnt];
			}

			// Fill space till end of flash queue
			for (byte_idx = g_TLM_current_idx_wr - shift_bytes_cnt + C_TLM_PACKET_HEADER_BYTES; byte_idx < C_TLM_CURRENT_MAX_DATA_BYTES; byte_idx++)
			{
				g_TLM_db.tlm_current_data[byte_idx] = NULL;
			}

			/* Update position of flash wr counter */
			g_TLM_current_idx_wr -= (shift_bytes_cnt);
		}

		/* B. Update flash header bytes (update number of bytes in flash) */
		g_TLM_current_header_counter++;
		memcpy(g_TLM_db.tlm_current_data, &g_TLM_current_header_counter, sizeof(g_TLM_current_header_counter));

		/* C. Write configuration bytes */
		memcpy(g_TLM_db.tlm_current_data + C_TLM_PACKET_HEADER_BYTES + g_TLM_current_idx_wr, g_TLM_temp_flags, C_TLM_NUM_FLAGS_BYTES * sizeof(char));


		/* D. Write data bytes to FLASH queue */
		memcpy(g_TLM_db.tlm_current_data + C_TLM_PACKET_HEADER_BYTES + C_TLM_NUM_FLAGS_BYTES + g_TLM_current_idx_wr, g_TLM_temp_data, num_real_byte * sizeof(char));

		/* E. update flash write counter */
		g_TLM_current_idx_wr += new_packet_size;
	}
	else
	{
		ret = false;
	}

	return (ret);
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall pack TLM DB parameter in bytes.
\return         bool: true - function operation ok, false - input xi_param_info point to NULL address or 
                field xi_param_info->data_type not in his valid range.
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			DT_TLM_param_info* xi_param_info - TLM parameter info structure.
				range: Not NULL.
				bool flash_pack - If the packet should be compressed to flash.
				range: [true, false].
*/
/*--------------------------------------------------------------------------------------------------*/
bool p_TLM_pack(DT_TLM_param_info* xi_param_info)
{
	bool ret = false;


	memset(g_TLM_temp_flags, 0, sizeof(g_TLM_temp_flags));
	memset(g_TLM_temp_data, 0, sizeof(g_TLM_temp_data));

	/* Prepere first configuration flag */
	g_TLM_temp_flags[0] |= xi_param_info->param_exist << TLM_BIT_FIELD_A_EXIST_IDX;
	g_TLM_temp_flags[0] |= xi_param_info->group << TLM_BIT_FIELD_A_GROUP_IDX;
	g_TLM_temp_flags[0] |= xi_param_info->data_sign << TLM_BIT_FIELD_A_DATA_SIGN_IDX;

	/* Prepere Second configuration flag */
	g_TLM_temp_flags[1] |= xi_param_info->param_idx << TLM_BIT_FIELD_B_PARAM_IDX;
	g_TLM_temp_flags[1] |= xi_param_info->visuality << TLM_BIT_FIELD_B_VISUALITY_IDX;
	g_TLM_temp_flags[1] |= xi_param_info->flash_store << TLM_BIT_FIELD_B_FLASH_IDX;

	/* Prepere Third configuration flag */
	g_TLM_temp_flags[2] |= xi_param_info->data_type << TLM_BIT_FIELD_C_DATA_TYPE_IDX;

	if (xi_param_info->data_ptr != NULL)
	{
		switch (xi_param_info->data_type)
		{
			case TLM_DATA_INT1_INT8:
				memset(g_TLM_temp_data, 0, sizeof(g_TLM_temp_data));
				sprintf_s(g_TLM_temp_data, "%c", *(bool*)xi_param_info->data_ptr);
				break;

			case TLM_DATA_FLOAT_DOUBLE:
				memset(g_TLM_temp_data, 0, sizeof(g_TLM_temp_data));
				sprintf_s(g_TLM_temp_data, "%2.3f", *(float*)xi_param_info->data_ptr);
				break;

			case TLM_DATA_INT16:

				memset(g_TLM_temp_data, 0, sizeof(g_TLM_temp_data));

				if (xi_param_info->data_sign == TLM_DATA_SIGN)
				{
					sprintf_s(g_TLM_temp_data, "%3d", *(short*)xi_param_info->data_ptr);
				}
				else if (xi_param_info->data_sign == TLM_DATA_UNSIGN)
				{
					sprintf_s(g_TLM_temp_data, "%3d", *(unsigned short*)xi_param_info->data_ptr);
				}

				break;

			case TLM_DATA_INT32:

				memset(g_TLM_temp_data, 0, sizeof(g_TLM_temp_data));

				if (xi_param_info->data_sign == TLM_DATA_SIGN)
				{
					sprintf_s(g_TLM_temp_data, "%6d", *(int*)xi_param_info->data_ptr);
				}
				else if (xi_param_info->data_sign == TLM_DATA_UNSIGN)
				{
					sprintf_s(g_TLM_temp_data, "%6d", *(unsigned int*)xi_param_info->data_ptr);
				}
				
				break;

			case TLM_DATA_INT64:

				memset(g_TLM_temp_data, 0, sizeof(g_TLM_temp_data));
				
				if (xi_param_info->data_sign == TLM_DATA_SIGN)
				{
					sprintf_s(g_TLM_temp_data, "%12d", *(unsigned long long int*)xi_param_info->data_ptr);
				}
				else if (xi_param_info->data_sign == TLM_DATA_UNSIGN)
				{
					sprintf_s(g_TLM_temp_data, "%12d", *(long long int*)xi_param_info->data_ptr);
				}
				
				break;

			default:
				ret = false;
				break;
		}

		/* Compress packet */
		p_TLM_compress_packet();
		
		ret = true;
	}
	else
	{
		ret = false;
	}

	return (ret);
	
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall compress packet for Flash - Remove bytes that contain white spaces.
\return         Void.
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			Void.
*/
/*--------------------------------------------------------------------------------------------------*/
void p_TLM_compress_packet(void)
{
	unsigned short byte_idx = 0;

	/* Count real data byte (remove spaces) */
	while (g_TLM_temp_data[byte_idx++] != 0x00);
	g_TLM_temp_flags[2] |= (byte_idx - 1) << TLM_BIT_FIELD_C_DATA_BYTE_IDX;
}