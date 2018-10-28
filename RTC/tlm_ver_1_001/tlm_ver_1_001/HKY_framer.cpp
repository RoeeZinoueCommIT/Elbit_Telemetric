#define HKY_FRAMER_C

/*DESCRIPTION--------------------------------------
|CSC Name: HKY
|Implements the PFD_framer under uCOS and Windows.
-----------------------------------------------------*/

/* ----------------- */
/* Include file list */
/* ----------------- */

#include "stdafx.h"
#include "HKY_framer.h"

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

DT_TLM_hky_info g_TLM_module_info;

/* --------------------------- */
/* Internal Methods prototypes */
/* --------------------------- */

/* ---------------------- */
/* Methods implementation */
/* ---------------------- */

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup PFD
\brief          This function shall 
\return         void
\FRSLinks       PFD_SRS_
\DerivedDesc    N/A
\param          
*/
/*--------------------------------------------------------------------------------------------------*/
void p_HKY_framer_init(void)
{
	g_TLM_module_info.hky_test1 = 1;
	g_TLM_module_info.hky_test2 = 2;
	g_TLM_module_info.hky_test3 = 0;
	g_TLM_module_info.hky_test4 = 0;
	g_TLM_module_info.hky_test5 = 0;
}

bool dir = 1;

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup HKY
\brief          This function shall
\return         void
\FRSLinks       PFD_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
void p_HKY_update_params(void)
{
	g_TLM_module_info.hky_test1 += 2;
	g_TLM_module_info.hky_test2 += 2;
	g_TLM_module_info.hky_test3 += 10;
	g_TLM_module_info.hky_test4 += 0.1;
	g_TLM_module_info.hky_test5 += 0.5;
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup HKY
\brief          This function shall
\return         void
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
DT_TLM_hky_info* p_HKY_get_tlm_info(void)
{
	DT_TLM_hky_info* p_tlm_info;
	p_tlm_info = &g_TLM_module_info;
	return (p_tlm_info);
}