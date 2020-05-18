using System;
using System.Windows.Forms;
using System.IO.Ports;
using BqBusNet;

namespace Tester
{
    public partial class Form1 : Form
    {
        SerialPort serial = new SerialPort();
        BqBus arduino = new BqBus();

        public Form1()
        {
            InitializeComponent();
            serial.PortName = "COM7";
            arduino.Serial = serial;
            arduino.Size = 1;
        }

        private void BtConnect_Click(object sender, EventArgs e)
        {
            var bt = (Button)sender;
            if (arduino.IsConnected)
            {
                arduino.Disconnect();
                bt.Text = "Connect";
            }
            else
            {
                arduino.Connect();
                bt.Text = "Disconnect";
            }
        }

        private void CbLed_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            int value = cb.Checked ? 1 : 0;
            arduino.SetReg(0, value);
        }
    }
}