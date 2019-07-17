using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace banka_personel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("server=.; Initial Catalog=banka_personel;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("Select * From personel where personel.pid='" + uye_numarasi.Text + "'", con);
            con.Open();
            SqlDataReader cikti = cmd.ExecuteReader();

            
  
            if (cikti.Read())
            {
                if (cikti["psifre"].ToString() == uye_sifre.Text)
                {

                    if (cikti["punvani"].ToString() == "Manager")
                    {
                        yonetici yonetici_form = new yonetici();
                        yonetici_form.Show();
                        yonetici_form.yonetici_adi.Text = cikti["pisim"].ToString();
                        yonetici_form.yonetici_soyadi.Text = cikti["psoyisim"].ToString();
                        this.Visible = false;

                    }
                    else if (cikti["punvani"].ToString() == "Bireysel")
                    {
                        bireysel bireysel_form = new bireysel();
                        bireysel_form.label3.Text = uye_numarasi.Text;
                        bireysel_form.Show();
                        bireysel_form.bireysel_bankaci_adi.Text = cikti["pisim"].ToString();
                        bireysel_form.bireysel_bankaci_soyadi.Text = cikti["psoyisim"].ToString();

                        this.Visible = false;
                    }
                    else if (cikti["punvani"].ToString() == "Kobi")
                    {
                        kobi_bankacilik kobi_form = new kobi_bankacilik();
                        kobi_form.Show();
                        kobi_form.kobi_bankaci_adi.Text= cikti["pisim"].ToString();
                        kobi_form.kobi_bankaci_soyadi.Text = cikti["psoyisim"].ToString();
                        this.Visible = false;
                    }
                    else if (cikti["punvani"].ToString() == "Vezne")
                    {
                        Vezne vezne_form = new Vezne();
                        vezne_form.Show();
                        vezne_form.vezne_bankaci_adi.Text = cikti["pisim"].ToString();
                        vezne_form.vezne_bankaci_soyadi.Text = cikti["psoyisim"].ToString();

                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Personelin Unvanı Belli Olmadığından Giriş Yapılamadı");
                    }

                }
                else
                {

                    MessageBox.Show("Şifreyi yanlış girdiniz!");
                }


            }
            else
            {

                MessageBox.Show("Böyle kayıt bulanamaktadır!");
            }
            con.Close();
            
        }

        private void uye_numarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
