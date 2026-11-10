
using System;

namespace sporsalonuotomasyonu
{
    partial class frmüyeyönetim
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
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtara = new System.Windows.Forms.TextBox();
            this.comboüyelik = new System.Windows.Forms.ComboBox();
            this.combocinsiyet = new System.Windows.Forms.ComboBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.dtpkayıttarihi = new System.Windows.Forms.DateTimePicker();
            this.dgvuyeler = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.İSİM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet_Click = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(240, 102);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(201, 20);
            this.txtisim.TabIndex = 0;
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(755, 365);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(176, 20);
            this.txtara.TabIndex = 2;
            this.txtara.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboüyelik
            // 
            this.comboüyelik.FormattingEnabled = true;
            this.comboüyelik.Location = new System.Drawing.Point(240, 272);
            this.comboüyelik.Name = "comboüyelik";
            this.comboüyelik.Size = new System.Drawing.Size(201, 21);
            this.comboüyelik.TabIndex = 4;
            // 
            // combocinsiyet
            // 
            this.combocinsiyet.FormattingEnabled = true;
            this.combocinsiyet.Location = new System.Drawing.Point(240, 233);
            this.combocinsiyet.Name = "combocinsiyet";
            this.combocinsiyet.Size = new System.Drawing.Size(201, 21);
            this.combocinsiyet.TabIndex = 5;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(240, 153);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(201, 20);
            this.txtsoyisim.TabIndex = 0;
            // 
            // dtpkayıttarihi
            // 
            this.dtpkayıttarihi.Location = new System.Drawing.Point(240, 336);
            this.dtpkayıttarihi.Name = "dtpkayıttarihi";
            this.dtpkayıttarihi.Size = new System.Drawing.Size(201, 20);
            this.dtpkayıttarihi.TabIndex = 6;
            // 
            // dgvuyeler
            // 
            this.dgvuyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuyeler.Location = new System.Drawing.Point(476, 32);
            this.dgvuyeler.Name = "dgvuyeler";
            this.dgvuyeler.Size = new System.Drawing.Size(753, 324);
            this.dgvuyeler.TabIndex = 7;
            this.dgvuyeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvüyeler_CellContentClick);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnekle.Location = new System.Drawing.Point(361, 515);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(161, 62);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsil.Location = new System.Drawing.Point(545, 515);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(156, 62);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btngüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngüncelle.Location = new System.Drawing.Point(721, 515);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(157, 62);
            this.btngüncelle.TabIndex = 10;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btntemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntemizle.Location = new System.Drawing.Point(896, 515);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(152, 62);
            this.btntemizle.TabIndex = 11;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(240, 194);
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(201, 20);
            this.mtxtTelefon.TabIndex = 13;
            // 
            // İSİM
            // 
            this.İSİM.AutoSize = true;
            this.İSİM.BackColor = System.Drawing.SystemColors.ControlText;
            this.İSİM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İSİM.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.İSİM.Location = new System.Drawing.Point(160, 102);
            this.İSİM.Name = "İSİM";
            this.İSİM.Size = new System.Drawing.Size(74, 31);
            this.İSİM.TabIndex = 14;
            this.İSİM.Text = "İSİM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(84, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "SOY  İSİM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(87, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "TELEFON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(85, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "CİNSİYET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(117, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "ÜYELİK";
            // 
            // btnKaydet_Click
            // 
            this.btnKaydet_Click.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnKaydet_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet_Click.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKaydet_Click.Location = new System.Drawing.Point(166, 515);
            this.btnKaydet_Click.Name = "btnKaydet_Click";
            this.btnKaydet_Click.Size = new System.Drawing.Size(166, 62);
            this.btnKaydet_Click.TabIndex = 19;
            this.btnKaydet_Click.Text = "KAYDET";
            this.btnKaydet_Click.UseVisualStyleBackColor = false;
            this.btnKaydet_Click.Click += new System.EventHandler(this.btnKaydet_Click_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(7, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 54);
            this.button1.TabIndex = 20;
            this.button1.Text = "ANA SAYFA GERİ DÖNÜŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(637, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "ÜYE ARA";
            // 
            // frmüyeyönetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sporsalonuotomasyonu.Properties.Resources.Gemini_Generated_Image_bmqtkqbmqtkqbmqt;
            this.ClientSize = new System.Drawing.Size(1241, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKaydet_Click);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.İSİM);
            this.Controls.Add(this.mtxtTelefon);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dgvuyeler);
            this.Controls.Add(this.dtpkayıttarihi);
            this.Controls.Add(this.combocinsiyet);
            this.Controls.Add(this.comboüyelik);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.txtisim);
            this.Name = "frmüyeyönetim";
            this.Text = "frmüyeyönetim";
            this.Load += new System.EventHandler(this.frmüyeyönetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuyeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            NewMethod();
        }

        private static void NewMethod()
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.ComboBox comboüyelik;
        private System.Windows.Forms.ComboBox combocinsiyet;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.DateTimePicker dtpkayıttarihi;
        private System.Windows.Forms.DataGridView dgvuyeler;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.Label İSİM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet_Click;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}