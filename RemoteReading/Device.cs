using System;

namespace RemoteReading
{
    class Device
    {

        //日常综合数据
        int ItemYear = 17;
        int ItemMonth = 18;
        int ItemDay = 19;
        int ItemCS = 20;
        //byte[] DayeDate = new byte[] { 0x68, 0x80, 0x40, 0x10, 0x81, 0xC8, 0x00, 0x68, 0x12, 0x09, 0x00, 0x40, 0x01, 0x01, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x16 };
        public byte[] ReadDayData()
        {
            byte[] DayeDate = new byte[] { 0x68, 0x80, 0x40, 0x10, 0x81, 0xC8, 0x00, 0x68, 0x12, 0x09, 0x00, 0x40, 0x01, 0x01, 0x00, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x16 };
            DayeDate[ItemYear] = Convert.ToByte(((DateTime.Now.Year - 2000) / 10) * 16 + ((DateTime.Now.Year - 2000) % 10));
            //MessageBox.Show(DayeDate[ItemYear].ToString());
            DayeDate[ItemMonth] = Convert.ToByte(((DateTime.Now.Month) / 10) * 16 + ((DateTime.Now.Month) % 10));
            DayeDate[ItemDay] = Convert.ToByte(((DateTime.Now.Day - 1) / 10) * 16 + ((DateTime.Now.Day - 1) % 10));
            int SumTemp = 0;
            for (int i = 0; i < (DayeDate.Length - 2); i++)
            {
                SumTemp = SumTemp + DayeDate[i];


            }
            DayeDate[ItemCS] = Convert.ToByte(SumTemp % 256);

            return DayeDate;

        }
    }
}
