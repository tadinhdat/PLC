using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Plc plc;
        
        void ConnectToPLC()
        {
            if (plc == null)
            {
                plc = new Plc(CpuType.S71200, "192.168.1.200", 0, 1);
                MessageBox.Show("t la null ne");
                plc.Open();
            }
            if (plc.IsConnected)
            {
                MessageBox.Show("haha, may da connecterd");
            }
            else
            {
                MessageBox.Show("may chua connected dk nha");
            }
        }



        private void button_Check_Click(object sender, EventArgs e)
        {
            ConnectToPLC();
        }

        private void buttonWrite01_Click(object sender, EventArgs e)
        {

        }
    }
}
