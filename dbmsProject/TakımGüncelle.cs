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
    public partial class TakımGüncelle : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HpGaming\\SQLEXPRESS;Initial Catalog=SportsDatabase;Integrated Security=True");
        public TakımGüncelle()
        {
            InitializeComponent();
        }

        private void TakımGüncelle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select takım_id as 'Takım ID', takım_adı as 'Takım Adı',takım_ülke as 'Bulunduğu Ülke',takım_bütce as 'Takımın Bütçesi',takım_stad as 'Takımın Stadı' from takımlar"; ;
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void TakımGüncellebtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update takımlar set takım_adı=@takım_adı," +
                "takım_ülke=@takım_ülke,takım_bütce=@takım_bütce,takım_stad=@takım_stad where takım_id=@takım_id", baglantı);
            int secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@takım_id", secilenid);
            komut.Parameters.AddWithValue("@takım_adı", TakımAdgüncelletxt.Text);
            komut.Parameters.AddWithValue("@takım_ülke", Takımülkegüncelletxt.Text);
            komut.Parameters.AddWithValue("@takım_bütce", Takımbütcegüncelletxt.Text);
            komut.Parameters.AddWithValue("@takım_stad", Takımstadgüncelletxt.Text);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.CommandText = "Select takım_id as 'Takım ID',takım_adı as 'Takım Adı',takım_ülke as 'Bulunduğu Ülke',takım_bütce as 'Takımın Bütçesi',takım_stad as 'Takımın Stadı'from takımlar ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
