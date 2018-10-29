using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

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
                TLM_OPT_SAVE_FILE_RAW,
                TLM_OPT_SAVE_FILE_VISUAL,
                TLM_OPT_SAVE_FILE_TEXT,

                /* SORT TYPE */
                TLM_OPT_SORT_GROUPS,
                TLM_OPT_SORT_HIGH_LOW,
                TLM_OPT_SORT_INDEX,

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

            /* FLASH STORE: YES / NO */
            TLM_BIT_FIELD_A_FLASH_IDX = 0x0,
            TLM_BIT_FIELD_A_FLASH_LEN = 0x1,

            /* GROUP - Up to 32 groups */
            TLM_BIT_FIELD_A_GROUP_IDX = 0x1,
            TLM_BIT_FIELD_A_GROUP_LEN = 0x5,

            /* DATA SIGN */
            TLM_BIT_FIELD_A_DATA_SIGN_IDX = 0x6,
            TLM_BIT_FIELD_A_DATA_SIGN_LEN = 0x1,

            /* Second configuration byte */

            /* PARAM_IDX - Up to 8 params in each module */
            TLM_BIT_FIELD_B_PARAM_IDX = 0x0,
            TLM_BIT_FIELD_B_PARAM_LEN = 0x3,

            /* VISUALITY: YES / NO */
            TLM_BIT_FIELD_B_VISUALITY_IDX = 0x3,
            TLM_BIT_FIELD_B_VISUALITY_LEN = 0x1,

            /* RATE: */
            TLM_BIT_FIELD_B_RATE_IDX = 0x4,
            TLM_BIT_FIELD_B_RATE_LEN = 0x2,

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
            TLM_DATA_CHAR = 0,              /* char range: 0 - 255 */
            TLM_DATA_INT16,                 /* int range: 0 -:- 65,535 */
            TLM_DATA_INT32,                 /* int range: 0 -:- 65,535 */
            TLM_DATA_INT64,                 /* int range: 0 -:- 65,535 */
            TLM_DATA_REAL,                  /* Float range: 6 decimal places, Double range: 15 decimal places */
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
            TLM_OPT_IDX_CONF_PATH,
            TLM_OPT_IDX_SORT_MODE_IDX,
            TLM_OPT_IDX_DATA_TYPE_IDX,
        };

        enum enumTLM_rate_type : int
        {
            TLM_RATE_FAST   = 1,    /* 1 * 100 mSec rate = 100 msec*/
            TLM_RATE_NORMAL = 2,    /* 2 * 100 mSec rate = 200 msec*/
            TLM_RATE_SLOW   = 3     /* 3 * 100 mSec rate = 300 msec*/
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
            public string Data_sign { get; set; }
            public UInt32 param_key { get; set; }
        }

        public class TLMOptions
        {
            
            public TLMModuleOptions.enumTLM_opt read_source { get; internal set; }
            public TLMModuleOptions.enumTLM_opt sort_mode { get; internal set; }
            public TLMModuleOptions.enumTLM_opt data_type { get; internal set; }
            public TLMModuleOptions.enumTLM_opt Save_format { get; internal set; }
            public string conf_path { get; internal set; }
            public string file_read_path { get; internal set; }
            public string save_out_path { get; internal set; }
            
        }

        public class TLMNamesTable
        {
            public string name { get; set; }
            public UInt32 key { get; set; }
        }

        #endregion

        #region Verbs

        string _readFileSourcePath = string.Empty;
        string _storeRawFilesPath = string.Empty;
        private readonly Int16 C_TLM_MAX_PACKET_SIZE_BYTES = 20;
        int C_TLM_HEADER_NUM_BYTES = 2;
        

        /* Binding source */

        public TLMOptions g_TLM_conf;
        public List<TLMDataTable> g_TLM_db;
        List<TLMNamesTable> _tlm_db_names;
        
        private bool _first_round_flag = true;
        private string C_TLM_CONF_FILE_EXTENSION = @"\conf1.text";

        public List<double> tlm_x_chart { get; set; }
        public List<double> tlm_y_chart { get; set; }
        public List<string> tlm_view_table { get; set; }
        public string[] g_TLM_ret_conf { get; set; }
        public List<string> tlm_group_list { get; set; }


        #endregion

        #region C`tor

        public TLMModule(SocketHandler.enumDevice_id deviceID)
        {
            deviceIdConnected = deviceID;


            /* Init module TLM lists */
            g_TLM_db = new List<TLMDataTable>();
            tlm_x_chart = new List<double>();
            tlm_y_chart = new List<double>();
            tlm_view_table = new List<string>();
            tlm_group_list = new List<string>();
            g_TLM_conf = new TLMOptions();

            g_TLM_ret_conf = new string[6];
            g_TLM_conf.conf_path = string.Empty;
            read_config_files();
        }

        private void read_config_files()
        {
            //if(g_TLM_conf.conf_path == string.Empty)
        }

        #endregion

        #endregion

        #region Set TLM module configuration

        internal void SetTlmOptions()
        {
            SetTlmMembersName();
            SaveConfigToFile();
        }

        private void SaveConfigToFile()
        {
            string conf_path = g_TLM_conf.conf_path + C_TLM_CONF_FILE_EXTENSION;
            if (g_TLM_conf.conf_path != string.Empty)
            {
                /*  Create file if don`t exist */
                if (false == File.Exists(conf_path))
                {
                    File.Create(conf_path);
                }

                using (StreamWriter writer = new StreamWriter(conf_path))
                {
                    writer.WriteLine(g_TLM_conf.conf_path);
                    writer.WriteLine(g_TLM_conf.data_type);
                    writer.WriteLine(g_TLM_conf.read_source);
                    writer.WriteLine(g_TLM_conf.sort_mode);
                    if(g_TLM_conf.file_read_path != null)
                    {
                        writer.WriteLine(g_TLM_conf.file_read_path);
                    }

                    if (g_TLM_conf.save_out_path != null)
                    {
                        writer.WriteLine(g_TLM_conf.save_out_path);
                    }

                }
            }
        }

        private void SetTlmMembersName()
        {
            int a = 0x7;
        }

        #endregion

        #region Find data member

        internal string SelectDataMember(string xi_find_name, string xi_find_group)
        {
            UInt16 MAX_ALLOWED_PARAMS_IN_GROUP = 5; /* Need to be part of the header */
            UInt16 param_index = 0x0;

            Int32 calc_key = 0x0;
            string ret_val = string.Empty;

            if(xi_find_name != string.Empty)
            {
                /* check if name is param index */
                if (true == xi_find_name.All(char.IsDigit)) param_index = Convert.ToUInt16(xi_find_name);

                calc_key = (UInt16)(tlm_fromStringToEnumVal(xi_find_group) * MAX_ALLOWED_PARAMS_IN_GROUP + param_index);

                /* Update telemetric chart with this found key */ 
                ret_val = UpdateChartLists(calc_key);
            }
            else
            {
                ret_val = string.Empty;
            }
            
            /* Return data table */
            return (ret_val);
        }

        internal string UpdateChartLists(Int32 mem_key)
        {
            UInt16 MAX_ALLOWED_PARAMS_IN_GROUP = 5; /* Need to be part of the header */

            tlm_x_chart.Clear();
            tlm_y_chart.Clear();

            double t_count = 0x0;
            string legenet_text = string.Empty;

            foreach (var member in g_TLM_db)
            {
                if (member.param_key == mem_key)
                {
                    if (member.rate == "FAST")
                    {
                        t_count += 0.3;
                    }
                    else if (member.rate == "NORMAL")
                    {
                        t_count += 0.2;
                    }
                    else if (member.rate == "SLOW")
                    {
                        t_count += 0.1;
                    }

                    tlm_x_chart.Add(t_count * 1000);
                    tlm_y_chart.Add(Convert.ToDouble(member.value));
                    tlm_view_table.Add(string.Format("value: {0} \tTime: {1}", member.value, (t_count * 1000).ToString()));
                    legenet_text = string.Format("legend: group: {0} param index: {1}", member.group, member.idx);
                }
            }
            return (legenet_text);

        }

        

        #endregion

        #region Update Telemetric process

        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            TlmUpdateTable(msg, size, type, source);
            if (g_TLM_conf.Save_format == TLMModuleOptions.enumTLM_opt.TLM_OPT_SAVE_FILE_RAW)
            {
                TlmStoreData(msg);
            }

            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));
            return true;
        }

        private void TlmStoreData(byte[] msg)
        {
            string file_path = string.Format(@"{0}\{1}_", g_TLM_conf.save_out_path, DateTime.Now.ToString().Replace('/', '_').Replace(':', '_'));

            switch (g_TLM_conf.Save_format)
            {
                case TLMModuleOptions.enumTLM_opt.TLM_OPT_SAVE_FILE_RAW:
                    file_path += "raw.text"; 
                    break;

                case TLMModuleOptions.enumTLM_opt.TLM_OPT_SAVE_FILE_TEXT:
                    file_path += "raw.text";
                    break;

                default:
                    return;
            }

            using (Stream file = File.OpenWrite(file_path))
            {
                file.Write(msg, 0, msg.Length);
            }
        }

        public void TlmUpdateTable(byte[] msg, uint size, uint type, uint source)
        {
            if (_first_round_flag == true)
            {
                g_TLM_db.Clear();
                _first_round_flag = false;
            }
            
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
            if (g_TLM_conf.sort_mode == TLMModuleOptions.enumTLM_opt.TLM_OPT_SORT_GROUPS)
            {
                g_TLM_db.Sort((x, y) => x.group.CompareTo(y.group));
            }
            else if (g_TLM_conf.sort_mode == TLMModuleOptions.enumTLM_opt.TLM_OPT_SORT_INDEX)
            {
                g_TLM_db.Sort((x, y) => x.idx.CompareTo(y.idx));
            }
            else if (g_TLM_conf.sort_mode == TLMModuleOptions.enumTLM_opt.TLM_OPT_SORT_HIGH_LOW)
            {
                g_TLM_db.Sort((x, y) => x.value.CompareTo(y.value));
            }

            /* Display packet value by bytes */
            if (g_TLM_conf.data_type == TLMModuleOptions.enumTLM_opt.TLM_OPT_DATA_TYPE_CHARS)
            {
                foreach (var member in g_TLM_db)
                {
                    //if(member.Data_type == "INT32" || member.Data_type == "INT64")
                    //{
                    //    member.value = BitConverter.ToString(BitConverter.GetBytes(Convert.ToInt32(member.value))).Replace("-", "");
                    //}
                }
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
            bool exist_param = false;
            UInt16 MAX_ALLOWED_PARAMS_IN_GROUP = 5; /* Need to be part of the header */

            string temp_group_str = string.Empty;
            UInt16 temp_param_idx = 0x0, temp_group_int = 0x0;
            UInt16 temp_sign = 0x0;
            UInt16 temp_type = 0x0;
            UInt16 temp_rate = 0x0;


            temp_group_int = p_TLM_get_data(xi_flags[0], enumTLM_bit_field_type.TLM_BIT_FIELD_A_GROUP_IDX, enumTLM_bit_field_type.TLM_BIT_FIELD_A_GROUP_LEN);
            temp_group_str = ((enumTLM_group_type)temp_group_int).ToString();
            temp_sign = p_TLM_get_data(xi_flags[0], enumTLM_bit_field_type.TLM_BIT_FIELD_A_DATA_SIGN_IDX, enumTLM_bit_field_type.TLM_BIT_FIELD_A_DATA_SIGN_LEN);

            temp_param_idx = p_TLM_get_data(xi_flags[1], enumTLM_bit_field_type.TLM_BIT_FIELD_B_PARAM_IDX, enumTLM_bit_field_type.TLM_BIT_FIELD_B_PARAM_LEN);
            temp_rate = p_TLM_get_data(xi_flags[1], enumTLM_bit_field_type.TLM_BIT_FIELD_B_RATE_IDX, enumTLM_bit_field_type.TLM_BIT_FIELD_B_RATE_LEN);

            temp_type = p_TLM_get_data(xi_flags[2], enumTLM_bit_field_type.TLM_BIT_FIELD_C_DATA_TYPE_IDX, enumTLM_bit_field_type.TLM_BIT_FIELD_C_DATA_TYPE_LEN);
            
            /* Prepere new node and insert it to TLM DB list */
            try
            {
                var _node = new TLMDataTable
                {
                    name = "A",
                    group = ((enumTLM_group_type)temp_group_int).ToString().Split('_')[2],
                    idx = temp_param_idx.ToString(),
                    value = System.Text.Encoding.Default.GetString(xi_data),
                    rate = ((enumTLM_rate_type)temp_rate).ToString().Split('_')[2],
                    Data_type = ((enumTLM_data_type)temp_type).ToString().Split('_')[2],
                    Data_sign = ((enumTLM_data_sign)temp_sign).ToString().Split('_')[2],
                    param_key = (UInt16)(temp_group_int * MAX_ALLOWED_PARAMS_IN_GROUP + temp_param_idx)
                };

                foreach (var item in g_TLM_db)
                {
                    if(item.param_key == _node.param_key)
                    {
                        if(item.value == _node.value)
                        {
                            exist_param = true;
                            break;
                        }
                    }
                }
                if(exist_param == false)
                {
                    g_TLM_db.Add(_node);

                    /* Update groups names list */
                    if (tlm_group_list.FindIndex(s => s.Contains(temp_group_str)) < 0)
                    {
                        tlm_group_list.Add(temp_group_str);
                    }
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



        internal void ResetCommand()
        {
            _first_round_flag = true;
        }

        internal void LoadList(string text)
        {
            string config_path = g_TLM_conf.conf_path != string.Empty ? g_TLM_conf.conf_path : text;
            config_path += C_TLM_CONF_FILE_EXTENSION;

            if (config_path != string.Empty)
            {
                g_TLM_ret_conf = System.IO.File.ReadAllLines(config_path);
            }
        }
    }
}
