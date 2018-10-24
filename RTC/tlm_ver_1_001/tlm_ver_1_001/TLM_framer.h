#ifndef C_TLM_FRAMER_H
#define C_TLM_FRAMER_H

/* Include file list */

#include "TLM_config.h"

/* Exported Constants */


/* Exported Macros */


/* Exported Data type declarations */

/* Exported variables */


/* Exported Methods prototypes */



void p_TLM_framer_init(void);
unsigned char* p_TLM_get_flash_data(void);
unsigned short p_TLM_num_bytes_in_flash(void);
unsigned char* p_TLM_get_current_data(void);
DT_TLM_param_info* p_TLM_get_tlm_info(void);
void p_TLM_framer_update(void);
unsigned short p_TLM_get_data(unsigned char* xi_data, unsigned short xi_bit_index, unsigned short xi_bits_len);
void p_TLM_flash_store(void);
unsigned short p_TLM_num_of_parameter(void);

#endif /* C_TLM_FRAMER_H */