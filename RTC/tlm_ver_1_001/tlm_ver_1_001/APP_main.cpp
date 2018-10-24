#define APP_FRAMER_C

/*DESCRIPTION--------------------------------------
|CSC Name: APP
|Implements the APP_main under uCOS and Windows.
-----------------------------------------------------*/

/* ----------------- */
/* Include file list */
/* ----------------- */

#include "stdafx.h"
#include "TLM_framer.h"
#include "VTU_framer.h"

#include "PFD_framer.h"
#include "HKY_framer.h"

/* ------------------ */
/* Internal Constants */
/* ------------------ */

#define C_APP_TIMER_BASE_TIME_MSEC (50u)

/* --------------- */
/* Internal Macros */
/* --------------- */

/* ------------------------------- */
/* Internal Data type declarations */
/* ------------------------------- */

typedef enum
{
	TIME_UPDATE_PARAMS		= 5,	/* 50 msec * 1 = 50 msec */
	TIME_PFD_REFRESH		= 1,	/* 50 msec * 5 = 500 msec */
	TIME_flah_store			= 10,	/* 50 msec * 10 = 1000 mse */
	TIME_READ_VTU_CURRENT	= 15,	/* 100 msec * 15 = 1500 mse */
	TIME_READ_VTU_FLASH		= 30,	/* 100 msec * 30 = 3000 mse */
	MAX_TIME
}DT_APP_TIME_SEQUANCE;

/* ----------------------- */
/* Internal data variables */
/* ----------------------- */

unsigned short g_APP_timer = 0;

/* --------------------------- */
/* Internal Methods prototypes */
/* --------------------------- */

static void p_APP_update_timer(void);
static void p_APP_init(void);

/* ---------------------- */
/* Methods implementation */
/* ---------------------- */

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup APP
\brief          This function shall update APP timer.
\return         void
\FRSLinks       APP_SRS_
\DerivedDesc    N/A
\param			void
*/
/*--------------------------------------------------------------------------------------------------*/
void p_APP_update_timer(void)
{
	if (g_APP_timer > MAX_TIME)
	{
		g_APP_timer = 0;
	}
	else
	{
		g_APP_timer++;
	}
	p_OS_delay(C_APP_TIMER_BASE_TIME_MSEC);
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup APP
\brief          This function shall run main cycle polling thread.
\return         void
\FRSLinks       APP_SRS_
\DerivedDesc    N/A
\param			Void.
*/	
/*--------------------------------------------------------------------------------------------------*/
void p_APP_main_cycle(void)
{

	while (true)
	{
		
		if (g_APP_timer % TIME_PFD_REFRESH == 0)
		{
			p_PFD_update_params();
			p_HKY_update_params();
		}
		if (g_APP_timer % TIME_UPDATE_PARAMS == 0)
		{
			p_TLM_framer_update();
		}
		if (g_APP_timer % TIME_flah_store == 0)
		{
			p_TLM_flash_store();
		}
		if (g_APP_timer % TIME_READ_VTU_CURRENT == 0)
		{
			p_VTU_tlm_read_current();
		}
		if (g_APP_timer % TIME_READ_VTU_FLASH == 0)
		{
			//p_VTU_tlm_read_flash();
		}

		p_APP_update_timer();

	}
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup APP
\brief          This function shall initialize APP module.
\return         void
\FRSLinks       APP_SRS_
\DerivedDesc    N/A
\param			Void.
*/
/*--------------------------------------------------------------------------------------------------*/
void p_APP_init(void)
{
	p_OS_framer_init();
	p_PFD_framer_init();
	p_HKY_framer_init();
	p_TLM_framer_init();

	/* Start APP main task */
	p_APP_main_cycle();
}

/*$PROCEDURE$---------------------------------------------------------------------------------------*/
/*! \ingroup APP
\brief          This function shall serve as main application routine.
\return         void
\FRSLinks       APP_SRS_
\DerivedDesc    N/A
\param			int argc, _TCHAR* argv[] - Comming arguments. Range: Full range.
\param			_TCHAR* argv[] - Comming arguments. Range: Not NULL.
*/
/*--------------------------------------------------------------------------------------------------*/
int _tmain(int argc, _TCHAR* argv[])
{
	p_APP_init();
	return 0;
}
