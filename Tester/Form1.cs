using System;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
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
