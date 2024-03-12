using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama12
{
    public partial class Form1 : Form
    {
        ArrayList sehirler = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirler.Text);
            Listele();
        }

        private void Listele()
        {
            listeSehirler.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listeSehirler.Items.Add(sehir);
            }
        }

        private void btnArayaEkle_Click(object sender, EventArgs e)
        {
            int indexNo = listeSehirler.SelectedIndex;
            sehirler.Insert(indexNo, txtSehirler.Text);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int indexNo = listeSehirler.SelectedIndex;
            sehirler[indexNo] = txtSehirler.Text;
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int indexNo =listeSehirler.SelectedIndex;
            sehirler.RemoveAt(indexNo);
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains(txtSehirler.Text))
            {
                lblDurum.Text = "Aranan Değer Bulundu" ;
                listeSehirler.SelectedIndex = sehirler.IndexOf(txtSehirler.Text);
            }
            else
            {
                lblDurum.Text = "Aranan Değer Buluamadı.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sehirler.Reverse();
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Sort();
            Listele();
        }
    }
}
