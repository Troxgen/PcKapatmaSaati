using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troxgen_Bilgisayar_Kapatma
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public static string KullaniciAdiK { get; set; }
        public void OpenForm(Type formType)
        {
            Form form = (Form)Activator.CreateInstance(formType);
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PortSecmeEkrani pse = new PortSecmeEkrani();
            pse.ShowDialog();
            panel1.Controls.Clear();
            PcKapatma form1 = new PcKapatma();
            form1.TopLevel = false;
            panel1.Controls.Add(form1);
            form1.BringToFront();
            form1.Show();
            form1.FormClosed += new FormClosedEventHandler(Form2_FormClosed);


        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form2 kapandı!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PortSecmeEkrani pse = new PortSecmeEkrani();
            pse.ShowDialog();
            panel1.Controls.Clear();
            PcKapatma form1 = new PcKapatma();
            form1.TopLevel = false;
            panel1.Controls.Add(form1);
            form1.BringToFront();
            form1.Show();
            form1.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
        }
    }
}
