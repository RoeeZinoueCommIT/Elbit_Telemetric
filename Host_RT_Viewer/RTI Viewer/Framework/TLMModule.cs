using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.ComponentModel;
using System.Data;

namespace RT_Viewer.Framework
{
    public class TLMModule : IModule
    {
        #region class C`tor and data members

        #region Enums

        public static class TLMModuleOptions
        {
            public enum enumTLM_opt : int
            {
                TLM_OPT_NOT_SELECTED,

                /* Read source type */
                TLM_OPT_READ_SOURCE_FLASH,
                TLM_OPT_READ_SOURCE_CURRENT,
                TLM_OPT_READ_SOURCE_FILE,

                /* Save file */
                TLM_OPT_SAVE_FILE_NO,
                TLM_OPT_SAVE_FILE_YES,

                /* SORT TYPE */
                TLM_OPT_SORT_GROUPS,
                TLM_OPT_SORT_HIGH_LOW,
                TLM_OPT_SORT_LOW_HIGH,

                /* Data type */
                TLM_OPT_DATA_TYPE_CHARS,
                TLM_OPT_DATA_TYPE_ORG,

                /* VISUAL MODE */
                TLM_OPT_VISUAL_FIGURE,
                TLM_OPT_VISUAL_TABLE,

            };
        }

        enum enumTLM_bit_field_type : int
        {
            /* First configuration byte */

            /* PARAM_EXIST */
            TLM_BIT_FIELD_A_EXIST_IDX = 0x0,
            TLM_BIT_FIELD_A_EXIST_LEN = 0x1,

            /* GROUP - Up to 32 groups */
            TLM_BIT_FIELD_A_GROUP_IDX = 0x1,
            TLM_BIT_FIELD_A_GROUP_LEN = 0x5,

            /* DATA SIGN */
            TLM_BIT_FIELD_A_DATA_SIGN_IDX = 0x4,
            TLM_BIT_FIELD_A_DATA_SIGN_LEN = 0x1,

            /* Second configuration byte */

            /* PARAM_IDX - Up to 15 params in each module */
            TLM_BIT_FIELD_B_PARAM_IDX = 0x0,
            TLM_BIT_FIELD_B_PARAM_LEN = 0x4,

            /* VISUALITY: YES / NO */
            TLM_BIT_FIELD_B_VISUALITY_IDX = 0x4,
            TLM_BIT_FIELD_B_VISUALITY_LEN = 0x1,

            /* FLASH STORE: YES / NO */
            TLM_BIT_FIELD_B_FLASH_IDX = 0x5,
            TLM_BIT_FIELD_B_FLASH_LEN = 0x1,

            /* Third configuration byte */

            /* DATA TYPE */
            TLM_BIT_FIELD_C_DATA_TYPE_IDX = 0x0,
            TLM_BIT_FIELD_C_DATA_TYPE_LEN = 0x3,

            /* REAL DATA BYTE */
            TLM_BIT_FIELD_C_DATA_BYTE_IDX = 0x3,
            TLM_BIT_FIELD_C_DATA_BYTE_LEN = 0x4,
        };

        enum enumTLM_group_type : int
        {
            TLM_GROUP_NA = 0,
            TLM_GROUP_PFD,
            TLM_GROUP_HKY,
            /* TLM_GROUP_IRD, */
            TLM_GROUP_LAST_GROUP,
        };

        enum enumTLM_data_type : int
        {
            TLM_DATA_INT1_INT8 = 0,         /* char range: 0 - 255 */
            TLM_DATA_INT16,                 /* int range: 0 -:- 65,535 */
            TLM_DATA_INT32,                 /* int range: 0 -:- 65,535 */
            TLM_DATA_INT64,                 /* int range: 0 -:- 65,535 */
            TLM_DATA_FLOAT_DOUBLE,          /* Float range: 6 decimal places, Double range: 15 decimal places */
        };

        enum enumTLM_data_sign : int
        {
            TLM_DATA_UNSIGN = 0,
            TLM_DATA_SIGN,
        };

        enum enumTLM_opt_idx : int
        {
            TLM_OPT_IDX_READ_SOURCE_IDX = 0,
            TLM_OPT_IDX_SAVE_FILE_IDX,
            TLM_OPT_IDX_SORT_MODE_IDX,
            TLM_OPT_IDX_DATA_TYPE_IDX,
        };

        #endregion

        #region TLM data tables

        public class TLMDataTable
        {
            public string name { get; set; }
            public string group { get; set; }
            public string idx { get; set; }
            public string value { get; set; }
            public string rate { get; set; }
            public string Data_type { get; set; }
            public UInt32 param_key { get; set; }
        }

        public class TLMNamesTable
        {
            public string name { get; set; }
            public UInt32 key { get; set; }
        }

        #endregion

        #region Verbs

        List<TLMModuleOptions.enumTLM_opt> _tlmOptions;
        string _readFileSourcePath = string.Empty;
        string _storeRawFilesPath = string.Empty;
        private readonly Int16 C_TLM_MAX_PACKET_SIZE_BYTES = 20;
        int C_TLM_HEADER_NUM_BYTES = 2;

        /* Binding source */
        public BindingList<TLMDataTable> BL_TLMDataTable;

        List<TLMDataTable> _tlm_db;
        List<TLMNamesTable> _tlm_db_names;

        public List<double> tlm_x_chart { get; set; }
        public List<double> tlm_y_chart { get; set; }

        public List<string> tlm_group_list { get; set; }


        #endregion

        #region C`tor

        public TLMModule(SocketHandler.enumDevice_id deviceID)
        {
            deviceIdConnected = deviceID;
            _tlmOptions = new List<TLMModuleOptions.enumTLM_opt>
            {
                TLMModuleOptions.enumTLM_opt.TLM_OPT_NOT_SELECTED,
                TLMModuleOptions.enumTLM_opt.TLM_OPT_NOT_SELECTED,
                TLMModuleOptions.enumTLM_opt.TLM_OPT_NOT_SELECTED,
                TLMModuleOptions.enumTLM_opt.TLM_OPT_NOT_SELECTED,
                TLMModuleOptions.enumTLM_opt.TLM_OPT_NOT_SELECTED
            };

            /* Init module TLM lists */
            BL_TLMDataTable = new BindingList<TLMDataTable>();
            _tlm_db = new List<TLMDataTable>();

            tlm_x_chart = new List<double>();
            tlm_y_chart = new List<double>();

            tlm_group_list = new List<string>();
        }

        #endregion

        #endregion

        #region Set TLM module configuration

        internal void SetTlmOptions
        (
            TLMModuleOptions.enumTLM_opt read_source,
            string read_source_file_path,
            TLMModuleOptions.enumTLM_opt sort_mode,
            TLMModuleOptions.enumTLM_opt data_type
        )
        {

            _tlmOptions[(Int16)enumTLM_opt_idx.TLM_OPT_IDX_READ_SOURCE_IDX] = read_source;
            if (read_source == TLMModuleOptions.enumTLM_opt.TLM_OPT_READ_SOURCE_FILE)
            {
                _readFileSourcePath = read_source_file_path == string.Empty ? string.Empty : _readFileSourcePath;
            }

            _tlmOptions[(Int16)enumTLM_opt_idx.TLM_OPT_IDX_SORT_MODE_IDX] = sort_mode;

            _tlmOptions[(Int16)enumTLM_opt_idx.TLM_OPT_IDX_DATA_TYPE_IDX] = data_type;
        }

        #endregion

        #region Find data member

        internal Int32 SelectDataMember(string xi_find_name, string xi_find_group)
        {
            UInt16 MAX_ALLOWED_PARAMS_IN_GROUP = 5; /* Need to be part of the header */
            UInt16 param_index = 0x0;

            Int32 ret_code = 0x0;

            if(xi_find_name != string.Empty)
            {
                /* check if name is param index */
                if (true == xi_find_name.All(char.IsDigit)) param_index = Convert.ToUInt16(xi_find_name);

                ret_code = (UInt16)(tlm_fromStringToEnumVal(xi_find_group) * MAX_ALLOWED_PARAMS_IN_GROUP + param_index);
            }
            else
            {
                ret_code = -1;
            }
            
            /* Return data table */
            return (ret_code);
        }

        private ushort tlm_fromStringToEnumVal(string xi_find_group)
        {
            UInt16 cnt = 0x0;

            foreach (var mc in Enum.GetNames(typeof(enumTLM_group_type)))
            {
                if (mc == xi_find_group) break;
                cnt++;
            }

            return (cnt);
        }

        #endregion

        #region Update Telemetric process

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            TlmUpdateTable(msg, size, type, source);
            TlmStoreData(msg, size, type, source);


            //BL_TLMDataTable.Clear();
            BL_TLMDataTable = new BindingList<TLMDataTable>(_tlm_db);
            
            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));
            return true;
        }

        private void TlmUpdateTable(byte[] msg, uint size, uint type, uint source)
        {
            Int32 read_bytes = 0x0;
            UInt32 num_params = 0x0;

            try
            {
                if (msg.Length > 3)
                {
                    num_params = msg[0];

                    if (num_params > 0)
                    {
                        for (int idx = 0; idx < num_params; idx++)
                        {
                            read_bytes = Prepere_read_packet(msg, read_bytes);
                            if(read_bytes == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            /* Sort TLM DB table if needed */
            if(_tlmOptions[(Int16)enumTLM_opt_idx.TLM_OPT_IDX_SORT_MODE_IDX] == TLMModuleOptions.enumTLM_opt.TLM_OPT_SORT_HIGH_LOW)
            {
                var newlist = _tlm_db.OrderBy(x => x.group);
            }
        }

        private Int32 Prepere_read_packet(byte[] msg, Int32 read_bytes)
        {
            UInt16 num_of_flags_bytes = 0x3;
            byte[] flags = new Byte[3];
            UInt16 data_size = 0x0;
            byte[] data;

            try
            {
                /* Copy flags */
                Buffer.BlockCopy(msg, C_TLM_HEADER_NUM_BYTES + read_bytes, flags, 0, 3);

                /* Copy data */
                data_size = p_TLM_get_data(flags[2], enumTLM_bit_field_type.TLM_BIT_FIELD_C_DATA_BYTE_IDX, enumTLM_bit_field_type.TLM_BIT_FIELD_C_DATA_BYTE_LEN);
                data = new byte[data_size];
                if ((read_bytes + 3 + data_size) < msg.Length)
                {
                    Buffer.BlockCopy(msg, C_TLM_HEADER_NUM_BYTES + read_bytes + 3, data, 0, data_size);
                }
                else
                {
                    read_bytes = 0;
                }

                /* Pharsing new packet */
                InsertNewLinkToDataList(flags, data, data_size);

                read_bytes += data_size + num_of_flags_bytes;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            return (read_bytes);
        }

        private void InsertNewLinkToDataList(byte[] xi_flags, byte[] xi_data, UInt16 xi_data_size)
        {
            UInt16 MAX_ALLOWED_PARAMS_IN_GROUP = 5; /* Need to be part of the header */

            string temp_group_str = string.Empty;
            UInt16 temp_param_idx = 0x0, temp_group_int = 0x0;
            UInt16 temp_type = 0x0;
            string temp_rate = string.Empty;


            temp_group_int = p_TLM_get_data(xi_flags[0], enumTLM_bit_field_type.TLM_BIT_FIELD_A_GROUP_IDX, enumTLM_bit_field_type.TLM_BIT_FIELD_A_GROUP_LEN);
            temp_group_str = ((enumTLM_group_type)temp_group_int).ToString();
            temp_param_idx = p_TLM_get_data(xi_flags[1], enumTLM_bit_field_type.TLM_BIT_FIELD_B_PARAM_IDX, enumTLM_bit_field_type.TLM_BIT_FIELD_B_PARAM_LEN);
            temp_type = p_TLM_get_data(xi_flags[1], enumTLM_bit_field_type.TLM_BIT_FIELD_C_DATA_TYPE_IDX, enumTLM_bit_field_type.TLM_BIT_FIELD_C_DATA_TYPE_LEN);
            temp_rate = p_TLM_get_data(xi_flags[1], enumTLM_bit_field_type.TLM_BIT_FIELD_C_DATA_TYPE_IDX, enumTLM_bit_field_type.TLM_BIT_FIELD_C_DATA_TYPE_LEN).ToString();

            /* Prepere new node and insert it to TLM DB list */
            try
            {
                var _node = new TLMDataTable
                {
                    name = "A",
                    group = temp_group_str,
                    idx = temp_param_idx.ToString(),
                    value = System.Text.Encoding.Default.GetString(xi_data),
                    rate = "E",
                    Data_type = temp_type.ToString(),
                    param_key = (UInt16)(temp_group_int * MAX_ALLOWED_PARAMS_IN_GROUP + temp_param_idx)
                };

                _tlm_db.Add(_node);

                /* Update groups names list */
                if (tlm_group_list.FindIndex(s => s.Contains(temp_group_str)) < 0)
                {
                    tlm_group_list.Add(temp_group_str);
                }
            }
            catch (Exception)
            {
                int a = 7;
            }
        }

        #endregion

        #region TLM store data process

        private void TlmStoreData(byte[] msg, uint size, uint type, uint source)
        {
            byte[] data = new byte[C_TLM_MAX_PACKET_SIZE_BYTES];

            if (_tlmOptions[(Int16)enumTLM_opt_idx.TLM_OPT_IDX_READ_SOURCE_IDX] != TLMModuleOptions.enumTLM_opt.TLM_OPT_NOT_SELECTED)
            {
                switch (_tlmOptions[(Int16)enumTLM_opt_idx.TLM_OPT_IDX_READ_SOURCE_IDX])
                {
                    case TLMModuleOptions.enumTLM_opt.TLM_OPT_READ_SOURCE_FILE:
                        Buffer.BlockCopy(ReadRawFromFile(_readFileSourcePath), 0, data, 0, C_TLM_MAX_PACKET_SIZE_BYTES);
                        break;

                    case TLMModuleOptions.enumTLM_opt.TLM_OPT_READ_SOURCE_FLASH:
                        /* Pass command to RTC that we want to read TLM from flash - This will ready at next round */

                        Buffer.BlockCopy(msg, 0, data, 0, (int)size);
                        break;

                    case TLMModuleOptions.enumTLM_opt.TLM_OPT_READ_SOURCE_CURRENT:
                        /* Pass command to RTC that we want to read TLM Current data */

                        Buffer.BlockCopy(msg, 0, data, 0, (int)size);
                        break;

                    default:

                        break;
                }

                /* Save raw data to file */
                if (_tlmOptions[(Int16)enumTLM_opt_idx.TLM_OPT_IDX_SAVE_FILE_IDX] == TLMModuleOptions.enumTLM_opt.TLM_OPT_SAVE_FILE_YES)
                {
                    WriteTlmDataToFile(_storeRawFilesPath, data, size);
                }
            }

        }

        private Array ReadRawFromFile(string readFileSourcePath)
        {
            byte[] temp_data = new byte[C_TLM_MAX_PACKET_SIZE_BYTES];

            return temp_data;
        }

        private void WriteTlmDataToFile(string write_file_path, byte[] data_buff, uint size)
        {
            if (write_file_path != string.Empty)
            {
                using (StreamWriter writer = File.AppendText(write_file_path))
                {
                    writer.WriteLine(string.Format("Data size: {0} ", size));
                    foreach (var item in data_buff)
                    {
                        writer.Write(item);
                        writer.Write(" ");
                    }
                }
            }
        }

        #endregion

        #region TLM utils functions

        byte p_TLM_get_data(byte xi_data, enumTLM_bit_field_type xi_bit_index, enumTLM_bit_field_type xi_bits_len)
        {
            byte mask = 0x1;
            byte res_data = 0x0;

            UInt16 bit_length = (UInt16)xi_bits_len;
            UInt16 bit_index = (UInt16)xi_bit_index;

            if (bit_length > 0) do
            {
                mask <<= 0x1;
                mask |= 1;
            } while (bit_length-- > 2);


            mask <<= bit_index;

            res_data = (byte)((mask & xi_data) >> bit_index);

            return (res_data);
        }

        #endregion

        internal void UpdateChartLists(Int32 mem_key)
        {
            UInt16 MAX_ALLOWED_PARAMS_IN_GROUP = 5; /* Need to be part of the header */

            tlm_x_chart.Clear();
            tlm_y_chart.Clear();

            double count_t = 0.3;
            double t_count = 0x0;
            foreach (var member in _tlm_db)
            {
                if (member.param_key == mem_key)
                {
                    tlm_x_chart.Add(count_t * (1 + t_count++));
                    tlm_y_chart.Add(Convert.ToDouble(member.value));
                }
            }
        }
    }
}
