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
    public partial class kredikart_musteri : Form
    {
        public kredikart_musteri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            basvuru_paneli.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("server=.; Initial Catalog=banka_personel;Integrated Security=SSPI");
            con.Open();

          
                string musteri_kayit = "INSERT INTO musteriler (musteri_tc,musteri_adi,musteri_soyadi) VALUES (@musteri_tc,@musteri_adi,@musteri_soyadi)";
                string kredi_kayit = "INSERT INTO kredi_karti (ktur,kmiktari,musteri_tc,pid,tarih) VALUES (@ktur,@kmiktari,@musteri,@pid,@tarih)";
               
                
                SqlCommand musteri_komut = new SqlCommand(musteri_kayit, con);
                SqlCommand kredikart_komut = new SqlCommand(kredi_kayit, con);
             
                musteri_komut.Parameters.AddWithValue("@musteri_tc", textBox1.Text);
                musteri_komut.Parameters.AddWithValue("@musteri_adi", textBox5.Text);
                musteri_komut.Parameters.AddWithValue("@musteri_soyadi", textBox4.Text);

                kredikart_komut.Parameters.AddWithValue("@kmiktari", textBox3.Text);
                kredikart_komut.Parameters.AddWithValue("@ktur", comboBox1.Text );
                kredikart_komut.Parameters.AddWithValue("@musteri", textBox1.Text);
                kredikart_komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

       

                kredikart_komut.Parameters.AddWithValue("@pid", label6.Text );
                
              
                musteri_komut.ExecuteNonQuery();
               kredikart_komut.ExecuteNonQuery();
                
               
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                con.Close();

                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");

        }

        private void kredikart_musteri_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
           
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
 
            SqlConnection con;
            con = new SqlConnection("server=.; Initial Catalog=banka_personel;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("Select * From musteriler,kredi_karti where musteriler.musteri_tc='" + textBox2.Text + "'", con);
            con.Open();
            SqlDataReader cikti = cmd.ExecuteReader();
            
            if (cikti.Read())
            {
                comboBox2.Items.Add(cikti["kid"].ToString());
                textBox6.Text = cikti["kmiktari"].ToString();
                con.Close();
            }
            else
            {
                MessageBox.Show("Kredi Kartı Bulunmamaktadır.");
                con.Close();
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("server=.; Initial Catalog=banka_personel;Integrated Security=SSPI");
            con.Open();
            string yeni_kayit = "update kredi_karti set kmiktari=@kmiktari , tarih=@tarih where kid=" + comboBox2.Text + "";
            SqlCommand komut = new SqlCommand(yeni_kayit, con);

            komut.Parameters.AddWithValue("@kmiktari", textBox7.Text);
            komut.Parameters.AddWithValue("@kmiktari", dateTimePicker1.Text);

            komut.ExecuteNonQuery();
            con.Close();
        }
    }
}
