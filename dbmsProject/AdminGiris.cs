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
            string gelenAd = Kullan�c�Ad�.Text;
            string gelenSifre = Kullan�c�Sifre.Text;
            if (gelenAd == ("Admin") && gelenSifre == "123")
            {
                MessageBox.Show("Giri� Ba�ar�l�");
                IslemPaneli islempanel = new IslemPaneli();
                islempanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�");
            }
        }

        private void Kullan�c�Ad�_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}