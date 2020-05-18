using System;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort serial = new System.IO.Ports.SerialPort();
        BqBusNet.BqBus arduino = new BqBusNet.BqBus();

        public Form1()
        {
            InitializeComponent();
            serial.PortName = "COM7";
            arduino.Serial = serial;
            arduino.Size = 1;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void cbLed_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            int value = cb.Checked ? 1 : 0;
            arduino.SetReg(0, value);
        }
    }
}