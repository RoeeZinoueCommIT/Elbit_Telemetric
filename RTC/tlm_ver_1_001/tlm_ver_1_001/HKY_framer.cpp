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
	g_TLM_module_info.pfd_test1 = 5;
	g_TLM_module_info.pfd_test2 = 10;
}

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
	g_TLM_module_info.pfd_test1++;
	g_TLM_module_info.pfd_test2++;
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