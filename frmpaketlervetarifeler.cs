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
    public partial class frmpaketlervetarifeler : Form
    {
        // DÜZELTİLDİ: Sunucu adı doğru formata getirildi ve Initial Catalog=UCFITNESS eklendi
SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=UCFITNESS;Integrated Security=True");
        void Listele()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Paketler", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvListe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmpaketlervetarifeler()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmpaketlervetarifeler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaketAd.Text) || string.IsNullOrWhiteSpace(txtFiyat.Text))
            {
                MessageBox.Show("Lütfen paket adı ve fiyat alanlarını boş bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Paketler (PaketAd, SureAy, Fiyat) VALUES (@p1, @p2, @p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPaketAd.Text);
                komut.Parameters.AddWithValue("@p2", Convert.ToInt32(txtSure.Text));
                komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(txtFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Yeni paket başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrWhiteSpace(txtPaketId.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz paketi tablodan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Paketler WHERE PaketId=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPaketId.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Paket sistemden silindi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (string.IsNullOrWhiteSpace(txtPaketId.Text))
            {
                MessageBox.Show("Lütfen güncellenecek paketi tablodan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Tbl_Paketler SET PaketAd=@p1, SureAy=@p2, Fiyat=@p3 WHERE PaketId=@p4", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPaketAd.Text);
                komut.Parameters.AddWithValue("@p2", Convert.ToInt32(txtSure.Text));
                komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(txtFiyat.Text));
                komut.Parameters.AddWithValue("@p4", txtPaketId.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Paket bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Çökme yaşanmaması için satır indeksi kontrolü eklendi
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListe.Rows[e.RowIndex];
                txtPaketId.Text = row.Cells[0].Value?.ToString() ?? "";
                txtPaketAd.Text = row.Cells[1].Value?.ToString() ?? "";
                txtSure.Text = row.Cells[2].Value?.ToString() ?? "";
                txtFiyat.Text = row.Cells[3].Value?.ToString() ?? "";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            txtPaketId.Text = "";
            txtPaketAd.Text = "";
            txtSure.Text = "";
            txtFiyat.Text = "";
            txtPaketAd.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmanasayfa ana = new frmanasayfa();
            ana.Show();
            this.Hide();
        }
    }
}