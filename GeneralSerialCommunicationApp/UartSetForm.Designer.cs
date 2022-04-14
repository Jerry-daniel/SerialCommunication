
namespace GeneralSerialCommunicationApp
{
    partial class UartSetForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Baudrate_textBox = new System.Windows.Forms.TextBox();
            this.Enable_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ApprySet_Btn = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.StopBit_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DataBit_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Parity_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BaudRate_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.COMPort_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Baudrate_textBox);
            this.groupBox1.Controls.Add(this.Enable_checkBox);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baud Rate - Self define";
            // 
            // Baudrate_textBox
            // 
            this.Baudrate_textBox.Enabled = false;
            this.Baudrate_textBox.Location = new System.Drawing.Point(84, 19);
            this.Baudrate_textBox.Name = "Baudrate_textBox";
            this.Baudrate_textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Baudrate_textBox.Size = new System.Drawing.Size(144, 23);
            this.Baudrate_textBox.TabIndex = 2;
            this.Baudrate_textBox.Text = "9600";
            this.Baudrate_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Baudrate_textBox_KeyPress);
            // 
            // Enable_checkBox
            // 
            this.Enable_checkBox.AutoSize = true;
            this.Enable_checkBox.Location = new System.Drawing.Point(6, 22);
            this.Enable_checkBox.Name = "Enable_checkBox";
            this.Enable_checkBox.Size = new System.Drawing.Size(66, 20);
            this.Enable_checkBox.TabIndex = 1;
            this.Enable_checkBox.Text = "Enable";
            this.Enable_checkBox.UseVisualStyleBackColor = true;
            this.Enable_checkBox.CheckedChanged += new System.EventHandler(this.Enable_checkBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ApprySet_Btn);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port Set";
            // 
            // ApprySet_Btn
            // 
            this.ApprySet_Btn.BackColor = System.Drawing.SystemColors.Control;
            this.ApprySet_Btn.Location = new System.Drawing.Point(6, 245);
            this.ApprySet_Btn.Name = "ApprySet_Btn";
            this.ApprySet_Btn.Size = new System.Drawing.Size(229, 36);
            this.ApprySet_Btn.TabIndex = 2;
            this.ApprySet_Btn.Text = "Appry";
            this.ApprySet_Btn.UseVisualStyleBackColor = false;
            this.ApprySet_Btn.Click += new System.EventHandler(this.ApprySet_Btn_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.StopBit_comboBox);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(6, 195);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(229, 44);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // StopBit_comboBox
            // 
            this.StopBit_comboBox.FormattingEnabled = true;
            this.StopBit_comboBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.StopBit_comboBox.Location = new System.Drawing.Point(78, 13);
            this.StopBit_comboBox.Name = "StopBit_comboBox";
            this.StopBit_comboBox.Size = new System.Drawing.Size(144, 24);
            this.StopBit_comboBox.TabIndex = 1;
            this.StopBit_comboBox.Text = "1";
            this.StopBit_comboBox.SelectedIndexChanged += new System.EventHandler(this.StopBit_comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stop Bit";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DataBit_comboBox);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(6, 149);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(229, 44);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // DataBit_comboBox
            // 
            this.DataBit_comboBox.FormattingEnabled = true;
            this.DataBit_comboBox.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5",
            "4"});
            this.DataBit_comboBox.Location = new System.Drawing.Point(78, 14);
            this.DataBit_comboBox.Name = "DataBit_comboBox";
            this.DataBit_comboBox.Size = new System.Drawing.Size(144, 24);
            this.DataBit_comboBox.TabIndex = 1;
            this.DataBit_comboBox.Text = "8";
            this.DataBit_comboBox.SelectedIndexChanged += new System.EventHandler(this.DataBit_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Bit";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Parity_comboBox);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(6, 105);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(229, 44);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // Parity_comboBox
            // 
            this.Parity_comboBox.FormattingEnabled = true;
            this.Parity_comboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.Parity_comboBox.Location = new System.Drawing.Point(78, 14);
            this.Parity_comboBox.Name = "Parity_comboBox";
            this.Parity_comboBox.Size = new System.Drawing.Size(144, 24);
            this.Parity_comboBox.TabIndex = 1;
            this.Parity_comboBox.Text = "None";
            this.Parity_comboBox.SelectedIndexChanged += new System.EventHandler(this.Parity_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parity";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BaudRate_comboBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(6, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 44);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // BaudRate_comboBox
            // 
            this.BaudRate_comboBox.FormattingEnabled = true;
            this.BaudRate_comboBox.Items.AddRange(new object[] {
            "256000",
            "128000",
            "115200",
            "57600",
            "56000",
            "43000",
            "38400",
            "28800",
            "19200",
            "14400",
            "9600",
            "7200",
            "4800",
            "2400",
            "1800",
            "1200",
            "600",
            "300",
            "150",
            "134",
            "110",
            "75"});
            this.BaudRate_comboBox.Location = new System.Drawing.Point(78, 14);
            this.BaudRate_comboBox.Name = "BaudRate_comboBox";
            this.BaudRate_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BaudRate_comboBox.Size = new System.Drawing.Size(144, 24);
            this.BaudRate_comboBox.TabIndex = 1;
            this.BaudRate_comboBox.Text = "9600";
            this.BaudRate_comboBox.SelectedIndexChanged += new System.EventHandler(this.BaudRate_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baud Rate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.COMPort_comboBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 45);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // COMPort_comboBox
            // 
            this.COMPort_comboBox.FormattingEnabled = true;
            this.COMPort_comboBox.Location = new System.Drawing.Point(78, 15);
            this.COMPort_comboBox.Name = "COMPort_comboBox";
            this.COMPort_comboBox.Size = new System.Drawing.Size(144, 24);
            this.COMPort_comboBox.TabIndex = 2;
            this.COMPort_comboBox.SelectedIndexChanged += new System.EventHandler(this.COMPort_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // UartSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UartSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UartSetForm_FormClosed);
            this.Load += new System.EventHandler(this.UartSetForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Enable_checkBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox COMPort_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox BaudRate_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox Parity_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox DataBit_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox StopBit_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ApprySet_Btn;
        protected System.Windows.Forms.TextBox Baudrate_textBox;
    }
}