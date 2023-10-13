using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_11_10_2023_ornek_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tus;

            tus = MessageBox.Show("Programdan Çıkmak İstiyor Musunuz?",
                "Örnek-01",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (tus == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Program Devam Ediyor!", "Örnek-01");
            }
        }
    }
}
