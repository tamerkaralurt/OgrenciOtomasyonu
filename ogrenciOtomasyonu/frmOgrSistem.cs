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
    public partial class frmOgrSistem : Form
    {
        public frmOgrSistem()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        Md5Sifrele md5 = new Md5Sifrele();
        public static string OgrenciNo;
        /* BURAYI SILME - BASLANGIC*/
        private void frmOgrSistem_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

                if (txtOgrNo.Text == "" || txtSifre.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
                }
                else
                {
                    try
                    {
                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_ogrenciSistem WHERE ogrNo=@ogrNo";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", txtOgrNo.Text);
                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {

                            if (sqlBaglan.dataReader["ogrSifre"].Equals(md5.md5Sifrele(txtSifre.Text)))
                            {
                                OgrenciNo = txtOgrNo.Text;
                                frmOgrSistemEkrani frmOgrSistemEkrani = new frmOgrSistemEkrani();
                                frmOgrSistemEkrani.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı Bulunamadı veya Yanlış Şifre Kullanımı");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Böyle Bir Öğrenci Bulunamadı!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata : " + ex.Message);
                    }
                    finally
                    {
                        sqlBaglan.BaglantiKapat();
                    }
                }
        }
        /* BURAYI SILME - BITIS */
    }
}
