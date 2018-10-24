#ifndef C_PFD_FRAMER_H
#define C_PFD_FRAMER_H

/* Include file list */

/* Exported Constants */


/* Exported Macros */


/* Exported Data type declarations */

typedef struct
{
	float pfd_test1;
	short pfd_test2;
	int pfd_test3;
}DT_TLM_pfd_info;

/* Exported variables */


/* Exported Methods prototypes */

void p_PFD_framer_init(void);
void p_PFD_update_params(void);
DT_TLM_pfd_info* p_PFD_get_tlm_info(void);

#endif /* C_PFD_FRAMER_H */