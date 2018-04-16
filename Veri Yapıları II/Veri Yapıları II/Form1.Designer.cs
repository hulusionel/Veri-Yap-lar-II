namespace Veri_Yapıları_II
{
    partial class Form1
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
            this.btnArabaCikart = new System.Windows.Forms.Button();
            this.btnArabaEkle = new System.Windows.Forms.Button();
            this.txtEklenenler = new System.Windows.Forms.TextBox();
            this.txtCikanlar = new System.Windows.Forms.TextBox();
            this.btnBesSaniye = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCozumMiktari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArabaCikart
            // 
            this.btnArabaCikart.Location = new System.Drawing.Point(223, 11);
            this.btnArabaCikart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArabaCikart.Name = "btnArabaCikart";
            this.btnArabaCikart.Size = new System.Drawing.Size(191, 49);
            this.btnArabaCikart.TabIndex = 0;
            this.btnArabaCikart.Text = "Arabaları Çıkart";
            this.btnArabaCikart.UseVisualStyleBackColor = true;
            this.btnArabaCikart.Click += new System.EventHandler(this.btnArabaCikart_Click);
            // 
            // btnArabaEkle
            // 
            this.btnArabaEkle.Location = new System.Drawing.Point(9, 11);
            this.btnArabaEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArabaEkle.Name = "btnArabaEkle";
            this.btnArabaEkle.Size = new System.Drawing.Size(194, 49);
            this.btnArabaEkle.TabIndex = 1;
            this.btnArabaEkle.Text = "Arabaları Ekle";
            this.btnArabaEkle.UseVisualStyleBackColor = true;
            this.btnArabaEkle.Click += new System.EventHandler(this.btnArabaEkle_Click);
            // 
            // txtEklenenler
            // 
            this.txtEklenenler.Location = new System.Drawing.Point(9, 64);
            this.txtEklenenler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEklenenler.Multiline = true;
            this.txtEklenenler.Name = "txtEklenenler";
            this.txtEklenenler.Size = new System.Drawing.Size(194, 769);
            this.txtEklenenler.TabIndex = 2;
            // 
            // txtCikanlar
            // 
            this.txtCikanlar.Location = new System.Drawing.Point(223, 64);
            this.txtCikanlar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCikanlar.Multiline = true;
            this.txtCikanlar.Name = "txtCikanlar";
            this.txtCikanlar.Size = new System.Drawing.Size(191, 769);
            this.txtCikanlar.TabIndex = 3;
            // 
            // btnBesSaniye
            // 
            this.btnBesSaniye.Location = new System.Drawing.Point(431, 11);
            this.btnBesSaniye.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBesSaniye.Name = "btnBesSaniye";
            this.btnBesSaniye.Size = new System.Drawing.Size(183, 49);
            this.btnBesSaniye.TabIndex = 4;
            this.btnBesSaniye.Text = "5 Saniye Testi";
            this.btnBesSaniye.UseVisualStyleBackColor = true;
            this.btnBesSaniye.Click += new System.EventHandler(this.btnBesSaniye_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Çözüm Sayısı(5 sn bekle):";
            // 
            // lblCozumMiktari
            // 
            this.lblCozumMiktari.AutoSize = true;
            this.lblCozumMiktari.Location = new System.Drawing.Point(567, 73);
            this.lblCozumMiktari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCozumMiktari.Name = "lblCozumMiktari";
            this.lblCozumMiktari.Size = new System.Drawing.Size(0, 13);
            this.lblCozumMiktari.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 668);
            this.Controls.Add(this.lblCozumMiktari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBesSaniye);
            this.Controls.Add(this.txtCikanlar);
            this.Controls.Add(this.txtEklenenler);
            this.Controls.Add(this.btnArabaEkle);
            this.Controls.Add(this.btnArabaCikart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Veri Yapıları II. Ödev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArabaCikart;
        private System.Windows.Forms.Button btnArabaEkle;
        private System.Windows.Forms.TextBox txtEklenenler;
        private System.Windows.Forms.TextBox txtCikanlar;
        private System.Windows.Forms.Button btnBesSaniye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCozumMiktari;
    }
}

