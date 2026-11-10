
namespace sporsalonuotomasyonu
{
    partial class eğitimveyönetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEgitmenAdi = new System.Windows.Forms.TextBox();
            this.txtUzmanlik = new System.Windows.Forms.TextBox();
            this.txtEgitmenSoyadi = new System.Windows.Forms.TextBox();
            this.txtEgitmenAra = new System.Windows.Forms.TextBox();
            this.mtxtEgitmenTelefon = new System.Windows.Forms.MaskedTextBox();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnanasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEgitmenAdi
            // 
            this.txtEgitmenAdi.Location = new System.Drawing.Point(244, 116);
            this.txtEgitmenAdi.Name = "txtEgitmenAdi";
            this.txtEgitmenAdi.Size = new System.Drawing.Size(153, 20);
            this.txtEgitmenAdi.TabIndex = 1;
            // 
            // txtUzmanlik
            // 
            this.txtUzmanlik.Location = new System.Drawing.Point(244, 190);
            this.txtUzmanlik.Name = "txtUzmanlik";
            this.txtUzmanlik.Size = new System.Drawing.Size(153, 20);
            this.txtUzmanlik.TabIndex = 2;
            this.txtUzmanlik.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEgitmenSoyadi
            // 
            this.txtEgitmenSoyadi.Location = new System.Drawing.Point(244, 154);
            this.txtEgitmenSoyadi.Name = "txtEgitmenSoyadi";
            this.txtEgitmenSoyadi.Size = new System.Drawing.Size(153, 20);
            this.txtEgitmenSoyadi.TabIndex = 2;
            // 
            // txtEgitmenAra
            // 
            this.txtEgitmenAra.Location = new System.Drawing.Point(574, 309);
            this.txtEgitmenAra.Name = "txtEgitmenAra";
            this.txtEgitmenAra.Size = new System.Drawing.Size(153, 20);
            this.txtEgitmenAra.TabIndex = 2;
            this.txtEgitmenAra.TextChanged += new System.EventHandler(this.txtEgitmenAra_TextChanged);
            // 
            // mtxtEgitmenTelefon
            // 
            this.mtxtEgitmenTelefon.Location = new System.Drawing.Point(244, 222);
            this.mtxtEgitmenTelefon.Name = "mtxtEgitmenTelefon";
            this.mtxtEgitmenTelefon.Size = new System.Drawing.Size(153, 20);
            this.mtxtEgitmenTelefon.TabIndex = 3;
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(420, 90);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.Size = new System.Drawing.Size(438, 208);
            this.dgvListe.TabIndex = 4;
            this.dgvListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "eğitmenin soy adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(104, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "eğitmen adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(133, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "uzmanlık";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "eğitmenin telefon no";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(448, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "eğitmen ara";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEkle.Location = new System.Drawing.Point(44, 395);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(180, 100);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuncelle.Location = new System.Drawing.Point(230, 395);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(180, 100);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSil.Location = new System.Drawing.Point(420, 395);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(180, 100);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTemizle.Location = new System.Drawing.Point(606, 395);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(193, 100);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "TEMİZLEME";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnanasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanasayfa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnanasayfa.Location = new System.Drawing.Point(11, 25);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(162, 65);
            this.btnanasayfa.TabIndex = 8;
            this.btnanasayfa.Text = "ANA SAYFA DÖN";
            this.btnanasayfa.UseVisualStyleBackColor = false;
            this.btnanasayfa.Click += new System.EventHandler(this.btnanasayfa_Click);
            // 
            // eğitimveyönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sporsalonuotomasyonu.Properties.Resources.Gemini_Generated_Image_bmqtkqbmqtkqbmqt;
            this.ClientSize = new System.Drawing.Size(860, 507);
            this.Controls.Add(this.btnanasayfa);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.mtxtEgitmenTelefon);
            this.Controls.Add(this.txtEgitmenAra);
            this.Controls.Add(this.txtEgitmenSoyadi);
            this.Controls.Add(this.txtUzmanlik);
            this.Controls.Add(this.txtEgitmenAdi);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "eğitimveyönetimi";
            this.Text = "eğitimveyönetimi";
            this.Load += new System.EventHandler(this.eğitimveyönetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEgitmenAdi;
        private System.Windows.Forms.TextBox txtUzmanlik;
        private System.Windows.Forms.TextBox txtEgitmenSoyadi;
        private System.Windows.Forms.TextBox txtEgitmenAra;
        private System.Windows.Forms.MaskedTextBox mtxtEgitmenTelefon;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnanasayfa;
    }
}