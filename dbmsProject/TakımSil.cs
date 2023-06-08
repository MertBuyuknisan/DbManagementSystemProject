using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbmsProject
{
    public partial class TakımSil : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HpGaming\\SQLEXPRESS;Initial Catalog=SportsDatabase;Integrated Security=True");
        public TakımSil()
        {
            InitializeComponent();
        }

        private void TakımSil_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select takım_id as 'Takım ID',takım_adı as 'Takım Adı',takım_ülke as 'Bulunduğu Ülke',takım_bütce as 'Takım Bütçesi',takım_stad as 'Takımın Stadı' from takımlar ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void TakımSilbtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from takımlar where takım_id=@takım_id", baglantı);
            int secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@takım_id", secilenid);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.CommandText = "Select takım_id as 'Takım ID',takım_adı as 'Takım Adı',takım_ülke as 'Bulunduğu Ülke',takım_bütce as 'Takımın Bütçesi',takım_stad as 'Takımın Stadı'from takımlar";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
