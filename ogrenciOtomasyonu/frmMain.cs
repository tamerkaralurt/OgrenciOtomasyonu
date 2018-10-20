using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciOtomasyonu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            frmBilgiGiris frmBilgiGiris = new frmBilgiGiris();
            frmBilgiGiris.Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.sorgu.Parameters.Clear();
            sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_ayarlar";
            sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
            try
            {
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                if (sqlBaglan.dataReader.Read())
                {
                    if (sqlBaglan.dataReader["ogrGiris"].Equals(0)) btnOgrenciGiris.Enabled = false; //Öğr. Sisteme Girebilecek mi?
                    if (sqlBaglan.dataReader["akaGiris"].Equals(0)) btnAkaGiris.Enabled = false; //Aka. Sisteme Girebilecek mi?
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlBaglan.BaglantiKapat();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Otomasyonu Tamamen Kapatmak İstiyor musunuz?", "Öğrenci Otomasyonu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Dispose(true);
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            frmOgrSistem frmOgrSistem = new frmOgrSistem();
            frmOgrSistem.Show();
            this.Hide();
        }

        private void btnAkaGiris_Click(object sender, EventArgs e)
        {
            frmAkaSistemGiris frmAkaSistem = new frmAkaSistemGiris();
            frmAkaSistem.Show();
            this.Hide();
        }
    }
}
