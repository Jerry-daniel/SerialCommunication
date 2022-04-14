using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;

namespace GeneralSerialCommunicationApp
{
    public partial class UartSetForm : Form
    {
        public delegate void uartsetformEventHandler(string comportMsg,int baudrateMsg,int parityMsg,int databitMsg,int stopbitMsg);
        public uartsetformEventHandler EventUartSetFormTrigger;

        int i;
        public static bool Checked_Flag = false;

        public static int ComportSelectIndex,BaudrateSelectIndex,ParitySelectIndex,DatabitSelectIndex,StopbitSelectIndex;
        public static string textBox_baudrate;
        string[] GetSerialPort;
        int ArrayLength;// ItemCounter,SelectItem;
        bool flag;
        public UartSetForm()
        {
            InitializeComponent();
        }

        private void Baudrate_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((int)e.KeyChar<48|(int)e.KeyChar>57)&(int)e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }
        //--------------------------------------------------------------------//
        private void Enable_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Enable_checkBox.Checked == true)
            {
                Baudrate_textBox.Enabled = true;
                BaudRate_comboBox.Enabled = false;
                Checked_Flag = true;
            }
            else
            {
                Baudrate_textBox.Enabled = false;
                BaudRate_comboBox.Enabled = true;
                Checked_Flag = false;
            }
        }
        //--------------------------------------------------------------------//
        private void UartSetForm_Load(object sender, EventArgs e)
        {
            //MainForm mainform = new MainForm();
            CheckCheckBoxState();
            LoadingCOMPortSetting();
            LoadingBaudRateSetting();
            LoadingParitySetting();
            LoadingDataBitSetting();
            LoadingStopBitSetting();

            COMPort_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BaudRate_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Parity_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DataBit_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StopBit_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //------------------------------------------------------------------------//
        private void CheckCheckBoxState()
        {
            if(Checked_Flag==true)
            {
                Enable_checkBox.Checked = true;
            }
            else
            {
                Enable_checkBox.Checked = false;
            }
        }
        //------------------------------------------------------------------------//
        private void LoadingCOMPortSetting()
        {
            GetSerialPort = SerialPort.GetPortNames();
            ArrayLength = GetSerialPort.Length;
            if(ArrayLength>0)
            {
                for (i = 0; i < ArrayLength; i++)
                {
                    COMPort_comboBox.Items.Insert(i, GetSerialPort[i]);
                }

                if (ComportSelectIndex < ArrayLength)
                {
                    COMPort_comboBox.Text = GetSerialPort[ComportSelectIndex];
                }
                else
                {
                    COMPort_comboBox.Text = GetSerialPort[0];
                }
            }
            else
            {
                COMPort_comboBox.Items.Clear();
                COMPort_comboBox.Text = String.Empty;
            }
        }
        //------------------------------------------------------------------------//
        private void LoadingBaudRateSetting()
        {
            if (Enable_checkBox.Checked == true)
            {
                Baudrate_textBox.Text = textBox_baudrate;
            }
            else
            {
                ArrayLength = BaudRate_comboBox.Items.Count;
                if (BaudrateSelectIndex < ArrayLength)
                {
                    if (BaudrateSelectIndex != 0)
                    {
                        BaudRate_comboBox.Text = (String)BaudRate_comboBox.Items[BaudrateSelectIndex];
                    }
                    else
                    {
                        BaudRate_comboBox.Text = (String)BaudRate_comboBox.Items[10];
                    }
                }
                else
                {
                    BaudRate_comboBox.Text = (String)BaudRate_comboBox.Items[10];
                }
            } 
        }
        //------------------------------------------------------------------------//
        private void LoadingParitySetting()
        {
            ArrayLength = Parity_comboBox.Items.Count;
            if (ParitySelectIndex < ArrayLength)
            {
                Parity_comboBox.Text = (String)Parity_comboBox.Items[ParitySelectIndex];
            }
            else
            {
                Parity_comboBox.Text = (String)Parity_comboBox.Items[0];
            }
        }
        //------------------------------------------------------------------------//
        private void LoadingDataBitSetting()
        {
            ArrayLength = DataBit_comboBox.Items.Count;
            if (DatabitSelectIndex < ArrayLength)
            {
                DataBit_comboBox.Text = (String)DataBit_comboBox.Items[DatabitSelectIndex];
            }
            else
            {
                DataBit_comboBox.Text = (String)DataBit_comboBox.Items[0];
            }
        }
        //------------------------------------------------------------------------//
        private void LoadingStopBitSetting()
        {
            ArrayLength = StopBit_comboBox.Items.Count;
            if (StopbitSelectIndex < ArrayLength)
            {
                StopBit_comboBox.Text = (String)StopBit_comboBox.Items[StopbitSelectIndex];
            }
            else
            {
                StopBit_comboBox.Text = (String)StopBit_comboBox.Items[0];
            }
        }
        //------------------------------------------------------------------------//
        private void ApprySet_Btn_Click(object sender, EventArgs e)
        {
            string comport;
            int baudrate, parityitem, databit, stopbititem;

            comport = COMPort_comboBox.Text;

            if (Enable_checkBox.Checked == true)
            {
                textBox_baudrate = Baudrate_textBox.Text;
                baudrate = Convert.ToInt32(textBox_baudrate);
            }
            else
            {
                baudrate = Convert.ToInt32(BaudRate_comboBox.Text);
            }

            parityitem = Parity_comboBox.SelectedIndex;
            databit = Convert.ToInt32(DataBit_comboBox.Text);
            stopbititem = StopBit_comboBox.SelectedIndex;
            EventUartSetFormTrigger(comport, baudrate,parityitem,databit,stopbititem);
            //COMPort_comboBox.Items.Clear();
            this.Close();
        }

        private void COMPort_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComportSelectIndex = COMPort_comboBox.SelectedIndex;
        }

        private void UartSetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            COMPort_comboBox.Items.Clear();
            COMPort_comboBox.Text = String.Empty;
        }

        private void BaudRate_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaudrateSelectIndex = BaudRate_comboBox.SelectedIndex;
        }

        private void Parity_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParitySelectIndex = Parity_comboBox.SelectedIndex;
        }

        private void DataBit_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabitSelectIndex = DataBit_comboBox.SelectedIndex;
        }

        private void StopBit_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopbitSelectIndex = StopBit_comboBox.SelectedIndex;
        }
    }
}
