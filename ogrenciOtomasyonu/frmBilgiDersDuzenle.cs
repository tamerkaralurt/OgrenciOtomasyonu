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
    public partial class frmBilgiDersDuzenle : Form
    {
        public frmBilgiDersDuzenle()
        {
            InitializeComponent();
        }

        string dersID;
        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        private void cboxDoldur()
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.sorgu1.Parameters.Clear();
            sqlBaglan.sorgu1.CommandText = "SELECT bolumKodu,bolumAdi FROM tbl_bolumler";
            sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
            sqlBaglan.da.SelectCommand = sqlBaglan.sorgu1;
            DataSet ds = new DataSet();
            sqlBaglan.da.Fill(ds);
            try
            {
                cboxDuzenleDersBolum.Text = "Bölüm Seçiniz";
                cboxDuzenleDersBolum.DataSource = ds.Tables[0];
                cboxDuzenleDersBolum.DisplayMember = "bolumAdi";
                cboxDuzenleDersBolum.ValueMember = "bolumKodu";
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

        private void cboxDoldurAka()
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.sorgu1.Parameters.Clear();
            sqlBaglan.sorgu1.CommandText = "SELECT akaNo,akaAdi + ' ' + akaSoyadi AS adSoyad FROM tbl_akademisyenler";
            sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
            sqlBaglan.da.SelectCommand = sqlBaglan.sorgu1;
            DataSet ds = new DataSet();
            sqlBaglan.da.Fill(ds);
            try
            {
                cboxDersHocasi.Text = "Bölüm Seçiniz";
                cboxDersHocasi.DataSource = ds.Tables[0];
                cboxDersHocasi.DisplayMember = "adSoyad";
                cboxDersHocasi.ValueMember = "akaNo";
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

        private void btndersAra_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                string dersKodu, dersAdi, dersKredi, dersBolum, dersSinif, dersAka, dersAkaAdiSoyadi;
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;

                if (rbdersKodu.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_dersler ders INNER JOIN tbl_bolumler bolum ON ders.dersBolum = bolum.bolumKodu INNER JOIN tbl_dersAkademisyen akaDers ON akaders.dersKodu = ders.dersKodu INNER JOIN tbl_akademisyenler aka ON aka.akaNo=akaDers.akaNo WHERE ders.dersKodu = @dersKodu";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@dersKodu", txtAraDersKodu.Text);

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["dersKodu"].ToString().Equals(txtAraDersKodu.Text))
                                {
                                    dersID              = sqlBaglan.dataReader["id"].ToString();
                                    dersKodu            = sqlBaglan.dataReader["dersKodu"].ToString();
                                    dersAdi             = sqlBaglan.dataReader["dersAdi"].ToString();
                                    dersKredi           = sqlBaglan.dataReader["dersKredi"].ToString();
                                    dersBolum           = sqlBaglan.dataReader["bolumAdi"].ToString();
                                    dersSinif           = sqlBaglan.dataReader["dersSinif"].ToString();
                                    dersAka             = sqlBaglan.dataReader["akaNo"].ToString();
                                    dersAkaAdiSoyadi    = sqlBaglan.dataReader["akaAdi"].ToString() + " " + sqlBaglan.dataReader["akaSoyadi"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    sqlBaglan.dataReader.Close();
                                    cboxDoldur();

                                    sqlBaglan.dataReader.Close();
                                    cboxDoldurAka();

                                    txtDuzenleDersKodu.Text     = dersKodu;
                                    txtDuzenleDersAdi.Text      = dersAdi;
                                    txtDuzenleDersKredi.Text    = dersKredi;
                                    txtDuzenleDersSinif.Text    = dersSinif;
                                    cboxDuzenleDersBolum.Text   = dersBolum;
                                    cboxDersHocasi.Text         = dersAkaAdiSoyadi;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arama Sonucu : Böyle Bir Ders Kodu Bulunamadı!");
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
                else if (rbdersAdi.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_dersler ders INNER JOIN tbl_bolumler bolum ON ders.dersBolum = bolum.bolumKodu INNER JOIN tbl_dersAkademisyen akaDers ON akaders.dersKodu = ders.dersKodu INNER JOIN tbl_akademisyenler aka ON aka.akaNo=akaDers.akaNo  WHERE ders.dersAdi = @dersAdi";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@dersAdi", txtAraDersAdi.Text.Trim());

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["dersAdi"].ToString().Equals(txtAraDersAdi.Text.Trim()))
                                {
                                    dersID = sqlBaglan.dataReader["id"].ToString();
                                    dersKodu = sqlBaglan.dataReader["dersKodu"].ToString();
                                    dersAdi = sqlBaglan.dataReader["dersAdi"].ToString();
                                    dersKredi = sqlBaglan.dataReader["dersKredi"].ToString();
                                    dersBolum = sqlBaglan.dataReader["bolumAdi"].ToString();
                                    dersSinif = sqlBaglan.dataReader["dersSinif"].ToString();
                                    dersAka = sqlBaglan.dataReader["akaNo"].ToString();
                                    dersAkaAdiSoyadi = sqlBaglan.dataReader["akaAdi"].ToString() + " " + sqlBaglan.dataReader["akaSoyadi"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    sqlBaglan.dataReader.Close();
                                    cboxDoldur();

                                    sqlBaglan.dataReader.Close();
                                    cboxDoldurAka();

                                    txtDuzenleDersKodu.Text = dersKodu;
                                    txtDuzenleDersAdi.Text = dersAdi;
                                    txtDuzenleDersKredi.Text = dersKredi;
                                    txtDuzenleDersSinif.Text = dersSinif;
                                    cboxDuzenleDersBolum.Text = dersBolum;
                                    cboxDersHocasi.Text = dersAkaAdiSoyadi;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arama Sonucu : Böyle Bir Ders Adı Bulunamadı!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Böyle Bir Arama Sonucu Bulunamadı!", ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Bir Arama Yöntemi Seçiniz!");
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

        private void rbdersKodu_CheckedChanged(object sender, EventArgs e)
        {
            txtAraDersKodu.Enabled = true;
            txtAraDersAdi.Enabled = false;
            txtAraDersKodu.Focus();
        }

        private void rbdersAdi_CheckedChanged(object sender, EventArgs e)
        {
            txtAraDersAdi.Enabled = true;
            txtAraDersKodu.Enabled = false;
            txtAraDersAdi.Focus();
        }

        private void btndersDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDuzenleDersDuzenle.Checked)
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu1.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "UPDATE tbl_dersler SET dersKodu=@dersKodu, dersAdi=@dersAdi, dersKredi=@dersKredi, dersBolum=@dersBolum, dersSinif=@dersSinif WHERE id=@id";
                    sqlBaglan.sorgu1.CommandText = "UPDATE tbl_dersAkademisyen SET dersKodu=@dersKodu, akaNo=@akaNo WHERE dersKodu=@dersKodu";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@id", dersID.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@dersKodu", txtDuzenleDersKodu.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@dersAdi", txtDuzenleDersAdi.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@dersKredi", txtDuzenleDersKredi.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@dersSinif", txtDuzenleDersSinif.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@dersBolum", cboxDuzenleDersBolum.SelectedValue.ToString().Trim());
                    sqlBaglan.sorgu1.Parameters.AddWithValue("@dersKodu", txtDuzenleDersKodu.Text.Trim());
                    sqlBaglan.sorgu1.Parameters.AddWithValue("@akaNo", cboxDersHocasi.SelectedValue.ToString().Trim());
                    sqlBaglan.sorgu.ExecuteNonQuery();
                    sqlBaglan.sorgu1.ExecuteNonQuery();
                    MessageBox.Show("Ders Düzenlendi!");
                }
                else
                {
                    MessageBox.Show("Bölümü Düzenlemek İçin Onayınız Gerekmektedir!");
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

        private void btndersSil_Click(object sender, EventArgs e)
        {
            if (cbDuzenleDersSil.Checked)
            {
                if (MessageBox.Show("Dersi Gerçekten Silmek İstiyor musunuz?", "Öğrenci Otomasyonu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    try
                    {
                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu.CommandText = "DELETE FROM tbl_dersler WHERE id = @id";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@id", dersID.Trim());
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        MessageBox.Show("Ders Silindi!");
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
                else
                {
                    MessageBox.Show("Ders Silinmedi!");
                }
            }
            else
            {
                MessageBox.Show("Dersi Silmek İçin Onaylamanız Gerekmektedir!");
            }
        }
    }
}
