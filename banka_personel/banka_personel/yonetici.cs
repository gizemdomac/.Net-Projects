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
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yonetici_Load(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("server=.; Initial Catalog=banka_personel;Integrated Security=SSPI");
            con.Open();
            SqlCommand komut = new SqlCommand("Select * From personel", con);

            SqlDataAdapter da = new SqlDataAdapter(komut);
           
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            personel_islemleri frm = new personel_islemleri();
            frm.label2.Text = row.Cells[1].Value.ToString();
            frm.label3.Text = row.Cells[2].Value.ToString();
            frm.label4.Text = row.Cells[0].Value.ToString();
            frm.Show();
  
        }
    }
}
