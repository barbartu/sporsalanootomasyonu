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

namespace sporsalonuotomasyonu
{
    public partial class frmraporlaveistatislik : Form
    {
        public frmraporlaveistatislik()
        {
            InitializeComponent();
        }
        
SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=UCFITNESS;Integrated Security=True");
        private void frmraporlaveistatislik_Load(object sender, EventArgs e)
        {
            IstatistikleriGetir();
        }
        void IstatistikleriGetir()
        {
            try
            {
                baglanti.Open();

             
                SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Uyeler", baglanti);
                SqlDataReader dr1 = komut1.ExecuteReader();
                if (dr1.Read())
                {
                    lblToplamUye.Text = dr1[0].ToString();
                }
                dr1.Close();

             
                SqlCommand komut2 = new SqlCommand("SELECT SUM(Stok) FROM Tbl_Urunler", baglanti);
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                  
                    lblKritikStok.Text = dr2[0] != DBNull.Value ? dr2[0].ToString() : "0";
                }
                dr2.Close();

                
                SqlCommand komut3 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Paketler", baglanti);
                SqlDataReader dr3 = komut3.ExecuteReader();
                if (dr3.Read())
                {
                    
                }
                dr3.Close();

                baglanti.Close();
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("İstatistikler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            IstatistikleriGetir();
            MessageBox.Show("İstatistikler başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmanasayfa ana = new frmanasayfa();
            ana.Show();
            this.Hide();
        }
    }
}
