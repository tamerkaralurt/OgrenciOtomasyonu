namespace ogrenciOtomasyonu
{
    partial class frmBilgiHarfSisEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilgiHarfSisEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboxOgrEkle = new System.Windows.Forms.GroupBox();
            this.btnHarfEkle = new System.Windows.Forms.Button();
            this.txtharfDegeri = new System.Windows.Forms.TextBox();
            this.txtharfAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gboxOgrEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gboxOgrEkle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 120);
            this.panel1.TabIndex = 1;
            // 
            // gboxOgrEkle
            // 
            this.gboxOgrEkle.Controls.Add(this.btnHarfEkle);
            this.gboxOgrEkle.Controls.Add(this.txtharfDegeri);
            this.gboxOgrEkle.Controls.Add(this.txtharfAdi);
            this.gboxOgrEkle.Controls.Add(this.label2);
            this.gboxOgrEkle.Controls.Add(this.label1);
            this.gboxOgrEkle.ForeColor = System.Drawing.Color.White;
            this.gboxOgrEkle.Location = new System.Drawing.Point(3, 3);
            this.gboxOgrEkle.Name = "gboxOgrEkle";
            this.gboxOgrEkle.Size = new System.Drawing.Size(343, 113);
            this.gboxOgrEkle.TabIndex = 0;
            this.gboxOgrEkle.TabStop = false;
            this.gboxOgrEkle.Text = "Harfli Not Ekle";
            // 
            // btnHarfEkle
            // 
            this.btnHarfEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHarfEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHarfEkle.Location = new System.Drawing.Point(119, 63);
            this.btnHarfEkle.Name = "btnHarfEkle";
            this.btnHarfEkle.Size = new System.Drawing.Size(211, 41);
            this.btnHarfEkle.TabIndex = 20;
            this.btnHarfEkle.Text = "KAYDET";
            this.btnHarfEkle.UseVisualStyleBackColor = false;
            this.btnHarfEkle.Click += new System.EventHandler(this.btnHarfEkle_Click);
            // 
            // txtharfDegeri
            // 
            this.txtharfDegeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtharfDegeri.Location = new System.Drawing.Point(119, 37);
            this.txtharfDegeri.Name = "txtharfDegeri";
            this.txtharfDegeri.Size = new System.Drawing.Size(211, 20);
            this.txtharfDegeri.TabIndex = 14;
            // 
            // txtharfAdi
            // 
            this.txtharfAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtharfAdi.Location = new System.Drawing.Point(119, 13);
            this.txtharfAdi.Name = "txtharfAdi";
            this.txtharfAdi.Size = new System.Drawing.Size(211, 20);
            this.txtharfAdi.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Harfli Notun Değeri : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Harfli Notun Adı : ";
            // 
            // frmBilgiHarfSisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(375, 143);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBilgiHarfSisEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not - Harf Sistemi Düzenleme Ekleme";
            this.Load += new System.EventHandler(this.frmBilgiHarfSisEkle_Load);
            this.panel1.ResumeLayout(false);
            this.gboxOgrEkle.ResumeLayout(false);
            this.gboxOgrEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gboxOgrEkle;
        private System.Windows.Forms.Button btnHarfEkle;
        private System.Windows.Forms.TextBox txtharfDegeri;
        private System.Windows.Forms.TextBox txtharfAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}