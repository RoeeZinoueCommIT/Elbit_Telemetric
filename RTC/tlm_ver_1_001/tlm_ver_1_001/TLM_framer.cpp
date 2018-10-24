#define TLM_FRAMER_C

/*DESCRIPTION--------------------------------------
|CSC Name: TLM
|Implements the TLM_framer under uCOS and Windows.
-----------------------------------------------------*/

/* ----------------- */
/* Include file list */
/* ----------------- */

#include "stdafx.h"
#include "TLM_framer.h"
#include "Tlm_manage_params.h"
#include "TLM_db_pfd.h"
#include "TLM_db_hky.h"

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

DT_TLM_db		g_TLM_db;
unsigned int	g_TLM_flash_write_counter;
unsigned short	g_TLM_timer;
unsigned int	g_TLM_flash_address_write_counter;
unsigned int	g_TLM_flash_address_read_counter;
bool			g_TLM_caution_stop;

/* --------------------------- */
/* Internal Methods prototypes */
/* --------------------------- */

static void p_TLM_init_db(void);
static void p_TLM_update_timer(void);

/* ---------------------- */
/* Methods implementation */
/* ---------------------- */

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall initialize TLM main framer.
\return         void
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
void p_TLM_framer_init(void)
{
	/* Zero all TLM DB arrays. */
	memset(g_TLM_db.tlm_flash_data_wr, 0, sizeof(g_TLM_db.tlm_flash_data_wr));
	memset(g_TLM_db.tlm_flash_data_rd, 0, sizeof(g_TLM_db.tlm_flash_data_rd));
	memset(g_TLM_db.tlm_current_data, 0, sizeof(g_TLM_db.tlm_current_data));
	memset(g_TLM_db.tlm_info, 0, sizeof(g_TLM_db.tlm_info));

	/* Initialize TLM data base */
	p_TLM_hky_db_init();
	p_TLM_pfd_db_init();

	/* Initialize Flash counter */
	g_TLM_flash_address_write_counter = C_TLM_FLASH_START_ADDRESS_WRITE;
	g_TLM_flash_address_read_counter = C_TLM_FLASH_START_ADDRESS_READ;

	/* Initialize TLM DB data members */
	p_TLM_init_db();

	/* Set off caution stop */
	g_TLM_caution_stop = true;
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall initialize TLM data base parameters from all RT modules.
\return         void
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
void p_TLM_init_db(void)
{
	/* Init TLM data base */
	p_TLM_hky_db_init();
	p_TLM_pfd_db_init();
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall store TLM DB into flash at fix address location.
\return         Void.
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param void		Void.
*/
/*--------------------------------------------------------------------------------------------------*/
void p_TLM_flash_store(void)
{
	/* Check if there is atleast one TLM packet waiting to write into flash */
	p_OS_write(g_TLM_flash_address_write_counter, C_TLM_FLASH_MEM_MAP_REG_IDX, (void *)&g_TLM_db.tlm_flash_data_wr, sizeof(g_TLM_db.tlm_flash_data_wr));
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall read TLM data that store in flash location.
\return         unsigned char*: TLM packet struct that store in internal flash. 
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param void		Void.
*/
/*--------------------------------------------------------------------------------------------------*/
unsigned char* p_TLM_get_flash_data(void)
{
	unsigned char *ptr;
	p_OS_read(g_TLM_flash_address_read_counter, g_TLM_db.tlm_flash_data_rd, sizeof(g_TLM_db.tlm_flash_data_rd));
	ptr = &g_TLM_db.tlm_flash_data_rd[0];
	return ptr;
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall back number of TLM parameters
\return         unsigned short: Number of TLM parameters.
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param void		Void.
*/
/*--------------------------------------------------------------------------------------------------*/
unsigned short p_TLM_num_of_parameter(void)
{
	return (C_TLM_MAX_PARAMTERS_IN_GROUP * (TLM_GROUP_LAST_GROUP - 1));
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall back TLM packet structure current data.
\return         void
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
unsigned char* p_TLM_get_current_data(void)
{
	unsigned char *ptr;
	ptr = &g_TLM_db.tlm_current_data[0];
	return ptr;
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall back TLM DB info structure.
\return         void
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param 			Void
*/
/*--------------------------------------------------------------------------------------------------*/
DT_TLM_param_info* p_TLM_get_tlm_info(void)
{
	DT_TLM_param_info *ptr;
	ptr = &g_TLM_db.tlm_info[0];
	return (ptr);
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall prepere mask to pharsing TLM data from arrays of byte.
\return         void
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
unsigned short p_TLM_get_data(unsigned char* xi_data, unsigned short xi_bit_index, unsigned short xi_bits_len)
{
	unsigned short mask = 0x1, rotation;
	//rotation = index;

	if (xi_bits_len > 1) do
	{
		mask <<= 0x1;
		mask |= 1;
	} while (xi_bits_len-- > 2);


	mask <<= xi_bit_index;

	unsigned char res_data = (mask & (*xi_data)) >> xi_bit_index;
	return (res_data);
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall refresh TLM internal timer and update TLM data.
\return         void
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
void p_TLM_framer_update(void)
{
	if (g_TLM_caution_stop == true)
	{
		p_TLM_update_timer();
		g_TLM_caution_stop = p_TLM_update_params();
	}
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall refresh TLM internal timer.
\return         void
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
void p_TLM_update_timer(void)
{
	if (g_TLM_timer >= TLM_RATE_SLOW)
	{
		g_TLM_timer = 0;
	}
	else
	{
		g_TLM_timer++;
	}
}

