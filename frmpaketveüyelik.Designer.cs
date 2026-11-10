
using System;

namespace sporsalonuotomasyonu
{
    partial class frmpaketveuyelik
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
            this.txtPaketAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtSureAy = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.dgvPaketler = new System.Windows.Forms.DataGridView();
            this.txtPaketAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPaketAdi
            // 
            this.txtPaketAdi.Location = new System.Drawing.Point(244, 198);
            this.txtPaketAdi.Name = "txtPaketAdi";
            this.txtPaketAdi.Size = new System.Drawing.Size(193, 20);
            this.txtPaketAdi.TabIndex = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(244, 282);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(193, 20);
            this.txtAciklama.TabIndex = 1;
            // 
            // txtSureAy
            // 
            this.txtSureAy.Location = new System.Drawing.Point(244, 327);
            this.txtSureAy.Name = "txtSureAy";
            this.txtSureAy.Size = new System.Drawing.Size(193, 20);
            this.txtSureAy.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(244, 238);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(193, 20);
            this.txtFiyat.TabIndex = 3;
            // 
            // dgvPaketler
            // 
            this.dgvPaketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaketler.Location = new System.Drawing.Point(443, 41);
            this.dgvPaketler.Name = "dgvPaketler";
            this.dgvPaketler.Size = new System.Drawing.Size(767, 377);
            this.dgvPaketler.TabIndex = 4;
            // 
            // txtPaketAra
            // 
            this.txtPaketAra.Location = new System.Drawing.Point(442, 433);
            this.txtPaketAra.Name = "txtPaketAra";
            this.txtPaketAra.Size = new System.Drawing.Size(207, 20);
            this.txtPaketAra.TabIndex = 2;
            this.txtPaketAra.TextChanged += new System.EventHandler(this.txtPaketAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "PAKET ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(152, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "FİYAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "PAKET AÇIKLAMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(75, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "SÜRE VE AY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(321, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "ARAMA";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnekle.Location = new System.Drawing.Point(149, 459);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(150, 133);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btngüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btngüncelle.Location = new System.Drawing.Point(319, 459);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(150, 133);
            this.btngüncelle.TabIndex = 10;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsil.Location = new System.Drawing.Point(499, 459);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(150, 133);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(665, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 133);
            this.button4.TabIndex = 10;
            this.button4.Text = "TEMİZLEME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 115);
            this.button1.TabIndex = 11;
            this.button1.Text = "ANA SAYFAYA DÖN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmpaketveuyelik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sporsalonuotomasyonu.Properties.Resources.Gemini_Generated_Image_bmqtkqbmqtkqbmqt;
            this.ClientSize = new System.Drawing.Size(1222, 725);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPaketler);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtPaketAra);
            this.Controls.Add(this.txtSureAy);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPaketAdi);
            this.Name = "frmpaketveuyelik";
            this.Text = "frmpaketveüyelik";
            this.Load += new System.EventHandler(this.btntemizleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btntemizleme_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        private System.Windows.Forms.TextBox txtPaketAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtSureAy;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.DataGridView dgvPaketler;
        private System.Windows.Forms.TextBox txtPaketAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}