using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace dbmsProject
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        private void girisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = KullanýcýAdý.Text;
            string gelenSifre = KullanýcýSifre.Text;
            if (gelenAd == ("Admin") && gelenSifre == "123")
            {
                MessageBox.Show("Giriþ Baþarýlý");
                IslemPaneli islempanel = new IslemPaneli();
                islempanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý");
            }
        }

        private void KullanýcýAdý_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}