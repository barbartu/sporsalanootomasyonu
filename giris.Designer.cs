
namespace sporsalonuotomasyonu
{
    partial class giris
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
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.txtporola = new System.Windows.Forms.MaskedTextBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btngiriş = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(507, 140);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(276, 20);
            this.txtsoyisim.TabIndex = 0;
            // 
            // txtporola
            // 
            this.txtporola.Location = new System.Drawing.Point(507, 187);
            this.txtporola.Name = "txtporola";
            this.txtporola.Size = new System.Drawing.Size(276, 20);
            this.txtporola.TabIndex = 1;
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(507, 87);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(276, 20);
            this.txtisim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(432, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "İSİM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(377, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOY İSİM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(387, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "PAROLA";
            // 
            // btngiriş
            // 
            this.btngiriş.BackColor = System.Drawing.SystemColors.InfoText;
            this.btngiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiriş.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngiriş.Location = new System.Drawing.Point(334, 520);
            this.btngiriş.Name = "btngiriş";
            this.btngiriş.Size = new System.Drawing.Size(586, 119);
            this.btngiriş.TabIndex = 3;
            this.btngiriş.Text = "GİRİŞ YAP";
            this.btngiriş.UseVisualStyleBackColor = false;
            this.btngiriş.Click += new System.EventHandler(this.btngiriş_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sporsalonuotomasyonu.Properties.Resources.Gemini_Generated_Image_bmqtkqbmqtkqbmqt;
            this.ClientSize = new System.Drawing.Size(1215, 638);
            this.Controls.Add(this.btngiriş);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtporola);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.txtsoyisim);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "giris";
            this.Text = "yetkili giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.MaskedTextBox txtporola;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngiriş;
    }
}

