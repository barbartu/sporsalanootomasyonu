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
    public partial class frmurunsatıs : Form
    {
        public frmurunsatıs()
        {
            InitializeComponent();
        }

        // DÜZELTİLDİ: Bağlantı cümlesi doğru formata getirildi ve veritabanı adı eklendi
SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=UCFITNESS;Integrated Security=True");
        private void frmurunsatıs_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Urunler", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvListe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAd.Text) || string.IsNullOrWhiteSpace(txtFiyat.Text))
            {
                MessageBox.Show("Lütfen ürün adı ve fiyat alanlarını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Urunler (UrunAd, Fiyat, Stok) VALUES (@p1, @p2, @p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut.Parameters.AddWithValue("@p2", Convert.ToDecimal(txtFiyat.Text));
                komut.Parameters.AddWithValue("@p3", Convert.ToInt32(txtStok.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Ekleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunId.Text))
            {
                MessageBox.Show("Lütfen silinecek ürünü tablodan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Urunler WHERE UrunId=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtUrunId.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün sistemden silindi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunId.Text))
            {
                MessageBox.Show("Lütfen güncellenecek ürünü tablodan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Tbl_Urunler SET UrunAd=@p1, Fiyat=@p2, Stok=@p3 WHERE UrunId=@p4", baglanti);
                komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut.Parameters.AddWithValue("@p2", Convert.ToDecimal(txtFiyat.Text));
                komut.Parameters.AddWithValue("@p3", Convert.ToInt32(txtStok.Text));
                komut.Parameters.AddWithValue("@p4", txtUrunId.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün bilgileri ve stok güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DÜZELTİLDİ: Güvenli hücre seçimi (çökme önlendi)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListe.Rows[e.RowIndex];
                txtUrunId.Text = row.Cells[0].Value?.ToString() ?? "";
                txtUrunAd.Text = row.Cells[1].Value?.ToString() ?? "";
                txtFiyat.Text = row.Cells[2].Value?.ToString() ?? "";
                txtStok.Text = row.Cells[3].Value?.ToString() ?? "";
            }
        }

        void Temizle()
        {
            txtUrunId.Text = "";
            txtUrunAd.Text = "";
            txtFiyat.Text = "";
            txtStok.Text = "";
            txtUrunAd.Focus();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // SqlDataAdapter bağlantıyı otomatik yönettiği için ekstra Open/Close yapmaya gerek yok
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Urunler WHERE UrunAd LIKE '%" + txtUrunAra.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvListe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmanasayfa ana = new frmanasayfa();
            ana.Show();
            this.Hide();
        }
    }
}