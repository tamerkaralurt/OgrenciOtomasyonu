namespace ogrenciOtomasyonu
{
    partial class frmAkaNotGirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAkaNotGirme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colBolKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBolAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersSinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDersKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSinifNotGir = new System.Windows.Forms.Button();
            this.comBoxHangiNot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBolKodu,
            this.colBolAdi,
            this.colDersSinif,
            this.ColDersKodu,
            this.colDersAdi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // colBolKodu
            // 
            this.colBolKodu.HeaderText = "Bölüm Kodu";
            this.colBolKodu.Name = "colBolKodu";
            this.colBolKodu.ReadOnly = true;
            this.colBolKodu.Width = 87;
            // 
            // colBolAdi
            // 
            this.colBolAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBolAdi.HeaderText = "Bölüm Adı";
            this.colBolAdi.Name = "colBolAdi";
            this.colBolAdi.ReadOnly = true;
            // 
            // colDersSinif
            // 
            this.colDersSinif.HeaderText = "Sınıf";
            this.colDersSinif.Name = "colDersSinif";
            this.colDersSinif.ReadOnly = true;
            this.colDersSinif.Width = 50;
            // 
            // ColDersKodu
            // 
            this.ColDersKodu.HeaderText = "Ders Kodu";
            this.ColDersKodu.Name = "ColDersKodu";
            this.ColDersKodu.ReadOnly = true;
            this.ColDersKodu.Width = 87;
            // 
            // colDersAdi
            // 
            this.colDersAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDersAdi.HeaderText = "Ders Adı";
            this.colDersAdi.Name = "colDersAdi";
            this.colDersAdi.ReadOnly = true;
            // 
            // btnSinifNotGir
            // 
            this.btnSinifNotGir.Location = new System.Drawing.Point(12, 235);
            this.btnSinifNotGir.Name = "btnSinifNotGir";
            this.btnSinifNotGir.Size = new System.Drawing.Size(542, 49);
            this.btnSinifNotGir.TabIndex = 1;
            this.btnSinifNotGir.Text = "Sınıfa Not Gir";
            this.btnSinifNotGir.UseVisualStyleBackColor = true;
            this.btnSinifNotGir.Click += new System.EventHandler(this.btnSinifNotGir_Click);
            // 
            // comBoxHangiNot
            // 
            this.comBoxHangiNot.FormattingEnabled = true;
            this.comBoxHangiNot.Location = new System.Drawing.Point(126, 188);
            this.comBoxHangiNot.Name = "comBoxHangiNot";
            this.comBoxHangiNot.Size = new System.Drawing.Size(162, 21);
            this.comBoxHangiNot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hangi Not Girilecek : ";
            // 
            // frmAkaNotGirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(566, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBoxHangiNot);
            this.Controls.Add(this.btnSinifNotGir);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmAkaNotGirme";
            this.Text = "Akademisyen Notlama Ekranı";
            this.Load += new System.EventHandler(this.frmAkaNotGirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSinifNotGir;
        private System.Windows.Forms.ComboBox comBoxHangiNot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBolKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBolAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersSinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDersKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDersAdi;
    }
}