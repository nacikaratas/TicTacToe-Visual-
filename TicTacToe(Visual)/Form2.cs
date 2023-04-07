using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Visual_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string oyuncuAdi1, oyuncuAdi2;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (txtOyuncu1.Text == "" || txtOyuncu2.Text == "")
            {
                MessageBox.Show("Lütfen oyuncu isimlerini giriniz.", "UYARI!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                oyuncuAdi1 = txtOyuncu1.Text;
                oyuncuAdi2 = txtOyuncu2.Text;
                
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();

            }
        }

    }
}
