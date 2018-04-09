using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScoreboardSerialEmulator
{
    public partial class Form1 : Form
    {
        private string[] messages;
        private int messageNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.PortName = txtPortName.Text;
            serialPort.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                int intInterval = 0;

                if (int.TryParse(txtETBPause.Text, out intInterval))
                {
                    timer.Interval = intInterval;
                    messageNumber = 0;
                    messages = txtMessages.Text.Split(new string[] { "\u0017" }, StringSplitOptions.None);
                    timer.Start();

                }
                else
                {
                    MessageBox.Show("Milliseconds to pause after ETB is not an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Serial port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer.Stop();
            serialPort.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (messageNumber < messages.Length)
            {
                serialPort.Write(messages[messageNumber] + "\u0017");
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
