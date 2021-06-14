using System;

namespace RemoteReading
{
    class DataSaveToDB
    {
        //保存日常抄收电量数据
        public int SaveDayPower(byte[] buffer)
        {
            //数据库实例
            MeterBD DataBS = new MeterBD();
            int BufferLenght = buffer.Length;
            string selectItem = buffer[15].ToString() + buffer[16].ToString();
            //电表编号
            //string MeterIDStr = null;
            int DataLenght = buffer[9] + buffer[10] * 256;
            int MeterNumber = (DataLenght - 9) / (buffer[26] + 6);
            // 只读电表编码和日末电量两项
            string[,] Meterlist = new string[MeterNumber, 2];

            //BCD日期码转换成string

            string date = "20";
            for (int i = 0; i < 3; i++)
            {
                if (i != 2)
                {
                    date += Convert.ToString(buffer[17 + i], 16) + "-";
                }
                else
                {
                    date += Convert.ToString(buffer[17 + i], 16);
                }
            }



            //电表编号和日电量的读取
            int countMeter = 0;
            for (int i = 0; i < MeterNumber; i++)
            {
                //电表编号转换
                string MeterIDTemp = null;
                for (int k = 0; k < 6; k++)
                {
                    if (buffer[25 + countMeter - k] < 16)
                    {
                        MeterIDTemp += "0";
                        MeterIDTemp += Convert.ToString(buffer[25 + countMeter - k], 16);
                    }
                    else
                    {
                        MeterIDTemp += Convert.ToString(buffer[25 + countMeter - k], 16);
                    }
                }
                Meterlist[i, 0] = MeterIDTemp;


                //电量转换，16进制转换为10进制
                byte powerHigh = 0, powerLow = 0;
                int[] powerTemp = new int[4];
                for (int n = 0; n < 4; n++)
                {
                    if (buffer[29 + countMeter + n] < 0xff)
                    {
                        powerHigh = Convert.ToByte(buffer[29 + countMeter + n] & 0xF0);//取出高四位；
                        powerHigh = Convert.ToByte(powerHigh >> 4);
                        powerLow = Convert.ToByte(buffer[29 + countMeter + n] & 0x0F);
                        powerTemp[n] = (powerHigh * 10 + powerLow);
                    }
                    else
                    {
                        powerTemp[n] = 0x00;
                    }
                }
                Meterlist[i, 1] = Convert.ToString(powerTemp[0] * 0.01 + powerTemp[1] + powerTemp[2] * 100 + powerTemp[3] * 10000);
                countMeter += (buffer[26] + 7);
            }


            //查询课室号
            string[] classroomID = new string[MeterNumber];
            for (int i = 0; i < MeterNumber; i++)
            {
                string Serchcommand = "Select ClassRoomID from MeterPlace where MeterID='" + Meterlist[i, 0] + "'";
                classroomID[i] = DataBS.ReadDB(Serchcommand);

            }
            //查设备号
            string[] MeterID = new string[MeterNumber];
            for (int i = 0; i < MeterNumber; i++)
            {
                string Serchcommand = "Select MeterID from MeterPlace where MeterID='" + Meterlist[i, 0] + "'";
                MeterID[i] = DataBS.ReadDB(Serchcommand);

            }
            //查询最大的记录编号
            string SerchMax = "Select max(RecordID) from ReadRecord";
            string MaxRecordID = DataBS.ReadDB(SerchMax);
            //string MaxRecordID = null;
            if (MaxRecordID == null)
            {
                MaxRecordID = "0";
            }
            int maxID = Convert.ToInt32(MaxRecordID);



            //写入数据库

            for (int i = 0; i < MeterNumber; i++)
            {
                if ((classroomID[i] != null) & (MeterID[i] != null) & (Meterlist[i, 1] != "0"))
                {
                    string command = "insert into ReadRecord(RecordID,ClassRoomID,MeterID,MeterStatu,DayPower,TotalPower,HighPower,PeakPower,AvergePower,VallagePower,ReadDate) values (";
                    command += "'" + Convert.ToString(maxID + 1) + "'," + "'" + classroomID[i] + "'," + "'" + Meterlist[i, 0] + "'," + "'0'," + "'" + Meterlist[i, 1] + "'," + "'0'," + "'0'," + "'0'," + "'0'," + "'0'," + "'" + date + "'" + ")";
                    int back = DataBS.WriteDB(command);
                    maxID += 1;
                }
            }

            return 1;

        }

    }
}