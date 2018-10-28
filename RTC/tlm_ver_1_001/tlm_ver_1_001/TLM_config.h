#ifndef C_TLM_CONFIG_H
#define C_TLM_CONFIG_H

/* Include file list */

#include "string.h"
#include "OS_framer.h"

/* Exported Constants */

#define C_TLM_MAX_DATA_BYTE_IN_PARAM	(8u)
#define C_TLM_MAX_PARAMTERS_IN_GROUP	(5u)

		/* Packet shape */
#define C_TLM_NUM_FLAGS_BYTES			(3u)
#define C_TLM_FIRST_CONFIG_BYTE			(C_TLM_MAX_DATA_BYTE_IN_PARAM + 1u)
#define C_TLM_SECOND_CONFIG_BYTE		(C_TLM_MAX_DATA_BYTE_IN_PARAM + 2u)
#define C_TLM_PACKET_SIZE				(C_TLM_MAX_DATA_BYTE_IN_PARAM + C_TLM_NUM_FLAGS_BYTES)
#define	C_TLM_PACKET_HEADER_BYTES		(2u)

		/* Current data constants */
#define C_TLM_FLASH_MAX_DATA_BYTES		(100u)
#define C_TLM_FLASH_START_ADDRESS_WRITE (0u)
#define C_TLM_FLASH_START_ADDRESS_READ	(0u)
#define C_TLM_FLASH_MEM_MAP_REG_IDX		(0u)
		
		/* Current data constants */
#define C_TLM_CURRENT_MAX_DATA_BYTES	(100u) 
		
		/* Time constants */
#define C_TLM_TIME_STORE_FLASH_MSEC		(50u)	/* Need to be read from offline parameters */
#define C_TLM_REFRESH_MULT_FACTOR_MSEC  (50u)


/* Exported Macros */

/* Exported Data type declarations */

typedef enum
{
		/* First configuration byte */

	/* FLASH STORE: YES / NO */
	TLM_BIT_FIELD_A_FLASH_IDX		= 0x0,
	TLM_BIT_FIELD_A_FLASH_LEN		= 0x1,

	/* GROUP - Up to 32 groups */
	TLM_BIT_FIELD_A_GROUP_IDX		= 0x1,
	TLM_BIT_FIELD_A_GROUP_LEN		= 0x5,

	/* DATA SIGN */
	TLM_BIT_FIELD_A_DATA_SIGN_IDX	= 0x6,
	TLM_BIT_FIELD_A_DATA_SIGN_LEN	= 0x1,

		/* Second configuration byte */
	
	/* PARAM_IDX - Up to 8 params in each module */
	TLM_BIT_FIELD_B_PARAM_IDX		= 0x0,
	TLM_BIT_FIELD_B_PARAM_LEN		= 0x3,
	
	/* VISUALITY: YES / NO */
	TLM_BIT_FIELD_B_VISUALITY_IDX	= 0x3,
	TLM_BIT_FIELD_B_VISUALITY_LEN	= 0x1,

	/* RATE: */
	TLM_BIT_FIELD_B_RATE_IDX		= 0x4,
	TLM_BIT_FIELD_B_RATE_LEN		= 0x2,

		/* Third configuration byte */

	/* DATA TYPE */
	TLM_BIT_FIELD_C_DATA_TYPE_IDX	= 0x0,
	TLM_BIT_FIELD_C_DATA_TYPE_LEN	= 0x3,
	
	/* REAL DATA BYTE */
	TLM_BIT_FIELD_C_DATA_BYTE_IDX	= 0x3,
	TLM_BIT_FIELD_C_DATA_BYTE_LEN	= 0x4,

}enumTLM_bit_field_type;

typedef enum
{
	TLM_GROUP_NA			= 0,
	TLM_GROUP_PFD, 
	TLM_GROUP_HKY,
	/* TLM_GROUP_IRD, */
	TLM_GROUP_LAST_GROUP,
}enumTLM_group_type;

typedef enum
{
	TLM_DATA_INT1_INT8		= 0,	/* char range: 0 - 255 */
	TLM_DATA_INT16,					/* int range: 0 -:- 65,535 */
	TLM_DATA_INT32,					/* int range: 0 -:- 65,535 */
	TLM_DATA_INT64,					/* int range: 0 -:- 65,535 */
	TLM_DATA_FLOAT_DOUBLE,			/* Float range: 6 decimal places, Double range: 15 decimal places */
}enumTLM_data_type;

typedef enum
{
	TLM_DATA_UNSIGN			= 0,
	TLM_DATA_SIGN,
}enumTLM_data_sign;

typedef enum
{
	TLM_FLASH_STORE_NO		= 0,
	TLM_FLASH_STORE_YES,
}enumTLM_flash_store;

typedef enum
{
	TLM_VISUAL_NO			= 0,
	TLM_VISUAL_YES,
}enumTLM_visual_type;

typedef enum
{
	TLM_PARMAM_EXIST_NO		= 0,
	TLM_PARMAM_EXIST_YES,
}enumTLM_param_exist_type;

typedef enum
{
	TLM_RATE_FAST			= 1,		/* 1 * 100 mSec rate = 100 msec*/
	TLM_RATE_NORMAL			= 2, 		/* 2 * 100 mSec rate = 200 msec*/
	TLM_RATE_SLOW			= 3			/* 3 * 100 mSec rate = 300 msec*/
}enumTLM_rate_type;

typedef struct
{
	void*					data_ptr;
	unsigned short			param_idx;
	enumTLM_group_type		group;
	enumTLM_data_type		data_type;
	enumTLM_data_sign		data_sign;
	enumTLM_rate_type		rate_level;
	enumTLM_visual_type		visuality;
	enumTLM_flash_store		flash_store;
	enumTLM_param_exist_type param_exist;
}DT_TLM_param_info;

/* Define number of all TLM parameters list */
#define C_TLM_NUM_OF_PARAMS				C_TLM_MAX_PARAMTERS_IN_GROUP * (TLM_GROUP_LAST_GROUP - 1)

typedef struct
{
	unsigned char tlm_flash_data_wr[C_TLM_FLASH_MAX_DATA_BYTES + C_TLM_PACKET_HEADER_BYTES];
	unsigned char tlm_flash_data_rd[C_TLM_FLASH_MAX_DATA_BYTES + C_TLM_PACKET_HEADER_BYTES];
	unsigned char tlm_current_data[C_TLM_CURRENT_MAX_DATA_BYTES + C_TLM_PACKET_HEADER_BYTES];	/* It must contain all parameters in TLM in all modules - This fix value. */
	DT_TLM_param_info tlm_info[C_TLM_MAX_PARAMTERS_IN_GROUP * (TLM_GROUP_LAST_GROUP - 1)];		/* Fix size */
}DT_TLM_db;

/* Exported variables */

/* Exported Methods prototypes */

#endif /* C_TLM_CONFIG_H */


