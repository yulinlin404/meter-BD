using System;
using System.IO.Ports;
using System.Windows.Forms;
//using System.Windows.Forms.TreeView;
namespace RemoteReading
{
    //服务器设置参数结构体
    public struct ServerSetList
    {
        //通讯方式（串口0/GPRS1）
        public string ComunictionStyle;
        public string ComPortID;
        public string BodeRate;
        public string Stop;
        public string Databit;
        public string Parity;
        public string MeterReadingRate;
        public string MeterTime;
        public string MeterDay;
        public string DataLength;
    };

    public partial class RemoteReadingSystem : Form
    {
        //声明变量serialPort
        private System.IO.Ports.SerialPort serialPort = new System.IO.Ports.SerialPort();
        //串口号变量
        private string[] protNames;

        //串口接收数据变量
        private string strtemp = string.Empty;

        //日常数据抄收变量
        static bool DayReadModleStart = false;
        //发送命令
        static bool Sended = false;
        //重发命令
        static bool SendAgain = false;
        //接收成功
        static bool reciveSucess = false;
        //日常数据抄收标志
        static bool MarkTask = false;
        //发送次数
        float sendTimes = 0;
        //接收次数
        float reciveTimes = 0;



        //实例化serversetlist
        private ServerSetList lists;
        public ServerSetList Setlist
        {
            set
            {
                lists = value;
            }
        }

        public RemoteReadingSystem()
        {
            InitializeComponent();
        }
        //开串口的方法
        private void SerialOpen()
        {
            //判断串口状态
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            try
            {
                //设置串口参数
                serialPort.PortName = lists.ComPortID;
                serialPort.BaudRate = Convert.ToInt32(lists.BodeRate);
                //设置奇偶校验位
                if (lists.Parity == "偶校验")
                {
                    serialPort.Parity = System.IO.Ports.Parity.Even;
                }
                else if (lists.Parity == "奇校验")
                {
                    serialPort.Parity = System.IO.Ports.Parity.Odd;
                }
                else
                {
                    serialPort.Parity = System.IO.Ports.Parity.None;
                }
                serialPort.DataBits = Convert.ToByte(lists.Databit);
                //设置停止位
                if (lists.Stop == "1")
                {
                    serialPort.StopBits = System.IO.Ports.StopBits.One;
                }
                else if (lists.Stop == "2")
                {
                    serialPort.StopBits = System.IO.Ports.StopBits.Two;
                }
                else
                {
                    serialPort.StopBits = System.IO.Ports.StopBits.None;
                }
                //serialPort.ReadBufferSize = 1024;


                //打开串口
                serialPort.Open();
                //声明串口接收事件
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //关串口方法

        //串口发送数据方法
        private void SerialWrite(byte[] SendData)
        {

            try
            {
                serialPort.Write(SendData, 0, SendData.Length);

                //显示通讯数据

                string strtemp = string.Empty;
                string stra = string.Empty;
                foreach (byte b in SendData)
                {
                    stra = Convert.ToString(b, 16);
                    strtemp = strtemp + stra + " ";

                }
                txtData.AppendText(DateTime.Now.ToString() + "send(" + Convert.ToString(SendData.Length) + " Byte):" + strtemp + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        //接收串口数据
        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int ReceivedBufSize;
            System.Threading.Thread.Sleep(2000);
            try
            {
                ReceivedBufSize = serialPort.BytesToRead;
                byte[] bytebuffer = new byte[ReceivedBufSize];
                strtemp = string.Empty;
                strtemp = DateTime.Now.ToString() + "received(" + Convert.ToString(ReceivedBufSize) + " Byte):";
                string stra = string.Empty;
                serialPort.Read(bytebuffer, 0, ReceivedBufSize);
                if (ReceivedBufSize > 0)
                {
                    if (bytebuffer[ReceivedBufSize - 1] == 0x16)
                    {

                        foreach (byte b in bytebuffer)
                        {
                            stra = Convert.ToString(b, 16);
                            strtemp = strtemp + stra + " ";

                        }
                        strtemp += Environment.NewLine;
                        //MessageBox.Show("收到数据！");
                        //有可能收到由于串口误触发的为0的字节；

                        //通过代理更新mainform上的控件
                        txtData.BeginInvoke(new myDelegate(updataTextBox));
                        DataSaveToDB DBsave = new DataSaveToDB();
                        DBsave.SaveDayPower(bytebuffer);
                        reciveSucess = true;
                        Sended = false;
                        reciveTimes += 1;

                    }
                    else
                    {
                        SendAgain = true;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        //通过代理把接收的的数据显示在txtdata上

        public delegate void myDelegate();
        public void updataTextBox()
        {
            txtData.AppendText(strtemp);
            txtData.ScrollToCaret();
            lbreceive.Text = (Convert.ToInt32(lbreceive.Text) + 1).ToString();
        }

        //显示所有电表在treeview中
        private void meterListShow()
        {

            //TreeNode B7totalMeter = new TreeNode();
            //B7totalMeter.Text = "B7总表";
            //trvMeter.Nodes.Add(B7totalMeter);
            //TreeNode Meter = new TreeNode();
            //Meter.Text = "B7-401(615422)";
            //B7totalMeter.Nodes.Add("1111");
            trvMeter.Nodes.Add("B7totalMeter");





        }
        //private void TreeView1_AfterSelect(System.Object sender,
        //System.Windows.Forms.TreeViewEventArgs e)
        //{ 

        //}




        private void RemoteReadingSystem_Load(object sender, EventArgs e)
        {
            //设置数据接收事件
            //SerialData.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);

            //显示所有串口
            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();
            //服务器启动按钮不可选
            //btnStart.Visible=false ;
            //显示所有电表
            meterListShow();
            //数据库连接测试
            MeterBD DataBS = new MeterBD();
            //DataBS.DBInit();
            //string command = "insert into login(UseID,UseName,UseRight) values ('004','MA','0')";
            //int back =DataBS.WriteDB(command );
            //MessageBox.Show(back.ToString() );
            string command = "Select ClassRoomID from MeterPlace where MeterID='000000615431'";
            string classroom = DataBS.ReadDB(command);
            MessageBox.Show("数据库连接测试：" + classroom);



        }

        //服务器参数设置界面
        private void btnServerSet_Click(object sender, EventArgs e)
        {

            //获得串口号列表
            protNames = SerialPort.GetPortNames();
            ServerSet serverSetForm = new ServerSet();
            //seversetform的owner指针指向form1
            serverSetForm.Owner = this;

            //传递串口号到服务器设置界面
            serverSetForm.ComPorts = protNames;

            serverSetForm.ShowDialog();
            //测试显示参数测试界面返回参数，显示COM号
            //MessageBox.Show(lists.ComPortID);

            //列出所有电表


        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            //启动串口
            SerialOpen();
            //发送数据
            //读电表列表
            //byte[] lbyte = new byte[] { 0x68, 0x80, 0x40, 0x10, 0x81, 0xc8, 0x01, 0x68, 0x15, 0x04, 0x00, 0x01, 0x00, 0x06, 0x00, 0x0A, 0x16 };
            //SerialWrite(lbyte);
            //日常数据抄收模式开启,由timer控制每日抄收任务
            SendAgain = false;
            DayReadModleStart = true;
            MarkTask = true;
            reciveSucess = false;
            Sended = false;



        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                //关闭串口
                serialPort.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Tasktimer_Tick(object sender, EventArgs e)
        {

            //是否开启日常数据抄收模式
            if (DayReadModleStart)
            {

                if (((DateTime.Now.Hour == 9) & MarkTask) | SendAgain)
                {
                    //MessageBox.Show("心跳");
                    TimerSendAgain.Stop();
                    MarkTask = false;
                    //读日常综合数据；
                    Device meterDevice = new Device();
                    byte[] DayeDate = meterDevice.ReadDayData();
                    SerialWrite(DayeDate);
                    Sended = true;
                    SendAgain = false;
                    sendTimes += 1;
                    TimerSendAgain.Start();
                    //MessageBox.Show(DateTime.Today.ToString() + "电量成功记录!");
                }
                if ((DateTime.Now.Hour != 9) & (!MarkTask))
                {
                    MarkTask = true;
                    reciveSucess = false;
                }

            }


        }

        private void TimerSendAgain_Tick(object sender, EventArgs e)
        {
            if ((reciveSucess == false) & Sended)
            {
                //读日常综合数据；
                Device meterDevice = new Device();
                byte[] DayeDate = meterDevice.ReadDayData();
                SerialWrite(DayeDate);
                //Sended = false ;
                sendTimes += 1;
                //MessageBox.Show ("重新发送！");

            }
            SendSuccess();

        }

        private void SendSuccess()
        {
            if ((sendTimes != 0) & (reciveTimes != 0))
            {
                lbSuccess.Text = Convert.ToString((reciveTimes / sendTimes) * 100) + "%";
            }

        }


    }
}
