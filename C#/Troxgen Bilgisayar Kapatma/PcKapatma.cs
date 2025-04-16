using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Troxgen_Bilgisayar_Kapatma
{
    public partial class PcKapatma : Form
    {
        public PcKapatma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Visible){ button2.Visible = false;}
            else{button2.Visible = true;}

            

            int hours = Convert.ToInt32(comboBox2.SelectedItem);
            if (hours>0)
            {
                serialPort1.Open();
                int delayInSeconds = hours * 3600;
                serialPort1.Write(hours.ToString());
                Process.Start("shutdown", "/s /f /t " + delayInSeconds);
                serialPort1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            Process.Start("shutdown", "/a ");
            serialPort1.Write("E");
            serialPort1.Close();
            button2.Visible = false;
        }

        private void PcKapatma_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                comboBox2.Items.Add(i);
            }
            if (PortSecmeEkrani.PortAdi == null)
            {
                MessageBox.Show("Program Yanlış Başlatılmıştır.");
            }
            serialPort1.PortName = PortSecmeEkrani.PortAdi;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
