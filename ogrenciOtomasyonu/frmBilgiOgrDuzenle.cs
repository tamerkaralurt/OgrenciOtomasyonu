using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ogrenciOtomasyonu
{
    public partial class frmBilgiOgrDuzenle : Form
    {

        string ogrNo;
        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        public frmBilgiOgrDuzenle()
        {
            InitializeComponent();
        }

        private void frmOgrDuzenle_Load(object sender, EventArgs e)
        {
            panelOgrDuzenle.Enabled     = false;
            gboxOgrDuzenle.Enabled      = false;
            txtAraOgrAdi.Enabled        = false;
            txtAraOgrSoyadi.Enabled     = false;
            txtAraOgrTC.Enabled         = false;
            txtAraOgrNo.Enabled         = true;
            rbOgrNo.Checked             = true;
            txtAraOgrNo.Focus();
        }

        private void rbOgrNo_CheckedChanged(object sender, EventArgs e)
        {
            txtAraOgrAdi.Enabled        = false;
            txtAraOgrSoyadi.Enabled     = false;
            txtAraOgrTC.Enabled         = false;
            txtAraOgrNo.Enabled         = true;
            txtAraOgrNo.Focus();
        }

        private void rbOgrTC_CheckedChanged(object sender, EventArgs e)
        {
            txtAraOgrAdi.Enabled        = false;
            txtAraOgrSoyadi.Enabled     = false;
            txtAraOgrTC.Enabled         = true;
            txtAraOgrNo.Enabled         = false;
            txtAraOgrTC.Focus();
        }

        private void rbOgrAdi_CheckedChanged(object sender, EventArgs e)
        {
            txtAraOgrAdi.Enabled        = true;
            txtAraOgrSoyadi.Enabled     = false;
            txtAraOgrTC.Enabled         = false;
            txtAraOgrNo.Enabled         = false;
            txtAraOgrAdi.Focus();
        }

        private void rbOgrSoyadi_CheckedChanged(object sender, EventArgs e)
        {
            txtAraOgrAdi.Enabled        = false;
            txtAraOgrSoyadi.Enabled     = true;
            txtAraOgrTC.Enabled         = false;
            txtAraOgrNo.Enabled         = false;
            txtAraOgrSoyadi.Focus();
        }

        private void cboxDoldur()
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu1.Parameters.Clear();
                sqlBaglan.sorgu1.CommandText = "SELECT bolumKodu,bolumAdi FROM tbl_bolumler";
                sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                sqlBaglan.dataReader.Close();
                sqlBaglan.da.SelectCommand = sqlBaglan.sorgu1;
                DataSet ds = new DataSet();
                sqlBaglan.da.Fill(ds);
                cboxDuzenleOgrBolum.Text = "Bölüm Seçiniz";
                cboxDuzenleOgrBolum.DataSource = ds.Tables[0];
                cboxDuzenleOgrBolum.DisplayMember = "bolumAdi";
                cboxDuzenleOgrBolum.ValueMember = "bolumKodu";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                string ogrTC;
                string ogrAdi;
                string ogrSoyadi;
                string ogrTel;
                string ogrAdres;
                string ogrBolum;
                string ogrGNO;
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;

                if(rbOgrNo.Checked){
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_ogrenciler ogr INNER JOIN tbl_bolumler bol ON ogr.ogrBolum = bol.bolumKodu WHERE ogrNo = @ogrNo";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@OgrNo", txtAraOgrNo.Text);

                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    if (sqlBaglan.dataReader.Read())
                    {
                        sqlBaglan.dataReader.Close();
                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            if (sqlBaglan.dataReader["ogrNo"].ToString() == txtAraOgrNo.Text)
                            {
                                ogrNo       = sqlBaglan.dataReader["ogrNo"].ToString();
                                ogrTC       = sqlBaglan.dataReader["ogrTC"].ToString();
                                ogrAdi      = sqlBaglan.dataReader["ogrAdi"].ToString();
                                ogrSoyadi   = sqlBaglan.dataReader["ogrSoyadi"].ToString();
                                ogrTel      = sqlBaglan.dataReader["ogrTel"].ToString();
                                ogrAdres    = sqlBaglan.dataReader["ogrAdres"].ToString();
                                ogrBolum    = sqlBaglan.dataReader["bolumAdi"].ToString();
                                ogrGNO      = sqlBaglan.dataReader["ogrGNO"].ToString();

                                panelOgrDuzenle.Enabled     = true;
                                gboxOgrDuzenle.Enabled      = true;

                                cboxDoldur();

                                txtDuzenleOgrTC.Text = ogrTC;
                                txtDuzenleOgrAdi.Text = ogrAdi;
                                txtDuzenleOgrSoyadi.Text = ogrSoyadi;
                                txtDuzenleOgrTel.Text = ogrTel;
                                txtDuzenleOgrAdres.Text = ogrAdres;
                                cboxDuzenleOgrBolum.Text = ogrBolum;
                                txtDuzenleOgrGNO.Text = Math.Round(Convert.ToDouble(ogrGNO), 2).ToString();
                                lblOgrNo.Text = ogrNo;
                            }
                            else
                            {
                                MessageBox.Show(sqlBaglan.dataReader["ogrNo"].ToString());
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Arama Sonucu : Böyle Bir Öğrenci Numarası Bulunamadı!");
                    }
                }else if(rbOgrTC.Checked){
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_ogrenciler ogr INNER JOIN tbl_bolumler bol ON ogr.ogrBolum = bol.bolumKodu WHERE ogrTC = @ogrTC";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrTC", txtAraOgrTC.Text);

                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    if (sqlBaglan.dataReader.Read())
                    {
                        sqlBaglan.dataReader.Close();
                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            if (sqlBaglan.dataReader["ogrTC"].Equals(txtAraOgrTC.Text.Trim()))
                            {
                                ogrNo       = sqlBaglan.dataReader["ogrNo"].ToString();
                                ogrTC       = sqlBaglan.dataReader["ogrTC"].ToString();
                                ogrAdi      = sqlBaglan.dataReader["ogrAdi"].ToString();
                                ogrSoyadi   = sqlBaglan.dataReader["ogrSoyadi"].ToString();
                                ogrTel      = sqlBaglan.dataReader["ogrTel"].ToString();
                                ogrAdres    = sqlBaglan.dataReader["ogrAdres"].ToString();
                                ogrBolum    = sqlBaglan.dataReader["bolumAdi"].ToString();
                                ogrGNO      = sqlBaglan.dataReader["ogrGNO"].ToString();

                                panelOgrDuzenle.Enabled = true;
                                gboxOgrDuzenle.Enabled = true;

                                cboxDoldur();

                                txtDuzenleOgrTC.Text = ogrTC;
                                txtDuzenleOgrAdi.Text = ogrAdi;
                                txtDuzenleOgrSoyadi.Text = ogrSoyadi;
                                txtDuzenleOgrTel.Text = ogrTel;
                                txtDuzenleOgrAdres.Text = ogrAdres;
                                cboxDuzenleOgrBolum.Text = ogrBolum;
                                txtDuzenleOgrGNO.Text = Math.Round(Convert.ToDouble(ogrGNO), 2).ToString();
                                lblOgrNo.Text = ogrNo;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Arama Sonucu : Böyle Bir Öğrenci TC Bulunamadı!");
                    }

                }else if (rbOgrAdi.Checked) {
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_ogrenciler ogr INNER JOIN tbl_bolumler bol ON ogr.ogrBolum = bol.bolumKodu WHERE ogrAdi = @ogrAdi";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrAdi", txtAraOgrAdi.Text);

                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    if (sqlBaglan.dataReader.Read())
                    {
                        sqlBaglan.dataReader.Close();
                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            if (sqlBaglan.dataReader["ogrAdi"].Equals(txtAraOgrAdi.Text.Trim()))
                            {
                                ogrNo       = sqlBaglan.dataReader["ogrNo"].ToString();
                                ogrTC       = sqlBaglan.dataReader["ogrTC"].ToString();
                                ogrAdi      = sqlBaglan.dataReader["ogrAdi"].ToString();
                                ogrSoyadi   = sqlBaglan.dataReader["ogrSoyadi"].ToString();
                                ogrTel      = sqlBaglan.dataReader["ogrTel"].ToString();
                                ogrAdres    = sqlBaglan.dataReader["ogrAdres"].ToString();
                                ogrBolum    = sqlBaglan.dataReader["bolumAdi"].ToString();
                                ogrGNO      = sqlBaglan.dataReader["ogrGNO"].ToString();

                                panelOgrDuzenle.Enabled = true;
                                gboxOgrDuzenle.Enabled = true;

                                cboxDoldur();

                                txtDuzenleOgrTC.Text = ogrTC;
                                txtDuzenleOgrAdi.Text = ogrAdi;
                                txtDuzenleOgrSoyadi.Text = ogrSoyadi;
                                txtDuzenleOgrTel.Text = ogrTel;
                                txtDuzenleOgrAdres.Text = ogrAdres;
                                cboxDuzenleOgrBolum.Text = ogrBolum;
                                lblOgrNo.Text = ogrNo;
                                txtDuzenleOgrGNO.Text = Math.Round(Convert.ToDouble(ogrGNO), 2).ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Arama Sonucu : Böyle Bir Öğrenci Adı Bulunamadı!");
                    }

                }else if (rbOgrSoyadi.Checked) {
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_ogrenciler ogr INNER JOIN tbl_bolumler bol ON ogr.ogrBolum = bol.bolumKodu WHERE ogrSoyadi = @ogrSoyadi";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrSoyadi", txtAraOgrSoyadi.Text);

                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    if (sqlBaglan.dataReader.Read())
                    {
                        sqlBaglan.dataReader.Close();
                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            if (sqlBaglan.dataReader["ogrSoyadi"].Equals(txtAraOgrSoyadi.Text.Trim()))
                            {
                                ogrNo       = sqlBaglan.dataReader["ogrNo"].ToString();
                                ogrTC       = sqlBaglan.dataReader["ogrTC"].ToString();
                                ogrAdi      = sqlBaglan.dataReader["ogrAdi"].ToString();
                                ogrSoyadi   = sqlBaglan.dataReader["ogrSoyadi"].ToString();
                                ogrTel      = sqlBaglan.dataReader["ogrTel"].ToString();
                                ogrAdres    = sqlBaglan.dataReader["ogrAdres"].ToString();
                                ogrBolum    = sqlBaglan.dataReader["bolumAdi"].ToString();
                                ogrGNO      = sqlBaglan.dataReader["ogrGNO"].ToString();

                                panelOgrDuzenle.Enabled = true;
                                gboxOgrDuzenle.Enabled = true;

                                cboxDoldur();

                                txtDuzenleOgrTC.Text = ogrTC;
                                txtDuzenleOgrAdi.Text = ogrAdi;
                                txtDuzenleOgrSoyadi.Text = ogrSoyadi;
                                txtDuzenleOgrTel.Text = ogrTel;
                                txtDuzenleOgrAdres.Text = ogrAdres;
                                cboxDuzenleOgrBolum.Text = ogrBolum;
                                txtDuzenleOgrGNO.Text = Math.Round(Convert.ToDouble(ogrGNO), 2).ToString();
                                lblOgrNo.Text = ogrNo;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Arama Sonucu : Böyle Bir Öğrenci Soyadi Bulunamadı!");
                    }

                }else {
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cbDuzenleOgrSil.Checked)
            {
                if (MessageBox.Show("Öğrenciyi Gerçekten Silmek İstiyor musunuz?", "Öğrenci Otomasyonu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    
                    try
                    {
                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu1.Parameters.Clear();
                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu1.CommandText = "DELETE FROM tbl_ogrenciSistem WHERE ogrNo = @ogrNo";
                        sqlBaglan.sorgu1.Parameters.AddWithValue("@ogrNo", ogrNo);
                        sqlBaglan.sorgu.CommandText = "DELETE FROM tbl_ogrenciler WHERE ogrNo = @ogrNo";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", ogrNo);
                        sqlBaglan.sorgu1.ExecuteNonQuery();
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        MessageBox.Show("Öğrenci Silindi!");
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
                    MessageBox.Show("Öğrenci Silinmedi!");
                }
            }
            else
            {
                MessageBox.Show("Öğrenciyi Silmek İçin Onaylamanız Gerekmektedir!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDuzenleOgrDuzenle.Checked)
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "UPDATE tbl_ogrenciler SET ogrTC=@ogrTC, ogrAdi=@ogrAdi, ogrSoyadi=@ogrSoyadi, ogrTel=@ogrTel, ogrAdres=@ogrAdres, ogrBolum=@ogrBolum WHERE ogrNo=@ogrNo";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", ogrNo.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrTC", txtDuzenleOgrTC.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrAdi", txtDuzenleOgrAdi.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrSoyadi", txtDuzenleOgrSoyadi.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrTel", txtDuzenleOgrTel.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrAdres", txtDuzenleOgrAdres.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrBolum", cboxDuzenleOgrBolum.SelectedValue.ToString().Trim());
                    sqlBaglan.sorgu.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Düzenlendi!");
                }
                else
                {
                    MessageBox.Show("Öğrenciyi Düzenlemek İçin Onayınız Gerekmektedir!");
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
