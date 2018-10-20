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
    public partial class frmBilgiIslem : Form
    {

        public frmBilgiIslem()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        private void refOgr()
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                string ogrCount;
                string maxGNO;

                try
                {
                    sqlBaglan.sorgu.CommandText = "SELECT COUNT(1) AS sayiOgr, MAX(ogrGNO) AS maxGNO FROM tbl_ogrenciler";
                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    if (sqlBaglan.dataReader.Read())
                    {
                        ogrCount            = sqlBaglan.dataReader["sayiOgr"].ToString();
                        maxGNO              = sqlBaglan.dataReader["maxGNO"].ToString();
                        lblToplamOgr.Text   = ogrCount;
                        lblEnYukGNO.Text    = maxGNO;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void refDers()
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                string dersAdi, dersKredi, dersBolum, dersSinif,dersKodu;
                int toplamDers = 0;

                try
                {
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_dersler";
                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    if (sqlBaglan.dataReader.Read())
                    {
                        sqlBaglan.dataReader.Close();
                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        dataGridView2.Rows.Clear();
                        while (sqlBaglan.dataReader.Read())
                        {
                            toplamDers++;
                            dersKodu        = sqlBaglan.dataReader["dersKodu"].ToString();
                            dersAdi         = sqlBaglan.dataReader["dersAdi"].ToString();
                            dersKredi       = sqlBaglan.dataReader["dersKredi"].ToString();
                            dersBolum       = sqlBaglan.dataReader["dersBolum"].ToString();
                            dersSinif       = sqlBaglan.dataReader["dersSinif"].ToString();
                            int n = dataGridView2.Rows.Add();
                            dataGridView2.Rows[n].Cells[0].Value = dersKodu;
                            dataGridView2.Rows[n].Cells[1].Value = dersAdi;
                            dataGridView2.Rows[n].Cells[2].Value = dersKredi;
                            dataGridView2.Rows[n].Cells[3].Value = dersBolum;
                            dataGridView2.Rows[n].Cells[4].Value = dersSinif;
                        }

                        lblToplamDers.Text = toplamDers.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Arama Sonucu : Böyle Bir Harfli Not Adı Bulunamadı!");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlBaglan.BaglantiKapat();
            }
        }

        private void refBol()
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                string bolAdi, bolKodu, bolBaskani;
                int toplamBolum = 0;

                try
                {
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_bolumler";

                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    if (sqlBaglan.dataReader.Read())
                    {
                        sqlBaglan.dataReader.Close();
                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        dataGridView1.Rows.Clear();
                        while (sqlBaglan.dataReader.Read())
                        {
                            toplamBolum++;
                            bolAdi      = sqlBaglan.dataReader["bolumKodu"].ToString();
                            bolKodu     = sqlBaglan.dataReader["bolumAdi"].ToString();
                            bolBaskani  = sqlBaglan.dataReader["bolumBaskani"].ToString();
                            int n = dataGridView1.Rows.Add();
                            dataGridView1.Rows[n].Cells[0].Value = bolKodu;
                            dataGridView1.Rows[n].Cells[1].Value = bolAdi;
                            dataGridView1.Rows[n].Cells[2].Value = bolBaskani;
                        }

                        lblToplamBolum.Text = toplamBolum.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Arama Sonucu : Sistemde Kayıtlı Bölüm Bulunamadı!");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlBaglan.BaglantiKapat();
            }
        }

        private void refAka()
        {
            try
            {
                if (sqlBaglan.baglan.State != ConnectionState.Open) { sqlBaglan.baglan.Open(); }
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                string akaCount;

                try
                {
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "SELECT COUNT(1) AS sayiAka FROM tbl_akademisyenler";
                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    if (sqlBaglan.dataReader.Read())
                    {
                        akaCount            = sqlBaglan.dataReader["sayiAka"].ToString(); ;
                        lblToplamAka.Text   = akaCount;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlBaglan.BaglantiKapat();
            }
        }

        private void refNotlar()
        {
            try
            {
                if (sqlBaglan.baglan.State != ConnectionState.Open) { sqlBaglan.baglan.Open(); }
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                string harfAdi, harfNotu;
                int toplamHarfliNotlar = 0;

                try
                {
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_harfSistemi";

                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    if (sqlBaglan.dataReader.Read())
                    {
                        sqlBaglan.dataReader.Close();
                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        lboxHarfliNotlar.Items.Clear();
                        lboxHarfliNotlar.Items.Add("HARF ADI - HARF DEĞERİ");
                        while (sqlBaglan.dataReader.Read())
                        {
                            toplamHarfliNotlar++;
                            harfAdi     = sqlBaglan.dataReader["harfAdi"].ToString();
                            harfNotu    = sqlBaglan.dataReader["harfNotu"].ToString();
                            lboxHarfliNotlar.Items.Add(harfAdi + " - " + harfNotu);
                        }

                        lblToplamHarfliNotlar.Text = toplamHarfliNotlar.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Arama Sonucu : Böyle Bir Harfli Not Adı Bulunamadı!");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlBaglan.BaglantiKapat();
            }
        }

        private void frmBilgiIslem_Load(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Visible = false;
            tsslblBilgiNoAdi.Text = frmBilgiGiris.bilgiNoAdi;
        }

        private void frmBilgiIslem_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBilgiOgrEkle frmOgrEkle = new frmBilgiOgrEkle();
            frmOgrEkle.Show();
        }

        private void düzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBilgiAyarlar frmAyarlar = new frmBilgiAyarlar();
            frmAyarlar.Show();
        }

        private void düzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBilgiOgrDuzenle frmOgrDuzenle = new frmBilgiOgrDuzenle();
            frmOgrDuzenle.Show();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBilgiAkaEkle frmBilgiAkaEkle = new frmBilgiAkaEkle();
            frmBilgiAkaEkle.Show();
        }

        private void ekleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmBilgiAyarlar frmBilgiAyarlar = new frmBilgiAyarlar();
            frmBilgiAyarlar.Show();
        }

        private void düzenlemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBilgiAkaDuzenle frmBilgiAkaDuzenle = new frmBilgiAkaDuzenle();
            frmBilgiAkaDuzenle.Show();
        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBilgiPersonelEkle frmBilgiPersonelEkle = new frmBilgiPersonelEkle();
            frmBilgiPersonelEkle.Show();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBilgiPersonelDuzenle frmBilgiPersonelDuzenle = new frmBilgiPersonelDuzenle();
            frmBilgiPersonelDuzenle.Show();
        }

        private void ekleToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmBilgiHarfSisEkle frmBilgiHarfSisEkle = new frmBilgiHarfSisEkle();
            frmBilgiHarfSisEkle.Show();
        }

        private void düzenleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBilgiHarfSisDuzenle frmBilgiHarfSisDuzenle = new frmBilgiHarfSisDuzenle();
            frmBilgiHarfSisDuzenle.Show();
        }

        private void btnRefOgr_Click(object sender, EventArgs e)
        {
            refOgr();
        }

        private void btnRefBol_Click(object sender, EventArgs e)
        {
            refBol();
        }

        private void btnRefAka_Click(object sender, EventArgs e)
        {
            refAka();
        }

        private void btnRefDers_Click(object sender, EventArgs e)
        {
            refDers();
        }

        private void btnRefNotlar_Click(object sender, EventArgs e)
        {
            refNotlar();
        }

        private void ekleToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmBilgiBolumEkle frmBilgiBolumEkle = new frmBilgiBolumEkle();
            frmBilgiBolumEkle.Show();
        }

        private void düzenleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBilgiBolumDuzenle frmBilgiBolumDuzenle = new frmBilgiBolumDuzenle();
            frmBilgiBolumDuzenle.Show();
        }

        private void ekleToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmBilgiDersEkle frmBilgiDersEkle = new frmBilgiDersEkle();
            frmBilgiDersEkle.Show();
        }

        private void düzenleSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBilgiDersDuzenle frmBilgiDersDuzenle = new frmBilgiDersDuzenle();
            frmBilgiDersDuzenle.Show();
        }
    }
}
