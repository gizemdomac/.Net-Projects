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
    public partial class kredi_musteri : Form
    {
        public kredi_musteri()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("server=.; Initial Catalog=banka_personel;Integrated Security=SSPI");
            con.Open();


            string musteri_kayit = "INSERT INTO musteriler (musteri_tc,musteri_adi,musteri_soyadi) VALUES (@musteri_tc,@musteri_adi,@musteri_soyadi)";
            string kredi_kayit = "INSERT INTO kredi (kredi_tur,kredi_miktari,musteri_tc,pid,tarih) VALUES (@ktur,@kmiktari,@musteri,@pid,@tarih)";


            SqlCommand musteri_komut = new SqlCommand(musteri_kayit, con);
            SqlCommand kredi_komut = new SqlCommand(kredi_kayit, con);

            musteri_komut.Parameters.AddWithValue("@musteri_tc", textBox1.Text);
            musteri_komut.Parameters.AddWithValue("@musteri_adi", textBox5.Text);
            musteri_komut.Parameters.AddWithValue("@musteri_soyadi", textBox4.Text);

            kredi_komut.Parameters.AddWithValue("@kmiktari", textBox3.Text);
            kredi_komut.Parameters.AddWithValue("@ktur", comboBox1.Text);
            kredi_komut.Parameters.AddWithValue("@musteri", textBox1.Text);
            kredi_komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);



            kredi_komut.Parameters.AddWithValue("@pid", label6.Text);


            musteri_komut.ExecuteNonQuery();
            kredi_komut.ExecuteNonQuery();


            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            con.Close();

            MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            basvuru_paneli.Visible = true;
        }
    }
}
