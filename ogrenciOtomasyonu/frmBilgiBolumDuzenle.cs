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
    public partial class frmBilgiBolumDuzenle : Form
    {
        public frmBilgiBolumDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        string bolID;

        private void cboxDoldur(string deger)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu1.CommandText = "SELECT akaAdi + ' ' + akaSoyadi AS bolumBaskani FROM tbl_bolumler bolum RIGHT JOIN tbl_akademisyenler aka ON aka.akaAdi+ ' ' + aka.akaSoyadi = bolum.bolumBaskani";
                sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                sqlBaglan.da.SelectCommand = sqlBaglan.sorgu1;
                DataSet ds = new DataSet();
                sqlBaglan.da.Fill(ds);
                if (deger.Equals("cboxDuzenleBolBaskani"))
                {
                    cboxDuzenleBolBaskani.Text = "Bölüm Seçiniz";
                    cboxDuzenleBolBaskani.DataSource = ds.Tables[0];
                    cboxDuzenleBolBaskani.DisplayMember = "bolumBaskani";
                    cboxDuzenleBolBaskani.ValueMember = "bolumBaskani";
                }
                else if (deger.Equals("cboxBolumBaskani"))
                {
                    cboxBolumBaskani.Text = "Bölüm Seçiniz";
                    cboxBolumBaskani.DataSource = ds.Tables[0];
                    cboxBolumBaskani.DisplayMember = "bolumBaskani";
                    cboxBolumBaskani.ValueMember = "bolumBaskani";
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
        }

        private void frmBilgiBolumDuzenle_Load(object sender, EventArgs e)
        {
            panelOgrDuzenle.Enabled = false;
            gboxOgrDuzenle.Enabled = false;
            txtAraBolAdi.Enabled = false;
            txtAraBolKodu.Enabled = true;
            rbBolKodu.Checked = true;
            txtAraBolKodu.Focus();
        }

        private void rbBolKodu_CheckedChanged(object sender, EventArgs e)
        {
            cboxBolumBaskani.Enabled = false;
            txtAraBolAdi.Enabled = false;
            txtAraBolKodu.Enabled = true;
            txtAraBolKodu.Focus();
        }

        private void rbBolAdi_CheckedChanged(object sender, EventArgs e)
        {
            cboxBolumBaskani.Enabled = false;
            txtAraBolAdi.Enabled = true;
            txtAraBolKodu.Enabled = false;
            txtAraBolAdi.Focus();
        }

        private void rbAkaAdi_CheckedChanged(object sender, EventArgs e)
        {
            cboxBolumBaskani.Enabled = true;
            txtAraBolAdi.Enabled = false;
            txtAraBolKodu.Enabled = false;
            cboxBolumBaskani.Focus();
            cboxDoldur("cboxBolumBaskani");
        }

        private void btnBolAra_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                string bolumKodu, bolumAdi, bolumBaskani;
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;

                if (rbBolKodu.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_bolumler WHERE bolumKodu = @bolumKodu";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bolumKodu", txtAraBolKodu.Text.Trim());

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["bolumKodu"].ToString().Equals(txtAraBolKodu.Text))
                                {
                                    bolID           = sqlBaglan.dataReader["id"].ToString();
                                    bolumKodu       = sqlBaglan.dataReader["bolumKodu"].ToString();
                                    bolumAdi        = sqlBaglan.dataReader["bolumAdi"].ToString();
                                    bolumBaskani    = sqlBaglan.dataReader["bolumBaskani"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    sqlBaglan.dataReader.Close();
                                    cboxDoldur("cboxDuzenleBolBaskani");
                                    
                                    txtDuzenleBolKodu.Text = bolumKodu;
                                    txtDuzenleBolAdi.Text = bolumAdi;
                                    cboxDuzenleBolBaskani.Text = bolumBaskani;
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
                else if (rbBolAdi.Checked)
                {
                    try
                    {
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_bolumler WHERE bolumAdi LIKE '%@bolumAdi%'";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bolumAdi", txtAraBolAdi.Text.ToLower().Trim());

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["bolumAdi"].ToString().Equals(txtAraBolAdi.Text.ToLower().Trim()))
                                {
                                    bolID           = sqlBaglan.dataReader["id"].ToString();
                                    bolumKodu       = sqlBaglan.dataReader["bolumKodu"].ToString();
                                    bolumAdi        = sqlBaglan.dataReader["bolumAdi"].ToString();
                                    bolumBaskani    = sqlBaglan.dataReader["bolumBaskani"].ToString();

                                    panelOgrDuzenle.Enabled = true;
                                    gboxOgrDuzenle.Enabled = true;

                                    sqlBaglan.dataReader.Close();
                                    cboxDoldur("cboxDuzenleBolBaskani");

                                    txtDuzenleBolKodu.Text = bolumKodu;
                                    txtDuzenleBolAdi.Text = bolumAdi;
                                    cboxDuzenleBolBaskani.Text = bolumBaskani;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arama Sonucu : Böyle Bir Bölüm Adı Bulunamadı!");
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
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_bolumler WHERE bolumBaskani = @bolumBaskani";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@bolumBaskani", cboxBolumBaskani.SelectedValue.ToString().Trim());

                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (sqlBaglan.dataReader.Read())
                        {
                            sqlBaglan.dataReader.Close();
                            sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                            if (sqlBaglan.dataReader.Read())
                            {
                                if (sqlBaglan.dataReader["bolumBaskani"].ToString().Equals(cboxBolumBaskani.SelectedValue.ToString().Trim()))
                                {
                                    bolID           = sqlBaglan.dataReader["id"].ToString();
                                    bolumKodu       = sqlBaglan.dataReader["bolumKodu"].ToString();
                                    bolumAdi        = sqlBaglan.dataReader["bolumAdi"].ToString();
                                    bolumBaskani    = sqlBaglan.dataReader["bolumBaskani"].ToString();

                                    panelOgrDuzenle.Enabled     = true;
                                    gboxOgrDuzenle.Enabled      = true;

                                    sqlBaglan.dataReader.Close();
                                    cboxDoldur("cboxDuzenleBolBaskani");

                                    txtDuzenleBolKodu.Text      = bolumKodu;
                                    txtDuzenleBolAdi.Text       = bolumAdi;
                                    cboxDuzenleBolBaskani.Text  = bolumBaskani;
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

        private void btnABolDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDuzenleBolDuzenle.Checked)
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "UPDATE tbl_bolumler SET bolumKodu=@bolumKodu, bolumAdi=@bolumAdi, bolumBaskani=@bolumBaskani WHERE id=@id";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@id", bolID.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@bolumKodu", txtDuzenleBolKodu.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@bolumAdi", txtDuzenleBolAdi.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@bolumBaskani", cboxDuzenleBolBaskani.SelectedValue.ToString().Trim());
                    sqlBaglan.sorgu.ExecuteNonQuery();
                    MessageBox.Show("Bölüm Düzenlendi!");
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

        private void btnBolSil_Click(object sender, EventArgs e)
        {
            if (cbDuzenleBolSil.Checked)
            {
                if (MessageBox.Show("Bölümü Gerçekten Silmek İstiyor musunuz?", "Öğrenci Otomasyonu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    try
                    {
                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu.CommandText = "DELETE FROM tbl_bolumler WHERE id = @id";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@id", bolID.Trim());
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        MessageBox.Show("Bölüm Silindi!");
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
                    MessageBox.Show("Bölüm Silinmedi!");
                }
            }
            else
            {
                MessageBox.Show("Bölümü Silmek İçin Onaylamanız Gerekmektedir!");
            }
        }
    }
}
