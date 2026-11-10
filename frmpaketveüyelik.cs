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
    public partial class frmpaketveuyelik : Form
    {
        public frmpaketveuyelik()
        {
            InitializeComponent();
        }

        // DÜZELTİLDİ: Sunucu adı ve eksik olan Initial Catalog=UCFITNESS eklendi
SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=UCFITNESS;Integrated Security=True");
        void Listele()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Paketler", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPaketler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmpaketveuyelik_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaketAdi.Text) || string.IsNullOrWhiteSpace(txtFiyat.Text))
            {
                MessageBox.Show("Lütfen Paket Adı ve Fiyat alanlarını boş bırakmayınız!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Paketler (PaketAdi, SureAy, Fiyat, Aciklama) VALUES (@p1, @p2, @p3, @p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPaketAdi.Text);
                komut.Parameters.AddWithValue("@p2", Convert.ToInt32(txtSureAy.Text));
                komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(txtFiyat.Text));
                komut.Parameters.AddWithValue("@p4", txtAciklama.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Paket başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                FormTemizle();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Ekleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            if (dgvPaketler.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtPaketAdi.Text) || string.IsNullOrWhiteSpace(txtFiyat.Text))
                {
                    MessageBox.Show("Paket adı ve fiyat alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow seciliSatir = dgvPaketler.SelectedRows[0];
                string id = seciliSatir.Cells[0].Value.ToString();

                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE Tbl_Paketler SET PaketAdi=@p1, SureAy=@p2, Fiyat=@p3, Aciklama=@p4 WHERE PaketId=@p5", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtPaketAdi.Text);
                    komut.Parameters.AddWithValue("@p2", Convert.ToInt32(txtSureAy.Text));
                    komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(txtFiyat.Text));
                    komut.Parameters.AddWithValue("@p4", txtAciklama.Text);
                    komut.Parameters.AddWithValue("@p5", id);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Paket bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    FormTemizle();
                }
                catch (Exception ex)
                {
                    if (baglanti.State == ConnectionState.Open) baglanti.Close();
                    MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz paketi tablodan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dgvPaketler.SelectedRows.Count > 0)
            {
                DialogResult onay = MessageBox.Show("Seçili paketi silmek istediğinize emin misiniz?", "Paket Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    DataGridViewRow seciliSatir = dgvPaketler.SelectedRows[0];
                    string id = seciliSatir.Cells[0].Value.ToString();

                    try
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Paketler WHERE PaketId=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", id);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Paket sistemden başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        FormTemizle();
                    }
                    catch (Exception ex)
                    {
                        if (baglanti.State == ConnectionState.Open) baglanti.Close();
                        MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz paketi tablodan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void FormTemizle()
        {
            txtPaketAdi.Clear();
            txtSureAy.Clear();
            txtFiyat.Clear();
            txtAciklama.Clear();
            txtPaketAdi.Focus();
        }

        private void txtPaketAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Paketler WHERE PaketAdi LIKE '%" + txtPaketAra.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPaketler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPaketler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPaketler.Rows[e.RowIndex];
                txtPaketAdi.Text = row.Cells[1].Value?.ToString() ?? "";
                txtSureAy.Text = row.Cells[2].Value?.ToString() ?? "";
                txtFiyat.Text = row.Cells[3].Value?.ToString() ?? "";
                txtAciklama.Text = row.Cells[4].Value?.ToString() ?? "";
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