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
    public partial class TaraftarSil : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HpGaming\\SQLEXPRESS;Initial Catalog=SportsDatabase;Integrated Security=True");
        public TaraftarSil()
        {
            InitializeComponent();
        }

        private void TaraftarSil_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select taraftarid as 'Taraftar ID',taraftar_isim as 'Taraftar Ad',taraftar_soyisim as 'Taraftar Soyad',taraftar_yas as 'Taraftarın Yaşı',taraftar_takım as 'Taraftarın Takımı',taraftar_telefon as 'Taraftarın Telefonu' from taraftarlar ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void TaraftarSilbtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from taraftarlar where taraftarid=@taraftarid", baglantı);
            int secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@taraftarid", secilenid);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.CommandText = "Select taraftarid as 'Taraftar ID',taraftar_isim as 'Taraftar Ad',taraftar_soyisim as 'Taraftar Soyad',taraftar_yas as 'Taraftarın Yaşı',taraftar_takım as 'Taraftarın Takımı',taraftar_telefon as 'Taraftarın Telefonu' from taraftarlar ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
