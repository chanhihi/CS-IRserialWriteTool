namespace IR_Serial_Write_Tool_
{
    partial class IR_serial_write_tool
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IR_serial_write_tool));
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.serialWrite = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.KitNum = new System.Windows.Forms.TextBox();
            this.config = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.KitList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SerialNumberWrite = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_msg
            // 
            this.textBox_msg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_msg.Location = new System.Drawing.Point(0, 0);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.ReadOnly = true;
            this.textBox_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_msg.Size = new System.Drawing.Size(384, 210);
            this.textBox_msg.TabIndex = 96;
            // 
            // serialWrite
            // 
            this.serialWrite.Location = new System.Drawing.Point(10, 175);
            this.serialWrite.Name = "serialWrite";
            this.serialWrite.Size = new System.Drawing.Size(190, 36);
            this.serialWrite.TabIndex = 97;
            this.serialWrite.Text = "Serial Write";
            this.serialWrite.UseVisualStyleBackColor = true;
            this.serialWrite.Click += new System.EventHandler(this.serialWrite_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // KitNum
            // 
            this.KitNum.Location = new System.Drawing.Point(58, 130);
            this.KitNum.Name = "KitNum";
            this.KitNum.Size = new System.Drawing.Size(139, 21);
            this.KitNum.TabIndex = 99;
            this.KitNum.Text = "131E049900264400";
            this.KitNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // config
            // 
            this.config.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.config.Location = new System.Drawing.Point(3, 0);
            this.config.Multiline = true;
            this.config.Name = "config";
            this.config.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.config.Size = new System.Drawing.Size(381, 207);
            this.config.TabIndex = 100;
            this.config.Text = resources.GetString("config.Text");
            this.config.DoubleClick += new System.EventHandler(this.config_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 236);
            this.tabControl1.TabIndex = 101;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_msg);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.config);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.KitList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(380, 210);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "KitList";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // KitList
            // 
            this.KitList.FormattingEnabled = true;
            this.KitList.ItemHeight = 12;
            this.KitList.Items.AddRange(new object[] {
            "191A16CF01214400 ",
            "131E049900264400",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            "  ",
            " ",
            " ",
            " ",
            " ",
            " "});
            this.KitList.Location = new System.Drawing.Point(0, 0);
            this.KitList.Name = "KitList";
            this.KitList.Size = new System.Drawing.Size(384, 220);
            this.KitList.TabIndex = 0;
            this.KitList.Click += new System.EventHandler(this.KitList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 102;
            this.label1.Text = "Kit Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 103;
            this.label2.Text = "Serial Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbComPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SerialNumberWrite);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.serialWrite);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.KitNum);
            this.groupBox1.Location = new System.Drawing.Point(417, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 221);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            // 
            // cbComPort
            // 
            this.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(58, 30);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(139, 20);
            this.cbComPort.TabIndex = 110;
            this.cbComPort.Click += new System.EventHandler(this.ComPortDisplay);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 109;
            this.label3.Text = "Port Number";
            // 
            // SerialNumberWrite
            // 
            this.SerialNumberWrite.Location = new System.Drawing.Point(58, 80);
            this.SerialNumberWrite.Name = "SerialNumberWrite";
            this.SerialNumberWrite.Size = new System.Drawing.Size(139, 21);
            this.SerialNumberWrite.TabIndex = 106;
            this.SerialNumberWrite.Text = "000001";
            this.SerialNumberWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SerialNumberWrite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialNumberWrite_KeyDown);
            // 
            // IR_serial_write_tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IR_serial_write_tool";
            this.Text = "IR Serial Number Write Tool By chanhhh";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.Button serialWrite;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox config;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox KitList;
        private System.Windows.Forms.TextBox KitNum;
        public System.Windows.Forms.TextBox SerialNumberWrite;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label label3;
    }
}

