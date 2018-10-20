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
    public partial class frmBilgiPersonelEkle : Form
    {
        public frmBilgiPersonelEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        Md5Sifrele md5 = new Md5Sifrele();

        int akaNo;

        private int PerNoOlustur()
        {
            sqlBaglan.BaglantiAc();
            string akaNo1;
            sqlBaglan.sorgu.Parameters.Clear();
            sqlBaglan.sorgu.CommandText = "SELECT akaNo FROM tbl_akademisyenler";
            sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
            Random rnd = new Random();
            akaNo1 = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + rnd.Next(10, 100);
            try
            {
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                while (sqlBaglan.dataReader.Read())
                {
                    if (sqlBaglan.dataReader["akaNo"].Equals(akaNo))
                    {
                        akaNo1 = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + rnd.Next(10, 100);
                    }
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

            akaNo = Int32.Parse(akaNo1);
            return akaNo;
        }

        private void frmBilgiPersonelEkle_Load(object sender, EventArgs e)
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.sorgu.Parameters.Clear();
            sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_bolumler";
            sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
            sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
            DataSet ds = new DataSet();
            sqlBaglan.da.Fill(ds);
            try
            {
                cboxBolum.Text = "Bölüm Seçiniz";
                cboxBolum.DataSource = ds.Tables[0];
                cboxBolum.DisplayMember = "bolumAdi";
                cboxBolum.ValueMember = "bolumKodu";
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

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtperAdi.Text == "" || txtperSoyadi.Text == "" || txtperTC.Text == "" || txtperTelefon.Text == "" || txtperAdres.Text == "")
                {
                    MessageBox.Show("Boş Alan Bırakamazsınız. Lütfen Tekrardan Kontrol Ediniz.");
                }
                else
                {
                    try
                    {
                        sqlBaglan.BaglantiAc();
                        int PersonelNo = PerNoOlustur();

                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu1.Parameters.Clear();

                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;

                        sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_bilgiIslem (bilgiNo,bilgiTC,bilgiAdi,bilgiSoyadi,bilgiBolum,bilgiTel,bilgiAdres) VALUES (@bilgiNo, @bilgiTC, @bilgiAdi, @bilgiSoyadi, @bilgiBolum, @bilgiTel, @bilgiAdres)";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiNo", PersonelNo);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiTC", txtperTC.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiAdi", txtperAdi.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiSoyadi", txtperSoyadi.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiTel", txtperTelefon.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiAdres", txtperAdres.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiBolum", cboxBolum.SelectedValue.ToString());

                        sqlBaglan.sorgu1.CommandText = "INSERT INTO tbl_bilgiIslemSistemi (bilgiNo,bilgiSifre,bilgiGiris,bilgiYetki) VALUES (@bilgiNo1, @bilgiSifre, @bilgiGiris, @bilgiYetki)";
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@bilgiNo1", PersonelNo);
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@bilgiSifre", md5.md5Sifrele(txtperTC.Text));
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@bilgiGiris", DateTime.Now);
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@bilgiYetki", 0);

                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        sqlBaglan.sorgu1.ExecuteNonQuery();
                        MessageBox.Show("Bilgi İşlem Personeli Kaydı Başarılı! - Bilgi İşlem Personeli Numarası : " + PersonelNo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                MessageBox.Show(ex.Message, " Message: {0}");
            }
            finally
            {
                sqlBaglan.BaglantiKapat();
            }
        }
    }
}
