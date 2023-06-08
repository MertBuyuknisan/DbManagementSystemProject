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
    public partial class OyuncuSil : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HpGaming\\SQLEXPRESS;Initial Catalog=SportsDatabase;Integrated Security=True");
        public OyuncuSil()
        {
            InitializeComponent();
        }

        private void OyuncuSil_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select oyuncu_id as 'Oyuncu ID',oyuncu_ad as 'Oyuncu Adı',oyuncu_soyad as 'Oyuncu Soyadı',oyuncu_degeri as 'Oyuncu Değeri',oyuncu_takım as 'Oyuncunun Takımı',oyuncu_yas as 'Oyuncunun Yaşı' from oyuncular ";

            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void OyuncuSilbtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from oyuncular where oyuncu_id=@oyuncu_id", baglantı);
            int secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@oyuncu_id", secilenid);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.CommandText = "Select oyuncu_id as 'Oyuncu ID',oyuncu_ad as 'Oyuncu Adı',oyuncu_soyad as 'Oyuncu Soyadı',oyuncu_degeri as 'Oyuncu Değeri',oyuncu_takım as 'Oyuncunun Takımı',oyuncu_yas as 'Oyuncunun Yaşı' from oyuncular "; ;
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }
    }
}
