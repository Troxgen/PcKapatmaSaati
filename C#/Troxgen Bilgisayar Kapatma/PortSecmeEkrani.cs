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

namespace Troxgen_Bilgisayar_Kapatma
{
    public partial class PortSecmeEkrani : Form
    {
        public PortSecmeEkrani()
        {
            InitializeComponent();
        }
        public static string PortAdi { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
      
            if (comboBox1.SelectedItem!=null)
            {
                PortAdi = comboBox1.SelectedItem.ToString();
            }
            this.Close();
        }
      
        private void PortSecmeEkrani_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Burada form kapandığında yapılacak işlemler yazılabilir.
        }
        private void PortSecmeEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }
    }
}
