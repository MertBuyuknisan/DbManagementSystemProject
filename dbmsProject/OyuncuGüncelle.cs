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
    public partial class OyuncuGüncelle : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HpGaming\\SQLEXPRESS;Initial Catalog=SportsDatabase;Integrated Security=True");
        public OyuncuGüncelle()
        {
            InitializeComponent();
        }

        private void OyuncuGüncelle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select oyuncu_id as 'Oyuncu ID',oyuncu_ad as 'Oyuncu Adı',oyuncu_soyad as 'Oyuncu Soyadı',oyuncu_degeri as 'Oyuncu Değeri',oyuncu_takım as 'Oyuncunun Takımı',oyuncu_yas as 'Oyuncunun Yaşı' from oyuncular "; ;
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OyuncuGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update oyuncular set oyuncu_ad=@oyuncu_ad," +
                "oyuncu_soyad=@oyuncu_soyad,oyuncu_degeri=@oyuncu_degeri,oyuncu_takım=@oyuncu_takım,oyuncu_yas=@oyuncu_yas where oyuncu_id=@oyuncu_id", baglantı);
            int secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            komut.Parameters.AddWithValue("@oyuncu_id", secilenid);
            komut.Parameters.AddWithValue("@oyuncu_ad", OyuncuAdtxt.Text);
            komut.Parameters.AddWithValue("@oyuncu_soyad", OyuncuSoyadtxt.Text);
            komut.Parameters.AddWithValue("@oyuncu_degeri", OyuncuDegertxt.Text);
            komut.Parameters.AddWithValue("@oyuncu_takım", OyuncuTakımtxt.Text);
            komut.Parameters.AddWithValue("@oyuncu_yas", OyuncuYas.Text);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.CommandText = "Select  oyuncu_id as 'Oyuncu ID',oyuncu_ad as 'Oyuncu Adı',oyuncu_soyad as 'Oyuncu Soyadı',oyuncu_degeri as 'Oyuncu Değeri',oyuncu_takım as 'Oyuncunun Takımı',oyuncu_yas as 'Oyuncunun Yaşı' from oyuncular ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }


    }
}
