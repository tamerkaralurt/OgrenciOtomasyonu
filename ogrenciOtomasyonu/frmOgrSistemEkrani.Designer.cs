namespace ogrenciOtomasyonu
{
    partial class frmOgrSistemEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrSistemEkrani));
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tpAnaSayfa = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBolum = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOgrGNO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOgrSoyad = new System.Windows.Forms.Label();
            this.lblOgrAdi = new System.Windows.Forms.Label();
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpBasariIzleme = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colDersKodu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersAdi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersVize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersOrtalama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersKredi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersNotu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpDersKayit = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDersKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDersSec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDersKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersKredi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersSinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpDevamsizlik = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajGeçmişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColDevamDersKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDevamDersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDevamAkaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDevamTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDevamSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage.SuspendLayout();
            this.tpAnaSayfa.SuspendLayout();
            this.tpBasariIzleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpDersKayit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpDevamsizlik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tpAnaSayfa);
            this.tabPage.Controls.Add(this.tpBasariIzleme);
            this.tabPage.Controls.Add(this.tpDersKayit);
            this.tabPage.Controls.Add(this.tpDevamsizlik);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Location = new System.Drawing.Point(0, 24);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(809, 509);
            this.tabPage.TabIndex = 0;
            // 
            // tpAnaSayfa
            // 
            this.tpAnaSayfa.Controls.Add(this.label6);
            this.tpAnaSayfa.Controls.Add(this.lblBolum);
            this.tpAnaSayfa.Controls.Add(this.lblSinif);
            this.tpAnaSayfa.Controls.Add(this.label5);
            this.tpAnaSayfa.Controls.Add(this.lblOgrGNO);
            this.tpAnaSayfa.Controls.Add(this.label4);
            this.tpAnaSayfa.Controls.Add(this.lblOgrSoyad);
            this.tpAnaSayfa.Controls.Add(this.lblOgrAdi);
            this.tpAnaSayfa.Controls.Add(this.lblOgrNo);
            this.tpAnaSayfa.Controls.Add(this.label3);
            this.tpAnaSayfa.Controls.Add(this.label2);
            this.tpAnaSayfa.Controls.Add(this.label1);
            this.tpAnaSayfa.Location = new System.Drawing.Point(4, 22);
            this.tpAnaSayfa.Name = "tpAnaSayfa";
            this.tpAnaSayfa.Size = new System.Drawing.Size(801, 483);
            this.tpAnaSayfa.TabIndex = 2;
            this.tpAnaSayfa.Text = "Ana Sayfa";
            this.tpAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Öğrenci Bölüm : ";
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(114, 107);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(35, 13);
            this.lblBolum.TabIndex = 10;
            this.lblBolum.Text = "label6";
            // 
            // lblSinif
            // 
            this.lblSinif.AutoSize = true;
            this.lblSinif.Location = new System.Drawing.Point(114, 85);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(35, 13);
            this.lblSinif.TabIndex = 9;
            this.lblSinif.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Öğrenci Sınıf : ";
            // 
            // lblOgrGNO
            // 
            this.lblOgrGNO.AutoSize = true;
            this.lblOgrGNO.Location = new System.Drawing.Point(746, 17);
            this.lblOgrGNO.Name = "lblOgrGNO";
            this.lblOgrGNO.Size = new System.Drawing.Size(35, 13);
            this.lblOgrGNO.TabIndex = 7;
            this.lblOgrGNO.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "GNO:";
            // 
            // lblOgrSoyad
            // 
            this.lblOgrSoyad.AutoSize = true;
            this.lblOgrSoyad.Location = new System.Drawing.Point(114, 63);
            this.lblOgrSoyad.Name = "lblOgrSoyad";
            this.lblOgrSoyad.Size = new System.Drawing.Size(35, 13);
            this.lblOgrSoyad.TabIndex = 5;
            this.lblOgrSoyad.Text = "label6";
            // 
            // lblOgrAdi
            // 
            this.lblOgrAdi.AutoSize = true;
            this.lblOgrAdi.Location = new System.Drawing.Point(114, 39);
            this.lblOgrAdi.Name = "lblOgrAdi";
            this.lblOgrAdi.Size = new System.Drawing.Size(35, 13);
            this.lblOgrAdi.TabIndex = 4;
            this.lblOgrAdi.Text = "label5";
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.Location = new System.Drawing.Point(114, 17);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(35, 13);
            this.lblOgrNo.TabIndex = 3;
            this.lblOgrNo.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Soyadı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No : ";
            // 
            // tpBasariIzleme
            // 
            this.tpBasariIzleme.Controls.Add(this.dataGridView2);
            this.tpBasariIzleme.Location = new System.Drawing.Point(4, 22);
            this.tpBasariIzleme.Name = "tpBasariIzleme";
            this.tpBasariIzleme.Padding = new System.Windows.Forms.Padding(3);
            this.tpBasariIzleme.Size = new System.Drawing.Size(801, 483);
            this.tpBasariIzleme.TabIndex = 1;
            this.tpBasariIzleme.Text = "Başarı İzleme";
            this.tpBasariIzleme.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDersKodu2,
            this.colDersAdi2,
            this.colDersVize,
            this.colDersFinal,
            this.colDersOrtalama,
            this.colDersKredi2,
            this.colDersNotu});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(795, 477);
            this.dataGridView2.TabIndex = 0;
            // 
            // colDersKodu2
            // 
            this.colDersKodu2.HeaderText = "Ders Kodu";
            this.colDersKodu2.Name = "colDersKodu2";
            this.colDersKodu2.ReadOnly = true;
            // 
            // colDersAdi2
            // 
            this.colDersAdi2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDersAdi2.HeaderText = "Ders Adi";
            this.colDersAdi2.Name = "colDersAdi2";
            this.colDersAdi2.ReadOnly = true;
            // 
            // colDersVize
            // 
            this.colDersVize.HeaderText = "Vize";
            this.colDersVize.Name = "colDersVize";
            this.colDersVize.ReadOnly = true;
            // 
            // colDersFinal
            // 
            this.colDersFinal.HeaderText = "Final";
            this.colDersFinal.Name = "colDersFinal";
            this.colDersFinal.ReadOnly = true;
            // 
            // colDersOrtalama
            // 
            this.colDersOrtalama.HeaderText = "Ortalama";
            this.colDersOrtalama.Name = "colDersOrtalama";
            this.colDersOrtalama.ReadOnly = true;
            // 
            // colDersKredi2
            // 
            this.colDersKredi2.HeaderText = "Kredi";
            this.colDersKredi2.Name = "colDersKredi2";
            this.colDersKredi2.ReadOnly = true;
            // 
            // colDersNotu
            // 
            this.colDersNotu.HeaderText = "Ders Notu";
            this.colDersNotu.Name = "colDersNotu";
            this.colDersNotu.ReadOnly = true;
            // 
            // tpDersKayit
            // 
            this.tpDersKayit.Controls.Add(this.groupBox1);
            this.tpDersKayit.Location = new System.Drawing.Point(4, 22);
            this.tpDersKayit.Name = "tpDersKayit";
            this.tpDersKayit.Padding = new System.Windows.Forms.Padding(3);
            this.tpDersKayit.Size = new System.Drawing.Size(801, 483);
            this.tpDersKayit.TabIndex = 0;
            this.tpDersKayit.Text = "Ders Kayıt";
            this.tpDersKayit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDersKaydet);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Seçiniz";
            // 
            // btnDersKaydet
            // 
            this.btnDersKaydet.Location = new System.Drawing.Point(6, 399);
            this.btnDersKaydet.Name = "btnDersKaydet";
            this.btnDersKaydet.Size = new System.Drawing.Size(773, 40);
            this.btnDersKaydet.TabIndex = 1;
            this.btnDersKaydet.Text = "Dersleri Kaydet";
            this.btnDersKaydet.UseVisualStyleBackColor = true;
            this.btnDersKaydet.Click += new System.EventHandler(this.btnDersKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDersSec,
            this.colDersKodu,
            this.colDersAdi,
            this.colDersKredi,
            this.colDersSinif,
            this.colDersDurum});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // colDersSec
            // 
            this.colDersSec.HeaderText = "Ders Seç";
            this.colDersSec.Name = "colDersSec";
            // 
            // colDersKodu
            // 
            this.colDersKodu.HeaderText = "Ders Kodu";
            this.colDersKodu.Name = "colDersKodu";
            // 
            // colDersAdi
            // 
            this.colDersAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDersAdi.HeaderText = "Ders Adi";
            this.colDersAdi.Name = "colDersAdi";
            // 
            // colDersKredi
            // 
            this.colDersKredi.HeaderText = "Ders Kredisi";
            this.colDersKredi.Name = "colDersKredi";
            // 
            // colDersSinif
            // 
            this.colDersSinif.HeaderText = "Sınıf";
            this.colDersSinif.Name = "colDersSinif";
            // 
            // colDersDurum
            // 
            this.colDersDurum.HeaderText = "Ders Durumu";
            this.colDersDurum.Name = "colDersDurum";
            // 
            // tpDevamsizlik
            // 
            this.tpDevamsizlik.Controls.Add(this.dataGridView3);
            this.tpDevamsizlik.Location = new System.Drawing.Point(4, 22);
            this.tpDevamsizlik.Name = "tpDevamsizlik";
            this.tpDevamsizlik.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevamsizlik.Size = new System.Drawing.Size(801, 483);
            this.tpDevamsizlik.TabIndex = 3;
            this.tpDevamsizlik.Text = "Devamsızlık";
            this.tpDevamsizlik.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDevamDersKodu,
            this.colDevamDersAdi,
            this.ColDevamAkaAdi,
            this.ColDevamTarih,
            this.ColDevamSaat});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(795, 477);
            this.dataGridView3.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.mesajlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // mesajlarToolStripMenuItem
            // 
            this.mesajlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesajGönderToolStripMenuItem,
            this.mesajGeçmişiToolStripMenuItem});
            this.mesajlarToolStripMenuItem.Name = "mesajlarToolStripMenuItem";
            this.mesajlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.mesajlarToolStripMenuItem.Text = "Mesajlar";
            // 
            // mesajGönderToolStripMenuItem
            // 
            this.mesajGönderToolStripMenuItem.Name = "mesajGönderToolStripMenuItem";
            this.mesajGönderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.mesajGönderToolStripMenuItem.Text = "Mesaj Gönder";
            this.mesajGönderToolStripMenuItem.Click += new System.EventHandler(this.mesajGönderToolStripMenuItem_Click);
            // 
            // mesajGeçmişiToolStripMenuItem
            // 
            this.mesajGeçmişiToolStripMenuItem.Name = "mesajGeçmişiToolStripMenuItem";
            this.mesajGeçmişiToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.mesajGeçmişiToolStripMenuItem.Text = "Mesaj Geçmişi";
            this.mesajGeçmişiToolStripMenuItem.Click += new System.EventHandler(this.mesajGeçmişiToolStripMenuItem_Click);
            // 
            // ColDevamDersKodu
            // 
            this.ColDevamDersKodu.HeaderText = "Ders Kodu";
            this.ColDevamDersKodu.Name = "ColDevamDersKodu";
            this.ColDevamDersKodu.ReadOnly = true;
            // 
            // colDevamDersAdi
            // 
            this.colDevamDersAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDevamDersAdi.HeaderText = "Ders Adı";
            this.colDevamDersAdi.Name = "colDevamDersAdi";
            this.colDevamDersAdi.ReadOnly = true;
            // 
            // ColDevamAkaAdi
            // 
            this.ColDevamAkaAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDevamAkaAdi.HeaderText = "Akademisyen Adı Soyadı";
            this.ColDevamAkaAdi.Name = "ColDevamAkaAdi";
            this.ColDevamAkaAdi.ReadOnly = true;
            // 
            // ColDevamTarih
            // 
            this.ColDevamTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDevamTarih.HeaderText = "Tarih";
            this.ColDevamTarih.Name = "ColDevamTarih";
            this.ColDevamTarih.ReadOnly = true;
            // 
            // ColDevamSaat
            // 
            this.ColDevamSaat.HeaderText = "Durum";
            this.ColDevamSaat.Name = "ColDevamSaat";
            this.ColDevamSaat.ReadOnly = true;
            // 
            // frmOgrSistemEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 533);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOgrSistemEkrani";
            this.Text = "Öğrenci Sistem Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOgrSistemEkrani_FormClosing);
            this.Load += new System.EventHandler(this.frmOgrSistemEkrani_Load);
            this.tabPage.ResumeLayout(false);
            this.tpAnaSayfa.ResumeLayout(false);
            this.tpAnaSayfa.PerformLayout();
            this.tpBasariIzleme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tpDersKayit.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpDevamsizlik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tpDersKayit;
        private System.Windows.Forms.TabPage tpAnaSayfa;
        private System.Windows.Forms.Label lblOgrGNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOgrSoyad;
        private System.Windows.Forms.Label lblOgrAdi;
        private System.Windows.Forms.Label lblOgrNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajGeçmişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajGönderToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDersKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tpBasariIzleme;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersKodu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersAdi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersVize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersOrtalama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersKredi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersNotu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDersSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersKredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersSinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersDurum;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.TabPage tpDevamsizlik;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDevamDersKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDevamDersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDevamAkaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDevamTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDevamSaat;
    }
}