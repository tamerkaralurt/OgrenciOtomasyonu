namespace ogrenciOtomasyonu
{
    partial class frmBilgiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilgiGiris));
            this.lblBilgiNo = new System.Windows.Forms.Label();
            this.txtBilgiGirisNo = new System.Windows.Forms.TextBox();
            this.txtBilgiGirisSifre = new System.Windows.Forms.TextBox();
            this.lblBilgiSifre = new System.Windows.Forms.Label();
            this.btnBilgiGiris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKayitSifreOnay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKayitAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKayitTel = new System.Windows.Forms.TextBox();
            this.txtKayitTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKayitBolum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKayitAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKayitSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBilgiNo
            // 
            this.lblBilgiNo.AutoSize = true;
            this.lblBilgiNo.ForeColor = System.Drawing.Color.White;
            this.lblBilgiNo.Location = new System.Drawing.Point(12, 22);
            this.lblBilgiNo.Name = "lblBilgiNo";
            this.lblBilgiNo.Size = new System.Drawing.Size(52, 13);
            this.lblBilgiNo.TabIndex = 0;
            this.lblBilgiNo.Text = "Bilgi No : ";
            // 
            // txtBilgiGirisNo
            // 
            this.txtBilgiGirisNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBilgiGirisNo.Location = new System.Drawing.Point(70, 19);
            this.txtBilgiGirisNo.Name = "txtBilgiGirisNo";
            this.txtBilgiGirisNo.Size = new System.Drawing.Size(159, 20);
            this.txtBilgiGirisNo.TabIndex = 1;
            // 
            // txtBilgiGirisSifre
            // 
            this.txtBilgiGirisSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBilgiGirisSifre.Location = new System.Drawing.Point(70, 44);
            this.txtBilgiGirisSifre.Name = "txtBilgiGirisSifre";
            this.txtBilgiGirisSifre.PasswordChar = '*';
            this.txtBilgiGirisSifre.Size = new System.Drawing.Size(159, 20);
            this.txtBilgiGirisSifre.TabIndex = 3;
            // 
            // lblBilgiSifre
            // 
            this.lblBilgiSifre.AutoSize = true;
            this.lblBilgiSifre.ForeColor = System.Drawing.Color.White;
            this.lblBilgiSifre.Location = new System.Drawing.Point(27, 47);
            this.lblBilgiSifre.Name = "lblBilgiSifre";
            this.lblBilgiSifre.Size = new System.Drawing.Size(37, 13);
            this.lblBilgiSifre.TabIndex = 2;
            this.lblBilgiSifre.Text = "Şifre : ";
            // 
            // btnBilgiGiris
            // 
            this.btnBilgiGiris.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBilgiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiGiris.ForeColor = System.Drawing.Color.White;
            this.btnBilgiGiris.Location = new System.Drawing.Point(70, 70);
            this.btnBilgiGiris.Name = "btnBilgiGiris";
            this.btnBilgiGiris.Size = new System.Drawing.Size(159, 52);
            this.btnBilgiGiris.TabIndex = 4;
            this.btnBilgiGiris.Text = "GİRİŞ YAP";
            this.btnBilgiGiris.UseVisualStyleBackColor = false;
            this.btnBilgiGiris.Click += new System.EventHandler(this.btnBilgiGiris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBilgiGirisNo);
            this.groupBox1.Controls.Add(this.btnBilgiGiris);
            this.groupBox1.Controls.Add(this.lblBilgiNo);
            this.groupBox1.Controls.Add(this.txtBilgiGirisSifre);
            this.groupBox1.Controls.Add(this.lblBilgiSifre);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 299);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sisteme Giriş";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtKayitSifreOnay);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtKayitSifre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtKayitAdres);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtKayitTel);
            this.groupBox2.Controls.Add(this.txtKayitTC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtKayitBolum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtKayitAdi);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtKayitSoyadi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 297);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Ol";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Şifre Onay : ";
            // 
            // txtKayitSifreOnay
            // 
            this.txtKayitSifreOnay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayitSifreOnay.Location = new System.Drawing.Point(108, 201);
            this.txtKayitSifreOnay.Name = "txtKayitSifreOnay";
            this.txtKayitSifreOnay.PasswordChar = '*';
            this.txtKayitSifreOnay.Size = new System.Drawing.Size(159, 20);
            this.txtKayitSifreOnay.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(65, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Şifre : ";
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayitSifre.Location = new System.Drawing.Point(108, 175);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.PasswordChar = '*';
            this.txtKayitSifre.Size = new System.Drawing.Size(159, 20);
            this.txtKayitSifre.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(59, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Adres : ";
            // 
            // txtKayitAdres
            // 
            this.txtKayitAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayitAdres.Location = new System.Drawing.Point(108, 149);
            this.txtKayitAdres.Name = "txtKayitAdres";
            this.txtKayitAdres.Size = new System.Drawing.Size(159, 20);
            this.txtKayitAdres.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefon : ";
            // 
            // txtKayitTel
            // 
            this.txtKayitTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayitTel.Location = new System.Drawing.Point(108, 123);
            this.txtKayitTel.Name = "txtKayitTel";
            this.txtKayitTel.Size = new System.Drawing.Size(159, 20);
            this.txtKayitTel.TabIndex = 15;
            // 
            // txtKayitTC
            // 
            this.txtKayitTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayitTC.Location = new System.Drawing.Point(108, 71);
            this.txtKayitTC.Name = "txtKayitTC";
            this.txtKayitTC.Size = new System.Drawing.Size(159, 20);
            this.txtKayitTC.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bölüm : ";
            // 
            // txtKayitBolum
            // 
            this.txtKayitBolum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayitBolum.Location = new System.Drawing.Point(108, 96);
            this.txtKayitBolum.Name = "txtKayitBolum";
            this.txtKayitBolum.Size = new System.Drawing.Size(159, 20);
            this.txtKayitBolum.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "TC : ";
            // 
            // txtKayitAdi
            // 
            this.txtKayitAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayitAdi.Location = new System.Drawing.Point(108, 20);
            this.txtKayitAdi.Name = "txtKayitAdi";
            this.txtKayitAdi.Size = new System.Drawing.Size(159, 20);
            this.txtKayitAdi.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(108, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "KAYIT OL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adi  : ";
            // 
            // txtKayitSoyadi
            // 
            this.txtKayitSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayitSoyadi.Location = new System.Drawing.Point(108, 45);
            this.txtKayitSoyadi.Name = "txtKayitSoyadi";
            this.txtKayitSoyadi.Size = new System.Drawing.Size(159, 20);
            this.txtKayitSoyadi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadi : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 304);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(279, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 304);
            this.panel2.TabIndex = 8;
            // 
            // frmBilgiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(613, 326);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBilgiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi İşlem Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBilgiGiris_FormClosing);
            this.Load += new System.EventHandler(this.frmBilgiGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBilgiNo;
        private System.Windows.Forms.TextBox txtBilgiGirisNo;
        private System.Windows.Forms.TextBox txtBilgiGirisSifre;
        private System.Windows.Forms.Label lblBilgiSifre;
        private System.Windows.Forms.Button btnBilgiGiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKayitAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKayitTel;
        private System.Windows.Forms.TextBox txtKayitTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKayitBolum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKayitAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKayitSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKayitSifreOnay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}