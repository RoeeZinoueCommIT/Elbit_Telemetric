#include "stdafx.h"
#include "OS_framer.h"

#define C_OS_TOTAL_MEM_SECTION_BYTES	(400u)
#define C_OS_MEM_REGIONS				(4u)

typedef struct
{
	void *rtv_from_ptr;
	void *str_to_1_ptr;
	void *str_to_2_ptr;
	void *str_to_3_ptr;
} DT_CDS_mem_reg_t;

DT_CDS_mem_reg_t memory_regions_array[4];

unsigned char g_OS_mem[C_OS_TOTAL_MEM_SECTION_BYTES];


void p_OS_framer_init(void)
{
	memset(g_OS_mem, 0u, sizeof(g_OS_mem));
	memory_regions_array[0].rtv_from_ptr = g_OS_mem;
	memory_regions_array[0].str_to_1_ptr = (void*)0;
	memory_regions_array[0].str_to_2_ptr = (void*)0;
	memory_regions_array[0].str_to_3_ptr = (void*)0;
}

void p_OS_delay(int xi_mili_sec)
{
	int milli_seconds = xi_mili_sec;
	clock_t start_time = clock();
	while (clock() < start_time + milli_seconds); /* looping till required time is not acheived */
}

void p_OS_write(int xi_app_id, int xi_reg, const void* xi_src, int xi_size)
{
	switch (xi_reg)
	{
		case 0:
			memcpy(memory_regions_array[xi_app_id].rtv_from_ptr, xi_src, (unsigned int) xi_size);
			break;

		case 1:
			memcpy(memory_regions_array[xi_app_id].str_to_1_ptr, xi_src, (unsigned int)xi_size);
			break;
		default:
			break;
	}
}

void p_OS_read(int xi_app_id, void *xi_dst, int xi_size)
{
	memcpy(xi_dst, memory_regions_array[xi_app_id].rtv_from_ptr, (unsigned int)xi_size);
}