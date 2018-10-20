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
    public partial class frmBilgiAkaDuzenle : Form
    {
        public frmBilgiAkaDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        string akaNo;

        private void frmBilgiAkaDuzenle_Load(object sender, EventArgs e)
        {
            panelOgrDuzenle.Enabled = false;
            gboxOgrDuzenle.Enabled = false;
            txtAraAkaAdi.Enabled = false;
            txtAraAkaSoyadi.Enabled = false;
            txtAraAkaTC.Enabled = false;
            txtAraAkaNo.Enabled = true;
            rbAkaNo.Checked = true;
            txtAraAkaNo.Focus();
        }

        private void rbAkaNo_CheckedChanged(object sender, EventArgs e)
        {
            txtAraAkaAdi.Enabled = false;
            txtAraAkaSoyadi.Enabled = false;
            txtAraAkaTC.Enabled = false;
            txtAraAkaNo.Enabled = true;
            txtAraAkaNo.Focus();
        }

        private void rbAkaTC_CheckedChanged(object sender, EventArgs e)
        {
            txtAraAkaAdi.Enabled = false;
            txtAraAkaSoyadi.Enabled = false;
            txtAraAkaTC.Enabled = true;
            txtAraAkaNo.Enabled = false;
            txtAraAkaTC.Focus();
        }

        private void rbAkaAdi_CheckedChanged(object sender, EventArgs e)
        {
            txtAraAkaAdi.Enabled = true;
            txtAraAkaSoyadi.Enabled = false;
            txtAraAkaTC.Enabled = false;
            txtAraAkaNo.Enabled = false;
            txtAraAkaAdi.Focus();
        }

        private void rbAkaSoyadi_CheckedChanged(object sender, EventArgs e)
        {
            txtAraAkaAdi.Enabled = false;
            txtAraAkaSoyadi.Enabled = true;
            txtAraAkaTC.Enabled = false;
            txtAraAkaNo.Enabled = false;
            txtAraAkaSoyadi.Focus();
        }

        private void cboxDoldur()
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.sorgu1.Parameters.Clear();
            sqlBaglan.dataReader.Close();
            sqlBaglan.sorgu1.CommandText = "SELECT bolumKodu,bolumAdi,bolumBaskani FROM tbl_bolumler";
            sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
            sqlBaglan.da = new System.Data.SqlClient.SqlDataAdapter(sqlBaglan.sorgu1);
            DataSet ds = new DataSet();
            sqlBaglan.da.Fill(ds);
            try
            {
                cboxDuzenleAkaBolum.Text            = "Bölüm Seçiniz";
                cboxDuzenleAkaBolum.DataSource      = ds.Tables[0];
                cboxDuzenleAkaBolum.DisplayMember   = "bolumAdi";
                cboxDuzenleAkaBolum.ValueMember     = "bolumKodu";
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

        private void btnAkaAra_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                string akaTC;
                string akaAdi;
                string akaSoyadi;
                string akaTel;
                string akaAdres;
                string akaBolum;
                //baglan.sorgu = new SqlCommand();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;

                if (rbAkaNo.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_akademisyenler aka INNER JOIN tbl_bolumler bol ON aka.akaBolum = bol.bolumKodu WHERE akaNo = @akaNo";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", txtAraAkaNo.Text);

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["akaNo"].ToString().Equals(txtAraAkaNo.Text))
                                {
                                    akaNo       = sqlBaglan.dataReader["akaNo"].ToString();
                                    akaTC       = sqlBaglan.dataReader["akaTC"].ToString();
                                    akaAdi      = sqlBaglan.dataReader["akaAdi"].ToString();
                                    akaSoyadi   = sqlBaglan.dataReader["akaSoyadi"].ToString();
                                    akaTel      = sqlBaglan.dataReader["akaTel"].ToString();
                                    akaAdres    = sqlBaglan.dataReader["akaAdres"].ToString();
                                    akaBolum    = sqlBaglan.dataReader["bolumAdi"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    cboxDoldur();

                                    txtDuzenleAkaTC.Text = akaTC;
                                    txtDuzenleAkaAdi.Text = akaAdi;
                                    txtDuzenleAkaSoyadi.Text = akaSoyadi;
                                    txtDuzenleAkaTel.Text = akaTel;
                                    txtDuzenleAkaAdres.Text = akaAdres;
                                    cboxDuzenleAkaBolum.Text = akaBolum;
                                    lblAkaNo.Text = akaNo;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arama Sonucu : Böyle Bir Akademisyen Numarası Bulunamadı!");
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
                else if (rbAkaTC.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_akademisyenler aka INNER JOIN tbl_bolumler bol ON aka.akaBolum = bol.bolumKodu WHERE akaTC = @akaTC";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaTC", txtAraAkaTC.Text);

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["akaTC"].ToString().Equals(txtAraAkaTC.Text))
                                {
                                    akaNo       = sqlBaglan.dataReader["akaNo"].ToString();
                                    akaTC       = sqlBaglan.dataReader["akaTC"].ToString();
                                    akaAdi      = sqlBaglan.dataReader["akaAdi"].ToString();
                                    akaSoyadi   = sqlBaglan.dataReader["akaSoyadi"].ToString();
                                    akaTel      = sqlBaglan.dataReader["akaTel"].ToString();
                                    akaAdres    = sqlBaglan.dataReader["akaAdres"].ToString();
                                    akaBolum    = sqlBaglan.dataReader["bolumAdi"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    cboxDoldur();

                                    txtDuzenleAkaTC.Text = akaTC;
                                    txtDuzenleAkaAdi.Text = akaAdi;
                                    txtDuzenleAkaSoyadi.Text = akaSoyadi;
                                    txtDuzenleAkaTel.Text = akaTel;
                                    txtDuzenleAkaAdres.Text = akaAdres;
                                    cboxDuzenleAkaBolum.Text = akaBolum;
                                    lblAkaNo.Text = akaNo;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arama Sonucu : Böyle Bir Akademisyen TC Bulunamadı!");
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
                else if (rbAkaAdi.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_akademisyenler aka INNER JOIN tbl_bolumler bol ON aka.akaBolum = bol.bolumKodu WHERE akaAdi = @akaAdi";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaAdi", txtAraAkaAdi.Text);

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["akaAdi"].ToString().Equals(txtAraAkaAdi.Text))
                                {
                                    akaNo       = sqlBaglan.dataReader["akaNo"].ToString();
                                    akaTC       = sqlBaglan.dataReader["akaTC"].ToString();
                                    akaAdi      = sqlBaglan.dataReader["akaAdi"].ToString();
                                    akaSoyadi   = sqlBaglan.dataReader["akaSoyadi"].ToString();
                                    akaTel      = sqlBaglan.dataReader["akaTel"].ToString();
                                    akaAdres    = sqlBaglan.dataReader["akaAdres"].ToString();
                                    akaBolum    = sqlBaglan.dataReader["bolumAdi"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    cboxDoldur();

                                    txtDuzenleAkaTC.Text = akaTC;
                                    txtDuzenleAkaAdi.Text = akaAdi;
                                    txtDuzenleAkaSoyadi.Text = akaSoyadi;
                                    txtDuzenleAkaTel.Text = akaTel;
                                    txtDuzenleAkaAdres.Text = akaAdres;
                                    cboxDuzenleAkaBolum.Text = akaBolum;
                                    lblAkaNo.Text = akaNo;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arama Sonucu : Böyle Bir Akademisyen Adı Bulunamadı!");
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
                else if (rbAkaSoyadi.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_akademisyenler aka INNER JOIN tbl_bolumler bol ON aka.akaBolum = bol.bolumKodu WHERE akaSoyadi = @akaSoyadi";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaSoyadi", txtAraAkaSoyadi.Text);

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["akaSoyadi"].ToString().Equals(txtAraAkaSoyadi.Text))
                                {
                                    akaNo       = sqlBaglan.dataReader["akaNo"].ToString();
                                    akaTC       = sqlBaglan.dataReader["akaTC"].ToString();
                                    akaAdi      = sqlBaglan.dataReader["akaAdi"].ToString();
                                    akaSoyadi   = sqlBaglan.dataReader["akaSoyadi"].ToString();
                                    akaTel      = sqlBaglan.dataReader["akaTel"].ToString();
                                    akaAdres    = sqlBaglan.dataReader["akaAdres"].ToString();
                                    akaBolum    = sqlBaglan.dataReader["bolumAdi"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    cboxDoldur();

                                    txtDuzenleAkaTC.Text = akaTC;
                                    txtDuzenleAkaAdi.Text = akaAdi;
                                    txtDuzenleAkaSoyadi.Text = akaSoyadi;
                                    txtDuzenleAkaTel.Text = akaTel;
                                    txtDuzenleAkaAdres.Text = akaAdres;
                                    cboxDuzenleAkaBolum.Text = akaBolum;
                                    lblAkaNo.Text = akaNo;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arama Sonucu : Böyle Bir Akademisyen Soyadi Bulunamadı!");
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

        private void btnAkaSil_Click(object sender, EventArgs e)
        {
            if (cbDuzenleAkaSil.Checked)
            {
                if (MessageBox.Show("Akademisyeni Gerçekten Silmek İstiyor musunuz?", "Öğrenci Otomasyonu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    try
                    {
                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu1.Parameters.Clear();
                        sqlBaglan.sorgu1.CommandText = "DELETE FROM tbl_akademisyenSistem WHERE akaNo = @akaNo";
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@akaNo", akaNo);
                        sqlBaglan.sorgu.CommandText = "DELETE FROM tbl_akademisyenler WHERE akaNo = @akaNo";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", akaNo);
                        sqlBaglan.sorgu1.ExecuteNonQuery();
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        MessageBox.Show("Akademisyen Silindi!");
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
                    MessageBox.Show("Akademisyen Silinmedi!");
                }
            }
            else
            {
                MessageBox.Show("Akademisyen Silmek İçin Onaylamanız Gerekmektedir!");
            }
        }

        private void btnAkaDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDuzenleAkaDuzenle.Checked)
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "UPDATE tbl_akademisyenler SET akaTC=@akaTC, akaAdi=@akaAdi, akaSoyadi=@akaSoyadi, akaTel=@akaTel, akaAdres=@akaAdres, akaBolum=@akaBolum WHERE akaNo=@akaNo";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", akaNo.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@akaTC", txtDuzenleAkaTC.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@akaAdi", txtDuzenleAkaAdi.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@akaSoyadi", txtDuzenleAkaSoyadi.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@akaTel", txtDuzenleAkaTel.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@akaAdres", txtDuzenleAkaAdres.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@akaBolum", cboxDuzenleAkaBolum.SelectedValue.ToString().Trim());
                    sqlBaglan.sorgu.ExecuteNonQuery();
                    MessageBox.Show("Akademisyen Düzenlendi!");
                }
                else
                {
                    MessageBox.Show("Akademisyen Düzenlemek İçin Onayınız Gerekmektedir!");
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
