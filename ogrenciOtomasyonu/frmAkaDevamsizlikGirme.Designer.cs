namespace ogrenciOtomasyonu
{
    partial class frmAkaDevamsizlikGirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAkaDevamsizlikGirme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colOgrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOgrAdiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOgrSinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDevTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDevamsizlik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnDevamGir = new System.Windows.Forms.Button();
            this.cboxDevamsizlik = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDersSec = new System.Windows.Forms.Button();
            this.comboxDersSec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.colDevTarih,
            this.colDevamsizlik});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 504);
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
            this.colOgrAdiSoyadi.HeaderText = "Öğrenci Adı Soyadı";
            this.colOgrAdiSoyadi.Name = "colOgrAdiSoyadi";
            this.colOgrAdiSoyadi.ReadOnly = true;
            // 
            // colOgrSinif
            // 
            this.colOgrSinif.HeaderText = "Sınıfı";
            this.colOgrSinif.Name = "colOgrSinif";
            this.colOgrSinif.ReadOnly = true;
            // 
            // colDevTarih
            // 
            this.colDevTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDevTarih.HeaderText = "Tarih";
            this.colDevTarih.Name = "colDevTarih";
            this.colDevTarih.ReadOnly = true;
            // 
            // colDevamsizlik
            // 
            this.colDevamsizlik.HeaderText = "Devamsızlık";
            this.colDevamsizlik.Items.AddRange(new object[] {
            "GELDI",
            "GELMEDI"});
            this.colDevamsizlik.Name = "colDevamsizlik";
            // 
            // btnDevamGir
            // 
            this.btnDevamGir.Enabled = false;
            this.btnDevamGir.Location = new System.Drawing.Point(12, 553);
            this.btnDevamGir.Name = "btnDevamGir";
            this.btnDevamGir.Size = new System.Drawing.Size(774, 45);
            this.btnDevamGir.TabIndex = 1;
            this.btnDevamGir.Text = "Devamsızlıkları Gir";
            this.btnDevamGir.UseVisualStyleBackColor = true;
            this.btnDevamGir.Click += new System.EventHandler(this.btnDevamGir_Click);
            // 
            // cboxDevamsizlik
            // 
            this.cboxDevamsizlik.AutoSize = true;
            this.cboxDevamsizlik.Enabled = false;
            this.cboxDevamsizlik.Location = new System.Drawing.Point(12, 530);
            this.cboxDevamsizlik.Name = "cboxDevamsizlik";
            this.cboxDevamsizlik.Size = new System.Drawing.Size(217, 17);
            this.cboxDevamsizlik.TabIndex = 2;
            this.cboxDevamsizlik.Text = "Devamsızlıkları Kontrol Ettim Onaylıyorum";
            this.cboxDevamsizlik.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnDersSec);
            this.panel1.Controls.Add(this.comboxDersSec);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(62, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 131);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(520, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnDersSec
            // 
            this.btnDersSec.Location = new System.Drawing.Point(58, 69);
            this.btnDersSec.Name = "btnDersSec";
            this.btnDersSec.Size = new System.Drawing.Size(520, 43);
            this.btnDersSec.TabIndex = 4;
            this.btnDersSec.Text = "Dersi Seç";
            this.btnDersSec.UseVisualStyleBackColor = true;
            this.btnDersSec.Click += new System.EventHandler(this.btnDersSec_Click);
            // 
            // comboxDersSec
            // 
            this.comboxDersSec.FormattingEnabled = true;
            this.comboxDersSec.Location = new System.Drawing.Point(58, 16);
            this.comboxDersSec.Name = "comboxDersSec";
            this.comboxDersSec.Size = new System.Drawing.Size(520, 21);
            this.comboxDersSec.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders : ";
            // 
            // frmAkaDevamsizlikGirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboxDevamsizlik);
            this.Controls.Add(this.btnDevamGir);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAkaDevamsizlikGirme";
            this.Text = "Akademisyen Devamsızlık Girme Ekranı";
            this.Load += new System.EventHandler(this.frmAkaDevamsizlikGirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDevamGir;
        private System.Windows.Forms.CheckBox cboxDevamsizlik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDersSec;
        private System.Windows.Forms.ComboBox comboxDersSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOgrAdiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOgrSinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDevTarih;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDevamsizlik;
    }
}