#define VTU_FRAMER_C

/*DESCRIPTION--------------------------------------
|CSC Name: VTU
|Implements the VTU_framer under uCOS and Windows.
-----------------------------------------------------*/

/* ----------------- */
/* Include file list */
/* ----------------- */
#include<stdio.h>
#include<conio.h>

#include "stdafx.h"
#include "VTU_framer.h"
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
const char* group_names[] = { "PFD", "HKY" };
/* --------------------------- */
/* Internal Methods prototypes */
/* --------------------------- */

/* ---------------------- */
/* Methods implementation */
/* ---------------------- */



/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup VTU
\brief          This function shall read TLM data from flash.
\return         void
\FRSLinks       VTU_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
void p_VTU_tlm_read_flash(void)
{
	unsigned char*	p_read_array = NULL;
	unsigned short	members[C_TLM_PACKET_HEADER_BYTES];
	unsigned char	data[C_TLM_MAX_DATA_BYTE_IN_PARAM];
	unsigned char	flags[C_TLM_NUM_FLAGS_BYTES];

	unsigned short	data_type = 0x0, read_bytes = 0x0, data_bytes = 0x0, param_idx = 0x0, visual = 0x0;
	bool			flah_store = false;
	unsigned int	members_cnt = 0;
	unsigned int	group = 0x0;

	int				temp_int;
	float			temp_float;


	p_read_array = p_TLM_get_flash_data();
	memcpy(members, p_read_array + C_TLM_FLASH_MAX_DATA_BYTES, sizeof(members));
	
	if ((int)members[0] > 0)
	{
		for (; members_cnt < members[0]; members_cnt++)
		{
			/* Clear data container */
			memset(flags, 0, sizeof(flags));
			memset(data, 0, sizeof(data));
			
			/* Copy member flags */
			memcpy(flags, p_read_array + read_bytes, C_TLM_NUM_FLAGS_BYTES);

			/* Get number of real data byes */
			data_bytes = p_TLM_get_data(&flags[2], TLM_BIT_FIELD_C_DATA_BYTE_IDX, TLM_BIT_FIELD_C_DATA_BYTE_LEN);
			
			/* Copy member data */
			memcpy(data, (p_read_array + read_bytes) + C_TLM_NUM_FLAGS_BYTES, (data_bytes)* sizeof(char));

			/* Update data_bytes for next round */
			read_bytes += C_TLM_NUM_FLAGS_BYTES + data_bytes;

			/* Get group,  param_idx, data_type */
			group = p_TLM_get_data(&flags[0], TLM_BIT_FIELD_A_GROUP_IDX, TLM_BIT_FIELD_A_GROUP_LEN);
			param_idx = p_TLM_get_data(&flags[1], TLM_BIT_FIELD_B_PARAM_IDX, TLM_BIT_FIELD_B_PARAM_LEN);
			flah_store = p_TLM_get_data(&flags[1], TLM_BIT_FIELD_B_FLASH_IDX, TLM_BIT_FIELD_B_FLASH_LEN);
			visual = p_TLM_get_data(&flags[1], TLM_BIT_FIELD_B_VISUALITY_IDX, TLM_BIT_FIELD_B_VISUALITY_LEN);
			data_type = p_TLM_get_data(&flags[2], TLM_BIT_FIELD_C_DATA_TYPE_IDX, TLM_BIT_FIELD_C_DATA_TYPE_LEN);

			printf("Group = %s, \tidx_location = %d \tData type = %d \tStore flash = %d \tVisual = %d", group_names[group - 1], param_idx, data_type, flah_store, visual);
			switch (data_type)
			{
				case TLM_DATA_INT16:
					sscanf_s((const char*)data, "%3d", &temp_int);
					printf("\tData (INT16) = %3d \n\r", temp_int);
					break;

				case TLM_DATA_INT32:
					sscanf_s((const char*)data, "%6d", &temp_int);
					printf("\tData (INT32) = %6d \n\r", temp_int);
					break;

				case TLM_DATA_INT64:
					sscanf_s((const char*)data, "%12d", &temp_int);
					printf("\tData (INT64) = %12d \n\r", temp_int);
					break;

				case TLM_DATA_FLOAT_DOUBLE:
					sscanf_s((const char*)data, "%f", &temp_float);
					printf("\tData (REAL) = %f \n\r", temp_float);
					break;

				default:
					break;
			}
			
		}
	}
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup VTU
\brief          This function shall read TLM current data.
\return         void
\FRSLinks       VTU_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
void p_VTU_tlm_read_current(void)
{
	unsigned char*	p_read_array = NULL;
	unsigned short	members[C_TLM_PACKET_HEADER_BYTES];
	unsigned char	data[C_TLM_MAX_DATA_BYTE_IN_PARAM];
	unsigned char	flags[C_TLM_NUM_FLAGS_BYTES];

	unsigned short	data_type = 0x0, read_bytes = 0x0, data_bytes = 0x0, param_idx = 0x0, visual = 0x0;
	bool			flah_store = false;
	unsigned int	members_cnt = 0;
	unsigned int	group = 0x0;

	int				temp_int;
	float			temp_float;


	p_read_array = p_TLM_get_current_data();
	memcpy(members, p_read_array + C_TLM_CURRENT_MAX_DATA_BYTES, sizeof(members));

	if ((int)members[0] > 0)
	{
		for (; members_cnt < members[0]; members_cnt++)
		{
			/* Clear data container */
			memset(flags, 0, sizeof(flags));
			memset(data, 0, sizeof(data));

			/* Copy member flags */
			memcpy(flags, p_read_array + read_bytes, C_TLM_NUM_FLAGS_BYTES);

			/* Get number of real data byes */
			data_bytes = p_TLM_get_data(&flags[2], TLM_BIT_FIELD_C_DATA_BYTE_IDX, TLM_BIT_FIELD_C_DATA_BYTE_LEN);

			/* Copy member data */
			memcpy(data, (p_read_array + read_bytes) + C_TLM_NUM_FLAGS_BYTES, (data_bytes)* sizeof(char));

			/* Update data_bytes for next round */
			read_bytes += C_TLM_NUM_FLAGS_BYTES + data_bytes;

			/* Get group,  param_idx, data_type */
			group = p_TLM_get_data(&flags[0], TLM_BIT_FIELD_A_GROUP_IDX, TLM_BIT_FIELD_A_GROUP_LEN);
			param_idx = p_TLM_get_data(&flags[1], TLM_BIT_FIELD_B_PARAM_IDX, TLM_BIT_FIELD_B_PARAM_LEN);
			flah_store = p_TLM_get_data(&flags[1], TLM_BIT_FIELD_B_FLASH_IDX, TLM_BIT_FIELD_B_FLASH_LEN);
			visual = p_TLM_get_data(&flags[1], TLM_BIT_FIELD_B_VISUALITY_IDX, TLM_BIT_FIELD_B_VISUALITY_LEN);
			data_type = p_TLM_get_data(&flags[2], TLM_BIT_FIELD_C_DATA_TYPE_IDX, TLM_BIT_FIELD_C_DATA_TYPE_LEN);

			printf("Group = %s, \tidx_location = %d \tData type = %d \tStore flash = %d \tVisual = %d", group_names[group - 1], param_idx, data_type, flah_store, visual);
			switch (data_type)
			{
				case TLM_DATA_INT16:
					sscanf_s((const char*)data, "%3d", &temp_int);
					printf("\tData (INT16) = %3d \n\r", temp_int);
					break;

				case TLM_DATA_INT32:
					sscanf_s((const char*)data, "%6d", &temp_int);
					printf("\tData (INT32) = %6d \n\r", temp_int);
					break;

				case TLM_DATA_INT64:
					sscanf_s((const char*)data, "%12d", &temp_int);
					printf("\tData (INT64) = %12d \n\r", temp_int);
					break;

				case TLM_DATA_FLOAT_DOUBLE:
					sscanf_s((const char*)data, "%f", &temp_float);
					printf("\tData (REAL) = %f \n\r", temp_float);
					break;

				default:
					break;
			}

		}
	}
}