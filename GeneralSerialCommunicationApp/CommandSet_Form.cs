using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralSerialCommunicationApp
{
    public partial class CommandSet_Form : Form
    {
        public delegate void commandsetformEventHandler(string cmdtemp,int cmdn,int format);
        public commandsetformEventHandler CmdMsgSetEventTrigger;

        string Start = "{,";
        string End = ",#";
        int format = 0;
        private protected volatile bool Command1SetEnable_Flag = false;
        private protected volatile bool Command2SetEnable_Flag = false;
        private protected volatile bool Command3SetEnable_Flag = false;
        private protected volatile bool Command4SetEnable_Flag = false;
        private protected volatile bool Command5SetEnable_Flag = false;
        private protected volatile bool Command6SetEnable_Flag = false;
        private protected volatile bool Command7SetEnable_Flag = false;
        private protected volatile bool Command8SetEnable_Flag = false;
        private protected volatile bool Command9SetEnable_Flag = false;
        private protected volatile bool Command10SetEnable_Flag = false;
        private protected volatile bool Command11SetEnable_Flag = false;
        private protected volatile bool Command12SetEnable_Flag = false;

        bool Cmd1_String_Flag = false;
        bool Cmd2_String_Flag = false;
        bool Cmd3_String_Flag = false;
        bool Cmd4_String_Flag = false;
        bool Cmd5_String_Flag = false;
        bool Cmd6_String_Flag = false;
        bool Cmd7_String_Flag = false;
        bool Cmd8_String_Flag = false;
        bool Cmd9_String_Flag = false;
        bool Cmd10_String_Flag = false;
        bool Cmd11_String_Flag = false;
        bool Cmd12_String_Flag = false;

        int Cmd1_NumOfChar, Cmd2_NumOfChar, Cmd3_NumOfChar, Cmd4_NumOfChar, Cmd5_NumOfChar, Cmd6_NumOfChar;
        int Cmd7_NumOfChar, Cmd8_NumOfChar, Cmd9_NumOfChar, Cmd10_NumOfChar, Cmd11_NumOfChar, Cmd12_NumOfChar;

        public CommandSet_Form()
        {
            InitializeComponent();
        }

        private void CommandSet_Form_Load(object sender, EventArgs e)
        {
            FormLoadInitial();
        }

        private void CommandSet_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        //--------------------------------------------------------------//
        private void Cmd1Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if(Command1SetEnable_Flag==false)
            {
                if(Command1_textBox.Text!=string.Empty)
                {
                    commandmessage = Command1_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 0, format);
                    Command1_textBox.Enabled = false;
                    Cmd1Set_btn.Text = "Setting";
                    Cmd1Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command1SetEnable_Flag = true;
                }
            }
            else
            {
                Command1_textBox.Enabled = true;
                Cmd1Set_btn.Text = "Un Set";
                Cmd1Set_btn.ForeColor = System.Drawing.Color.Red;
                Command1SetEnable_Flag = false;
            }
        }
        //--------------------------------------------------------------//
        private void Cmd2Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if (Command2SetEnable_Flag == false)
            {
                if (Command2_textBox.Text != string.Empty)
                {
                    commandmessage = Command2_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 1, format);
                    Command2_textBox.Enabled = false;
                    Cmd2Set_btn.Text = "Setting";
                    Cmd2Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command2SetEnable_Flag = true;
                }
            }
            else
            {
                Command2_textBox.Enabled = true;
                Cmd2Set_btn.Text = "Un Set";
                Cmd2Set_btn.ForeColor = System.Drawing.Color.Red;
                Command2SetEnable_Flag = false;
            }
        }
        //--------------------------------------------------------------//
        private void Cmd3Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if (Command3SetEnable_Flag == false)
            {
                if (Command3_textBox.Text != string.Empty)
                {
                    commandmessage = Command3_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 2, format);
                    Command3_textBox.Enabled = false;
                    Cmd3Set_btn.Text = "Setting";
                    Cmd3Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command3SetEnable_Flag = true;
                }
            }
            else
            {
                Command3_textBox.Enabled = true;
                Cmd3Set_btn.Text = "Un Set";
                Cmd3Set_btn.ForeColor = System.Drawing.Color.Red;
                Command3SetEnable_Flag = false;
            }
        }
        //--------------------------------------------------------------//
        private void Cmd4Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if (Command4SetEnable_Flag == false)
            {
                if (Command4_textBox.Text != string.Empty)
                {
                    commandmessage = Command4_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 3, format);
                    Command4_textBox.Enabled = false;
                    Cmd4Set_btn.Text = "Setting";
                    Cmd4Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command4SetEnable_Flag = true;
                }
            }
            else
            {
                Command4_textBox.Enabled = true;
                Cmd4Set_btn.Text = "Un Set";
                Cmd4Set_btn.ForeColor = System.Drawing.Color.Red;
                Command4SetEnable_Flag = false;
            }
        }
        //--------------------------------------------------------------//
        private void Cmd5Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if (Command5SetEnable_Flag == false)
            {
                if (Command5_textBox.Text != string.Empty)
                {
                    commandmessage = Command5_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 4, format);
                    Command5_textBox.Enabled = false;
                    Cmd5Set_btn.Text = "Setting";
                    Cmd5Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command5SetEnable_Flag = true;
                }
            }
            else
            {
                Command5_textBox.Enabled = true;
                Cmd5Set_btn.Text = "Un Set";
                Cmd5Set_btn.ForeColor = System.Drawing.Color.Red;
                Command5SetEnable_Flag = false;
            }
        }

        

        //--------------------------------------------------------------//
        private void Cmd6Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if (Command6SetEnable_Flag == false)
            {
                if (Command6_textBox.Text != string.Empty)
                {
                    commandmessage = Command6_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 5, format);
                    Command6_textBox.Enabled = false;
                    Cmd6Set_btn.Text = "Setting";
                    Cmd6Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command6SetEnable_Flag = true;
                }
            }
            else
            {
                Command6_textBox.Enabled = true;
                Cmd6Set_btn.Text = "Un Set";
                Cmd6Set_btn.ForeColor = System.Drawing.Color.Red;
                Command6SetEnable_Flag = false;
            }
        }

        

        //--------------------------------------------------------------//
        private void Cmd7Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if (Command7SetEnable_Flag == false)
            {
                if (Command7_textBox.Text != string.Empty)
                {
                    commandmessage = Command7_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 6, format);
                    Command7_textBox.Enabled = false;
                    Cmd7Set_btn.Text = "Setting";
                    Cmd7Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command7SetEnable_Flag = true;
                }
            }
            else
            {
                Command7_textBox.Enabled = true;
                Cmd7Set_btn.Text = "Un Set";
                Cmd7Set_btn.ForeColor = System.Drawing.Color.Red;
                Command7SetEnable_Flag = false;
            }
        }

        

        //--------------------------------------------------------------//
        private void Cmd8Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if (Command8SetEnable_Flag == false)
            {
                if (Command8_textBox.Text != string.Empty)
                {
                    commandmessage = Command8_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 7, format);
                    Command8_textBox.Enabled = false;
                    Cmd8Set_btn.Text = "Setting";
                    Cmd8Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command8SetEnable_Flag = true;
                }
            }
            else
            {
                Command8_textBox.Enabled = true;
                Cmd8Set_btn.Text = "Un Set";
                Cmd8Set_btn.ForeColor = System.Drawing.Color.Red;
                Command8SetEnable_Flag = false;
            }
        }
        //--------------------------------------------------------------//
        private void Cmd9Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if (Command9SetEnable_Flag == false)
            {
                if (Command9_textBox.Text != string.Empty)
                {
                    commandmessage = Command9_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 8, format);
                    Command9_textBox.Enabled = false;
                    Cmd9Set_btn.Text = "Setting";
                    Cmd9Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command9SetEnable_Flag = true;
                }
            }
            else
            {
                Command9_textBox.Enabled = true;
                Cmd9Set_btn.Text = "Un Set";
                Cmd9Set_btn.ForeColor = System.Drawing.Color.Red;
                Command9SetEnable_Flag = false;
            }
        }
        //--------------------------------------------------------------//
        private void Cmd10Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if (Command10SetEnable_Flag == false)
            {
                if (Command10_textBox.Text != string.Empty)
                {
                    commandmessage = Command10_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 9, format);
                    Command10_textBox.Enabled = false;
                    Cmd10Set_btn.Text = "Setting";
                    Cmd10Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command10SetEnable_Flag = true;
                }
            }
            else
            {
                Command10_textBox.Enabled = true;
                Cmd10Set_btn.Text = "Un Set";
                Cmd10Set_btn.ForeColor = System.Drawing.Color.Red;
                Command10SetEnable_Flag = false;
            }
        }
        //--------------------------------------------------------------//
        private void Cmd11Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if (Command11SetEnable_Flag == false)
            {
                if (Command11_textBox.Text != string.Empty)
                {
                    commandmessage = Command11_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 10, format);
                    Command11_textBox.Enabled = false;
                    Cmd11Set_btn.Text = "Setting";
                    Cmd11Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command11SetEnable_Flag = true;
                }
            }
            else
            {
                Command11_textBox.Enabled = true;
                Cmd11Set_btn.Text = "Un Set";
                Cmd11Set_btn.ForeColor = System.Drawing.Color.Red;
                Command11SetEnable_Flag = false;
            }
        }
        //--------------------------------------------------------------//
        private void Cmd12Set_btn_Click(object sender, EventArgs e)
        {
            string commandmessage;
            if (Command12SetEnable_Flag == false)
            {
                if (Command12_textBox.Text != string.Empty)
                {
                    commandmessage = Command12_textBox.Text;// + End;
                    CmdMsgSetEventTrigger(commandmessage, 11, format);
                    Command12_textBox.Enabled = false;
                    Cmd12Set_btn.Text = "Setting";
                    Cmd12Set_btn.ForeColor = System.Drawing.Color.Green;
                    Command12SetEnable_Flag = true;
                }
            }
            else
            {
                Command12_textBox.Enabled = true;
                Cmd12Set_btn.Text = "Un Set";
                Cmd12Set_btn.ForeColor = System.Drawing.Color.Red;
                Command12SetEnable_Flag = false;
            }
        }
        //=============== Self define function =========================//
        private void FormLoadInitial()
        {
            if(HexFormat_radioButton.Checked == true)
            {
                format = 1;
            }
            else if(StringFormat_radioButton.Checked ==  true)
            {
                format = 2;
            }
            
            CommandButtonInitial();
        }
        //--------------------------------------------------------------//
        private void CommandButtonInitial()
        {
            if (Command1SetEnable_Flag == false)
            {
                Cmd1Set_btn.Text = "Un Set";
                Cmd1Set_btn.ForeColor = System.Drawing.Color.Red;
            }
            if (Command2SetEnable_Flag == false)
            {
                Cmd2Set_btn.Text = "Un Set";
                Cmd2Set_btn.ForeColor = System.Drawing.Color.Red;
            }
            if (Command3SetEnable_Flag == false)
            {
                Cmd3Set_btn.Text = "Un Set";
                Cmd3Set_btn.ForeColor = System.Drawing.Color.Red;
            }
            if (Command4SetEnable_Flag == false)
            {
                Cmd4Set_btn.Text = "Un Set";
                Cmd4Set_btn.ForeColor = System.Drawing.Color.Red;
            }
            if (Command5SetEnable_Flag == false)
            {
                Cmd5Set_btn.Text = "Un Set";
                Cmd5Set_btn.ForeColor = System.Drawing.Color.Red;
            }
            if (Command6SetEnable_Flag == false)
            {
                Cmd6Set_btn.Text = "Un Set";
                Cmd6Set_btn.ForeColor = System.Drawing.Color.Red;
            }
            if (Command7SetEnable_Flag == false)
            {
                Cmd7Set_btn.Text = "Un Set";
                Cmd7Set_btn.ForeColor = System.Drawing.Color.Red;
            }
            if (Command8SetEnable_Flag == false)
            {
                Cmd8Set_btn.Text = "Un Set";
                Cmd8Set_btn.ForeColor = System.Drawing.Color.Red;
            }
            if (Command9SetEnable_Flag == false)
            {
                Cmd9Set_btn.Text = "Un Set";
                Cmd9Set_btn.ForeColor = System.Drawing.Color.Red;
            }
            if (Command10SetEnable_Flag == false)
            {
                Cmd10Set_btn.Text = "Un Set";
                Cmd10Set_btn.ForeColor = System.Drawing.Color.Red;
            }
            if (Command11SetEnable_Flag == false)
            {
                Cmd11Set_btn.Text = "Un Set";
                Cmd11Set_btn.ForeColor = System.Drawing.Color.Red;
            }
            if (Command12SetEnable_Flag == false)
            {
                Cmd12Set_btn.Text = "Un Set";
                Cmd12Set_btn.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Command1_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;

            if ((int)e.KeyChar != 8)
            {
                if ( (((int)e.KeyChar >= 48)&&((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65)&&((int)e.KeyChar <= 70)) || 
                     (((int)e.KeyChar >= 97)&&((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command1_textBox.Paste(PerChar.ToString());
                    Cmd1_NumOfChar++;
                    e.Handled = true;
                    if (Cmd1_NumOfChar % 2 == 0)
                    {
                        Cmd1_NumOfChar = 0;
                        Cmd1_String_Flag = true;
                        Command1_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd1_String_Flag = false;
                    }
                }  
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command1_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command1_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command1_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command1_textBox.Text = Command1_textBox.Text.Substring(0, StringIndex);
                            Command1_textBox.Select(Command1_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd1_NumOfChar = 0;
                    }
                }
            }  
        }
        private void Command2_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;
            if ((int)e.KeyChar != 8)
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                     (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command2_textBox.Paste(PerChar.ToString());
                    Cmd2_NumOfChar++;
                    e.Handled = true;
                    if (Cmd2_NumOfChar % 2 == 0)
                    {
                        Cmd2_NumOfChar = 0;
                        Cmd2_String_Flag = true;
                        Command2_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd2_String_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command2_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command2_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command2_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command2_textBox.Text = Command2_textBox.Text.Substring(0, StringIndex);
                            Command2_textBox.Select(Command2_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd2_NumOfChar = 0;
                    }
                }
            }  
        }

        private void Command3_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;
            if ((int)e.KeyChar != 8)
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                     (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command3_textBox.Paste(PerChar.ToString());
                    Cmd3_NumOfChar++;
                    e.Handled = true;
                    if (Cmd3_NumOfChar % 2 == 0)
                    {
                        Cmd3_NumOfChar = 0;
                        Cmd3_String_Flag = true;
                        Command3_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd3_String_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command3_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command3_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command3_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command3_textBox.Text = Command3_textBox.Text.Substring(0, StringIndex);
                            Command3_textBox.Select(Command3_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd3_NumOfChar = 0;
                    }
                }
            }            
        }
        private void Command4_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;
            if ((int)e.KeyChar != 8)
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                     (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command4_textBox.Paste(PerChar.ToString());
                    Cmd4_NumOfChar++;
                    e.Handled = true;
                    if (Cmd4_NumOfChar % 2 == 0)
                    {
                        Cmd4_NumOfChar = 0;
                        Cmd4_String_Flag = true;
                        Command4_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd4_String_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command4_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command4_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command4_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command4_textBox.Text = Command4_textBox.Text.Substring(0, StringIndex);
                            Command4_textBox.Select(Command4_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd4_NumOfChar = 0;
                    }
                }
            }
        }

        private void Command5_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;
            if ((int)e.KeyChar != 8)
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                     (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command5_textBox.Paste(PerChar.ToString());
                    Cmd5_NumOfChar++;
                    e.Handled = true;
                    if (Cmd5_NumOfChar % 2 == 0)
                    {
                        Cmd5_NumOfChar = 0;
                        Cmd5_String_Flag = true;
                        Command5_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd5_String_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command5_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command5_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command5_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command5_textBox.Text = Command5_textBox.Text.Substring(0, StringIndex);
                            Command5_textBox.Select(Command5_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd5_NumOfChar = 0;
                    }
                }
            }
        }

        private void Command6_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;
            if ((int)e.KeyChar != 8)
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                     (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command6_textBox.Paste(PerChar.ToString());
                    Cmd6_NumOfChar++;
                    e.Handled = true;
                    if (Cmd6_NumOfChar % 2 == 0)
                    {
                        Cmd6_NumOfChar = 0;
                        Cmd6_String_Flag = true;
                        Command6_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd6_String_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command6_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command6_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command6_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command6_textBox.Text = Command6_textBox.Text.Substring(0, StringIndex);
                            Command6_textBox.Select(Command6_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd6_NumOfChar = 0;
                    }
                }
            }
        }

        private void HexFormat_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(HexFormat_radioButton.Checked == true)
            {
                format = 1;
                SubscriptionKeyPressEvent(); //訂閱 cmd1~cmd12 textbox keyPress event //
            }
        }

        private void StringFormat_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(StringFormat_radioButton.Checked == true)
            {
                format = 2;
                UnsubscriptionKeyPressEvent(); //取消訂閱 cmd1~cmd12 textbox keyPress event //
            }
        }

        private void Command7_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;
            if ((int)e.KeyChar != 8)
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                     (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command7_textBox.Paste(PerChar.ToString());
                    Cmd7_NumOfChar++;
                    e.Handled = true;
                    if (Cmd7_NumOfChar % 2 == 0)
                    {
                        Cmd7_NumOfChar = 0;
                        Cmd7_String_Flag = true;
                        Command7_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd7_String_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command7_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command7_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command7_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command7_textBox.Text = Command7_textBox.Text.Substring(0, StringIndex);
                            Command7_textBox.Select(Command7_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd7_NumOfChar = 0;
                    }
                }
            }
        }

        private void Command8_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;
            if ((int)e.KeyChar != 8)
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                     (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command8_textBox.Paste(PerChar.ToString());
                    Cmd8_NumOfChar++;
                    e.Handled = true;
                    if (Cmd8_NumOfChar % 2 == 0)
                    {
                        Cmd8_NumOfChar = 0;
                        Cmd8_String_Flag = true;
                        Command8_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd8_String_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command8_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command8_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command8_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command8_textBox.Text = Command8_textBox.Text.Substring(0, StringIndex);
                            Command8_textBox.Select(Command8_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd8_NumOfChar = 0;
                    }
                }
            }
        }

        private void Command9_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;
            if ((int)e.KeyChar != 8)
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                     (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command9_textBox.Paste(PerChar.ToString());
                    Cmd9_NumOfChar++;
                    e.Handled = true;
                    if (Cmd9_NumOfChar % 2 == 0)
                    {
                        Cmd9_NumOfChar = 0;
                        Cmd9_String_Flag = true;
                        Command9_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd9_String_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command9_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command9_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command9_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command9_textBox.Text = Command9_textBox.Text.Substring(0, StringIndex);
                            Command9_textBox.Select(Command9_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd9_NumOfChar = 0;
                    }
                }
            }
        }

        private void Command10_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;
            if ((int)e.KeyChar != 8)
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                    (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command10_textBox.Paste(PerChar.ToString());
                    Cmd10_NumOfChar++;
                    e.Handled = true;
                    if (Cmd10_NumOfChar % 2 == 0)
                    {
                        Cmd10_NumOfChar = 0;
                        Cmd10_String_Flag = true;
                        Command10_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd10_String_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command10_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command10_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command10_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command10_textBox.Text = Command10_textBox.Text.Substring(0, StringIndex);
                            Command10_textBox.Select(Command10_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd10_NumOfChar = 0;
                    }
                }
            }
        }

        private void Command11_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;
            if ((int)e.KeyChar != 8)
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                    (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command11_textBox.Paste(PerChar.ToString());
                    Cmd11_NumOfChar++;
                    e.Handled = true;
                    if (Cmd11_NumOfChar % 2 == 0)
                    {
                        Cmd11_NumOfChar = 0;
                        Cmd11_String_Flag = true;
                        Command11_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd11_String_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command11_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command11_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command11_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command11_textBox.Text = Command11_textBox.Text.Substring(0, StringIndex);
                            Command11_textBox.Select(Command11_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd11_NumOfChar = 0;
                    }
                }
            }
        }

        private void Command12_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;
            if ((int)e.KeyChar != 8)
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                    (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    Command12_textBox.Paste(PerChar.ToString());
                    Cmd12_NumOfChar++;
                    e.Handled = true;
                    if (Cmd12_NumOfChar % 2 == 0)
                    {
                        Cmd12_NumOfChar = 0;
                        Cmd12_String_Flag = true;
                        Command12_textBox.Paste(" ");
                    }
                    else
                    {
                        Cmd12_String_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // e.Handled = true : 表示略過控制項的預設處理 ; e.Handled = false : 表示將事件直接傳遞至預設的控制項處理常式 //
                }
            }
            else
            {
                StringLength = Command12_textBox.Text.Length;
                if (StringLength > 0)
                {
                    StringIndex = Command12_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            Command12_textBox.Text = String.Empty;
                        }
                        else
                        {
                            Command12_textBox.Text = Command12_textBox.Text.Substring(0, StringIndex);
                            Command12_textBox.Select(Command12_textBox.Text.Length, 0);//使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        Cmd12_NumOfChar = 0;
                    }
                }
            }
        }
        //=============== Self define function =========================//
        private void SubscriptionKeyPressEvent()
        {
            Command1_textBox.KeyPress += new KeyPressEventHandler(Command1_textBox_KeyPress);
            Command2_textBox.KeyPress += new KeyPressEventHandler(Command2_textBox_KeyPress);
            Command3_textBox.KeyPress += new KeyPressEventHandler(Command3_textBox_KeyPress);
            Command4_textBox.KeyPress += new KeyPressEventHandler(Command4_textBox_KeyPress);
            Command5_textBox.KeyPress += new KeyPressEventHandler(Command5_textBox_KeyPress);
            Command6_textBox.KeyPress += new KeyPressEventHandler(Command6_textBox_KeyPress);
            Command7_textBox.KeyPress += new KeyPressEventHandler(Command7_textBox_KeyPress);
            Command8_textBox.KeyPress += new KeyPressEventHandler(Command8_textBox_KeyPress);
            Command9_textBox.KeyPress += new KeyPressEventHandler(Command9_textBox_KeyPress);
            Command10_textBox.KeyPress += new KeyPressEventHandler(Command10_textBox_KeyPress);
            Command11_textBox.KeyPress += new KeyPressEventHandler(Command11_textBox_KeyPress);
            Command12_textBox.KeyPress += new KeyPressEventHandler(Command12_textBox_KeyPress);

        }
        private void UnsubscriptionKeyPressEvent()
        {
            Command1_textBox.KeyPress -= new KeyPressEventHandler(Command1_textBox_KeyPress);
            Command2_textBox.KeyPress -= new KeyPressEventHandler(Command2_textBox_KeyPress);
            Command3_textBox.KeyPress -= new KeyPressEventHandler(Command3_textBox_KeyPress);
            Command4_textBox.KeyPress -= new KeyPressEventHandler(Command4_textBox_KeyPress);
            Command5_textBox.KeyPress -= new KeyPressEventHandler(Command5_textBox_KeyPress);
            Command6_textBox.KeyPress -= new KeyPressEventHandler(Command6_textBox_KeyPress);
            Command7_textBox.KeyPress -= new KeyPressEventHandler(Command7_textBox_KeyPress);
            Command8_textBox.KeyPress -= new KeyPressEventHandler(Command8_textBox_KeyPress);
            Command9_textBox.KeyPress -= new KeyPressEventHandler(Command9_textBox_KeyPress);
            Command10_textBox.KeyPress -= new KeyPressEventHandler(Command10_textBox_KeyPress);
            Command11_textBox.KeyPress -= new KeyPressEventHandler(Command11_textBox_KeyPress);
            Command12_textBox.KeyPress -= new KeyPressEventHandler(Command12_textBox_KeyPress);
        }
    }
}
