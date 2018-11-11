using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace RT_Viewer.Framework
{
    public class ICDModule : IModule
    {
        const uint MAX_NUM_OF_CODES = 300;
        const uint C_UAV_FIELD_ERROR_LENGTH = 51;

        enum enumSwCmpIdType
        {
            /* ------------------------ */
            MIN_SW_CMP_ID = 0,
            /* ------------------------ */
            HST_SW_CMP_ID, // 1
            NTP_SW_CMP_ID, // 2
            AGP_SW_CMP_ID, // 3
            RTI_SW_CMP_ID, // 4
            HKY_SW_CMP_ID, // 5
            APP_SW_CMP_ID, // 6
            UAV_SW_CMP_ID, // 7
            NVM_SW_CMP_ID, // 8
            FRM_SW_CMP_ID, // 9
            STK_SW_CMP_ID, // 10
            LOG_SW_CMP_ID, // 11
            VTU_SW_CMP_ID, // 12
            PFD_SW_CMP_ID, // 13
            GDT_SW_CMP_ID, // 14
            GDV_SW_CMP_ID, // 15
            MGC_SW_CMP_ID, // 16
            IRD_SW_CMP_ID, // 17
            ICD_SW_CMP_ID, // 18
            /* ------------------------ */
            MAX_SW_CMP_ID		   // 19
            /* ------------------------ */
        } ;


        public class ICDOpcodeErrorTableEntry
        {
            public string opcode { get; set; }
            public string module_name   { get; set; }
            public string line   { get; set; }
            public string error_field   { get; set; }
        }

        public struct OpcodeError
        {
            public uint opcode;
            public uint module_id;
            public uint line;
            public string error_field;
         }
        
        public struct ICDSturct
        {
            public uint NumOfLines;
            public OpcodeError[] opcodeErrorEntry;
        }

        public ICDSturct opcodeErrorEntryStruct;

        public BindingList<ICDOpcodeErrorTableEntry> BL_ICDOpcodeErrorTable;

        public uint m_nextFreeLine = 0;

        public ICDModule(SocketHandler.enumDevice_id deviceID)
        {
            deviceIdConnected = deviceID;
            opcodeErrorEntryStruct = new ICDSturct();

            opcodeErrorEntryStruct.NumOfLines = MAX_NUM_OF_CODES;
            opcodeErrorEntryStruct.opcodeErrorEntry = new OpcodeError[MAX_NUM_OF_CODES]; 

        }

        public void Clear()
        {
            opcodeErrorEntryStruct = new ICDSturct();

            opcodeErrorEntryStruct.NumOfLines = MAX_NUM_OF_CODES;
            opcodeErrorEntryStruct.opcodeErrorEntry = new OpcodeError[MAX_NUM_OF_CODES];

            m_nextFreeLine = 0;
        }


        public override bool update(byte[] msg, uint size, uint type, uint source)
        {
            uint opcode;
            int indexReader = 0;
            int opcodeIndex = -1;
            uint NumOfLines = 0;
            int lineNumber = -1;
            string module_name;
            uint num_of_line;
            uint module_id;
            string field_name;
            StringBuilder sb = new StringBuilder();
            char[] err_field = new char[C_UAV_FIELD_ERROR_LENGTH];


            BL_ICDOpcodeErrorTable = new BindingList<ICDOpcodeErrorTableEntry>();

            NumOfLines = (uint)BitConverter.ToInt32(msg, indexReader);
            indexReader += 4;

            for (int i = 0; i < NumOfLines; i++)
            {
                opcode = (uint)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;

                module_id = (uint)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;

                num_of_line = (uint)BitConverter.ToInt32(msg, indexReader);
                indexReader += 4;

                char[] carray = new char[C_UAV_FIELD_ERROR_LENGTH];

                for (int index = 0; index < C_UAV_FIELD_ERROR_LENGTH-1; index++)
                {
                    carray[index] = (char)msg[indexReader]; 

                    indexReader += 1;
                }

                carray[C_UAV_FIELD_ERROR_LENGTH - 1] = (char)0;

                sb = new StringBuilder();

                sb.Append(carray);

                field_name = sb.ToString();

                if (opcode > 0 && module_id > 0 && num_of_line > 0)
                {
                    Console.WriteLine("Received new line with OPCODE = " + opcode.ToString() + " MODULE = " + module_id.ToString() + " LINE = " + num_of_line.ToString() + " NAME = " + field_name);

                    Console.WriteLine("");

                    opcodeIndex = FindIndexOfOpcode(opcode, module_id);

                    if (opcodeIndex == -1)
                    {
                        // New opcode reported
                        if (m_nextFreeLine < MAX_NUM_OF_CODES)
                        {
                            // assign next free line
                            lineNumber = (int)m_nextFreeLine;

                            m_nextFreeLine++;

                            opcodeErrorEntryStruct.opcodeErrorEntry[lineNumber].opcode = opcode;

                            opcodeErrorEntryStruct.opcodeErrorEntry[lineNumber].module_id = module_id;
                        }
                        else
                        {
                            // no more space in table
                            lineNumber = -1;
                        }
                    }
                    else // opcode found
                    {
                        lineNumber = opcodeIndex;
                    }

                    if (lineNumber != -1)
                    {
                        opcodeErrorEntryStruct.opcodeErrorEntry[lineNumber].line = num_of_line;

                        opcodeErrorEntryStruct.opcodeErrorEntry[lineNumber].error_field = field_name;

                   }
                }
                else
                {
                    //Console.WriteLine("Received new line with all 0");
                }
            }

            for (uint i = m_nextFreeLine; i < MAX_NUM_OF_CODES; i++)
            {
                opcodeErrorEntryStruct.opcodeErrorEntry[i].opcode = 0;
                opcodeErrorEntryStruct.opcodeErrorEntry[i].module_id = 0;
                opcodeErrorEntryStruct.opcodeErrorEntry[i].line = 0;

                opcodeErrorEntryStruct.opcodeErrorEntry[i].error_field = "";
            }

            for (int i = 0; i < m_nextFreeLine; i++)
            {
                module_name = intToEnumICD_sw_component_kindType((int)opcodeErrorEntryStruct.opcodeErrorEntry[i].module_id);

                BL_ICDOpcodeErrorTable.Add(new ICDOpcodeErrorTableEntry
                {
                    opcode = opcodeErrorEntryStruct.opcodeErrorEntry[i].opcode.ToString(),
                    module_name = module_name,
                    line = opcodeErrorEntryStruct.opcodeErrorEntry[i].line.ToString(),
                    error_field = opcodeErrorEntryStruct.opcodeErrorEntry[i].error_field,
                });
            }
            for (uint i = m_nextFreeLine; i < MAX_NUM_OF_CODES; i++)
            {
                module_name = intToEnumICD_sw_component_kindType((int)opcodeErrorEntryStruct.opcodeErrorEntry[i].module_id);

                BL_ICDOpcodeErrorTable.Add(new ICDOpcodeErrorTableEntry
                {
                    opcode = "",
                    module_name = "",
                    line = "",
                    error_field = "",
                });
            }
        

            DoInvoke(new IModuleEventArgs(this.deviceIdConnected));
            return true;
        }

        private int FindIndexOfOpcode(uint pOpcode, uint pmoduleId)
        {
            int entry;
            int found_entry = -1;

            for (entry = 0; entry < opcodeErrorEntryStruct.opcodeErrorEntry.Length; entry++)
            {
                if ((opcodeErrorEntryStruct.opcodeErrorEntry[entry].opcode == pOpcode) &&
                    (opcodeErrorEntryStruct.opcodeErrorEntry[entry].module_id == pmoduleId))
                {
                    found_entry = entry;
                    break;
                }
            }

            return found_entry;
        }

        public string intToEnumICD_sw_component_kindType(int num)
        {

            if (enumSwCmpIdType.IsDefined(typeof(enumSwCmpIdType), num))
            {
                enumSwCmpIdType theEnum = (enumSwCmpIdType)num;
                return theEnum.ToString().Substring(0, 3) + " (" + num.ToString() + ")"; // Display only 3 first letters
            }
            else
            {
                return num.ToString();
            }

        }


    }
}
