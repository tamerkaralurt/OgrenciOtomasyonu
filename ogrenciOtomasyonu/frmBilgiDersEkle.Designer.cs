namespace ogrenciOtomasyonu
{
    partial class frmBilgiDersEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilgiDersEkle));
            this.txtdersKodu = new System.Windows.Forms.TextBox();
            this.btnDersKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxBolum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdersSinif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdersKredi = new System.Windows.Forms.TextBox();
            this.txtdersAdi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxHoca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxDersSecmeli = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdersKodu
            // 
            this.txtdersKodu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdersKodu.Location = new System.Drawing.Point(99, 19);
            this.txtdersKodu.Name = "txtdersKodu";
            this.txtdersKodu.Size = new System.Drawing.Size(211, 20);
            this.txtdersKodu.TabIndex = 1;
            // 
            // btnDersKaydet
            // 
            this.btnDersKaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDersKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersKaydet.Location = new System.Drawing.Point(99, 197);
            this.btnDersKaydet.Name = "btnDersKaydet";
            this.btnDersKaydet.Size = new System.Drawing.Size(211, 51);
            this.btnDersKaydet.TabIndex = 8;
            this.btnDersKaydet.Text = "KAYDET";
            this.btnDersKaydet.UseVisualStyleBackColor = false;
            this.btnDersKaydet.Click += new System.EventHandler(this.btnDersKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ders Kodu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ders Adi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ders Kredi : ";
            // 
            // cboxBolum
            // 
            this.cboxBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBolum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxBolum.FormattingEnabled = true;
            this.cboxBolum.Location = new System.Drawing.Point(99, 116);
            this.cboxBolum.Name = "cboxBolum";
            this.cboxBolum.Size = new System.Drawing.Size(211, 21);
            this.cboxBolum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ders Sınıf : ";
            // 
            // txtdersSinif
            // 
            this.txtdersSinif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdersSinif.Location = new System.Drawing.Point(99, 90);
            this.txtdersSinif.Name = "txtdersSinif";
            this.txtdersSinif.Size = new System.Drawing.Size(211, 20);
            this.txtdersSinif.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ders Bölüm : ";
            // 
            // txtdersKredi
            // 
            this.txtdersKredi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdersKredi.Location = new System.Drawing.Point(99, 66);
            this.txtdersKredi.Name = "txtdersKredi";
            this.txtdersKredi.Size = new System.Drawing.Size(211, 20);
            this.txtdersKredi.TabIndex = 3;
            // 
            // txtdersAdi
            // 
            this.txtdersAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdersAdi.Location = new System.Drawing.Point(99, 43);
            this.txtdersAdi.Name = "txtdersAdi";
            this.txtdersAdi.Size = new System.Drawing.Size(211, 20);
            this.txtdersAdi.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 273);
            this.panel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxHoca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdersKodu);
            this.groupBox1.Controls.Add(this.btnDersKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboxDersSecmeli);
            this.groupBox1.Controls.Add(this.cboxBolum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdersSinif);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdersKredi);
            this.groupBox1.Controls.Add(this.txtdersAdi);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Kaydet";
            // 
            // cboxHoca
            // 
            this.cboxHoca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxHoca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxHoca.FormattingEnabled = true;
            this.cboxHoca.Location = new System.Drawing.Point(99, 170);
            this.cboxHoca.Name = "cboxHoca";
            this.cboxHoca.Size = new System.Drawing.Size(211, 21);
            this.cboxHoca.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ders Hocasi : ";
            // 
            // cboxDersSecmeli
            // 
            this.cboxDersSecmeli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDersSecmeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxDersSecmeli.FormattingEnabled = true;
            this.cboxDersSecmeli.Items.AddRange(new object[] {
            "ZORUNLU",
            "SECMELI"});
            this.cboxDersSecmeli.Location = new System.Drawing.Point(99, 143);
            this.cboxDersSecmeli.Name = "cboxDersSecmeli";
            this.cboxDersSecmeli.Size = new System.Drawing.Size(211, 21);
            this.cboxDersSecmeli.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ders Durumu : ";
            // 
            // frmBilgiDersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(372, 296);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBilgiDersEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Ekle";
            this.Load += new System.EventHandler(this.frmBilgiDersEkle_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtdersKodu;
        private System.Windows.Forms.Button btnDersKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxBolum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdersSinif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdersKredi;
        private System.Windows.Forms.TextBox txtdersAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxHoca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxDersSecmeli;
        private System.Windows.Forms.Label label7;
    }
}