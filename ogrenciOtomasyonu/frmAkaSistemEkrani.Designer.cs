namespace ogrenciOtomasyonu
{
    partial class frmAkaSistemEkrani
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAkaSistemEkrani));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajKutusuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eskiMesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devamsızlıkGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAnaSayfa = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDersProgrami0 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colPazartesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarsamba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersembe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDersOnay = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colOnaylanacakSec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colOgrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOgrAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.timerMesaj = new System.Windows.Forms.Timer(this.components);
            this.ColKonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAnaSayfa.SuspendLayout();
            this.tabDersProgrami0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabDersOnay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(997, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.mesajKutusuToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
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
            // mesajKutusuToolStripMenuItem
            // 
            this.mesajKutusuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesajGönderToolStripMenuItem,
            this.eskiMesajlarToolStripMenuItem});
            this.mesajKutusuToolStripMenuItem.Name = "mesajKutusuToolStripMenuItem";
            this.mesajKutusuToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.mesajKutusuToolStripMenuItem.Text = "Mesajlar";
            // 
            // mesajGönderToolStripMenuItem
            // 
            this.mesajGönderToolStripMenuItem.Name = "mesajGönderToolStripMenuItem";
            this.mesajGönderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.mesajGönderToolStripMenuItem.Text = "Mesaj Gönder";
            this.mesajGönderToolStripMenuItem.Click += new System.EventHandler(this.mesajGönderToolStripMenuItem_Click);
            // 
            // eskiMesajlarToolStripMenuItem
            // 
            this.eskiMesajlarToolStripMenuItem.Name = "eskiMesajlarToolStripMenuItem";
            this.eskiMesajlarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.eskiMesajlarToolStripMenuItem.Text = "Mesaj Geçmişi";
            this.eskiMesajlarToolStripMenuItem.Click += new System.EventHandler(this.eskiMesajlarToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notGirişiToolStripMenuItem,
            this.devamsızlıkGirişiToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // notGirişiToolStripMenuItem
            // 
            this.notGirişiToolStripMenuItem.Name = "notGirişiToolStripMenuItem";
            this.notGirişiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.notGirişiToolStripMenuItem.Text = "Not Girişi";
            this.notGirişiToolStripMenuItem.Click += new System.EventHandler(this.notGirişiToolStripMenuItem_Click);
            // 
            // devamsızlıkGirişiToolStripMenuItem
            // 
            this.devamsızlıkGirişiToolStripMenuItem.Name = "devamsızlıkGirişiToolStripMenuItem";
            this.devamsızlıkGirişiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.devamsızlıkGirişiToolStripMenuItem.Text = "Devamsızlık Girişi";
            this.devamsızlıkGirişiToolStripMenuItem.Click += new System.EventHandler(this.devamsızlıkGirişiToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer1.Size = new System.Drawing.Size(997, 521);
            this.splitContainer1.SplitterDistance = 667;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAnaSayfa);
            this.tabControl1.Controls.Add(this.tabDersProgrami0);
            this.tabControl1.Controls.Add(this.tabDersOnay);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAnaSayfa
            // 
            this.tabAnaSayfa.Controls.Add(this.label1);
            this.tabAnaSayfa.Location = new System.Drawing.Point(4, 22);
            this.tabAnaSayfa.Name = "tabAnaSayfa";
            this.tabAnaSayfa.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnaSayfa.Size = new System.Drawing.Size(659, 495);
            this.tabAnaSayfa.TabIndex = 0;
            this.tabAnaSayfa.Text = "Ana Sayfa";
            this.tabAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duyurular";
            // 
            // tabDersProgrami0
            // 
            this.tabDersProgrami0.Controls.Add(this.dataGridView2);
            this.tabDersProgrami0.Location = new System.Drawing.Point(4, 22);
            this.tabDersProgrami0.Name = "tabDersProgrami0";
            this.tabDersProgrami0.Padding = new System.Windows.Forms.Padding(3);
            this.tabDersProgrami0.Size = new System.Drawing.Size(659, 495);
            this.tabDersProgrami0.TabIndex = 1;
            this.tabDersProgrami0.Text = "Ders Programı";
            this.tabDersProgrami0.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPazartesi,
            this.colSali,
            this.colCarsamba,
            this.colPersembe,
            this.colCuma});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(653, 489);
            this.dataGridView2.TabIndex = 0;
            // 
            // colPazartesi
            // 
            this.colPazartesi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPazartesi.HeaderText = "Pazartesi";
            this.colPazartesi.Name = "colPazartesi";
            this.colPazartesi.ReadOnly = true;
            // 
            // colSali
            // 
            this.colSali.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSali.HeaderText = "Salı";
            this.colSali.Name = "colSali";
            this.colSali.ReadOnly = true;
            // 
            // colCarsamba
            // 
            this.colCarsamba.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCarsamba.HeaderText = "Çarşamba";
            this.colCarsamba.Name = "colCarsamba";
            this.colCarsamba.ReadOnly = true;
            // 
            // colPersembe
            // 
            this.colPersembe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPersembe.HeaderText = "Perşembe";
            this.colPersembe.Name = "colPersembe";
            this.colPersembe.ReadOnly = true;
            // 
            // colCuma
            // 
            this.colCuma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCuma.HeaderText = "Cuma";
            this.colCuma.Name = "colCuma";
            this.colCuma.ReadOnly = true;
            // 
            // tabDersOnay
            // 
            this.tabDersOnay.Controls.Add(this.button1);
            this.tabDersOnay.Controls.Add(this.dataGridView1);
            this.tabDersOnay.Location = new System.Drawing.Point(4, 22);
            this.tabDersOnay.Name = "tabDersOnay";
            this.tabDersOnay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDersOnay.Size = new System.Drawing.Size(659, 495);
            this.tabDersOnay.TabIndex = 2;
            this.tabDersOnay.Text = "Ders Onayı";
            this.tabDersOnay.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(645, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dersleri Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOnaylanacakSec,
            this.colOgrNo,
            this.colOgrAdi,
            this.colDersKodu,
            this.colDersAdi,
            this.colDersDurum});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // colOnaylanacakSec
            // 
            this.colOnaylanacakSec.HeaderText = "Öğrenci Onayla";
            this.colOnaylanacakSec.Name = "colOnaylanacakSec";
            // 
            // colOgrNo
            // 
            this.colOgrNo.HeaderText = "Öğrenci Numarası";
            this.colOgrNo.Name = "colOgrNo";
            this.colOgrNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOgrNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colOgrAdi
            // 
            this.colOgrAdi.HeaderText = "Öğrenci Adi";
            this.colOgrAdi.Name = "colOgrAdi";
            // 
            // colDersKodu
            // 
            this.colDersKodu.HeaderText = "Ders Kodu";
            this.colDersKodu.Name = "colDersKodu";
            // 
            // colDersAdi
            // 
            this.colDersAdi.HeaderText = "Ders Adi";
            this.colDersAdi.Name = "colDersAdi";
            // 
            // colDersDurum
            // 
            this.colDersDurum.HeaderText = "Ders Durumu";
            this.colDersDurum.Name = "colDersDurum";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKonu,
            this.ColTarih});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(326, 521);
            this.dataGridView3.TabIndex = 0;
            // 
            // timerMesaj
            // 
            this.timerMesaj.Interval = 10000;
            this.timerMesaj.Tick += new System.EventHandler(this.timerMesaj_Tick);
            // 
            // ColKonu
            // 
            this.ColKonu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColKonu.HeaderText = "Konu";
            this.ColKonu.Name = "ColKonu";
            this.ColKonu.ReadOnly = true;
            // 
            // ColTarih
            // 
            this.ColTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTarih.HeaderText = "Tarih";
            this.ColTarih.Name = "ColTarih";
            this.ColTarih.ReadOnly = true;
            // 
            // frmAkaSistemEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 567);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAkaSistemEkrani";
            this.Text = "Akademisyen Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAkaSistemEkrani_FormClosed);
            this.Load += new System.EventHandler(this.frmAkaSistemEkrani_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabAnaSayfa.ResumeLayout(false);
            this.tabAnaSayfa.PerformLayout();
            this.tabDersProgrami0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabDersOnay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem mesajKutusuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eskiMesajlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAnaSayfa;
        private System.Windows.Forms.TabPage tabDersProgrami0;
        private System.Windows.Forms.Timer timerMesaj;
        private System.Windows.Forms.TabPage tabDersOnay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colOnaylanacakSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOgrAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersDurum;
        private System.Windows.Forms.ToolStripMenuItem notGirişiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPazartesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSali;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarsamba;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersembe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuma;
        private System.Windows.Forms.ToolStripMenuItem devamsızlıkGirişiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKonu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTarih;
    }
}