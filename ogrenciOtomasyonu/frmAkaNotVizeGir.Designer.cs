﻿namespace ogrenciOtomasyonu
{
    partial class frmAkaNotVizeGir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAkaNotVizeGir));
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colOgrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOgrAdiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOgrSinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxVizeOnay = new System.Windows.Forms.CheckBox();
            this.btnVizeGir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOgrNo,
            this.colOgrAdiSoyadi,
            this.colOgrSinif,
            this.colDersKodu,
            this.colDersAdi,
            this.colVize});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // colOgrNo
            // 
            this.colOgrNo.HeaderText = "Öğrenci No";
            this.colOgrNo.Name = "colOgrNo";
            this.colOgrNo.ReadOnly = true;
            // 
            // colOgrAdiSoyadi
            // 
            this.colOgrAdiSoyadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOgrAdiSoyadi.HeaderText = "Adı Soyadı";
            this.colOgrAdiSoyadi.Name = "colOgrAdiSoyadi";
            this.colOgrAdiSoyadi.ReadOnly = true;
            // 
            // colOgrSinif
            // 
            this.colOgrSinif.HeaderText = "Sınıf";
            this.colOgrSinif.Name = "colOgrSinif";
            this.colOgrSinif.ReadOnly = true;
            this.colOgrSinif.Width = 87;
            // 
            // colDersKodu
            // 
            this.colDersKodu.HeaderText = "Ders Kodu";
            this.colDersKodu.Name = "colDersKodu";
            this.colDersKodu.ReadOnly = true;
            this.colDersKodu.Width = 87;
            // 
            // colDersAdi
            // 
            this.colDersAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDersAdi.HeaderText = "Ders Adi";
            this.colDersAdi.Name = "colDersAdi";
            this.colDersAdi.ReadOnly = true;
            // 
            // colVize
            // 
            this.colVize.HeaderText = "Vizesi";
            this.colVize.Name = "colVize";
            // 
            // cboxVizeOnay
            // 
            this.cboxVizeOnay.AutoSize = true;
            this.cboxVizeOnay.Location = new System.Drawing.Point(12, 478);
            this.cboxVizeOnay.Name = "cboxVizeOnay";
            this.cboxVizeOnay.Size = new System.Drawing.Size(207, 17);
            this.cboxVizeOnay.TabIndex = 1;
            this.cboxVizeOnay.Text = "Notları Kontrol Ettim İşlemi Onaylıyorum";
            this.cboxVizeOnay.UseVisualStyleBackColor = true;
            // 
            // btnVizeGir
            // 
            this.btnVizeGir.Location = new System.Drawing.Point(12, 501);
            this.btnVizeGir.Name = "btnVizeGir";
            this.btnVizeGir.Size = new System.Drawing.Size(889, 41);
            this.btnVizeGir.TabIndex = 2;
            this.btnVizeGir.Text = "Vize Gir";
            this.btnVizeGir.UseVisualStyleBackColor = true;
            this.btnVizeGir.Click += new System.EventHandler(this.btnVizeGir_Click);
            // 
            // frmAkaNotVizeGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(913, 554);
            this.Controls.Add(this.btnVizeGir);
            this.Controls.Add(this.cboxVizeOnay);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAkaNotVizeGir";
            this.Text = "Akademisyen Vize Giriş Ekranı";
            this.Load += new System.EventHandler(this.frmAkaNotVizeGir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOgrAdiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOgrSinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVize;
        private System.Windows.Forms.CheckBox cboxVizeOnay;
        private System.Windows.Forms.Button btnVizeGir;
    }
}