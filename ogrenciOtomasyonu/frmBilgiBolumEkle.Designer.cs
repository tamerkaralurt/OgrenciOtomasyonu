namespace ogrenciOtomasyonu
{
    partial class frmBilgiBolumEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilgiBolumEkle));
            this.txtbolumKodu = new System.Windows.Forms.TextBox();
            this.btnBolumKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbolumAdi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxBolumBaskani = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbolumKodu
            // 
            this.txtbolumKodu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbolumKodu.Location = new System.Drawing.Point(106, 19);
            this.txtbolumKodu.Name = "txtbolumKodu";
            this.txtbolumKodu.Size = new System.Drawing.Size(211, 20);
            this.txtbolumKodu.TabIndex = 13;
            // 
            // btnBolumKaydet
            // 
            this.btnBolumKaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBolumKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumKaydet.Location = new System.Drawing.Point(106, 98);
            this.btnBolumKaydet.Name = "btnBolumKaydet";
            this.btnBolumKaydet.Size = new System.Drawing.Size(211, 51);
            this.btnBolumKaydet.TabIndex = 20;
            this.btnBolumKaydet.Text = "KAYDET";
            this.btnBolumKaydet.UseVisualStyleBackColor = false;
            this.btnBolumKaydet.Click += new System.EventHandler(this.btnBolumKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bolum Kodu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bolum Adı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bölüm Başkanı : ";
            // 
            // txtbolumAdi
            // 
            this.txtbolumAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbolumAdi.Location = new System.Drawing.Point(106, 45);
            this.txtbolumAdi.Name = "txtbolumAdi";
            this.txtbolumAdi.Size = new System.Drawing.Size(211, 20);
            this.txtbolumAdi.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 166);
            this.panel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxBolumBaskani);
            this.groupBox1.Controls.Add(this.txtbolumKodu);
            this.groupBox1.Controls.Add(this.btnBolumKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbolumAdi);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Akademisyen Kaydet";
            // 
            // cboxBolumBaskani
            // 
            this.cboxBolumBaskani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxBolumBaskani.FormattingEnabled = true;
            this.cboxBolumBaskani.Location = new System.Drawing.Point(106, 71);
            this.cboxBolumBaskani.Name = "cboxBolumBaskani";
            this.cboxBolumBaskani.Size = new System.Drawing.Size(211, 21);
            this.cboxBolumBaskani.TabIndex = 21;
            // 
            // frmBilgiBolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(365, 190);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBilgiBolumEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölüm Ekle";
            this.Load += new System.EventHandler(this.frmBilgiBolumEkle_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbolumKodu;
        private System.Windows.Forms.Button btnBolumKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbolumAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxBolumBaskani;
    }
}