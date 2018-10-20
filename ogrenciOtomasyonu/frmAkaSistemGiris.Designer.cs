namespace ogrenciOtomasyonu
{
    partial class frmAkaSistemGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAkaSistemGiris));
            this.txtAkaNo = new System.Windows.Forms.TextBox();
            this.txtAkaSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAkaGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAkaNo
            // 
            this.txtAkaNo.Location = new System.Drawing.Point(137, 47);
            this.txtAkaNo.Name = "txtAkaNo";
            this.txtAkaNo.Size = new System.Drawing.Size(214, 20);
            this.txtAkaNo.TabIndex = 0;
            // 
            // txtAkaSifre
            // 
            this.txtAkaSifre.Location = new System.Drawing.Point(137, 73);
            this.txtAkaSifre.Name = "txtAkaSifre";
            this.txtAkaSifre.PasswordChar = '*';
            this.txtAkaSifre.Size = new System.Drawing.Size(214, 20);
            this.txtAkaSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Akademisyen No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Akademisyen Şifre : ";
            // 
            // btnAkaGiris
            // 
            this.btnAkaGiris.Location = new System.Drawing.Point(137, 99);
            this.btnAkaGiris.Name = "btnAkaGiris";
            this.btnAkaGiris.Size = new System.Drawing.Size(214, 59);
            this.btnAkaGiris.TabIndex = 4;
            this.btnAkaGiris.Text = "Sisteme Giriş";
            this.btnAkaGiris.UseVisualStyleBackColor = true;
            this.btnAkaGiris.Click += new System.EventHandler(this.btnAkaGiris_Click);
            // 
            // frmAkaSistemGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 230);
            this.Controls.Add(this.btnAkaGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAkaSifre);
            this.Controls.Add(this.txtAkaNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAkaSistemGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akademisyen Sistemi Giriş";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAkaSistem_FormClosed);
            this.Load += new System.EventHandler(this.frmAkaSistemGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAkaNo;
        private System.Windows.Forms.TextBox txtAkaSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAkaGiris;
    }
}