using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RemoteReading
{
    public partial class ServerSet : Form
    {
        //串口列表变量
        private string[] ComPortsList;



        //获得串口列表
        public string[] ComPorts
        {
            set
            {
                ComPortsList = value;
            }
        }


        public ServerSet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //退出参数设置界面
            this.Close();

        }

        private void ServerSet_Load(object sender, EventArgs e)
        {

            // 装载串口号列表
            for (int i = 0; i < ComPortsList.Length; i++)
            {
                cbbComPorts.Items.Add(ComPortsList[i]);

            }
            //设置界面默认参数
            cbbComPorts.SelectedIndex = 0;
            cbbBodeRate.SelectedIndex = 0;
            cbbStopBit.SelectedIndex = 0;
            cbbDataBit.SelectedIndex = 0;
            cbbDataBit.SelectedIndex = 0;
            cbbParity.SelectedIndex = 2;
            txbMeterReadingRate.Text = "1";
            txbDayReadTime.Text = "0";
            txbMonthReading.Text = "15";
            txbDataLenght.Text = "1000";
            txbIp.Text = "192.168.0.131";
            txbPort.Text = "2000";

        }

        private void btnSaveSet_Click(object sender, EventArgs e)
        {
            //存储设置参数到listsave结构体
            ServerSetList ListSave = new ServerSetList();
            try
            {
                ListSave.ComunictionStyle = tbcComunication.SelectedIndex.ToString();
                ListSave.ComPortID = cbbComPorts.SelectedItem.ToString();
                ListSave.BodeRate = cbbBodeRate.SelectedItem.ToString();
                ListSave.Stop = cbbStopBit.SelectedItem.ToString();
                ListSave.Databit = cbbDataBit.SelectedItem.ToString();
                ListSave.Parity = cbbParity.SelectedItem.ToString();
                ListSave.MeterReadingRate = txbMeterReadingRate.Text;
                ListSave.MeterTime = txbDayReadTime.Text;
                ListSave.MeterDay = txbMonthReading.Text;
                ListSave.DataLength = txbDataLenght.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            //把setform的父窗口赋值给mainform
            RemoteReadingSystem back2mainForm = (RemoteReadingSystem)this.Owner;
            back2mainForm.Setlist = ListSave;

            FileStream fs = new FileStream("SeverSet.ini", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(ListSave.ComPortID + "\r\n" + ListSave.BodeRate + "\r\n" + ListSave.Stop + "\r\n" + ListSave.Databit + "\r\n" + ListSave.Parity + "\r\n" + ListSave.MeterReadingRate + "\r\n" + ListSave.MeterTime + "\r\n" + ListSave.MeterDay + "\r\n" + ListSave.DataLength);
            sw.Close();
            fs.Close();
            //退出窗口
            this.Close();
        }

    }
}
