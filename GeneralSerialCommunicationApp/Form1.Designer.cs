
namespace GeneralSerialCommunicationApp
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ReceiveDisplay_TextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PortState_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Bar1_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BaudRate_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Bar2_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Parity_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Bar3_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Databit_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Bar4_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Stopbit_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Date_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PowerOff_toolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMsg_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Setting_toolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Connect_toolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FileTransfer_toolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CommandSet_toolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SerialPortDetect_timer = new System.Windows.Forms.Timer(this.components);
            this.General_SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.ReeiveWindow_groupBox = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DisplayChar_textBox = new System.Windows.Forms.TextBox();
            this.SaveMsg_btn = new System.Windows.Forms.Button();
            this.ClearReceiveMsg_btn = new System.Windows.Forms.Button();
            this.TransferWindow_groupBox = new System.Windows.Forms.GroupBox();
            this.M_StringFormat_radioButton = new System.Windows.Forms.RadioButton();
            this.M_HexFormat_radioButton = new System.Windows.Forms.RadioButton();
            this.ClearTransferMsg_btn = new System.Windows.Forms.Button();
            this.ShowData_Control = new System.Windows.Forms.TabControl();
            this.Txt_tabPage = new System.Windows.Forms.TabPage();
            this.TransferDisplay_textBox = new System.Windows.Forms.TextBox();
            this.Hex_tabPage = new System.Windows.Forms.TabPage();
            this.Mot_tabPage = new System.Windows.Forms.TabPage();
            this.Command12_btn = new System.Windows.Forms.Button();
            this.Command11_btn = new System.Windows.Forms.Button();
            this.Command10_btn = new System.Windows.Forms.Button();
            this.Command9_btn = new System.Windows.Forms.Button();
            this.Command8_btn = new System.Windows.Forms.Button();
            this.Command7_btn = new System.Windows.Forms.Button();
            this.Command6_btn = new System.Windows.Forms.Button();
            this.Command5_btn = new System.Windows.Forms.Button();
            this.Command4_btn = new System.Windows.Forms.Button();
            this.Command3_btn = new System.Windows.Forms.Button();
            this.Command2_btn = new System.Windows.Forms.Button();
            this.Command1_btn = new System.Windows.Forms.Button();
            this.TransferMessage_btn = new System.Windows.Forms.Button();
            this.Date_timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.ReeiveWindow_groupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TransferWindow_groupBox.SuspendLayout();
            this.ShowData_Control.SuspendLayout();
            this.Txt_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReceiveDisplay_TextBox
            // 
            this.ReceiveDisplay_TextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveDisplay_TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ReceiveDisplay_TextBox.Location = new System.Drawing.Point(0, -2);
            this.ReceiveDisplay_TextBox.MaxLength = 0;
            this.ReceiveDisplay_TextBox.Multiline = true;
            this.ReceiveDisplay_TextBox.Name = "ReceiveDisplay_TextBox";
            this.ReceiveDisplay_TextBox.ReadOnly = true;
            this.ReceiveDisplay_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReceiveDisplay_TextBox.Size = new System.Drawing.Size(966, 225);
            this.ReceiveDisplay_TextBox.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PortState_toolStripStatusLabel,
            this.Bar1_toolStripStatusLabel,
            this.BaudRate_toolStripStatusLabel,
            this.Bar2_toolStripStatusLabel,
            this.Parity_toolStripStatusLabel,
            this.Bar3_toolStripStatusLabel,
            this.Databit_toolStripStatusLabel,
            this.Bar4_toolStripStatusLabel,
            this.Stopbit_toolStripStatusLabel,
            this.Date_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PortState_toolStripStatusLabel
            // 
            this.PortState_toolStripStatusLabel.Name = "PortState_toolStripStatusLabel";
            this.PortState_toolStripStatusLabel.Size = new System.Drawing.Size(69, 17);
            this.PortState_toolStripStatusLabel.Text = "Disconnect";
            // 
            // Bar1_toolStripStatusLabel
            // 
            this.Bar1_toolStripStatusLabel.Name = "Bar1_toolStripStatusLabel";
            this.Bar1_toolStripStatusLabel.Size = new System.Drawing.Size(10, 17);
            this.Bar1_toolStripStatusLabel.Text = "|";
            // 
            // BaudRate_toolStripStatusLabel
            // 
            this.BaudRate_toolStripStatusLabel.Name = "BaudRate_toolStripStatusLabel";
            this.BaudRate_toolStripStatusLabel.Size = new System.Drawing.Size(56, 17);
            this.BaudRate_toolStripStatusLabel.Text = "2560000";
            // 
            // Bar2_toolStripStatusLabel
            // 
            this.Bar2_toolStripStatusLabel.Name = "Bar2_toolStripStatusLabel";
            this.Bar2_toolStripStatusLabel.Size = new System.Drawing.Size(10, 17);
            this.Bar2_toolStripStatusLabel.Text = "|";
            // 
            // Parity_toolStripStatusLabel
            // 
            this.Parity_toolStripStatusLabel.Name = "Parity_toolStripStatusLabel";
            this.Parity_toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.Parity_toolStripStatusLabel.Text = "None";
            // 
            // Bar3_toolStripStatusLabel
            // 
            this.Bar3_toolStripStatusLabel.Name = "Bar3_toolStripStatusLabel";
            this.Bar3_toolStripStatusLabel.Size = new System.Drawing.Size(10, 17);
            this.Bar3_toolStripStatusLabel.Text = "|";
            // 
            // Databit_toolStripStatusLabel
            // 
            this.Databit_toolStripStatusLabel.Name = "Databit_toolStripStatusLabel";
            this.Databit_toolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.Databit_toolStripStatusLabel.Text = "8";
            // 
            // Bar4_toolStripStatusLabel
            // 
            this.Bar4_toolStripStatusLabel.Name = "Bar4_toolStripStatusLabel";
            this.Bar4_toolStripStatusLabel.Size = new System.Drawing.Size(10, 17);
            this.Bar4_toolStripStatusLabel.Text = "|";
            // 
            // Stopbit_toolStripStatusLabel
            // 
            this.Stopbit_toolStripStatusLabel.Name = "Stopbit_toolStripStatusLabel";
            this.Stopbit_toolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.Stopbit_toolStripStatusLabel.Text = "1";
            // 
            // Date_toolStripStatusLabel
            // 
            this.Date_toolStripStatusLabel.Name = "Date_toolStripStatusLabel";
            this.Date_toolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Date_toolStripStatusLabel.Size = new System.Drawing.Size(761, 17);
            this.Date_toolStripStatusLabel.Spring = true;
            this.Date_toolStripStatusLabel.Text = "1980/12/29 上午 04:10";
            this.Date_toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PowerOff_toolStripBtn,
            this.toolStripSeparator3,
            this.SaveMsg_toolStripButton,
            this.toolStripSeparator1,
            this.Setting_toolStripBtn,
            this.toolStripSeparator5,
            this.Connect_toolStripBtn,
            this.toolStripSeparator2,
            this.FileTransfer_toolStripBtn,
            this.toolStripSeparator4,
            this.CommandSet_toolStripBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1008, 45);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // PowerOff_toolStripBtn
            // 
            this.PowerOff_toolStripBtn.AutoSize = false;
            this.PowerOff_toolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PowerOff_toolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("PowerOff_toolStripBtn.Image")));
            this.PowerOff_toolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PowerOff_toolStripBtn.Name = "PowerOff_toolStripBtn";
            this.PowerOff_toolStripBtn.Size = new System.Drawing.Size(43, 42);
            this.PowerOff_toolStripBtn.Text = "toolStripButton1";
            this.PowerOff_toolStripBtn.ToolTipText = "PowerOff";
            this.PowerOff_toolStripBtn.Click += new System.EventHandler(this.Power_toolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            this.toolStripSeparator3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // SaveMsg_toolStripButton
            // 
            this.SaveMsg_toolStripButton.AutoSize = false;
            this.SaveMsg_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveMsg_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveMsg_toolStripButton.Image")));
            this.SaveMsg_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveMsg_toolStripButton.Name = "SaveMsg_toolStripButton";
            this.SaveMsg_toolStripButton.Size = new System.Drawing.Size(43, 42);
            this.SaveMsg_toolStripButton.Text = "toolStripButton1";
            this.SaveMsg_toolStripButton.ToolTipText = "Save Message";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            this.toolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // Setting_toolStripBtn
            // 
            this.Setting_toolStripBtn.AutoSize = false;
            this.Setting_toolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Setting_toolStripBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.Setting_toolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("Setting_toolStripBtn.Image")));
            this.Setting_toolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Setting_toolStripBtn.Name = "Setting_toolStripBtn";
            this.Setting_toolStripBtn.Size = new System.Drawing.Size(43, 42);
            this.Setting_toolStripBtn.Text = "toolStripButton1";
            this.Setting_toolStripBtn.ToolTipText = "Setting";
            this.Setting_toolStripBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 45);
            this.toolStripSeparator5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // Connect_toolStripBtn
            // 
            this.Connect_toolStripBtn.AutoSize = false;
            this.Connect_toolStripBtn.BackColor = System.Drawing.SystemColors.Control;
            this.Connect_toolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Connect_toolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("Connect_toolStripBtn.Image")));
            this.Connect_toolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Connect_toolStripBtn.Name = "Connect_toolStripBtn";
            this.Connect_toolStripBtn.Size = new System.Drawing.Size(43, 42);
            this.Connect_toolStripBtn.Text = "toolStripButton1";
            this.Connect_toolStripBtn.ToolTipText = "Connect";
            this.Connect_toolStripBtn.Click += new System.EventHandler(this.Connect_toolStripBtn_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            this.toolStripSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // FileTransfer_toolStripBtn
            // 
            this.FileTransfer_toolStripBtn.AutoSize = false;
            this.FileTransfer_toolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FileTransfer_toolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("FileTransfer_toolStripBtn.Image")));
            this.FileTransfer_toolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileTransfer_toolStripBtn.Name = "FileTransfer_toolStripBtn";
            this.FileTransfer_toolStripBtn.Size = new System.Drawing.Size(43, 42);
            this.FileTransfer_toolStripBtn.Text = "toolStripButton1";
            this.FileTransfer_toolStripBtn.ToolTipText = "File Transfer";
            this.FileTransfer_toolStripBtn.Click += new System.EventHandler(this.FileTransfer_toolStripBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 45);
            this.toolStripSeparator4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // CommandSet_toolStripBtn
            // 
            this.CommandSet_toolStripBtn.AutoSize = false;
            this.CommandSet_toolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CommandSet_toolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("CommandSet_toolStripBtn.Image")));
            this.CommandSet_toolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CommandSet_toolStripBtn.Name = "CommandSet_toolStripBtn";
            this.CommandSet_toolStripBtn.Size = new System.Drawing.Size(43, 42);
            this.CommandSet_toolStripBtn.Text = "toolStripButton1";
            this.CommandSet_toolStripBtn.ToolTipText = "Command Set";
            this.CommandSet_toolStripBtn.Click += new System.EventHandler(this.CommandSet_toolStripBtn_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // SerialPortDetect_timer
            // 
            this.SerialPortDetect_timer.Tick += new System.EventHandler(this.SerialPortDetect_timer_Tick);
            // 
            // ReeiveWindow_groupBox
            // 
            this.ReeiveWindow_groupBox.Controls.Add(this.tabControl1);
            this.ReeiveWindow_groupBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReeiveWindow_groupBox.Location = new System.Drawing.Point(12, 72);
            this.ReeiveWindow_groupBox.Name = "ReeiveWindow_groupBox";
            this.ReeiveWindow_groupBox.Size = new System.Drawing.Size(984, 282);
            this.ReeiveWindow_groupBox.TabIndex = 12;
            this.ReeiveWindow_groupBox.TabStop = false;
            this.ReeiveWindow_groupBox.Text = "Receiver window";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 254);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.ReceiveDisplay_TextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(964, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "16\'s";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.DisplayChar_textBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Char";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DisplayChar_textBox
            // 
            this.DisplayChar_textBox.Location = new System.Drawing.Point(0, 0);
            this.DisplayChar_textBox.MaxLength = 0;
            this.DisplayChar_textBox.Multiline = true;
            this.DisplayChar_textBox.Name = "DisplayChar_textBox";
            this.DisplayChar_textBox.ReadOnly = true;
            this.DisplayChar_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayChar_textBox.Size = new System.Drawing.Size(962, 223);
            this.DisplayChar_textBox.TabIndex = 0;
            // 
            // SaveMsg_btn
            // 
            this.SaveMsg_btn.BackColor = System.Drawing.SystemColors.Control;
            this.SaveMsg_btn.Location = new System.Drawing.Point(474, 27);
            this.SaveMsg_btn.Name = "SaveMsg_btn";
            this.SaveMsg_btn.Size = new System.Drawing.Size(125, 29);
            this.SaveMsg_btn.TabIndex = 3;
            this.SaveMsg_btn.Text = "Save Message";
            this.SaveMsg_btn.UseVisualStyleBackColor = false;
            // 
            // ClearReceiveMsg_btn
            // 
            this.ClearReceiveMsg_btn.BackColor = System.Drawing.SystemColors.Control;
            this.ClearReceiveMsg_btn.Location = new System.Drawing.Point(626, 27);
            this.ClearReceiveMsg_btn.Name = "ClearReceiveMsg_btn";
            this.ClearReceiveMsg_btn.Size = new System.Drawing.Size(125, 29);
            this.ClearReceiveMsg_btn.TabIndex = 2;
            this.ClearReceiveMsg_btn.Text = "Clear Message";
            this.ClearReceiveMsg_btn.UseVisualStyleBackColor = false;
            this.ClearReceiveMsg_btn.Click += new System.EventHandler(this.ClearMsg_btn_Click);
            // 
            // TransferWindow_groupBox
            // 
            this.TransferWindow_groupBox.Controls.Add(this.M_StringFormat_radioButton);
            this.TransferWindow_groupBox.Controls.Add(this.M_HexFormat_radioButton);
            this.TransferWindow_groupBox.Controls.Add(this.ClearTransferMsg_btn);
            this.TransferWindow_groupBox.Controls.Add(this.ShowData_Control);
            this.TransferWindow_groupBox.Controls.Add(this.Command12_btn);
            this.TransferWindow_groupBox.Controls.Add(this.Command11_btn);
            this.TransferWindow_groupBox.Controls.Add(this.Command10_btn);
            this.TransferWindow_groupBox.Controls.Add(this.Command9_btn);
            this.TransferWindow_groupBox.Controls.Add(this.Command8_btn);
            this.TransferWindow_groupBox.Controls.Add(this.Command7_btn);
            this.TransferWindow_groupBox.Controls.Add(this.Command6_btn);
            this.TransferWindow_groupBox.Controls.Add(this.Command5_btn);
            this.TransferWindow_groupBox.Controls.Add(this.Command4_btn);
            this.TransferWindow_groupBox.Controls.Add(this.Command3_btn);
            this.TransferWindow_groupBox.Controls.Add(this.Command2_btn);
            this.TransferWindow_groupBox.Controls.Add(this.Command1_btn);
            this.TransferWindow_groupBox.Controls.Add(this.TransferMessage_btn);
            this.TransferWindow_groupBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TransferWindow_groupBox.Location = new System.Drawing.Point(12, 360);
            this.TransferWindow_groupBox.Name = "TransferWindow_groupBox";
            this.TransferWindow_groupBox.Size = new System.Drawing.Size(984, 344);
            this.TransferWindow_groupBox.TabIndex = 13;
            this.TransferWindow_groupBox.TabStop = false;
            this.TransferWindow_groupBox.Text = "Transfer window";
            // 
            // M_StringFormat_radioButton
            // 
            this.M_StringFormat_radioButton.AutoSize = true;
            this.M_StringFormat_radioButton.Location = new System.Drawing.Point(88, 278);
            this.M_StringFormat_radioButton.Name = "M_StringFormat_radioButton";
            this.M_StringFormat_radioButton.Size = new System.Drawing.Size(62, 20);
            this.M_StringFormat_radioButton.TabIndex = 18;
            this.M_StringFormat_radioButton.Text = "String";
            this.M_StringFormat_radioButton.UseVisualStyleBackColor = true;
            this.M_StringFormat_radioButton.CheckedChanged += new System.EventHandler(this.M_StringFormat_radioButton_CheckedChanged);
            // 
            // M_HexFormat_radioButton
            // 
            this.M_HexFormat_radioButton.AutoSize = true;
            this.M_HexFormat_radioButton.Checked = true;
            this.M_HexFormat_radioButton.Location = new System.Drawing.Point(13, 278);
            this.M_HexFormat_radioButton.Name = "M_HexFormat_radioButton";
            this.M_HexFormat_radioButton.Size = new System.Drawing.Size(49, 20);
            this.M_HexFormat_radioButton.TabIndex = 17;
            this.M_HexFormat_radioButton.TabStop = true;
            this.M_HexFormat_radioButton.Text = "16\'s";
            this.M_HexFormat_radioButton.UseVisualStyleBackColor = true;
            this.M_HexFormat_radioButton.CheckedChanged += new System.EventHandler(this.M_HexFormat_radioButton_CheckedChanged);
            // 
            // ClearTransferMsg_btn
            // 
            this.ClearTransferMsg_btn.BackColor = System.Drawing.SystemColors.Control;
            this.ClearTransferMsg_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearTransferMsg_btn.Location = new System.Drawing.Point(88, 308);
            this.ClearTransferMsg_btn.Name = "ClearTransferMsg_btn";
            this.ClearTransferMsg_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClearTransferMsg_btn.Size = new System.Drawing.Size(90, 30);
            this.ClearTransferMsg_btn.TabIndex = 3;
            this.ClearTransferMsg_btn.Text = "Clear Msg";
            this.ClearTransferMsg_btn.UseVisualStyleBackColor = false;
            this.ClearTransferMsg_btn.Click += new System.EventHandler(this.ClearTransferMsg_btn_Click);
            // 
            // ShowData_Control
            // 
            this.ShowData_Control.Controls.Add(this.Txt_tabPage);
            this.ShowData_Control.Controls.Add(this.Hex_tabPage);
            this.ShowData_Control.Controls.Add(this.Mot_tabPage);
            this.ShowData_Control.Location = new System.Drawing.Point(6, 22);
            this.ShowData_Control.Name = "ShowData_Control";
            this.ShowData_Control.SelectedIndex = 0;
            this.ShowData_Control.Size = new System.Drawing.Size(972, 244);
            this.ShowData_Control.TabIndex = 14;
            // 
            // Txt_tabPage
            // 
            this.Txt_tabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Txt_tabPage.Controls.Add(this.TransferDisplay_textBox);
            this.Txt_tabPage.Location = new System.Drawing.Point(4, 25);
            this.Txt_tabPage.Name = "Txt_tabPage";
            this.Txt_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Txt_tabPage.Size = new System.Drawing.Size(964, 215);
            this.Txt_tabPage.TabIndex = 0;
            this.Txt_tabPage.Text = "*.txt";
            this.Txt_tabPage.UseVisualStyleBackColor = true;
            // 
            // TransferDisplay_textBox
            // 
            this.TransferDisplay_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransferDisplay_textBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferDisplay_textBox.Location = new System.Drawing.Point(1, 1);
            this.TransferDisplay_textBox.MaxLength = 0;
            this.TransferDisplay_textBox.Multiline = true;
            this.TransferDisplay_textBox.Name = "TransferDisplay_textBox";
            this.TransferDisplay_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TransferDisplay_textBox.Size = new System.Drawing.Size(961, 212);
            this.TransferDisplay_textBox.TabIndex = 0;
            this.TransferDisplay_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransferDisplay_textBox_KeyPress);
            this.TransferDisplay_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TransferDisplay_textBox_KeyUp);
            // 
            // Hex_tabPage
            // 
            this.Hex_tabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Hex_tabPage.Location = new System.Drawing.Point(4, 25);
            this.Hex_tabPage.Name = "Hex_tabPage";
            this.Hex_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Hex_tabPage.Size = new System.Drawing.Size(964, 215);
            this.Hex_tabPage.TabIndex = 1;
            this.Hex_tabPage.Text = "*.hex";
            this.Hex_tabPage.UseVisualStyleBackColor = true;
            // 
            // Mot_tabPage
            // 
            this.Mot_tabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Mot_tabPage.Location = new System.Drawing.Point(4, 25);
            this.Mot_tabPage.Name = "Mot_tabPage";
            this.Mot_tabPage.Size = new System.Drawing.Size(964, 215);
            this.Mot_tabPage.TabIndex = 2;
            this.Mot_tabPage.Text = "*.mot";
            this.Mot_tabPage.UseVisualStyleBackColor = true;
            // 
            // Command12_btn
            // 
            this.Command12_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command12_btn.Enabled = false;
            this.Command12_btn.Location = new System.Drawing.Point(904, 308);
            this.Command12_btn.Name = "Command12_btn";
            this.Command12_btn.Size = new System.Drawing.Size(70, 30);
            this.Command12_btn.TabIndex = 14;
            this.Command12_btn.Text = "Cmd12";
            this.Command12_btn.UseVisualStyleBackColor = false;
            this.Command12_btn.Click += new System.EventHandler(this.Command12_btn_Click);
            // 
            // Command11_btn
            // 
            this.Command11_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command11_btn.Enabled = false;
            this.Command11_btn.Location = new System.Drawing.Point(828, 308);
            this.Command11_btn.Name = "Command11_btn";
            this.Command11_btn.Size = new System.Drawing.Size(70, 30);
            this.Command11_btn.TabIndex = 13;
            this.Command11_btn.Text = "Cmd11";
            this.Command11_btn.UseVisualStyleBackColor = false;
            this.Command11_btn.Click += new System.EventHandler(this.Command11_btn_Click);
            // 
            // Command10_btn
            // 
            this.Command10_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command10_btn.Enabled = false;
            this.Command10_btn.Location = new System.Drawing.Point(752, 308);
            this.Command10_btn.Name = "Command10_btn";
            this.Command10_btn.Size = new System.Drawing.Size(70, 30);
            this.Command10_btn.TabIndex = 12;
            this.Command10_btn.Text = "Cmd10";
            this.Command10_btn.UseVisualStyleBackColor = false;
            this.Command10_btn.Click += new System.EventHandler(this.Command10_btn_Click);
            // 
            // Command9_btn
            // 
            this.Command9_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command9_btn.Enabled = false;
            this.Command9_btn.Location = new System.Drawing.Point(676, 308);
            this.Command9_btn.Name = "Command9_btn";
            this.Command9_btn.Size = new System.Drawing.Size(70, 30);
            this.Command9_btn.TabIndex = 11;
            this.Command9_btn.Text = "Cmd9";
            this.Command9_btn.UseVisualStyleBackColor = false;
            this.Command9_btn.Click += new System.EventHandler(this.Command9_btn_Click);
            // 
            // Command8_btn
            // 
            this.Command8_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command8_btn.Enabled = false;
            this.Command8_btn.Location = new System.Drawing.Point(600, 308);
            this.Command8_btn.Name = "Command8_btn";
            this.Command8_btn.Size = new System.Drawing.Size(70, 30);
            this.Command8_btn.TabIndex = 10;
            this.Command8_btn.Text = "Cmd8";
            this.Command8_btn.UseVisualStyleBackColor = false;
            this.Command8_btn.Click += new System.EventHandler(this.Command8_btn_Click);
            // 
            // Command7_btn
            // 
            this.Command7_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command7_btn.Enabled = false;
            this.Command7_btn.Location = new System.Drawing.Point(524, 308);
            this.Command7_btn.Name = "Command7_btn";
            this.Command7_btn.Size = new System.Drawing.Size(70, 30);
            this.Command7_btn.TabIndex = 9;
            this.Command7_btn.Text = "Cmd7";
            this.Command7_btn.UseVisualStyleBackColor = false;
            this.Command7_btn.Click += new System.EventHandler(this.Command7_btn_Click);
            // 
            // Command6_btn
            // 
            this.Command6_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command6_btn.Enabled = false;
            this.Command6_btn.Location = new System.Drawing.Point(904, 272);
            this.Command6_btn.Name = "Command6_btn";
            this.Command6_btn.Size = new System.Drawing.Size(70, 30);
            this.Command6_btn.TabIndex = 8;
            this.Command6_btn.Text = "Cmd6";
            this.Command6_btn.UseVisualStyleBackColor = false;
            this.Command6_btn.Click += new System.EventHandler(this.Command6_btn_Click);
            // 
            // Command5_btn
            // 
            this.Command5_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command5_btn.Enabled = false;
            this.Command5_btn.Location = new System.Drawing.Point(828, 272);
            this.Command5_btn.Name = "Command5_btn";
            this.Command5_btn.Size = new System.Drawing.Size(70, 30);
            this.Command5_btn.TabIndex = 7;
            this.Command5_btn.Text = "Cmd5";
            this.Command5_btn.UseVisualStyleBackColor = false;
            this.Command5_btn.Click += new System.EventHandler(this.Command5_btn_Click);
            // 
            // Command4_btn
            // 
            this.Command4_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command4_btn.Enabled = false;
            this.Command4_btn.Location = new System.Drawing.Point(752, 273);
            this.Command4_btn.Name = "Command4_btn";
            this.Command4_btn.Size = new System.Drawing.Size(70, 30);
            this.Command4_btn.TabIndex = 6;
            this.Command4_btn.Text = "Cmd4";
            this.Command4_btn.UseVisualStyleBackColor = false;
            this.Command4_btn.Click += new System.EventHandler(this.Command4_btn_Click);
            // 
            // Command3_btn
            // 
            this.Command3_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command3_btn.Enabled = false;
            this.Command3_btn.Location = new System.Drawing.Point(676, 273);
            this.Command3_btn.Name = "Command3_btn";
            this.Command3_btn.Size = new System.Drawing.Size(70, 30);
            this.Command3_btn.TabIndex = 5;
            this.Command3_btn.Text = "Cmd3";
            this.Command3_btn.UseVisualStyleBackColor = false;
            this.Command3_btn.Click += new System.EventHandler(this.Command3_btn_Click);
            // 
            // Command2_btn
            // 
            this.Command2_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command2_btn.Enabled = false;
            this.Command2_btn.Location = new System.Drawing.Point(600, 273);
            this.Command2_btn.Name = "Command2_btn";
            this.Command2_btn.Size = new System.Drawing.Size(70, 30);
            this.Command2_btn.TabIndex = 4;
            this.Command2_btn.Text = "Cmd2";
            this.Command2_btn.UseVisualStyleBackColor = false;
            this.Command2_btn.Click += new System.EventHandler(this.Command2_btn_Click);
            // 
            // Command1_btn
            // 
            this.Command1_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Command1_btn.Enabled = false;
            this.Command1_btn.Location = new System.Drawing.Point(524, 272);
            this.Command1_btn.Name = "Command1_btn";
            this.Command1_btn.Size = new System.Drawing.Size(70, 30);
            this.Command1_btn.TabIndex = 2;
            this.Command1_btn.Text = "Cmd1";
            this.Command1_btn.UseVisualStyleBackColor = false;
            this.Command1_btn.Click += new System.EventHandler(this.Command1_btn_Click);
            // 
            // TransferMessage_btn
            // 
            this.TransferMessage_btn.BackColor = System.Drawing.SystemColors.Control;
            this.TransferMessage_btn.Location = new System.Drawing.Point(12, 308);
            this.TransferMessage_btn.Name = "TransferMessage_btn";
            this.TransferMessage_btn.Size = new System.Drawing.Size(70, 30);
            this.TransferMessage_btn.TabIndex = 1;
            this.TransferMessage_btn.Text = "Transfer";
            this.TransferMessage_btn.UseVisualStyleBackColor = false;
            this.TransferMessage_btn.Click += new System.EventHandler(this.TransferMessage_btn_Click);
            // 
            // Date_timer
            // 
            this.Date_timer.Interval = 1000;
            this.Date_timer.Tick += new System.EventHandler(this.Date_timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.SaveMsg_btn);
            this.Controls.Add(this.ClearReceiveMsg_btn);
            this.Controls.Add(this.TransferWindow_groupBox);
            this.Controls.Add(this.ReeiveWindow_groupBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Serial Communication Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ReeiveWindow_groupBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.TransferWindow_groupBox.ResumeLayout(false);
            this.TransferWindow_groupBox.PerformLayout();
            this.ShowData_Control.ResumeLayout(false);
            this.Txt_tabPage.ResumeLayout(false);
            this.Txt_tabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ReceiveDisplay_TextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel PortState_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Bar1_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel BaudRate_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Bar2_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Parity_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Bar3_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Databit_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Bar4_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Stopbit_toolStripStatusLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Setting_toolStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Connect_toolStripBtn;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer SerialPortDetect_timer;
        public System.IO.Ports.SerialPort General_SerialPort;
        private System.Windows.Forms.GroupBox ReeiveWindow_groupBox;
        private System.Windows.Forms.ToolStripButton PowerOff_toolStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton FileTransfer_toolStripBtn;
        private System.Windows.Forms.Button ClearReceiveMsg_btn;
        private System.Windows.Forms.Button SaveMsg_btn;
        private System.Windows.Forms.GroupBox TransferWindow_groupBox;
        private System.Windows.Forms.TextBox TransferDisplay_textBox;
        private System.Windows.Forms.Button ClearTransferMsg_btn;
        private System.Windows.Forms.Button Command1_btn;
        private System.Windows.Forms.Button TransferMessage_btn;
        private System.Windows.Forms.Button Command12_btn;
        private System.Windows.Forms.Button Command11_btn;
        private System.Windows.Forms.Button Command10_btn;
        private System.Windows.Forms.Button Command9_btn;
        private System.Windows.Forms.Button Command8_btn;
        private System.Windows.Forms.Button Command7_btn;
        private System.Windows.Forms.Button Command6_btn;
        private System.Windows.Forms.Button Command5_btn;
        private System.Windows.Forms.Button Command4_btn;
        private System.Windows.Forms.Button Command3_btn;
        private System.Windows.Forms.Button Command2_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton CommandSet_toolStripBtn;
        private System.Windows.Forms.ToolStripStatusLabel Date_toolStripStatusLabel;
        private System.Windows.Forms.Timer Date_timer;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TabControl ShowData_Control;
        private System.Windows.Forms.TabPage Txt_tabPage;
        private System.Windows.Forms.TabPage Hex_tabPage;
        private System.Windows.Forms.TabPage Mot_tabPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox DisplayChar_textBox;
        private System.Windows.Forms.ToolStripButton SaveMsg_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.RadioButton M_StringFormat_radioButton;
        private System.Windows.Forms.RadioButton M_HexFormat_radioButton;
    }
}

