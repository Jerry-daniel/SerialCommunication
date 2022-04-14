using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;

namespace GeneralSerialCommunicationApp
{
    public partial class MainForm : Form
    {
        bool test_flag = false;

        UartSetForm uartSetForm = new UartSetForm();
        CommandSet_Form CmdSetForm = new CommandSet_Form();
        private protected volatile string GET_SERIALPORT;
        private protected volatile int GET_BAUDRATE, GET_PARITY, GET_DATABITS, GET_STOPBIT;
        int m_format = 0;
        int NumOfChar = 0;
        int NumOfCmd = 0;
        int ReadDataByte = 0;
        int ByteCnt = 0;
        int CommandLength = 0;
        int TransferBoxStringLength = 0;
        private protected volatile int Cmd0Length, Cmd1Length, Cmd2Length, Cmd3Length, Cmd4Length, Cmd5Length, Cmd6Length, Cmd7Length, Cmd8Length, Cmd9Length, Cmd10Length, Cmd11Length, Cmd12Length;
        string[] ShowSerialData = new string[100];
        private protected volatile Byte[][] CommandArray = new byte[12][];
        Byte[] PerCommand;
        byte[] ByteMessage = new byte[2];
        byte[] perlinebytes;

        string TransferBoxString = string.Empty;
        string SerialDataOutput = string.Empty;
        string SerialDataToCharOutput = string.Empty; // display char format //
        string ShowCommand = string.Empty;
        bool SerialPortActive_Flag = false;
        bool TxWindowString_Flag = false;
        bool Transmit_Flag = false;
        bool Receiver_Flag = false;

        //char backspace;
        //string TxOutputString = string.Empty;

        private Thread SerialReceive_Thread;    // uart 接收執行緒函式定義 //
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialization();
        }
        
        public void triggered(string comportMsg, int baudrateMsg, int parityMsg, int databitMsg, int stopbitMsg)
        {
            SerialConfiguration_Initialization(comportMsg, baudrateMsg, parityMsg, databitMsg, stopbitMsg);
        }
        //----------------- command setting trigger function ----------------------------//
        public void cmdmsgtriggered(string cmdtmp,int cmdn,int format)
        {
            int i,j,length=0;
            int TureMsgLength = 0;
            int MsgLength = cmdtmp.Length;
            string Message = cmdtmp;
            string PerChar;
            string PerByte = string.Empty;
            Byte[] CmdMsgTmp = new byte[MsgLength];
            int asciicode = 0;
            //Byte[] ToASCII;
            switch(format)
            {
                //----------------------------------------------------------------//
                case 1:
                //----------------------------------------------------------------//
                    for (i = 0; i < MsgLength; i++)
                    {
                        PerChar = Message.Substring(i, 1);
                        if (PerChar != " ")
                        {
                            PerByte += PerChar;
                        }
                        else
                        {
                            CmdMsgTmp[TureMsgLength] = Convert.ToByte((Convert.ToInt16(PerByte, 16)));// 16進制格式處理 //
                            PerByte = string.Empty;
                            TureMsgLength++;
                        }
                    }
                    break;
                //----------------------------------------------------------------//
                case 2:// -----------超過16進位可表示範圍的數據格式處理(將字元轉成相對應的16進位編碼ASCII)------------ -//
                //----------------------------------------------------------------//
                    char[] values = Message.ToCharArray();
                    foreach (char signalchar in values)
                    {
                        asciicode = Convert.ToInt32(signalchar);
                        CmdMsgTmp[length] = Convert.ToByte(asciicode);
                        length++;
                    }
                    TureMsgLength = CmdMsgTmp.Length;
                    break;
                //----------------------------------------------------------------//
                default:
                //----------------------------------------------------------------//
                    for (i = 0; i < MsgLength; i++)
                    {
                        PerChar = Message.Substring(i, 1);
                        if (PerChar != " ")
                        {
                            PerByte += PerChar;
                        }
                        else
                        {
                            CmdMsgTmp[TureMsgLength] = Convert.ToByte((Convert.ToInt16(PerByte, 16)));// 16進制格式處理 //
                            PerByte = string.Empty;
                            TureMsgLength++;
                        }
                    }
                    break;
            }
            /*if(format == 1)
            {
                for (i = 0; i < MsgLength; i++)
                {
                    PerChar = Message.Substring(i, 1);
                    if (PerChar != " ")
                    {
                        PerByte += PerChar;
                    }
                    else
                    {
                        CmdMsgTmp[TureMsgLength] = Convert.ToByte((Convert.ToInt16(PerByte, 16)));// 16進制格式處理 //
                        PerByte = string.Empty;
                        TureMsgLength++;
                    }
                }
            }
            else//----------- 超過16進位可表示範圍的數據格式處理(將字元轉成相對應的16進位編碼ASCII)-------------//
            {
                char[] values = Message.ToCharArray();
                foreach (char signalchar in values)
                {
                    asciicode = Convert.ToInt32(signalchar);
                    CmdMsgTmp[length] = Convert.ToByte(asciicode);
                    length++;
                }
                TureMsgLength = CmdMsgTmp.Length;
            }*/
            CommandLength = TureMsgLength;
            CommandArray[cmdn] = new byte[TureMsgLength];
            for (i = 0; i < TureMsgLength; i++)
            {
                CommandArray[cmdn][i] = CmdMsgTmp[i];
            }
            CommandButtonTriggerProcess(cmdn);
        }
        //-------------------------------------------------------------------------------//
        private void CommandButtonTriggerProcess(int cmdn)
        {
            switch(cmdn)
            {
                case 0:
                    Cmd1Length = CommandLength;
                    Command1_btn.Enabled = true;
                    break;
                case 1:
                    Cmd2Length = CommandLength;
                    Command2_btn.Enabled = true;
                    break;
                case 2:
                    Cmd3Length = CommandLength;
                    Command3_btn.Enabled = true;
                    break;
                case 3:
                    Cmd4Length = CommandLength;
                    Command4_btn.Enabled = true;
                    break;
                case 4:
                    Cmd5Length = CommandLength;
                    Command5_btn.Enabled = true;
                    break;
                case 5:
                    Cmd6Length = CommandLength;
                    Command6_btn.Enabled = true;
                    break;
                case 6:
                    Cmd7Length = CommandLength;
                    Command7_btn.Enabled = true;
                    break;
                case 7:
                    Cmd8Length = CommandLength;
                    Command8_btn.Enabled = true;
                    break;
                case 8:
                    Cmd9Length = CommandLength;
                    Command9_btn.Enabled = true;
                    break;
                case 9:
                    Cmd10Length = CommandLength;
                    Command10_btn.Enabled = true;
                    break;
                case 10:
                    Cmd11Length = CommandLength;
                    Command11_btn.Enabled = true;
                    break;
                case 11:
                    Cmd12Length = CommandLength;
                    Command12_btn.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        

        //----------------- command setting trigger function ----------------------------//
        private void SerialConfiguration_Initialization(string getcomport,int getbaudrate,int getparity,int getdatabit,int getstopbit)
        {
            string showparity, showstopbit;
            try
            {
                GET_SERIALPORT = getcomport;
                GET_BAUDRATE = getbaudrate;
                GET_PARITY = getparity;
                GET_DATABITS = getdatabit;
                GET_STOPBIT = getstopbit;

                General_SerialPort.PortName = getcomport;
                General_SerialPort.BaudRate = getbaudrate;
                General_SerialPort.DataBits = getdatabit;
                switch (getparity)
                {
                    case 0:
                        General_SerialPort.Parity = System.IO.Ports.Parity.None;
                        showparity = "None";
                        break;
                    case 1:
                        General_SerialPort.Parity = System.IO.Ports.Parity.Odd;
                        showparity = "Odd";
                        break;
                    case 2:
                        General_SerialPort.Parity = System.IO.Ports.Parity.Even;
                        showparity = "Even";
                        break;
                    case 3:
                        General_SerialPort.Parity = System.IO.Ports.Parity.Mark;
                        showparity = "Mark";
                        break;
                    case 4:
                        General_SerialPort.Parity = System.IO.Ports.Parity.Space;
                        showparity = "Space";
                        break;
                    case -1:
                        General_SerialPort.Parity = System.IO.Ports.Parity.None;
                        showparity = "None";
                        break;
                    default:
                        General_SerialPort.Parity = System.IO.Ports.Parity.None;
                        showparity = "None";
                        break;
                }
                switch (getstopbit)
                {
                    case 0:
                        General_SerialPort.StopBits = System.IO.Ports.StopBits.One;
                        showstopbit = "1";
                        break;
                    case 1:
                        General_SerialPort.StopBits = System.IO.Ports.StopBits.OnePointFive;
                        showstopbit = "1.5";
                        break;
                    case 2:
                        General_SerialPort.StopBits = System.IO.Ports.StopBits.Two;
                        showstopbit = "2";
                        break;
                    case -1:
                        General_SerialPort.StopBits = System.IO.Ports.StopBits.One;
                        showstopbit = "1";
                        break;
                    default:
                        General_SerialPort.StopBits = System.IO.Ports.StopBits.One;
                        showstopbit = "1";
                        break;
                }
                OpenSerialPortProcess();

                PortState_toolStripStatusLabel.Text = General_SerialPort.PortName;// getcomport;
                PortState_toolStripStatusLabel.ForeColor = System.Drawing.Color.Green;
                BaudRate_toolStripStatusLabel.Text = Convert.ToString(General_SerialPort.BaudRate);//getbaudrate
                Parity_toolStripStatusLabel.Text = showparity;
                Databit_toolStripStatusLabel.Text = Convert.ToString(General_SerialPort.DataBits);//getdatabit
                Stopbit_toolStripStatusLabel.Text = showstopbit;

                Setting_toolStripBtn.Enabled = false;
                Connect_toolStripBtn.Enabled = true;
                Connect_toolStripBtn.Checked = true;
                Connect_toolStripBtn.CheckOnClick = true;
                SerialPortDetect_timer.Enabled = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Serial Port didn't connect or on useding!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Setting_toolStripBtn.Enabled = true;
            }
            
        }

        

        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Uart Receiver 控制程序 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<//
        private void SerialReceive_Task()
        {
            string ByteToString,StringToHex,ByteToHex;
            int i;
            int waitcounter = 0;
            int ReadNumOfByte = 0;
            byte[] displaymessage;
            bool datain_flag = false;
            bool ReadMessageTimeoutFlag = false;

            while (SerialPortActive_Flag==true)
            {
                try
                {
                    if(ReadMessageTimeoutFlag == false)
                    {
                        if (General_SerialPort.BytesToRead > 0)
                        {
                            if (ReadNumOfByte == General_SerialPort.BytesToRead)
                            {
                                Thread.Sleep(10);
                                waitcounter++;
                                if(waitcounter==10)
                                {
                                    waitcounter = 0;
                                    ReadMessageTimeoutFlag = true;
                                }
                            }
                            else
                            {
                                waitcounter = 0;
                            }
                            ReadNumOfByte = General_SerialPort.BytesToRead;
                            /*if (ReadNumOfByte == 8)
                            {
                                datain_flag = true;
                            }*/

                            /*ReadDataByte = General_SerialPort.ReadByte();
                            ByteToHex = String.Format("{0:X}", ReadDataByte);
                            SerialDataOutput += ByteToHex + " ";
                            this.Invoke(new EventHandler(ShowData));*/
                        }
                    }
                    else
                    {
                        displaymessage = new byte[ReadNumOfByte];
                        SerialDataToCharOutput = String.Empty;
                        //char[] bytetochar = new char[ReadNumOfByte];//20220327 modify for byte to char//
                        General_SerialPort.Read(displaymessage, 0, ReadNumOfByte);
                        for( i = 0; i < ReadNumOfByte; i++ )
                        {
                            ByteMessage[0] = displaymessage[i];
                            ByteToChar(ByteMessage, 0);  // byte to char function //
                            if(ByteMessage[0]<10)
                            {
                                ByteToHex = "0" + String.Format("{0:X}", displaymessage[i]);
                            }
                            else
                            {
                                ByteToHex = String.Format("{0:X}", displaymessage[i]);
                            }
                            //ByteToHex = String.Format("{0:X}", displaymessage[i]);
                            SerialDataOutput += ByteToHex + " ";
                        }
                        ReadNumOfByte = 0;
                        this.Invoke(new EventHandler(ShowData));
                        ReadMessageTimeoutFlag = false;
                    }
                    

                    //-------------------------------------------------//



                    //ReadDataByte = General_SerialPort.ReadByte();
                    //ByteToHex = String.Format("{0:X}",ReadDataByte);
                    //SerialDataOutput += ByteToHex + " ";
                    //ByteCnt++;
                    
                    /*if (ByteCnt == 100)
                    {
                        ByteCnt = 0;
                        this.Invoke(new EventHandler(ShowData));
                    }*/

                }
                catch (Exception)
                {
                    SerialPortActive_Flag = false;
                    SerialReceive_Thread.Join();
                }
            }
        }
        //===============================================================================================//
        // 傳回從位元組陣列中指定位置的兩個位元組所轉換的 Unicode 字元。 //
        // byte[]:陣列，其中包含要轉換的兩個位元組。//
        public void ByteToChar(byte[] bytes, int index)
        {

            char value = BitConverter.ToChar(bytes, index); // 從開始的兩位元組組成的字元 。//
            SerialDataToCharOutput += char.ToString(value);
        }

        //===============================================================================================//
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //UartSetForm uartSetForm = new UartSetForm();
            uartSetForm.EventUartSetFormTrigger = new UartSetForm.uartsetformEventHandler(triggered);
            uartSetForm.ShowDialog();
        }

        

        private void CommandSet_toolStripBtn_Click(object sender, EventArgs e)
        {
            CmdSetForm.CmdMsgSetEventTrigger = new CommandSet_Form.commandsetformEventHandler(cmdmsgtriggered);
            CmdSetForm.ShowDialog();
        }

        

        private void SerialPortDetect_timer_Tick(object sender, EventArgs e)
        {
            if (General_SerialPort.IsOpen == false)
            {
                SerialPortDetect_timer.Enabled = false;
            }
        }

        

        private void Connect_toolStripBtn_Click_1(object sender, EventArgs e)
        {
            if(Connect_toolStripBtn.CheckOnClick==false)
            {
                triggered(GET_SERIALPORT, GET_BAUDRATE, GET_PARITY, GET_DATABITS, GET_STOPBIT);
            }
            else
            {
                CloseSerialPortProcess();
            }
        }

       

        private void Power_toolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TransferDisplay_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StringLength = 0;
            int StringIndex = 0;
            string TextBoxString = string.Empty;
            string CutString = string.Empty;

            if (((int)e.KeyChar!=8)&& ((int)e.KeyChar != 13)) // 8:backspace鍵,13:enter鍵 //
            {
                if ((((int)e.KeyChar >= 48) && ((int)e.KeyChar <= 57)) || (((int)e.KeyChar >= 65) && ((int)e.KeyChar <= 70)) ||
                    (((int)e.KeyChar >= 97) && ((int)e.KeyChar <= 102)))
                {
                    char PerChar = e.KeyChar;//取得keyboard輸入的字元//
                    TransferDisplay_textBox.Paste(PerChar.ToString());
                    NumOfChar++;
                    e.Handled = true;
                    if (NumOfChar % 2 == 0)
                    {
                        NumOfChar = 0;
                        TxWindowString_Flag = true;
                        TransferDisplay_textBox.Paste(" ");
                    }
                    else
                    {
                        TxWindowString_Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Format is error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }
                    
            }
            else if ((int)e.KeyChar == 8)
            {
                StringLength = TransferDisplay_textBox.Text.Length;
                if(StringLength>0)
                {
                    StringIndex = TransferDisplay_textBox.Text.Length - 2;
                    if (StringLength % 3 == 0)
                    {
                        if (StringLength == 3)
                        {
                            TransferDisplay_textBox.Text = String.Empty;
                        }
                        else
                        {
                            TransferDisplay_textBox.Text = TransferDisplay_textBox.Text.Substring(0, StringIndex);
                            TransferDisplay_textBox.Select(TransferDisplay_textBox.Text.Length, 0); //使用Select方法將游標置放在textbox的結尾//
                        }
                    }
                    else
                    {
                        NumOfChar = 0;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        private void ClearTransferMsg_btn_Click(object sender, EventArgs e)
        {
            TransferDisplay_textBox.Text = string.Empty;
            if(NumOfChar!=0)
            {
                NumOfChar = 0;
            }
        }

        private void Date_timer_Tick(object sender, EventArgs e)
        {
            Date_toolStripStatusLabel.Text = DateTimeOffset.Now.ToString("yyyy/MM/dd tt hh:mm");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm aboutform = new AboutForm();
            aboutform.ShowDialog();
        }

       

        private void ClearMsg_btn_Click(object sender, EventArgs e)
        {
            ReceiveDisplay_TextBox.Text = String.Empty;
            DisplayChar_textBox.Text = String.Empty;
        }
        //================== My self define function area.==================================//
        private void Initialization()
        {
            Connect_toolStripBtn.Enabled = false;
            Connect_toolStripBtn.CheckOnClick = false;

            PortState_toolStripStatusLabel.Text = "Disconnect";
            BaudRate_toolStripStatusLabel.Text = String.Empty;
            Parity_toolStripStatusLabel.Text = String.Empty;
            Databit_toolStripStatusLabel.Text = String.Empty;
            Stopbit_toolStripStatusLabel.Text = String.Empty;
            PortState_toolStripStatusLabel.ForeColor = System.Drawing.Color.Red;

            ByteMessage[0] = 0;
            ByteMessage[1] = 0;

            Date_timer.Enabled = Enabled;
        }
        //----------------------------------------------------------------------------------------------//
        private void TransferMessage_btn_Click(object sender, EventArgs e)
        {
            int i;
            byte[] SendCommand;
            byte[] CmdTemp;
            string PerChar = string.Empty;
            string PerSubString = string.Empty;
            string ReadCommand = string.Empty;
            int CmdLength = TransferDisplay_textBox.Text.Length;
            int SendCmdLength = 0;
            int asciicode = 0;

            NumOfCmd = 0;
            if (CmdLength!=0)
            {
                CmdTemp = new byte[CmdLength];
                ReadCommand = TransferDisplay_textBox.Text;

                switch(m_format)
                {
                    //----------------------------------------------------------------//
                    case 1:                                 // --- for 16's format ---//
                    //----------------------------------------------------------------//
                        for (i = 0; i < CmdLength; i++)
                        {
                            PerChar = ReadCommand.Substring(i, 1);
                            if (PerChar != " ")
                            {
                                PerSubString += PerChar;
                            }
                            else
                            {
                                CmdTemp[SendCmdLength] = Convert.ToByte((Convert.ToInt16(PerSubString, 16)));
                                PerSubString = string.Empty;
                                SendCmdLength++;
                            }
                        }
                        break;
                    //----------------------------------------------------------------//
                    case 2:                               // --- for string format ---//
                    //----------------------------------------------------------------//
                        char[] values = ReadCommand.ToCharArray();
                        foreach (char signalchar in values)
                        {
                            asciicode = Convert.ToInt32(signalchar);
                            CmdTemp[SendCmdLength] = Convert.ToByte(asciicode);
                            SendCmdLength++;
                        }
                        break;
                    //----------------------------------------------------------------//
                    default:
                    //----------------------------------------------------------------//
                        for (i = 0; i < CmdLength; i++)
                        {
                            PerChar = ReadCommand.Substring(i, 1);
                            if (PerChar != " ")
                            {
                                PerSubString += PerChar;
                            }
                            else
                            {
                                CmdTemp[SendCmdLength] = Convert.ToByte((Convert.ToInt16(PerSubString, 16)));
                                PerSubString = string.Empty;
                                SendCmdLength++;
                            }
                        }
                        break;
                }
                //SendCommand = new byte[SendCmdLength];
                PerCommand = new byte[SendCmdLength];
                Cmd0Length = SendCmdLength;
                for (i=0;i< SendCmdLength;i++)
                {
                    PerCommand[i] = CmdTemp[i];
                }
                SerialPortTransferProcess(NumOfCmd);
            }
        }
        //----------------------------------------------------------------------------------------------//
        private void Command1_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 1;
            PerCommand = new byte[Cmd1Length];
            for (i = 0; i < Cmd1Length; i++)
            {
                PerCommand[i] = CommandArray[0][i];
                if (PerCommand[i]<10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[0][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[0][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }

        private void FileTransfer_toolStripBtn_Click(object sender, EventArgs e)
        {
            int i,bytecnt = 0;
            int filetype = 0;
            int strcnt = 0;
            
            var subchar = string.Empty;
            var substr = string.Empty;
            var filepath = string.Empty;
            var filecontent = string.Empty;
            var shownewstring = string.Empty;
            var filesize = 0;
            var numofbytesize = 0;
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    //fullpath = System.Environment.CurrentDirectory;
                    openFileDialog.InitialDirectory = "D:\\";//fullpath;
                    openFileDialog.Filter = "hex files (*.hex)|*.hex|mot files (*.mot)|*.mot|txt files (*.txt)|*.txt";
                    openFileDialog.FilterIndex = 3;
                    openFileDialog.RestoreDirectory = true;
                    if(openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filepath = openFileDialog.FileName;
                        var fileStream = openFileDialog.OpenFile();
                        using(StreamReader reader = new StreamReader(fileStream))
                        {
                            filetype = openFileDialog.FilterIndex;
                            while (reader.EndOfStream != true)
                            {
                                //if(Transmit_Flag == false)
                                //{
                                    filecontent = reader.ReadLine();
                                    filesize = filecontent.Length;
                                    numofbytesize = (filesize - 1) / 2;
                                    perlinebytes = new byte[numofbytesize];
                                    bytecnt = 0;
                                    for (i = 0; i < filesize; i++)
                                    {
                                        switch (filetype)
                                        {
                                            case 1: // *.hex file format //
                                                subchar = filecontent.Substring(i, 1);
                                                if (subchar != ":")
                                                {
                                                    substr += subchar;
                                                    strcnt++;
                                                    if (strcnt == 2)
                                                    {
                                                        strcnt = 0;
                                                        perlinebytes[bytecnt] = Convert.ToByte((Convert.ToInt16(substr, 16)));
                                                        
                                                        if (i != (filesize - 1))
                                                        {
                                                            shownewstring += substr + " ";
                                                        }
                                                        else
                                                        {
                                                            shownewstring += substr;
                                                        }
                                                        substr = string.Empty;
                                                        bytecnt++;
                                                    }
                                                }
                                                break;
                                            case 2: // *.mot file format //

                                                break;
                                            case 3: // *.txt file format //
                                                if (i != (filesize - 1))
                                                {
                                                    shownewstring += filecontent.Substring(i, 1) + " ";
                                                }
                                                else
                                                {
                                                    shownewstring += filecontent.Substring(i, 1);
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    Transmit_Flag = true;
                                    //Receiver_Flag = true;
                                    while(Transmit_Flag == true)
                                    {
                                        try
                                        {
                                            General_SerialPort.Write(perlinebytes, 0, numofbytesize);
                                        }
                                        catch
                                        {

                                        }
                                        finally
                                        {
                                            //ReceiveDisplay_TextBox.Text += shownewstring + Environment.NewLine;
                                            //ReceiveDisplay_TextBox.SelectionStart = ReceiveDisplay_TextBox.TextLength;
                                            //ReceiveDisplay_TextBox.ScrollToCaret();
                                            //if(Receiver_Flag == false)
                                            //{
                                                shownewstring = string.Empty;
                                                Transmit_Flag = false;
                                            //}
                                        }
                                    }
                                //}
                                /*else
                                {
                                    try
                                    {
                                        General_SerialPort.Write(perlinebytes, 0, numofbytesize);
                                    }
                                    catch
                                    {

                                    }
                                    finally
                                    {
                                        ReceiveDisplay_TextBox.Text += shownewstring + Environment.NewLine;
                                        ReceiveDisplay_TextBox.SelectionStart = ReceiveDisplay_TextBox.TextLength;
                                        ReceiveDisplay_TextBox.ScrollToCaret();
                                        shownewstring = string.Empty;
                                        Transmit_Flag = false;
                                    }
                                }*/
                            }
                            Transmit_Flag = false;
                        }
                    }

                }
            }
            catch
            {

            }
        }
        //private void 

        private void M_HexFormat_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(M_HexFormat_radioButton.Checked == true)
            {
                m_format = 1;
                FormatTransformProcess();
                SubscriptionTxDisplayBoxKeyPressEvent();
            }
        }
        private void M_StringFormat_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(M_StringFormat_radioButton.Checked == true)
            {
                m_format = 2;
                FormatTransformProcess();
                UnsubscriptionTxDisplayBoxKeyPressEvent();
            }
        }
        private void SubscriptionTxDisplayBoxKeyPressEvent()
        {
            TransferDisplay_textBox.KeyPress += new KeyPressEventHandler(TransferDisplay_textBox_KeyPress);
        }
        private void UnsubscriptionTxDisplayBoxKeyPressEvent()
        {
            TransferDisplay_textBox.KeyPress -= new KeyPressEventHandler(TransferDisplay_textBox_KeyPress);
        }

        private void TransferDisplay_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            CaculatorTransferBoxNumberOfStringAndLength();
        }

        //----------------------------------------------------------------------------------------------//
        private void Command2_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 2;
            PerCommand = new byte[Cmd2Length];
            for (i = 0; i < Cmd2Length; i++)
            {
                PerCommand[i] = CommandArray[1][i];
                if (PerCommand[i] < 10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[1][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[1][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }
        //----------------------------------------------------------------------------------------------//
        private void Command3_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 3;
            PerCommand = new byte[Cmd3Length];
            for (i = 0; i < Cmd3Length; i++)
            {
                PerCommand[i] = CommandArray[2][i];
                if (PerCommand[i] < 10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[2][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[2][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }
        //----------------------------------------------------------------------------------------------//
        private void Command4_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 4;
            PerCommand = new byte[Cmd4Length];
            for (i = 0; i < Cmd4Length; i++)
            {
                PerCommand[i] = CommandArray[3][i];
                if (PerCommand[i] < 10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[3][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[3][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }
        //----------------------------------------------------------------------------------------------//
        private void Command5_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 5;
            PerCommand = new byte[Cmd5Length];
            for (i = 0; i < Cmd5Length; i++)
            {
                PerCommand[i] = CommandArray[4][i];
                if (PerCommand[i] < 10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[4][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[4][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }
        //----------------------------------------------------------------------------------------------//
        private void Command6_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 6;
            PerCommand = new byte[Cmd6Length];
            for (i = 0; i < Cmd6Length; i++)
            {
                PerCommand[i] = CommandArray[5][i];
                if (PerCommand[i] < 10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[5][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[5][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }
        //----------------------------------------------------------------------------------------------//
        private void Command7_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 7;
            PerCommand = new byte[Cmd7Length];
            for (i = 0; i < Cmd7Length; i++)
            {
                PerCommand[i] = CommandArray[6][i];
                if (PerCommand[i] < 10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[6][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[6][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }
        //----------------------------------------------------------------------------------------------//
        private void Command8_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 8;
            PerCommand = new byte[Cmd8Length];
            for (i = 0; i < Cmd8Length; i++)
            {
                PerCommand[i] = CommandArray[7][i];
                if (PerCommand[i] < 10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[7][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[7][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }
        //-----------------------------------------------------------------------------//
        private void Command9_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 9;
            PerCommand = new byte[Cmd9Length];
            for (i = 0; i < Cmd9Length; i++)
            {
                PerCommand[i] = CommandArray[8][i];
                if (PerCommand[i] < 10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[8][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[8][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }
        //-----------------------------------------------------------------------------//
        private void Command10_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 10;
            PerCommand = new byte[Cmd10Length];
            for (i = 0; i < Cmd10Length; i++)
            {
                PerCommand[i] = CommandArray[9][i];
                if (PerCommand[i] < 10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[9][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[9][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }
        //-----------------------------------------------------------------------------//
        private void Command11_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 11;
            PerCommand = new byte[Cmd11Length];
            for (i = 0; i < Cmd11Length; i++)
            {
                PerCommand[i] = CommandArray[10][i];
                if (PerCommand[i] < 10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[10][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[10][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }
        //-----------------------------------------------------------------------------//
        private void Command12_btn_Click(object sender, EventArgs e)
        {
            int i;

            NumOfCmd = 12;
            PerCommand = new byte[Cmd12Length];
            for (i = 0; i < Cmd12Length; i++)
            {
                PerCommand[i] = CommandArray[11][i];
                if (PerCommand[i] < 10)
                {
                    ShowCommand += "0" + Convert.ToString(string.Format("{0:X}", CommandArray[11][i])) + " ";
                }
                else
                {
                    ShowCommand += Convert.ToString(string.Format("{0:X}", CommandArray[11][i])) + " ";
                }
            }
            SerialPortTransferProcess(NumOfCmd);
        }
        //-----------------------------------------------------------------------------//
        private void FormatTransformProcess()
        {
            var i = 0;
            var asciicode = 0;
            byte[] Tobyte = new byte[2];
            var PerChar = string.Empty;
            var PerByte = string.Empty;
            var Newstring = string.Empty;
            if (TransferBoxString!= string.Empty)
            {
                if (m_format == 1) //----------------------------- string transform to hex //
                {
                    char[] values = TransferBoxString.ToCharArray();
                    foreach (char signalchar in values)
                    {
                        asciicode = Convert.ToInt32(signalchar);
                        Tobyte[0] = Convert.ToByte(asciicode);
                        Newstring += Convert.ToString(string.Format("{0:X}", Tobyte[0])) + " ";
                    }
                    TransferDisplay_textBox.Text = Newstring;
                }
                else if (m_format == 2) //------------------------ hex transform to string //
                {
                    for(i = 0; i< TransferBoxStringLength; i++)
                    {
                        PerChar = TransferBoxString.Substring(i, 1);
                        if(PerChar != " ")
                        {
                            PerByte += PerChar;
                        }
                        else
                        {
                            Tobyte[1] = 0;
                            Tobyte[0] = Convert.ToByte((Convert.ToInt16(PerByte, 16)));// 16進制格式處理 //
                            char value = BitConverter.ToChar(Tobyte, 0); // 從開始的兩位元組組成的字元 。//
                            Newstring += value;
                            PerByte = string.Empty;
                        }
                    }
                    TransferDisplay_textBox.Text = Newstring;
                }
                CaculatorTransferBoxNumberOfStringAndLength(); // 取得textbox的字串內容與字串長度 //
            }  
        }
        private void CaculatorTransferBoxNumberOfStringAndLength()
        {
            TransferBoxString = TransferDisplay_textBox.Text;
            TransferBoxStringLength = TransferBoxString.Length;
        }
        private void SerialPortTransferProcess(int numofcmd)
        {
            try
            {
                switch(numofcmd)
                {
                    case 0:
                        General_SerialPort.Write(PerCommand, 0, Cmd0Length);
                        break;
                    case 1:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd1Length);
                        break;
                    case 2:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd2Length);
                        break;
                    case 3:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd3Length);
                        break;
                    case 4:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd4Length);
                        break;
                    case 5:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd5Length);
                        break;
                    case 6:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd6Length);
                        break;
                    case 7:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd7Length);
                        break;
                    case 8:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd8Length);
                        break;
                    case 9:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd9Length);
                        break;
                    case 10:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd10Length);
                        break;
                    case 11:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd11Length);
                        break;
                    case 12:
                        TransferDisplay_textBox.Text = ShowCommand;
                        General_SerialPort.Write(PerCommand, 0, Cmd12Length);
                        break;
                    default:
                        General_SerialPort.Write(PerCommand, 0, Cmd0Length);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Serial Port didn't connect or on useding!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CaculatorTransferBoxNumberOfStringAndLength();
            ShowCommand = String.Empty;
        }
        private void OpenSerialPortProcess()
        {
            if(General_SerialPort.IsOpen!=true)
            {
                General_SerialPort.Open();
                SerialPortActive_Flag = true;
            }
            SerialReceive_Thread = new Thread(SerialReceive_Task)  //--- Serial接收函式建立 ---//
            {
                IsBackground = true                                 //--- 設定Serial為背景作業 ---//
            };
            SerialReceive_Thread.Start();                           //--- 啟動Serial接收執行緒 ---//
        }
        //-----------------------------------------------------------------------------//
        private void CloseSerialPortProcess()
        {
            if (General_SerialPort.IsOpen == true)
            {
                General_SerialPort.Close();
            }
            //SerialReceive_Thread.Join();
            
            Connect_toolStripBtn.CheckOnClick = false;
            Connect_toolStripBtn.Checked = false;
            Setting_toolStripBtn.Enabled = true;

            PortState_toolStripStatusLabel.Text = "Disconnect";
            BaudRate_toolStripStatusLabel.Text = String.Empty;
            Parity_toolStripStatusLabel.Text = String.Empty;
            Databit_toolStripStatusLabel.Text = String.Empty;
            Stopbit_toolStripStatusLabel.Text = String.Empty;
            PortState_toolStripStatusLabel.ForeColor = System.Drawing.Color.Red;
            SerialPortDetect_timer.Enabled = false;
        }
        private void ShowData(object sender,EventArgs e)
        {
            ReceiveDisplay_TextBox.Text += SerialDataOutput + Environment.NewLine;
            ReceiveDisplay_TextBox.SelectionStart = ReceiveDisplay_TextBox.TextLength;
            ReceiveDisplay_TextBox.ScrollToCaret();
            SerialDataOutput = string.Empty;

            DisplayChar_textBox.Text += SerialDataToCharOutput + Environment.NewLine;
            DisplayChar_textBox.SelectionStart = DisplayChar_textBox.TextLength;
            DisplayChar_textBox.ScrollToCaret();
            SerialDataToCharOutput = string.Empty;
            //Receiver_Flag = false;
        }
        //================== My self define function area.==================================//
    }
}
