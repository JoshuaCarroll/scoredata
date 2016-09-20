using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace csharp_forms
{
    public partial class Form1 : Form
    {
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
    }
}
