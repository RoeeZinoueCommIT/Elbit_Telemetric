#define TLM_DB_PFD_C

/*DESCRIPTION--------------------------------------
|CSC Name: TLM
|Implements the TLM_db_pfd under uCOS and Windows.
-----------------------------------------------------*/

/* ----------------- */
/* Include file list */
/* ----------------- */

#include "stdafx.h"
#include "TLM_db_pfd.h"
#include "PFD_framer.h"

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

extern			DT_TLM_db g_TLM_db;
unsigned short	g_TLM_db_pfd_param_indx;

/* --------------------------- */
/* Internal Methods prototypes */
/* --------------------------- */

void p_TLM_pfd_db_init(void);

/* ---------------------- */
/* Methods implementation */
/* ---------------------- */

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup TLM
\brief          This function shall initialize TLM PFD DB.
\return         void
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void.
*/
/*--------------------------------------------------------------------------------------------------*/
void p_TLM_pfd_db_init(void)
{
	g_TLM_db_pfd_param_indx = 0;
	DT_TLM_pfd_info* p_db_base = p_PFD_get_tlm_info();
	

	/* Prepere exmaple unit */
	DT_TLM_param_info test1;
	test1.param_idx = g_TLM_db_pfd_param_indx;
	test1.data_ptr = &p_db_base->pfd_test1;
	test1.data_type = TLM_DATA_FLOAT_DOUBLE;
	test1.data_sign = TLM_DATA_UNSIGN;
	test1.group = TLM_GROUP_PFD;
	test1.flash_store = TLM_FLASH_STORE_YES;
	test1.visuality = TLM_VISUAL_YES;
	test1.rate_level = TLM_RATE_FAST;
	test1.param_exist = TLM_PARMAM_EXIST_YES;
	g_TLM_db.tlm_info[(TLM_GROUP_PFD - 1) * C_TLM_MAX_PARAMTERS_IN_GROUP + g_TLM_db_pfd_param_indx++] = test1;

	DT_TLM_param_info test2;
	test2.param_idx = g_TLM_db_pfd_param_indx;
	test2.data_ptr = &p_db_base->pfd_test2;
	test2.data_type = TLM_DATA_INT16;
	test2.data_sign = TLM_DATA_UNSIGN;
	test2.group = TLM_GROUP_PFD;
	test2.flash_store = TLM_FLASH_STORE_YES;
	test2.visuality = TLM_VISUAL_NO;
	test2.rate_level = TLM_RATE_SLOW;
	test2.param_exist = TLM_PARMAM_EXIST_YES;
	g_TLM_db.tlm_info[(TLM_GROUP_PFD - 1) * C_TLM_MAX_PARAMTERS_IN_GROUP + g_TLM_db_pfd_param_indx++] = test2;

	DT_TLM_param_info test3;
	test3.param_idx = g_TLM_db_pfd_param_indx;
	test3.data_ptr = &p_db_base->pfd_test3;
	test3.data_type = TLM_DATA_INT32;
	test3.data_sign = TLM_DATA_UNSIGN;
	test3.group = TLM_GROUP_PFD;
	test3.flash_store = TLM_FLASH_STORE_YES;
	test3.visuality = TLM_VISUAL_NO;
	test3.rate_level = TLM_RATE_FAST;
	test3.param_exist = TLM_PARMAM_EXIST_YES;
	g_TLM_db.tlm_info[(TLM_GROUP_PFD - 1) * C_TLM_MAX_PARAMTERS_IN_GROUP + g_TLM_db_pfd_param_indx++] = test3;

}