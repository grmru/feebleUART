using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feebleUART
{
    public partial class mainFrm : Form
    {
        private SerialPort _selectedPort;

        private System.Threading.Thread _read_thread;

        public mainFrm()
        {
            InitializeComponent();

            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            this.comboBox_ports.Items.AddRange(ports);

            this.comboBox_parityBit.SelectionStart = 0;
            this.comboBox_parityBit.SelectionLength = 0;

            this.comboBox_stopBits.SelectionStart = 0;
            this.comboBox_stopBits.SelectionLength = 0;

            this.comboBox_handshake.SelectionStart = 0;
            this.comboBox_handshake.SelectionLength = 0;

            //this._read_thread = new System.Threading.Thread();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            string portName = this.comboBox_ports.Text;
            int baudRate = 9600;
            int dataBits = 8;

            if (portName.Trim() == string.Empty)
            {
                MessageBox.Show("Port name shouldn't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.textBox_baudRate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Baud rate shouldn't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int.TryParse(this.textBox_baudRate.Text, out baudRate);
            this.textBox_baudRate.Text = "" + baudRate;

            if (this.comboBox_parityBit.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Parity bit shouldn't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Parity parity = Parity.None;

            if (this.comboBox_parityBit.Text.Trim().ToLower().StartsWith("None".ToLower())) { parity = Parity.None; }
            if (this.comboBox_parityBit.Text.Trim().ToLower().StartsWith("Odd".ToLower())) { parity = Parity.Odd; }
            if (this.comboBox_parityBit.Text.Trim().ToLower().StartsWith("Even".ToLower())) { parity = Parity.Even; }
            if (this.comboBox_parityBit.Text.Trim().ToLower().StartsWith("Mark".ToLower())) { parity = Parity.Mark; }
            if (this.comboBox_parityBit.Text.Trim().ToLower().StartsWith("Space".ToLower())) { parity = Parity.Space; }

            if (this.textBox_dataBits.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Data bits shouldn't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int.TryParse(this.textBox_dataBits.Text, out dataBits);
            this.textBox_dataBits.Text = "" + dataBits;

            if (this.comboBox_stopBits.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Stop bits shouldn't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StopBits stopBits = StopBits.One;

            if (this.comboBox_stopBits.Text.Trim().ToLower().StartsWith("One".ToLower())) { stopBits = StopBits.One; }
            if (this.comboBox_stopBits.Text.Trim().ToLower().StartsWith("Two".ToLower())) { stopBits = StopBits.Two; }
            if (this.comboBox_stopBits.Text.Trim().ToLower().StartsWith("OnePointFive".ToLower())) { stopBits = StopBits.OnePointFive; }

            if (this.comboBox_handshake.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Handshake shouldn't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Handshake handshake = Handshake.None;

            if (this.comboBox_handshake.Text.Trim().ToLower().StartsWith("None".ToLower())) { handshake = Handshake.None; }
            if (this.comboBox_handshake.Text.Trim().ToLower().StartsWith("XOnXOff".ToLower())) { handshake = Handshake.XOnXOff; }
            if (this.comboBox_handshake.Text.Trim().ToLower().StartsWith("RequestToSend".ToLower())) { handshake = Handshake.RequestToSend; }
            if (this.comboBox_handshake.Text.Trim().ToLower().StartsWith("RequestToSendXOnXOff".ToLower())) { handshake = Handshake.RequestToSendXOnXOff; }

            if (this._selectedPort == null || (this._selectedPort != null && this._selectedPort.IsOpen == false))
            {
                try
                {
                    this._selectedPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);
                    this._selectedPort.Handshake = handshake;
                    this._selectedPort.RtsEnable = this.checkBox_RtsEnable.Checked;
                    this._selectedPort.DtrEnable = this.checkBox_DtrEnable.Checked;
                    this._selectedPort.DataReceived += _selectedPort_DataReceived;

                    this._selectedPort.Open();
                    this.button_open.Text = "Close";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    this._selectedPort.Close();
                    this.button_open.Text = "Open";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void readingLogic()
        {

        }

        private void _selectedPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sender is SerialPort)
            {
                SerialPort curPort = (SerialPort)sender;

                string str = string.Empty;

                try
                {
                    str = curPort.ReadLine();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (this.checkBox_insertNewLine.Checked && this.textBox_recevied.Text != string.Empty)
                {
                    this.textBox_recevied.Text += System.Environment.NewLine;
                }

                if (this.checkBox_insertTimeStamp.Checked)
                {
                    this.textBox_recevied.Text += string.Format("[{0:yyMMdd - HH:mm:ss.fffff}]: ", DateTime.Now);
                }

                this.textBox_recevied.Text += str;
            }

        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (this._selectedPort == null)
            {
                MessageBox.Show("Serial port is not initialized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (this._selectedPort.IsOpen)
            {
                try
                {
                    this._selectedPort.Write(this.textBox_sending.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Serial port is closed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
