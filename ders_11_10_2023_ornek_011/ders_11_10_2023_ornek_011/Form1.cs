using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_11_10_2023_ornek_011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        

    private void button1_Click(object sender, EventArgs e)
    {
            DialogResult tus;
            tus = MessageBox.Show("Programdan çıkmak istiyor musunuz?",
                "Örnek_01",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (tus == DialogResult.Yes)
            {
                MessageBox.Show("Görüşmek üzere", "Örnek_01");
                Close();
            }
            else
            {
                MessageBox.Show("Program devam ediyor!", "Örnek_01");

            }
        }
        private void BAŞLAT_Click(object sender, EventArgs e)
        {
            DialogResult tus2;
            tus2 = MessageBox.Show("Programa başlamak istiyor musunuz?",
                "Örnek_01",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(tus2== DialogResult.Yes)
            {
                MessageBox.Show("Program başlamatakdır.","Örnek_01");
                MessageBox.Show("İyi Eğlenceler","Örnek_01");
            }
        }
    }
}
