namespace ogrenciOtomasyonu
{
    partial class frmAkaMesajGecmisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAkaMesajGecmisi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colAkaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOgrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMesaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNerdenNereye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKonu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKime = new System.Windows.Forms.Label();
            this.lblKimden = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.timerMesaj = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAkaNo,
            this.colOgrNo,
            this.colKonu,
            this.colMesaj,
            this.colTarih,
            this.colDurum,
            this.colNerdenNereye,
            this.colID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 306);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // colAkaNo
            // 
            this.colAkaNo.HeaderText = "Akademisyen Numarası";
            this.colAkaNo.Name = "colAkaNo";
            this.colAkaNo.ReadOnly = true;
            // 
            // colOgrNo
            // 
            this.colOgrNo.HeaderText = "Öğrenci Numarası";
            this.colOgrNo.Name = "colOgrNo";
            this.colOgrNo.ReadOnly = true;
            // 
            // colKonu
            // 
            this.colKonu.HeaderText = "Konu";
            this.colKonu.Name = "colKonu";
            this.colKonu.ReadOnly = true;
            // 
            // colMesaj
            // 
            this.colMesaj.HeaderText = "Mesaj";
            this.colMesaj.Name = "colMesaj";
            this.colMesaj.ReadOnly = true;
            // 
            // colTarih
            // 
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.ReadOnly = true;
            // 
            // colDurum
            // 
            this.colDurum.HeaderText = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.ReadOnly = true;
            // 
            // colNerdenNereye
            // 
            this.colNerdenNereye.HeaderText = "Kimden";
            this.colNerdenNereye.Name = "colNerdenNereye";
            this.colNerdenNereye.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblKonu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTarih);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDurum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMesaj);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblKime);
            this.panel1.Controls.Add(this.lblKimden);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 259);
            this.panel1.TabIndex = 1;
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Location = new System.Drawing.Point(410, 55);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(75, 13);
            this.lblKonu.TabIndex = 12;
            this.lblKonu.Text = "Mesaj Seçiniz.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Konu : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cevapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(409, 33);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(75, 13);
            this.lblTarih.TabIndex = 9;
            this.lblTarih.Text = "Mesaj Seçiniz.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tarih : ";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(409, 11);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(75, 13);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "Mesaj Seçiniz.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mesaj Durumu : ";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(12, 73);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.ReadOnly = true;
            this.txtMesaj.Size = new System.Drawing.Size(623, 174);
            this.txtMesaj.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mesaj : ";
            // 
            // lblKime
            // 
            this.lblKime.AutoSize = true;
            this.lblKime.Location = new System.Drawing.Point(70, 33);
            this.lblKime.Name = "lblKime";
            this.lblKime.Size = new System.Drawing.Size(75, 13);
            this.lblKime.TabIndex = 3;
            this.lblKime.Text = "Mesaj Seçiniz.";
            // 
            // lblKimden
            // 
            this.lblKimden.AutoSize = true;
            this.lblKimden.Location = new System.Drawing.Point(70, 11);
            this.lblKimden.Name = "lblKimden";
            this.lblKimden.Size = new System.Drawing.Size(75, 13);
            this.lblKimden.TabIndex = 2;
            this.lblKimden.Text = "Mesaj Seçiniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kime : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kimden : ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(744, 569);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 2;
            // 
            // timerMesaj
            // 
            this.timerMesaj.Enabled = true;
            this.timerMesaj.Interval = 10000;
            this.timerMesaj.Tick += new System.EventHandler(this.timerMesaj_Tick);
            // 
            // frmAkaMesajGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(744, 569);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmAkaMesajGecmisi";
            this.Text = "Akademisyen Mesaj Geçmişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAkaMesajGecmisi_FormClosing);
            this.Load += new System.EventHandler(this.frmAkaMesajGecmisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKime;
        private System.Windows.Forms.Label lblKimden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerMesaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAkaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKonu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNerdenNereye;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label label6;
    }
}