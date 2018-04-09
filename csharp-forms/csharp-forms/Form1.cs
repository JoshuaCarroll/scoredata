using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using csharp_forms.Properties;

namespace csharp_forms
{
    public partial class Form1 : Form
    {
        private byte[] currentMessage = new byte[0];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadComPorts();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cmbComPort.SelectedText != string.Empty)
            {
                serialPort.PortName = cmbComPort.SelectedText;
                serialPort.Open();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadComPorts();
        }

        private void loadComPorts()
        {
            for (int i = 0; i < cmbComPort.Items.Count; i++)
            {
                cmbComPort.Items.Remove(cmbComPort.Items[0]);
            }

            string[] comPorts;

            try
            {
                comPorts = SerialPort.GetPortNames();

                for (int i = 0; i < comPorts.Length; i++)
                {
                    cmbComPort.Items.Add(comPorts[i]);
                }
            }
            catch (Win32Exception)
            {
                throw;
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            int length = sp.BytesToRead;
            byte[] buffer = new byte[length];

            sp.Read(buffer, 0, length);

            // Add this to the full message buffer
            currentMessage = Combine(currentMessage, buffer);

            // The End-of-Transmission Block (ETB) character is at the end of each message,
            //  and is always the last character in a block (on this scoreboard).
            if (buffer[buffer.Length - 1] == 23)
            {
                Daktronics.AllSport5000.ScoreboardMessageFootball msg = new Daktronics.AllSport5000.ScoreboardMessageFootball(currentMessage);
                currentMessage = new byte[0];

                lblBallOn.Text = msg.BallOnYardLine;
                lblClock.Text = msg.MainClock;
                lblDown.Text = msg.DownOrdinal;
                lblGuestFirstDowns.Text = msg.GuestFirstDowns;
                lblGuestPassing.Text = msg.GuestPassingYards;
                lblGuestRushing.Text = msg.GuestRushingYards;
                lblGuestScore.Text = msg.GuestTeamScore;
                lblGuestTimeOfPoss.Text = "NA";
                lblGuestTimeOutsLeft.Text = msg.GuestTimeOutsLeftTotal;
                lblGuestTotalYards.Text = msg.GuestTotalYards;
                lblHomeFirstDowns.Text = msg.HomeFirstDowns;
                lblHomePassing.Text = msg.HomePassingYards;
                lblHomeRushing.Text = msg.HomeRushingYards;
                lblHomeTimeOfPoss.Text = "NA";
                lblHomeTimeOutsLeft.Text = msg.HomeTimeOutsLeftTotal;
                lblHomeTotalYards.Text = msg.HomeTotalYards;
                lblQuarter.Text = msg.QuarterDescription;
                lblScoreHome.Text = msg.HomeTeamScore;
                lblToGo.Text = msg.ToGoYards;
            }
        }

        private byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }
    }
}
