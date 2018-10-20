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
    public partial class frmBilgiAkaEkle : Form
    {

        int akaNo;
        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        Md5Sifrele md5 = new Md5Sifrele();

        public frmBilgiAkaEkle()
        {
            InitializeComponent();
        }

        private int AkaNoOlustur()
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

        private void frmBilgiAkaEkle_Load(object sender, EventArgs e)
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

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
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
                        int AkademisyenNo = AkaNoOlustur();

                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_akademisyenler (akaNo,akaTC,akaAdi,akaSoyadi,akaTel,akaAdres,akaBolum) VALUES (@akaNo, @akaTC, @akaAdi, @akaSoyadi, @akaTel, @akaAdres, @akaBolum)";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", AkademisyenNo);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaTC", txtogrTC.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaAdi", txtogrAdi.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaSoyadi", txtogrSoyadi.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaTel", txtogrTelefon.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaAdres", txtogrAdres.Text);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaBolum", cboxBolum.SelectedValue.ToString());

                        sqlBaglan.sorgu1.Parameters.Clear();
                        sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu1.CommandText = "INSERT INTO tbl_akademisyenSistem (akaNo,akaSifre,akaGiris,akaYetki) VALUES (@akaNo1, @akaSifre, @akaGiris, @akaYetki)";
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@akaNo1", AkademisyenNo);
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@akaSifre", md5.md5Sifrele(txtogrTC.Text));
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@akaGiris", DateTime.Now);
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@akaYetki", 0);

                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        sqlBaglan.sorgu1.ExecuteNonQuery();
                        MessageBox.Show("Akademisyen Kaydı Başarılı! - Akademisyen No : " + AkademisyenNo.ToString());
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
