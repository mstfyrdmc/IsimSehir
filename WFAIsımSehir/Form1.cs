using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAIsımSehir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        string[] isimler = new string[15];
        string[] sehirler = new string[15];
        int ad = 0;
        int sehir = 0;

        private void btnAd_Click(object sender, EventArgs e)
        {
            isimler[ad] = txtAd.Text;
            lblAd.Text += txtAd.Text + "\n";
            ad++;
            txtAd.Text = string.Empty;
        }

        private void btnSehir_Click(object sender, EventArgs e)
        {
            sehirler[sehir] = txtSehir.Text;
            lblSehir.Text += txtSehir.Text + "\n";
            sehir++;
            txtSehir.Text = string.Empty;
        }

        private void btnEsle_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(0, ad-1);
            int s = rnd.Next(0, sehir-1);

            MessageBox.Show("Eşleştirme: " + isimler[a] + " " + sehirler[s]);

            isimler[a].Remove(a, a);
            sehirler[s].Remove(s, s);

          //  lblAd.Text = isimler[];
          //  lblSehir.Text = sehirler.ToString();

            

        }
    }
}
