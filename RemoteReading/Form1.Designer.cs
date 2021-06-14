namespace RemoteReading
{
    partial class RemoteReadingSystem
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SystemName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnServerSet = new System.Windows.Forms.Button();
            this.btnMeterParameters = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbSuccess = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbDataTeam = new System.Windows.Forms.Label();
            this.lbreceive = new System.Windows.Forms.Label();
            this.lbSessionNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trvMeter = new System.Windows.Forms.TreeView();
            this.lbMeterNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tasktimer = new System.Windows.Forms.Timer(this.components);
            this.TimerSendAgain = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemName
            // 
            this.SystemName.AutoSize = true;
            this.SystemName.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SystemName.Location = new System.Drawing.Point(125, 9);
            this.SystemName.Name = "SystemName";
            this.SystemName.Size = new System.Drawing.Size(360, 24);
            this.SystemName.TabIndex = 0;
            this.SystemName.Text = "远程集中抄表系统（服务器端）";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 364);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnServerSet);
            this.panel4.Controls.Add(this.btnMeterParameters);
            this.panel4.Controls.Add(this.btnStop);
            this.panel4.Controls.Add(this.btnStart);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(463, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 351);
            this.panel4.TabIndex = 2;
            // 
            // btnServerSet
            // 
            this.btnServerSet.Location = new System.Drawing.Point(6, 154);
            this.btnServerSet.Name = "btnServerSet";
            this.btnServerSet.Size = new System.Drawing.Size(111, 43);
            this.btnServerSet.TabIndex = 5;
            this.btnServerSet.Text = "服务器参数";
            this.btnServerSet.UseVisualStyleBackColor = true;
            this.btnServerSet.Click += new System.EventHandler(this.btnServerSet_Click);
            // 
            // btnMeterParameters
            // 
            this.btnMeterParameters.Location = new System.Drawing.Point(6, 203);
            this.btnMeterParameters.Name = "btnMeterParameters";
            this.btnMeterParameters.Size = new System.Drawing.Size(111, 43);
            this.btnMeterParameters.TabIndex = 4;
            this.btnMeterParameters.Text = "集中器参数";
            this.btnMeterParameters.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 301);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 43);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "服务器停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 252);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 43);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "服务器启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lbSuccess);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.lbDataTeam);
            this.panel5.Controls.Add(this.lbreceive);
            this.panel5.Controls.Add(this.lbSessionNum);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(5, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 125);
            this.panel5.TabIndex = 1;
            // 
            // lbSuccess
            // 
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.Location = new System.Drawing.Point(76, 102);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(29, 12);
            this.lbSuccess.TabIndex = 7;
            this.lbSuccess.Text = "100%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "通讯成功率：";
            // 
            // lbDataTeam
            // 
            this.lbDataTeam.AutoSize = true;
            this.lbDataTeam.Location = new System.Drawing.Point(76, 71);
            this.lbDataTeam.Name = "lbDataTeam";
            this.lbDataTeam.Size = new System.Drawing.Size(11, 12);
            this.lbDataTeam.TabIndex = 5;
            this.lbDataTeam.Text = "1";
            // 
            // lbreceive
            // 
            this.lbreceive.AutoSize = true;
            this.lbreceive.Location = new System.Drawing.Point(76, 39);
            this.lbreceive.Name = "lbreceive";
            this.lbreceive.Size = new System.Drawing.Size(11, 12);
            this.lbreceive.TabIndex = 4;
            this.lbreceive.Text = "0";
            // 
            // lbSessionNum
            // 
            this.lbSessionNum.AutoSize = true;
            this.lbSessionNum.Location = new System.Drawing.Point(76, 10);
            this.lbSessionNum.Name = "lbSessionNum";
            this.lbSessionNum.Size = new System.Drawing.Size(11, 12);
            this.lbSessionNum.TabIndex = 3;
            this.lbSessionNum.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "包队列长度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "接收包数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "会话数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "服务器状态";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtData);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(158, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 353);
            this.panel3.TabIndex = 1;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtData.Location = new System.Drawing.Point(-1, 26);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(299, 325);
            this.txtData.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "通讯数据";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.trvMeter);
            this.panel2.Controls.Add(this.lbMeterNum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 353);
            this.panel2.TabIndex = 0;
            // 
            // trvMeter
            // 
            this.trvMeter.Location = new System.Drawing.Point(-1, 25);
            this.trvMeter.Name = "trvMeter";
            this.trvMeter.Size = new System.Drawing.Size(147, 327);
            this.trvMeter.TabIndex = 2;
            // 
            // lbMeterNum
            // 
            this.lbMeterNum.AutoSize = true;
            this.lbMeterNum.Location = new System.Drawing.Point(101, 4);
            this.lbMeterNum.Name = "lbMeterNum";
            this.lbMeterNum.Size = new System.Drawing.Size(41, 12);
            this.lbMeterNum.TabIndex = 1;
            this.lbMeterNum.Text = "共30台";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "电能表";
            // 
            // Tasktimer
            // 
            this.Tasktimer.Enabled = true;
            this.Tasktimer.Interval = 5000;
            this.Tasktimer.Tick += new System.EventHandler(this.Tasktimer_Tick);
            // 
            // TimerSendAgain
            // 
            this.TimerSendAgain.Enabled = true;
            this.TimerSendAgain.Interval = 10000;
            this.TimerSendAgain.Tick += new System.EventHandler(this.TimerSendAgain_Tick);
            // 
            // RemoteReadingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SystemName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoteReadingSystem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoteReadingSystemV1.0";
            this.Load += new System.EventHandler(this.RemoteReadingSystem_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SystemName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMeterNum;
        private System.Windows.Forms.Button btnMeterParameters;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbSuccess;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbDataTeam;
        private System.Windows.Forms.Label lbreceive;
        private System.Windows.Forms.Label lbSessionNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnServerSet;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TreeView trvMeter;
        private System.Windows.Forms.Timer TimerSendAgain;
        private System.Windows.Forms.Timer Tasktimer;
    }
}

