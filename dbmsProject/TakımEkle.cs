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
    public partial class TakımEkle : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HpGaming\\SQLEXPRESS;Initial Catalog=SportsDatabase;Integrated Security=True");
        public TakımEkle()
        {
            InitializeComponent();
        }


        private void takımkayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into takımlar(takım_adı,takım_ülke,takım_bütce,takım_stad)" +
                "values (@takım_adı,@takım_ülke,@takım_bütce,@takım_stad)", baglantı);
            komut.Parameters.AddWithValue("@takım_adı", Takımadtxt.Text);
            komut.Parameters.AddWithValue("@takım_ülke", Takımülketxt.Text);
            komut.Parameters.AddWithValue("@takım_bütce", Transferbütcetxt.Text);
            komut.Parameters.AddWithValue("@takım_stad", takımstadıtxt.Text);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.CommandText = "Select takım_id as 'Takım ID',takım_adı as 'Takım Adı',takım_ülke as 'Bulunduğu Ülke',takım_bütce as 'Takım Bütçesi',takım_stad as 'Takımın Stadı' from takımlar ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void TakımEkle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select takım_id as 'Takım ID',takım_adı as 'Takım Adı',takım_ülke as 'Bulunduğu Ülke',takım_bütce as 'Takım Bütçesi',takım_stad as 'Takımın Stadı' from takımlar ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }


    }
}
