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
    public partial class frmBilgiBolumEkle : Form
    {
        public frmBilgiBolumEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        private void frmBilgiBolumEkle_Load(object sender, EventArgs e)
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.sorgu.Parameters.Clear();
            sqlBaglan.sorgu.CommandText = "SELECT akaAdi+ ' ' +akaSoyadi AS ADSOYAD FROM tbl_akademisyenler";
            sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
            sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
            DataSet ds = new DataSet();
            sqlBaglan.da.Fill(ds);
            try
            {
                cboxBolumBaskani.Text = "Bölüm Seçiniz";
                cboxBolumBaskani.DataSource = ds.Tables[0];
                cboxBolumBaskani.DisplayMember = "ADSOYAD";
                cboxBolumBaskani.ValueMember = "ADSOYAD";
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

        private void btnBolumKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbolumKodu.Text == "" || txtbolumAdi.Text == "")
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
                        sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_bolumler (bolumKodu,bolumAdi,bolumBaskani) VALUES (@bolumKodu, @bolumAdi, @bolumBaskani)";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bolumKodu", txtbolumKodu.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bolumAdi", txtbolumAdi.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bolumBaskani", cboxBolumBaskani.SelectedValue.ToString());
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        MessageBox.Show("Bölüm Kaydı Başarılı!");
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
