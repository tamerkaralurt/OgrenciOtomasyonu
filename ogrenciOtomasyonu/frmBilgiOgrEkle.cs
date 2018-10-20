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
    public partial class frmBilgiOgrEkle : Form
    {
        int ogrNo;
        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        Md5Sifrele md5 = new Md5Sifrele();

        public frmBilgiOgrEkle()
        {
            InitializeComponent();
        }

        private void frmOgrEkle_Load(object sender, EventArgs e)
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.sorgu.Parameters.Clear();
            sqlBaglan.sorgu.CommandText = "SELECT bolumKodu,bolumAdi FROM tbl_bolumler";
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

        private int OgrNoOlustur()
        {
            string ogrNo1;
            Random rnd = new Random();
            ogrNo1 = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + rnd.Next(10, 100);
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.CommandText = "SELECT ogrNo FROM tbl_ogrenciler";
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                while (sqlBaglan.dataReader.Read())
                {
                    if (sqlBaglan.dataReader["ogrNo"].Equals(ogrNo))
                    {
                        ogrNo1 = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + rnd.Next(10, 100);
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

            ogrNo = Int32.Parse(ogrNo1);
            return ogrNo;
        }

        private void btnOgrenciKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtogrAdi.Text == "" || txtogrSoyadi.Text == "" || txtogrTC.Text == "" || txtogrTelefon.Text == "" || txtogrAdres.Text == "")
                {
                    MessageBox.Show("Boş Alan Bırakamazsınız. Lütfen Tekrardan Kontrol Ediniz.");
                }
                else
                {
                    try
                    {
                        sqlBaglan.BaglantiAc();
                        int OgrenciNo = OgrNoOlustur();

                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu1.Parameters.Clear();

                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;

                        sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_ogrenciler (ogrNo,ogrTC,ogrAdi,ogrSoyadi,ogrTel,ogrAdres,ogrBolum,ogrGNO,ogrSinif) VALUES (@ogrNo, @ogrTC, @ogrAdi, @ogrSoyadi, @ogrTel, @ogrAdres, @ogrBolum, @ogrGNO, @ogrSinif)";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", OgrenciNo);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrTC", txtogrTC.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrAdi", txtogrAdi.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrSoyadi", txtogrSoyadi.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrTel", txtogrTelefon.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrAdres", txtogrAdres.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrBolum", cboxBolum.SelectedValue.ToString());
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrGNO", 0);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrSinif", 1);

                        sqlBaglan.sorgu1.CommandText = "INSERT INTO tbl_ogrenciSistem (ogrNo,ogrSifre,ogrGiris,ogrYetki) VALUES (@ogrNo1, @ogrSifre, @ogrGiris, @ogrYetki)";
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@ogrNo1", OgrenciNo);
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@ogrSifre", md5.md5Sifrele(txtogrTC.Text));
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@ogrGiris", DateTime.Now);
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@ogrYetki", 0);

                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        sqlBaglan.sorgu1.ExecuteNonQuery();
                        MessageBox.Show("Öğrenci Kaydı Başarılı! - Öğrenci Numarası : " + OgrenciNo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Böyle bir TC si olan öğrenci zaten var!");
                    }
                    finally
                    {
                        sqlBaglan.BaglantiKapat();
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
