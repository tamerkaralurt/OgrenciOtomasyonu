namespace ogrenciOtomasyonu
{
    partial class frmOgrMesajGonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrMesajGonder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrKime = new System.Windows.Forms.TextBox();
            this.txtOgrKonu = new System.Windows.Forms.TextBox();
            this.txtOgrMesaj = new System.Windows.Forms.TextBox();
            this.btnOgrMesajGonder = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Konu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mesaj : ";
            // 
            // txtOgrKime
            // 
            this.txtOgrKime.Location = new System.Drawing.Point(57, 6);
            this.txtOgrKime.Name = "txtOgrKime";
            this.txtOgrKime.ReadOnly = true;
            this.txtOgrKime.Size = new System.Drawing.Size(456, 20);
            this.txtOgrKime.TabIndex = 3;
            // 
            // txtOgrKonu
            // 
            this.txtOgrKonu.Location = new System.Drawing.Point(57, 29);
            this.txtOgrKonu.Name = "txtOgrKonu";
            this.txtOgrKonu.Size = new System.Drawing.Size(456, 20);
            this.txtOgrKonu.TabIndex = 4;
            // 
            // txtOgrMesaj
            // 
            this.txtOgrMesaj.Location = new System.Drawing.Point(57, 54);
            this.txtOgrMesaj.Multiline = true;
            this.txtOgrMesaj.Name = "txtOgrMesaj";
            this.txtOgrMesaj.Size = new System.Drawing.Size(456, 143);
            this.txtOgrMesaj.TabIndex = 5;
            // 
            // btnOgrMesajGonder
            // 
            this.btnOgrMesajGonder.Location = new System.Drawing.Point(57, 203);
            this.btnOgrMesajGonder.Name = "btnOgrMesajGonder";
            this.btnOgrMesajGonder.Size = new System.Drawing.Size(456, 46);
            this.btnOgrMesajGonder.TabIndex = 6;
            this.btnOgrMesajGonder.Text = "Mesajı Gönder";
            this.btnOgrMesajGonder.UseVisualStyleBackColor = true;
            this.btnOgrMesajGonder.Click += new System.EventHandler(this.btnOgrMesajGonder_Click);
            // 
            // frmOgrMesajGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 273);
            this.Controls.Add(this.btnOgrMesajGonder);
            this.Controls.Add(this.txtOgrMesaj);
            this.Controls.Add(this.txtOgrKonu);
            this.Controls.Add(this.txtOgrKime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOgrMesajGonder";
            this.Text = "Öğrenci Mesaj Gönderme";
            this.Load += new System.EventHandler(this.frmOgrMesajGonder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrKime;
        private System.Windows.Forms.TextBox txtOgrKonu;
        private System.Windows.Forms.TextBox txtOgrMesaj;
        private System.Windows.Forms.Button btnOgrMesajGonder;
    }
}