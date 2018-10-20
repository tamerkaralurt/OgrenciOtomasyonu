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
    public partial class frmBilgiGiris : Form
    {

        public frmBilgiGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        Md5Sifrele md5 = new Md5Sifrele();
        string bilgiNo;
        public static string bilgiNoAdi;

        private string bilgiNoOlustur()
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.sorgu.Parameters.Clear();
            sqlBaglan.sorgu.CommandText = "SELECT bilgiNo FROM tbl_bilgiIslem";
            sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
            Random rnd = new Random();
            bilgiNo = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + rnd.Next(1, 100);
            try
            {
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                while (sqlBaglan.dataReader.Read())
                {
                    if (sqlBaglan.dataReader["bilgiNo"].Equals(bilgiNo))
                    {
                        bilgiNo = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + rnd.Next(1, 100);
                    }
                }
                sqlBaglan.dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
            finally
            {
                sqlBaglan.BaglantiKapat();
            }

            return bilgiNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKayitAdi.Text == "" || txtKayitAdres.Text == "" || txtKayitBolum.Text == "" || txtKayitSifre.Text == "" || txtKayitSoyadi.Text == "" || txtKayitTC.Text == "" || txtKayitTel.Text == "")
                {
                    MessageBox.Show("Boş Alan Bırakamazsınız Lütfen Tekrar Kontrol Ediniz.");
                }
                else
                {
                    if (txtKayitSifreOnay.Text.Equals(txtKayitSifre.Text))
                    {
                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu1.Parameters.Clear();
                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_bilgiIslem (bilgiNo,bilgiAdi,bilgiSoyadi,bilgiTC,bilgiBolum,bilgiTel,bilgiAdres) VALUES (@bilgiNo,@bilgiAdi,@bilgiSoyadi,@bilgiTC,@bilgiBolum,@bilgiTel,@bilgiAdres)";
                        sqlBaglan.sorgu1.CommandText = "INSERT INTO tbl_bilgiIslemSistemi (bilgiNo,bilgiSifre,bilgiGiris,bilgiYetki) VALUES (@bilgiNo,@bilgiSifre,@bilgiGiris,@bilgiYetki)";

                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiNo", bilgiNoOlustur());
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiAdi", txtKayitAdi.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiSoyadi", txtKayitSoyadi.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiTC", txtKayitTC.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiBolum", txtKayitBolum.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiTel", txtKayitTel.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiAdres", txtKayitAdres.Text);

                        sqlBaglan.sorgu1.Parameters.AddWithValue("@bilgiNo", bilgiNoOlustur());
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@bilgiSifre", md5.md5Sifrele(txtKayitSifre.Text));
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@bilgiGiris", DateTime.Now);
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@bilgiYetki", 0);

                        sqlBaglan.sorgu.ExecuteNonQuery();
                        sqlBaglan.sorgu1.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı!");
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor. Lütfen Tekrar Deneyiniz.");
                        MessageBox.Show(txtKayitSifre.Text.ToString() + " " + txtKayitSifreOnay.Text.ToString());
                    }
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

        private void frmBilgiGiris_Load(object sender, EventArgs e)
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.sorgu.Parameters.Clear();
            sqlBaglan.sorgu1.Parameters.Clear();
            sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_ayarlar";
            sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
            sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
            try
            {
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                if (sqlBaglan.dataReader.Read())
                {
                    if (sqlBaglan.dataReader["bilgiKayit"].Equals(0)) //bilgiKayit sistemine bilgi işlem personeli kaydi olacak mı?
                    {
                        groupBox2.Enabled = false;
                    }
                    else 
                    {
                        if (sqlBaglan.dataReader["bilgiKayit"].Equals(0)) 
                        {
                            sqlBaglan.sorgu.CommandText = "SELECT COUNT(*) AS SAYI FROM tbl_bilgiIslemSistemi";
                            sqlBaglan.dataReader = sqlBaglan.sorgu1.ExecuteReader();
                            if(sqlBaglan.dataReader["SAYI"].Equals(0)) groupBox2.Enabled = false;
                        }
                    } 
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

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            if (txtBilgiGirisNo.Text == "" || txtBilgiGirisSifre.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
            }
            else
            {
                try
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "SELECT bilSis.bilgiNo,bilIs.bilgiAdi,bilIs.bilgiSoyadi,bilSis.bilgiSifre FROM tbl_bilgiIslem bilIs INNER JOIN tbl_bilgiIslemSistemi bilSis ON bilIs.bilgiNo  = bilSis.bilgiNo WHERE bilIs.bilgiNo=@girisBilgiNo";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@girisBilgiNo", txtBilgiGirisNo.Text);
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    if (sqlBaglan.dataReader.Read())
                    {
                        if (sqlBaglan.dataReader["bilgiSifre"].Equals(md5.md5Sifrele(txtBilgiGirisSifre.Text)))
                        {

                            bilgiNoAdi = sqlBaglan.dataReader["bilgiNo"].ToString() + " - " + sqlBaglan.dataReader["bilgiAdi"].ToString() + " " + sqlBaglan.dataReader["bilgiSoyadi"].ToString();
                            sqlBaglan.sorgu1.Parameters.Clear();
                            sqlBaglan.sorgu1.CommandText = "UPDATE tbl_bilgiIslemSistemi SET bilgiGiris = @bilgiGiris WHERE bilgiNo = @bilgiNo";
                            sqlBaglan.sorgu1.Parameters.AddWithValue("@bilgiGiris", DateTime.Now);
                            sqlBaglan.sorgu1.Parameters.AddWithValue("@bilgiNo", sqlBaglan.dataReader["bilgiNo"]);
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                            sqlBaglan.sorgu1.ExecuteNonQuery();
                            frmBilgiIslem frmBilgiIslem = new frmBilgiIslem();
                            frmMain frmMain = new frmMain();
                            this.Hide();
                            frmBilgiIslem.Show();
                            frmMain.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Bulunamadı veya Yanlış Şifre Kullanımı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Böyle Bir Personel Bulunamadı!");
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

        private void frmBilgiGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Visible = true;
            frmMain.Show();
            this.Hide();
        }
    }
}
