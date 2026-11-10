namespace sporsalonuotomasyonu
{
    partial class frmgiriş_cıkıs
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
            this.txtUyeId = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.btngeri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUyeId
            // 
            this.txtUyeId.Location = new System.Drawing.Point(187, 327);
            this.txtUyeId.Name = "txtUyeId";
            this.txtUyeId.Size = new System.Drawing.Size(478, 20);
            this.txtUyeId.TabIndex = 0;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGirisYap.Location = new System.Drawing.Point(187, 353);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(118, 90);
            this.btnGirisYap.TabIndex = 1;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisYap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCikisYap.Location = new System.Drawing.Point(311, 353);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(118, 90);
            this.btnCikisYap.TabIndex = 1;
            this.btnCikisYap.Text = "ÇIKIŞ YAP";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYenile.Location = new System.Drawing.Point(435, 353);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(109, 90);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click_1);
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(12, 12);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.Size = new System.Drawing.Size(813, 312);
            this.dgvListe.TabIndex = 2;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.SystemColors.Desktop;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngeri.Location = new System.Drawing.Point(550, 353);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(115, 90);
            this.btngeri.TabIndex = 1;
            this.btngeri.Text = "GERİ ÇIKIŞ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 111);
            this.button1.TabIndex = 3;
            this.button1.Text = "ANA SAYFAYA DÖNÜŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmgiriş_cıkıs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sporsalonuotomasyonu.Properties.Resources.Gemini_Generated_Image_bmqtkqbmqtkqbmqt;
            this.ClientSize = new System.Drawing.Size(837, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtUyeId);
            this.Name = "frmgiriş_cıkıs";
            this.Text = "frmgiriş_cıkıs";
            this.Load += new System.EventHandler(this.frmgiriş_cıkıs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUyeId;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button button1;
    }
}