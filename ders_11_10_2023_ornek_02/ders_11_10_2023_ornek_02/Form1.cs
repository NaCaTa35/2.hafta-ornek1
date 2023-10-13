using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_11_10_2023_ornek_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;

            // birinci sayının elde edilmesi
            sayi1 = Convert.ToInt32(textBox1.Text);

            // ikinci sayının elde edilmesi
            sayi2 = Convert.ToInt32(textBox2.Text);

            // toplama işleminin gerçekleştirilmesi
            sonuc = sayi1 + sayi2;

            // sonucun yazdırılması
            textBox3.Text = sonuc.ToString();

        }
    }
}
