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
    public partial class personel_islemleri : Form
    {
        public personel_islemleri()
        {
            InitializeComponent();
        }

        private void personel_islemleri_Load(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("server=.; Initial Catalog=banka_personel;Integrated Security=SSPI");
            con.Open();
            SqlCommand komut = new SqlCommand("Select * From kredi_karti where pid ="+label4.Text+" ", con);
            SqlCommand komut2 = new SqlCommand("Select * From kredi where pid =" + label4.Text + " ", con);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);

            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt2;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            
            SqlConnection con;
            con = new SqlConnection("server=.; Initial Catalog=banka_personel;Integrated Security=SSPI");
            con.Open();
            SqlCommand komut = new SqlCommand("Select * From kredi_karti where pid =" + label4.Text + "AND tarih=" + dateTimePicker1.Text.ToString() + " ", con);
           SqlCommand komut2 = new SqlCommand("Select * From kredi where pid =" + label4.Text + " AND tarih=" + dateTimePicker1.Text.ToString() + " ", con);

            SqlDataAdapter da = new SqlDataAdapter(komut);
           SqlDataAdapter da2 = new SqlDataAdapter(komut2);

            DataTable dt = new DataTable();
            da.Fill(dt);
           DataTable dt2 = new DataTable();
           da2.Fill(dt2);
            
            dataGridView1.DataSource = dt;
           dataGridView2.DataSource = dt2;
           
            con.Close();
        }
    }
}
