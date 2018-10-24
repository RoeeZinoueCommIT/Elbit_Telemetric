#ifndef C_OS_FRAMER_H
#define C_OS_FRAMER_H

/* Include file list */

#include <time.h> 
#include "string.h"

/* Exported Constants */


/* Exported Macros */


/* Exported Data type declarations */

void p_OS_framer_init(void);
void p_OS_delay(int xi_mili_sec);
void p_OS_write(int xi_app_id, int xi_reg, const void* xi_src, int xi_size);
void p_OS_read(int xi_app_id, void *xi_dst, int xi_size);

#endif /* C_OS_FRAMER_H */