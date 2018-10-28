#define PFD_FRAMER_C

/*DESCRIPTION--------------------------------------
|CSC Name: PFD
|Implements the PFD_framer under uCOS and Windows.
-----------------------------------------------------*/

/* ----------------- */
/* Include file list */
/* ----------------- */

#include "stdafx.h"
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

DT_TLM_pfd_info g_TLM_module_info;

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
void p_PFD_framer_init(void)
{
	g_TLM_module_info.pfd_test1 = 1.123567;
	g_TLM_module_info.pfd_test2 = 7;
	g_TLM_module_info.pfd_test3 = 8;
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup PFD
\brief          This function shall
\return         void
\FRSLinks       PFD_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
void p_PFD_update_params(void)
{
	g_TLM_module_info.pfd_test1+= 0.0005;
	g_TLM_module_info.pfd_test2++;
	g_TLM_module_info.pfd_test3++;
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup PFD
\brief          This function shall
\return         void
\FRSLinks       TLM_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
DT_TLM_pfd_info* p_PFD_get_tlm_info(void)
{
	DT_TLM_pfd_info* p_tlm_info;
	p_tlm_info = &g_TLM_module_info;
	return (p_tlm_info);
}