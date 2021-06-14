namespace RemoteReading
{
    partial class ServerSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSaveSet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbMonthReading = new System.Windows.Forms.TextBox();
            this.txbDataLenght = new System.Windows.Forms.TextBox();
            this.txbDayReadTime = new System.Windows.Forms.TextBox();
            this.txbMeterReadingRate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbcComunication = new System.Windows.Forms.TabControl();
            this.tabPageRS232 = new System.Windows.Forms.TabPage();
            this.cbbParity = new System.Windows.Forms.ComboBox();
            this.cbbDataBit = new System.Windows.Forms.ComboBox();
            this.cbbStopBit = new System.Windows.Forms.ComboBox();
            this.cbbBodeRate = new System.Windows.Forms.ComboBox();
            this.cbbComPorts = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageInternet = new System.Windows.Forms.TabPage();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.txbIp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbcComunication.SuspendLayout();
            this.tabPageRS232.SuspendLayout();
            this.tabPageInternet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSaveSet);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 404);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaveSet
            // 
            this.btnSaveSet.Location = new System.Drawing.Point(391, 364);
            this.btnSaveSet.Name = "btnSaveSet";
            this.btnSaveSet.Size = new System.Drawing.Size(94, 30);
            this.btnSaveSet.TabIndex = 5;
            this.btnSaveSet.Text = "保存参数";
            this.btnSaveSet.UseVisualStyleBackColor = true;
            this.btnSaveSet.Click += new System.EventHandler(this.btnSaveSet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "服务器设置：";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(8, 356);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 3);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txbMonthReading);
            this.panel3.Controls.Add(this.txbDataLenght);
            this.panel3.Controls.Add(this.txbDayReadTime);
            this.panel3.Controls.Add(this.txbMeterReadingRate);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(8, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 146);
            this.panel3.TabIndex = 2;
            // 
            // txbMonthReading
            // 
            this.txbMonthReading.Location = new System.Drawing.Point(108, 77);
            this.txbMonthReading.Name = "txbMonthReading";
            this.txbMonthReading.Size = new System.Drawing.Size(100, 21);
            this.txbMonthReading.TabIndex = 8;
            // 
            // txbDataLenght
            // 
            this.txbDataLenght.Location = new System.Drawing.Point(108, 108);
            this.txbDataLenght.Name = "txbDataLenght";
            this.txbDataLenght.Size = new System.Drawing.Size(100, 21);
            this.txbDataLenght.TabIndex = 7;
            // 
            // txbDayReadTime
            // 
            this.txbDayReadTime.Location = new System.Drawing.Point(108, 48);
            this.txbDayReadTime.Name = "txbDayReadTime";
            this.txbDayReadTime.Size = new System.Drawing.Size(100, 21);
            this.txbDayReadTime.TabIndex = 6;
            // 
            // txbMeterReadingRate
            // 
            this.txbMeterReadingRate.Location = new System.Drawing.Point(108, 17);
            this.txbMeterReadingRate.Name = "txbMeterReadingRate";
            this.txbMeterReadingRate.Size = new System.Drawing.Size(100, 21);
            this.txbMeterReadingRate.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "数据长度";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "月冻结日期(日）";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "日冻结时间(h)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "抄表频率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "通讯方式：";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbcComunication);
            this.panel2.Location = new System.Drawing.Point(8, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 147);
            this.panel2.TabIndex = 0;
            // 
            // tbcComunication
            // 
            this.tbcComunication.Controls.Add(this.tabPageRS232);
            this.tbcComunication.Controls.Add(this.tabPageInternet);
            this.tbcComunication.Location = new System.Drawing.Point(5, 4);
            this.tbcComunication.Name = "tbcComunication";
            this.tbcComunication.SelectedIndex = 0;
            this.tbcComunication.Size = new System.Drawing.Size(569, 138);
            this.tbcComunication.TabIndex = 0;
            // 
            // tabPageRS232
            // 
            this.tabPageRS232.Controls.Add(this.cbbParity);
            this.tabPageRS232.Controls.Add(this.cbbDataBit);
            this.tabPageRS232.Controls.Add(this.cbbStopBit);
            this.tabPageRS232.Controls.Add(this.cbbBodeRate);
            this.tabPageRS232.Controls.Add(this.cbbComPorts);
            this.tabPageRS232.Controls.Add(this.label6);
            this.tabPageRS232.Controls.Add(this.label5);
            this.tabPageRS232.Controls.Add(this.label4);
            this.tabPageRS232.Controls.Add(this.label3);
            this.tabPageRS232.Controls.Add(this.label2);
            this.tabPageRS232.Location = new System.Drawing.Point(4, 22);
            this.tabPageRS232.Name = "tabPageRS232";
            this.tabPageRS232.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRS232.Size = new System.Drawing.Size(561, 112);
            this.tabPageRS232.TabIndex = 0;
            this.tabPageRS232.Text = "R232串口";
            this.tabPageRS232.UseVisualStyleBackColor = true;
            // 
            // cbbParity
            // 
            this.cbbParity.FormattingEnabled = true;
            this.cbbParity.Items.AddRange(new object[] {
            "奇校验",
            "偶校验",
            "无"});
            this.cbbParity.Location = new System.Drawing.Point(248, 56);
            this.cbbParity.Name = "cbbParity";
            this.cbbParity.Size = new System.Drawing.Size(100, 20);
            this.cbbParity.TabIndex = 10;
            // 
            // cbbDataBit
            // 
            this.cbbDataBit.FormattingEnabled = true;
            this.cbbDataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.cbbDataBit.Location = new System.Drawing.Point(65, 56);
            this.cbbDataBit.Name = "cbbDataBit";
            this.cbbDataBit.Size = new System.Drawing.Size(100, 20);
            this.cbbDataBit.TabIndex = 9;
            // 
            // cbbStopBit
            // 
            this.cbbStopBit.FormattingEnabled = true;
            this.cbbStopBit.Items.AddRange(new object[] {
            "1",
            "2",
            "无"});
            this.cbbStopBit.Location = new System.Drawing.Point(418, 16);
            this.cbbStopBit.Name = "cbbStopBit";
            this.cbbStopBit.Size = new System.Drawing.Size(100, 20);
            this.cbbStopBit.TabIndex = 8;
            // 
            // cbbBodeRate
            // 
            this.cbbBodeRate.FormattingEnabled = true;
            this.cbbBodeRate.Items.AddRange(new object[] {
            "9600",
            "4800",
            "2400",
            "1600",
            "1200",
            "800",
            "600"});
            this.cbbBodeRate.Location = new System.Drawing.Point(248, 16);
            this.cbbBodeRate.Name = "cbbBodeRate";
            this.cbbBodeRate.Size = new System.Drawing.Size(100, 20);
            this.cbbBodeRate.TabIndex = 7;
            // 
            // cbbComPorts
            // 
            this.cbbComPorts.FormattingEnabled = true;
            this.cbbComPorts.Location = new System.Drawing.Point(65, 16);
            this.cbbComPorts.Name = "cbbComPorts";
            this.cbbComPorts.Size = new System.Drawing.Size(100, 20);
            this.cbbComPorts.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "校验位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "数据位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "波特率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "串口号";
            // 
            // tabPageInternet
            // 
            this.tabPageInternet.Controls.Add(this.txbPort);
            this.tabPageInternet.Controls.Add(this.txbIp);
            this.tabPageInternet.Controls.Add(this.label8);
            this.tabPageInternet.Controls.Add(this.label7);
            this.tabPageInternet.Location = new System.Drawing.Point(4, 22);
            this.tabPageInternet.Name = "tabPageInternet";
            this.tabPageInternet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInternet.Size = new System.Drawing.Size(561, 112);
            this.tabPageInternet.TabIndex = 1;
            this.tabPageInternet.Text = "GPRS\\以太网";
            this.tabPageInternet.UseVisualStyleBackColor = true;
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(88, 58);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(115, 21);
            this.txbPort.TabIndex = 3;
            // 
            // txbIp
            // 
            this.txbIp.Location = new System.Drawing.Point(88, 31);
            this.txbIp.Name = "txbIp";
            this.txbIp.Size = new System.Drawing.Size(115, 21);
            this.txbIp.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "网络端口";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "前置机IP";
            // 
            // ServerSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 411);
            this.Controls.Add(this.panel1);
            this.Name = "ServerSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务器参数设置";
            this.Load += new System.EventHandler(this.ServerSet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tbcComunication.ResumeLayout(false);
            this.tabPageRS232.ResumeLayout(false);
            this.tabPageRS232.PerformLayout();
            this.tabPageInternet.ResumeLayout(false);
            this.tabPageInternet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tbcComunication;
        private System.Windows.Forms.TabPage tabPageRS232;
        private System.Windows.Forms.TabPage tabPageInternet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbParity;
        private System.Windows.Forms.ComboBox cbbDataBit;
        private System.Windows.Forms.ComboBox cbbStopBit;
        private System.Windows.Forms.ComboBox cbbBodeRate;
        private System.Windows.Forms.ComboBox cbbComPorts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.TextBox txbIp;
        private System.Windows.Forms.TextBox txbDataLenght;
        private System.Windows.Forms.TextBox txbDayReadTime;
        private System.Windows.Forms.TextBox txbMeterReadingRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaveSet;
        private System.Windows.Forms.TextBox txbMonthReading;
    }
}