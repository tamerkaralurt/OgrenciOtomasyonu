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
    public partial class frmBilgiPersonelDuzenle : Form
    {
        public frmBilgiPersonelDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        string bilgiNo;

        private void frmBilgiPersonelDuzenle_Load(object sender, EventArgs e)
        {
            panelOgrDuzenle.Enabled = false;
            gboxOgrDuzenle.Enabled = false;
            txtAraPerAdi.Enabled = false;
            txtAraPerSoyadi.Enabled = false;
            txtAraPerTC.Enabled = false;
            txtAraPerNo.Enabled = true;
            rbPerNo.Checked = true;
            txtAraPerNo.Focus();
        }

        private void rbPerNo_CheckedChanged(object sender, EventArgs e)
        {
            txtAraPerAdi.Enabled = false;
            txtAraPerSoyadi.Enabled = false;
            txtAraPerTC.Enabled = false;
            txtAraPerNo.Enabled = true;
            txtAraPerNo.Focus();
        }

        private void rbPerTC_CheckedChanged(object sender, EventArgs e)
        {
            txtAraPerAdi.Enabled = false;
            txtAraPerSoyadi.Enabled = false;
            txtAraPerTC.Enabled = true;
            txtAraPerNo.Enabled = false;
            txtAraPerTC.Focus();
        }

        private void rbPerAdi_CheckedChanged(object sender, EventArgs e)
        {
            txtAraPerAdi.Enabled = true;
            txtAraPerSoyadi.Enabled = false;
            txtAraPerTC.Enabled = false;
            txtAraPerNo.Enabled = false;
            txtAraPerAdi.Focus();
        }

        private void rbPerSoyadi_CheckedChanged(object sender, EventArgs e)
        {
            txtAraPerAdi.Enabled = false;
            txtAraPerSoyadi.Enabled = true;
            txtAraPerTC.Enabled = false;
            txtAraPerNo.Enabled = false;
            txtAraPerSoyadi.Focus();
        }

        private void btnPerAra_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                string bilgiTC;
                string bilgiAdi;
                string bilgiSoyadi;
                string bilgiTel;
                string bilgiAdres;
                string bilgiBolum;
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;

                if (rbPerNo.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_bilgiIslem bil INNER JOIN tbl_bolumler bol ON bil.bilgiBolum = bol.bolumKodu WHERE bilgiNo = @bilgiNo";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiNo", txtAraPerNo.Text);

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["bilgiNo"].ToString().Equals(txtAraPerNo.Text))
                                {
                                    bilgiNo = sqlBaglan.dataReader["bilgiNo"].ToString();
                                    bilgiTC = sqlBaglan.dataReader["bilgiTC"].ToString();
                                    bilgiAdi = sqlBaglan.dataReader["bilgiAdi"].ToString();
                                    bilgiSoyadi = sqlBaglan.dataReader["bilgiSoyadi"].ToString();
                                    bilgiTel = sqlBaglan.dataReader["bilgiTel"].ToString();
                                    bilgiAdres = sqlBaglan.dataReader["bilgiAdres"].ToString();
                                    bilgiBolum = sqlBaglan.dataReader["bilgiBolum"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    cboxDoldur();

                                    txtDuzenlePerTC.Text = bilgiTC;
                                    txtDuzenlePerAdi.Text = bilgiAdi;
                                    txtDuzenlePerSoyadi.Text = bilgiSoyadi;
                                    txtDuzenlePerTel.Text = bilgiTel;
                                    txtDuzenlePerAdres.Text = bilgiAdres;
                                    cboxDuzenlePerBolum.Text = bilgiBolum;
                                    lblPerNo.Text = bilgiNo;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arama Sonucu : Böyle Bir Personel Numarası Bulunamadı!");
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
                else if (rbPerTC.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_bilgiIslem bil INNER JOIN tbl_bolumler bol ON bil.bilgiBolum = bol.bolumKodu WHERE bilgiTC = @bilgiTC";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiTC", txtAraPerTC.Text);

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["bilgiTC"].ToString().Equals(txtAraPerTC.Text))
                                {
                                    bilgiNo = sqlBaglan.dataReader["bilgiNo"].ToString();
                                    bilgiTC = sqlBaglan.dataReader["bilgiTC"].ToString();
                                    bilgiAdi = sqlBaglan.dataReader["bilgiAdi"].ToString();
                                    bilgiSoyadi = sqlBaglan.dataReader["bilgiSoyadi"].ToString();
                                    bilgiTel = sqlBaglan.dataReader["bilgiTel"].ToString();
                                    bilgiAdres = sqlBaglan.dataReader["bilgiAdres"].ToString();
                                    bilgiBolum = sqlBaglan.dataReader["bilgiBolum"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    cboxDoldur();

                                    txtDuzenlePerTC.Text = bilgiTC;
                                    txtDuzenlePerAdi.Text = bilgiAdi;
                                    txtDuzenlePerSoyadi.Text = bilgiSoyadi;
                                    txtDuzenlePerTel.Text = bilgiTel;
                                    txtDuzenlePerAdres.Text = bilgiAdres;
                                    cboxDuzenlePerBolum.Text = bilgiBolum;
                                    lblPerNo.Text = bilgiNo;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arama Sonucu : Böyle Bir Personel TC Bulunamadı!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Böyle Bir Arama Sonucu Bulunamadı!", ex.Message);
                    }
                    finally
                    {
                        sqlBaglan.BaglantiKapat();
                    }

                }
                else if (rbPerAdi.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_bilgiIslem bil INNER JOIN tbl_bolumler bol ON bil.bilgiBolum = bol.bolumKodu WHERE bilgiAdi = @bilgiAdi";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiAdi", txtAraPerAdi.Text);

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["bilgiAdi"].ToString().Equals(txtAraPerAdi.Text))
                                {
                                    bilgiNo = sqlBaglan.dataReader["bilgiNo"].ToString();
                                    bilgiTC = sqlBaglan.dataReader["bilgiTC"].ToString();
                                    bilgiAdi = sqlBaglan.dataReader["bilgiAdi"].ToString();
                                    bilgiSoyadi = sqlBaglan.dataReader["bilgiSoyadi"].ToString();
                                    bilgiTel = sqlBaglan.dataReader["bilgiTel"].ToString();
                                    bilgiAdres = sqlBaglan.dataReader["bilgiAdres"].ToString();
                                    bilgiBolum = sqlBaglan.dataReader["bilgiBolum"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    cboxDoldur();

                                    txtDuzenlePerTC.Text = bilgiTC;
                                    txtDuzenlePerAdi.Text = bilgiAdi;
                                    txtDuzenlePerSoyadi.Text = bilgiSoyadi;
                                    txtDuzenlePerTel.Text = bilgiTel;
                                    txtDuzenlePerAdres.Text = bilgiAdres;
                                    cboxDuzenlePerBolum.Text = bilgiBolum;
                                    lblPerNo.Text = bilgiNo;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arama Sonucu : Böyle Bir Personel Adı Bulunamadı!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Böyle Bir Arama Sonucu Bulunamadı!", ex.Message);
                    }
                    finally
                    {
                        sqlBaglan.BaglantiKapat();
                    }

                }
                else if (rbPerSoyadi.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_bilgiIslem bil INNER JOIN tbl_bolumler bol ON bil.bilgiBolum = bol.bolumKodu WHERE bilgiSoyadi = @bilgiSoyadi";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiSoyadi", txtAraPerSoyadi.Text);

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["bilgiSoyadi"].ToString().Equals(txtAraPerSoyadi.Text))
                                {
                                    bilgiNo = sqlBaglan.dataReader["bilgiNo"].ToString();
                                    bilgiTC = sqlBaglan.dataReader["bilgiTC"].ToString();
                                    bilgiAdi = sqlBaglan.dataReader["bilgiAdi"].ToString();
                                    bilgiSoyadi = sqlBaglan.dataReader["bilgiSoyadi"].ToString();
                                    bilgiTel = sqlBaglan.dataReader["bilgiTel"].ToString();
                                    bilgiAdres = sqlBaglan.dataReader["bilgiAdres"].ToString();
                                    bilgiBolum = sqlBaglan.dataReader["bilgiBolum"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    cboxDoldur();

                                    txtDuzenlePerTC.Text = bilgiTC;
                                    txtDuzenlePerAdi.Text = bilgiAdi;
                                    txtDuzenlePerSoyadi.Text = bilgiSoyadi;
                                    txtDuzenlePerTel.Text = bilgiTel;
                                    txtDuzenlePerAdres.Text = bilgiAdres;
                                    cboxDuzenlePerBolum.Text = bilgiBolum;
                                    lblPerNo.Text = bilgiNo;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arama Sonucu : Böyle Bir Personel Soyadi Bulunamadı!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Böyle Bir Arama Sonucu Bulunamadı!", ex.Message);
                    }
                    finally
                    {
                        sqlBaglan.BaglantiKapat();
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

        private void cboxDoldur()
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.dataReader.Close();
            sqlBaglan.sorgu1.Parameters.Clear();
            sqlBaglan.sorgu1.CommandText = "SELECT bolumKodu,bolumAdi,bolumBaskani FROM tbl_bolumler";
            sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
            sqlBaglan.da.SelectCommand = sqlBaglan.sorgu1;
            DataSet ds = new DataSet();
            sqlBaglan.da.Fill(ds);
            try
            {
                cboxDuzenlePerBolum.Text = "Bölüm Seçiniz";
                cboxDuzenlePerBolum.DataSource = ds.Tables[0];
                cboxDuzenlePerBolum.DisplayMember = "bolumAdi";
                cboxDuzenlePerBolum.ValueMember = "bolumKodu";
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

        private void btnPerSil_Click(object sender, EventArgs e)
        {
            if (cbDuzenlePerSil.Checked)
            {
                if (MessageBox.Show("Personeli Gerçekten Silmek İstiyor musunuz?", "Öğrenci Otomasyonu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    try
                    {
                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu1.Parameters.Clear();
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu1.CommandText = "DELETE FROM tbl_bilgiIslemSistemi WHERE bilgiNo = @bilgiNo";
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@bilgiNo", bilgiNo);
                        sqlBaglan.sorgu.CommandText = "DELETE FROM tbl_bilgiIslem WHERE bilgiNo = @bilgiNo";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiNo", bilgiNo);
                        sqlBaglan.sorgu1.ExecuteNonQuery();
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        MessageBox.Show("Personel Silindi!");
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
                    MessageBox.Show("Personel Silinmedi!");
                }
            }
            else
            {
                MessageBox.Show("Personeli Silmek İçin Onaylamanız Gerekmektedir!");
            }
        }

        private void btnPerDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDuzenlePerDuzenle.Checked)
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "UPDATE tbl_bilgiIslem SET bilgiTC=@bilgiTC, bilgiAdi=@bilgiAdi, bilgiSoyadi=@bilgiSoyadi, bilgiTel=@bilgiTel, bilgiAdres=@bilgiAdres, bilgiBolum=@bilgiBolum WHERE bilgiNo=@bilgiNo";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiNo", bilgiNo.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiTC", txtDuzenlePerTC.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiAdi", txtDuzenlePerAdi.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiSoyadi", txtDuzenlePerSoyadi.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiTel", txtDuzenlePerTel.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiAdres", txtDuzenlePerAdres.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiBolum", cboxDuzenlePerBolum.SelectedValue.ToString().Trim());
                    sqlBaglan.sorgu.ExecuteNonQuery();
                    MessageBox.Show("Personel Düzenlendi!");
                }
                else
                {
                    MessageBox.Show("Personeli Düzenlemek İçin Onayınız Gerekmektedir!");
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
