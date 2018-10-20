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
    public partial class frmBilgiDersEkle : Form
    {
        public frmBilgiDersEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        private void frmBilgiDersEkle_Load(object sender, EventArgs e)
        {
            try
            {
                cboxDoldur();
                cboxHocaDoldur();
                cboxDersSecmeli.Text = "ZORUNLU";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxDoldur()
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

        private void cboxHocaDoldur()
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.sorgu.Parameters.Clear();
            sqlBaglan.sorgu.CommandText = "SELECT akaNo,akaAdi + ' ' + akaSoyadi AS adSoyad FROM tbl_akademisyenler";
            sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
            sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
            DataSet ds = new DataSet();
            sqlBaglan.da.Fill(ds);
            try
            {
                cboxHoca.Text = "Hoca Seçiniz";
                cboxHoca.DataSource = ds.Tables[0];
                cboxHoca.DisplayMember = "adSoyad";
                cboxHoca.ValueMember = "akaNo";
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

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdersKodu.Text == "" || txtdersAdi.Text == "" || txtdersKredi.Text == "" || txtdersSinif.Text == "")
                {
                    MessageBox.Show("Boş Alan Bırakamazsınız. Lütfen Tekrardan Kontrol Ediniz.");
                }
                else
                {
                    try
                    {
                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu1.Parameters.Clear();
                        sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_dersler (dersKodu,dersAdi,dersKredi,dersSinif,dersBolum,dersSecmeli) VALUES (@dersKodu, @dersAdi, @dersKredi, @dersSinif, @dersBolum,@dersSecmeli)";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@dersKodu", txtdersKodu.Text.Trim());
                        sqlBaglan.sorgu.Parameters.AddWithValue("@dersAdi", txtdersAdi.Text.Trim());
                        sqlBaglan.sorgu.Parameters.AddWithValue("@dersKredi", txtdersKredi.Text.Trim());
                        sqlBaglan.sorgu.Parameters.AddWithValue("@dersSinif", txtdersSinif.Text.Trim());
                        sqlBaglan.sorgu.Parameters.AddWithValue("@dersBolum", cboxBolum.SelectedValue.ToString().Trim());
                        if (cboxDersSecmeli.Text.Equals("ZORUNLU"))
                        {
                            sqlBaglan.sorgu.Parameters.AddWithValue("@dersSecmeli", 0);
                        }
                        else
                        {
                            sqlBaglan.sorgu.Parameters.AddWithValue("@dersSecmeli", 2);
                        }
                        sqlBaglan.sorgu1.CommandText = "INSERT INTO tbl_dersAkademisyen (akaNo,dersKodu) VALUES (@akaNo,@dersKodu)";
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@dersKodu", txtdersKodu.Text.Trim());
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@akaNo", cboxHoca.SelectedValue.ToString().Trim());
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        sqlBaglan.sorgu1.ExecuteNonQuery();
                        MessageBox.Show("Ders Kaydı Başarılı!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlBaglan.BaglantiKapat();
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu1.Parameters.Clear();
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
