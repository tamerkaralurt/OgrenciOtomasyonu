namespace ogrenciOtomasyonu
{
    partial class frmBilgiPersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilgiPersonelEkle));
            this.txtperAdi = new System.Windows.Forms.TextBox();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtperAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxBolum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtperTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtperTC = new System.Windows.Forms.TextBox();
            this.txtperSoyadi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtperAdi
            // 
            this.txtperAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtperAdi.Location = new System.Drawing.Point(108, 19);
            this.txtperAdi.Name = "txtperAdi";
            this.txtperAdi.Size = new System.Drawing.Size(211, 20);
            this.txtperAdi.TabIndex = 13;
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPersonelKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelKaydet.Location = new System.Drawing.Point(108, 231);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(211, 51);
            this.btnPersonelKaydet.TabIndex = 20;
            this.btnPersonelKaydet.Text = "KAYDET";
            this.btnPersonelKaydet.UseVisualStyleBackColor = false;
            this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Personel Adı : ";
            // 
            // txtperAdres
            // 
            this.txtperAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtperAdres.Location = new System.Drawing.Point(108, 143);
            this.txtperAdres.Multiline = true;
            this.txtperAdres.Name = "txtperAdres";
            this.txtperAdres.Size = new System.Drawing.Size(211, 82);
            this.txtperAdres.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Personel Soyadı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Personel Adres : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Personel TC : ";
            // 
            // cboxBolum
            // 
            this.cboxBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBolum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxBolum.FormattingEnabled = true;
            this.cboxBolum.Location = new System.Drawing.Point(108, 116);
            this.cboxBolum.Name = "cboxBolum";
            this.cboxBolum.Size = new System.Drawing.Size(211, 21);
            this.cboxBolum.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Personel Telefon : ";
            // 
            // txtperTelefon
            // 
            this.txtperTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtperTelefon.Location = new System.Drawing.Point(108, 90);
            this.txtperTelefon.Name = "txtperTelefon";
            this.txtperTelefon.Size = new System.Drawing.Size(211, 20);
            this.txtperTelefon.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Personel Bölüm : ";
            // 
            // txtperTC
            // 
            this.txtperTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtperTC.Location = new System.Drawing.Point(108, 66);
            this.txtperTC.Name = "txtperTC";
            this.txtperTC.Size = new System.Drawing.Size(211, 20);
            this.txtperTC.TabIndex = 16;
            // 
            // txtperSoyadi
            // 
            this.txtperSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtperSoyadi.Location = new System.Drawing.Point(108, 43);
            this.txtperSoyadi.Name = "txtperSoyadi";
            this.txtperSoyadi.Size = new System.Drawing.Size(211, 20);
            this.txtperSoyadi.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 298);
            this.panel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtperAdi);
            this.groupBox1.Controls.Add(this.btnPersonelKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtperAdres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboxBolum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtperTelefon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtperTC);
            this.groupBox1.Controls.Add(this.txtperSoyadi);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi İşlem Personeli Kaydet";
            // 
            // frmBilgiPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(376, 320);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBilgiPersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi İşlem Personeli Ekleme";
            this.Load += new System.EventHandler(this.frmBilgiPersonelEkle_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtperAdi;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtperAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxBolum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtperTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtperTC;
        private System.Windows.Forms.TextBox txtperSoyadi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}