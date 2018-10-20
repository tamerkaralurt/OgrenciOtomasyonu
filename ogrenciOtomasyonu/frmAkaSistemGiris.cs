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
    public partial class frmAkaSistemGiris : Form
    {
        public frmAkaSistemGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        Md5Sifrele Md5Sifre = new Md5Sifrele();

        public static string AkaNoGonder;
        public static string AkaBolGonder;

        private void frmAkaSistem_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void frmAkaSistemGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnAkaGiris_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_akademisyenSistem akaSis INNER JOIN tbl_akademisyenler aka ON aka.akaNo = akaSis.akaNo WHERE akaSis.akaNo = @akaNo";
                sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", txtAkaNo.Text);
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                if (sqlBaglan.dataReader.Read())
                {
                    if (sqlBaglan.dataReader["akaSifre"].Equals(Md5Sifre.md5Sifrele(txtAkaSifre.Text)))
                    {
                        AkaNoGonder = txtAkaNo.Text;
                        AkaBolGonder = sqlBaglan.dataReader["akaBolum"].ToString();
                        frmAkaSistemEkrani frmAkaSistemEkrani = new frmAkaSistemEkrani();
                        frmAkaSistemEkrani.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Şifre Hatalı!");
                    }
                }
                else
                {
                    MessageBox.Show("Akademisyen Numarası Hatalı veya Böyle Bir Akademisyen Bulunmamaktadır.");
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
    }
}
