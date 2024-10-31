using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt2_ntp2_31Ekim_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<gorevler> gorevListesi = new List<gorevler>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0 && richTextBox1.Text.Length>0)
            {
                string baslik=textBox1.Text;
                string detay=richTextBox1.Text;
                int durum = 0;
                gorevler gorev=new gorevler(baslik,detay,durum);

                gorevListesi.Add(gorev);
                listBox1.Items.Add(gorev.baslik);

                textBox1.Clear();
                richTextBox1.Clear();


            }
            else
            {
                MessageBox.Show("Lütfen bilgi giriniz!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seciliIndex = listBox1.SelectedIndex;
            richTextBox2.Text = gorevListesi[seciliIndex].detay;
            if (gorevListesi[seciliIndex].durum==0)
            {
                label7.Text = "BEKLEMEDE";
                label7.ForeColor=Color.Red;
                radioButton2.Checked = true;
            }
            else if (gorevListesi[seciliIndex].durum == 1)
            {
                label7.Text = "Devam Ediyor";
                label7.ForeColor = Color.Blue;
                radioButton3.Checked = true;
            }
            else { 
                label7.Text = "Tamamlandı";
                label7.ForeColor = Color.Green;
                radioButton1.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gorevListesi[listBox1.SelectedIndex].durum = 2;
            }
            if (radioButton2.Checked)
            {
                gorevListesi[listBox1.SelectedIndex].durum = 0;
            }
            if (radioButton3.Checked)
            {
                gorevListesi[listBox1.SelectedIndex].durum = 1;
            }
}
    }
}
