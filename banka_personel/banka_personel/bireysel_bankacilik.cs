using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_personel
{
    public partial class bireysel : Form
    {
        public bireysel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bireysel_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kredikart_musteri kredikart_musteri_form = new kredikart_musteri();
            kredikart_musteri_form.label6.Text = label3.Text;
            kredikart_musteri_form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kredi_musteri kredi_musteri_form = new kredi_musteri();
            kredi_musteri_form.label6.Text = label3.Text;
            kredi_musteri_form.Show();
            this.Hide();
        }
    }
}
