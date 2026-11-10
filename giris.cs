using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sporsalonuotomasyonu
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void btngiriş_Click(object sender, EventArgs e)
        {
            string girilenIsim = txtisim.Text.Trim();
            string girilenSoyisim = txtsoyisim.Text.Trim();
            string girilenParola = txtporola.Text.Trim();

            if (girilenIsim == "batuhan" && girilenSoyisim.ToLower() == "uçar" && girilenParola == "7474")
            {
                MessageBox.Show("Giriş Başarılı! Hoş geldiniz, Batuhan Uçar.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                frmanasayfa anaSayfa = new frmanasayfa(); 
                anaSayfa.Show(); 
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı bilgi girdiniz! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
