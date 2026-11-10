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
    public partial class eğitimveyönetimi : Form
    {
        public eğitimveyönetimi()
        {
            InitializeComponent();
        }
SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=UCFITNESS;Integrated Security=True");        
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Egitmenler", baglanti);
            DataTable dt = new DataTable();
            int v = da.Fill(dt);

            dgvListe.DataSource = dt;
        }

        private void eğitimveyönetimi_Load(object sender, EventArgs e)
        {
            Listele(); 
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEgitmenAdi.Text) || string.IsNullOrWhiteSpace(txtEgitmenSoyadi.Text))
            {
                MessageBox.Show("Lütfen Eğitmen Adı ve Soyadı alanlarını boş bırakmayınız!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Egitmenler (Ad, Soyad, Telefon, Uzmanlik) VALUES (@p1, @p2, @p3, @p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtEgitmenAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtEgitmenSoyadi.Text);
            komut.Parameters.AddWithValue("@p3", mtxtEgitmenTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtUzmanlik.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Eğitmen başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            FormTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvListe.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtEgitmenAdi.Text) || string.IsNullOrWhiteSpace(txtEgitmenSoyadi.Text))
                {
                    MessageBox.Show("Ad ve Soyad alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow seciliSatir = dgvListe.SelectedRows[0];
                string id = seciliSatir.Cells[0].Value.ToString();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Tbl_Egitmenler SET Ad=@p1, Soyad=@p2, Telefon=@p3, Uzmanlik=@p4 WHERE EgitmenId=@p5", baglanti);
                komut.Parameters.AddWithValue("@p1", txtEgitmenAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtEgitmenSoyadi.Text);
                komut.Parameters.AddWithValue("@p3", mtxtEgitmenTelefon.Text);
                komut.Parameters.AddWithValue("@p4", txtUzmanlik.Text);
                komut.Parameters.AddWithValue("@p5", id);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Eğitmen bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                FormTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz eğitmeni tablodan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvListe.SelectedRows.Count > 0)
            {
                DialogResult onay = MessageBox.Show("Seçili eğitmeni silmek istediğinize emin misiniz?", "Eğitmen Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    DataGridViewRow seciliSatir = dgvListe.SelectedRows[0];
                    string id = seciliSatir.Cells[0].Value.ToString();

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Egitmenler WHERE EgitmenId=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Eğitmen sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    FormTemizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz eğitmeni tablodan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void FormTemizle()
        {
            txtEgitmenAdi.Clear();
            txtEgitmenSoyadi.Clear();
            mtxtEgitmenTelefon.Clear();
            txtUzmanlik.Clear();
            txtEgitmenAra.Clear();
            dgvListe.ClearSelection();
        }

        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListe.Rows[e.RowIndex];
                txtEgitmenAdi.Text = row.Cells[1].Value?.ToString() ?? "";
                txtEgitmenSoyadi.Text = row.Cells[2].Value?.ToString() ?? "";
                mtxtEgitmenTelefon.Text = row.Cells[3].Value?.ToString() ?? "";
                txtUzmanlik.Text = row.Cells[4].Value?.ToString() ?? "";
            }
        }

        private void txtEgitmenAra_TextChanged(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Egitmenler WHERE Ad LIKE '%" + txtEgitmenAra.Text + "%' OR Soyad LIKE '%" + txtEgitmenAra.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvListe.DataSource = dt;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            frmanasayfa ana = new frmanasayfa();
            ana.Show();
            this.Hide();
        }
    }
}

