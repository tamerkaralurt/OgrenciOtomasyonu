namespace ogrenciOtomasyonu
{
    partial class frmAkaMesajGonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAkaMesajGonder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKime = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.txtMesajGonder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnOgrSoyadi = new System.Windows.Forms.RadioButton();
            this.rbtnOgrAdi = new System.Windows.Forms.RadioButton();
            this.rbtnOgrTC = new System.Windows.Forms.RadioButton();
            this.rbtnOgrNo = new System.Windows.Forms.RadioButton();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAkaOgrAra = new System.Windows.Forms.Button();
            this.txtAkaOgrAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kime : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Konu : ";
            // 
            // txtKime
            // 
            this.txtKime.Location = new System.Drawing.Point(57, 6);
            this.txtKime.Name = "txtKime";
            this.txtKime.Size = new System.Drawing.Size(518, 20);
            this.txtKime.TabIndex = 2;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(57, 32);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(518, 20);
            this.txtKonu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mesaj : ";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(57, 58);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(518, 209);
            this.txtMesaj.TabIndex = 5;
            // 
            // txtMesajGonder
            // 
            this.txtMesajGonder.Location = new System.Drawing.Point(57, 273);
            this.txtMesajGonder.Name = "txtMesajGonder";
            this.txtMesajGonder.Size = new System.Drawing.Size(518, 75);
            this.txtMesajGonder.TabIndex = 6;
            this.txtMesajGonder.Text = "Mesajı Gönder";
            this.txtMesajGonder.UseVisualStyleBackColor = true;
            this.txtMesajGonder.Click += new System.EventHandler(this.txtMesajGonder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Öğrenci Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnOgrSoyadi);
            this.panel1.Controls.Add(this.rbtnOgrAdi);
            this.panel1.Controls.Add(this.rbtnOgrTC);
            this.panel1.Controls.Add(this.rbtnOgrNo);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnAkaOgrAra);
            this.panel1.Controls.Add(this.txtAkaOgrAra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 381);
            this.panel1.TabIndex = 8;
            // 
            // rbtnOgrSoyadi
            // 
            this.rbtnOgrSoyadi.AutoSize = true;
            this.rbtnOgrSoyadi.Location = new System.Drawing.Point(298, 50);
            this.rbtnOgrSoyadi.Name = "rbtnOgrSoyadi";
            this.rbtnOgrSoyadi.Size = new System.Drawing.Size(97, 17);
            this.rbtnOgrSoyadi.TabIndex = 8;
            this.rbtnOgrSoyadi.TabStop = true;
            this.rbtnOgrSoyadi.Text = "Öğrenci Soyadi";
            this.rbtnOgrSoyadi.UseVisualStyleBackColor = true;
            // 
            // rbtnOgrAdi
            // 
            this.rbtnOgrAdi.AutoSize = true;
            this.rbtnOgrAdi.Location = new System.Drawing.Point(220, 50);
            this.rbtnOgrAdi.Name = "rbtnOgrAdi";
            this.rbtnOgrAdi.Size = new System.Drawing.Size(80, 17);
            this.rbtnOgrAdi.TabIndex = 7;
            this.rbtnOgrAdi.TabStop = true;
            this.rbtnOgrAdi.Text = "Öğrenci Adi";
            this.rbtnOgrAdi.UseVisualStyleBackColor = true;
            // 
            // rbtnOgrTC
            // 
            this.rbtnOgrTC.AutoSize = true;
            this.rbtnOgrTC.Location = new System.Drawing.Point(135, 50);
            this.rbtnOgrTC.Name = "rbtnOgrTC";
            this.rbtnOgrTC.Size = new System.Drawing.Size(79, 17);
            this.rbtnOgrTC.TabIndex = 6;
            this.rbtnOgrTC.TabStop = true;
            this.rbtnOgrTC.Text = "Öğrenci TC";
            this.rbtnOgrTC.UseVisualStyleBackColor = true;
            // 
            // rbtnOgrNo
            // 
            this.rbtnOgrNo.AutoSize = true;
            this.rbtnOgrNo.Location = new System.Drawing.Point(50, 50);
            this.rbtnOgrNo.Name = "rbtnOgrNo";
            this.rbtnOgrNo.Size = new System.Drawing.Size(79, 17);
            this.rbtnOgrNo.TabIndex = 5;
            this.rbtnOgrNo.TabStop = true;
            this.rbtnOgrNo.Text = "Öğrenci No";
            this.rbtnOgrNo.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(583, 9);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(664, 297);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnAkaOgrAra
            // 
            this.btnAkaOgrAra.Location = new System.Drawing.Point(401, 20);
            this.btnAkaOgrAra.Name = "btnAkaOgrAra";
            this.btnAkaOgrAra.Size = new System.Drawing.Size(75, 23);
            this.btnAkaOgrAra.TabIndex = 2;
            this.btnAkaOgrAra.Text = "Ara";
            this.btnAkaOgrAra.UseVisualStyleBackColor = true;
            this.btnAkaOgrAra.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtAkaOgrAra
            // 
            this.txtAkaOgrAra.Location = new System.Drawing.Point(50, 22);
            this.txtAkaOgrAra.Name = "txtAkaOgrAra";
            this.txtAkaOgrAra.Size = new System.Drawing.Size(345, 20);
            this.txtAkaOgrAra.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ara : ";
            // 
            // frmAkaMesajGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtMesajGonder);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtKime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAkaMesajGonder";
            this.Text = "Akademisyen Mesaj Gönderme Sistemi";
            this.Load += new System.EventHandler(this.frmAkaMesajGonder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKime;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button txtMesajGonder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAkaOgrAra;
        private System.Windows.Forms.TextBox txtAkaOgrAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.RadioButton rbtnOgrSoyadi;
        private System.Windows.Forms.RadioButton rbtnOgrAdi;
        private System.Windows.Forms.RadioButton rbtnOgrTC;
        private System.Windows.Forms.RadioButton rbtnOgrNo;
    }
}