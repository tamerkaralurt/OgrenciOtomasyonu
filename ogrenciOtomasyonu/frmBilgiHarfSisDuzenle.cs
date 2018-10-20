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
    public partial class frmBilgiHarfSisDuzenle : Form
    {
        public frmBilgiHarfSisDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        string harfAdi;
        string harfNotu;
        string harfID;

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;

                try
                {
                    sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_harfSistemi WHERE harfAdi = @harfAdi";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@harfAdi", txtAraHarfAdi.Text);

                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    if (sqlBaglan.dataReader.Read())
                    {
                        sqlBaglan.dataReader.Close();
                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        while (sqlBaglan.dataReader.Read())
                        {
                            if (sqlBaglan.dataReader["harfAdi"].ToString().Equals(txtAraHarfAdi.Text.Trim()))
                            {
                                harfID      = sqlBaglan.dataReader["id"].ToString();
                                harfAdi     = sqlBaglan.dataReader["harfAdi"].ToString();
                                harfNotu    = sqlBaglan.dataReader["harfNotu"].ToString();

                                panelOgrDuzenle.Enabled = true;
                                gboxOgrDuzenle.Enabled = true;

                                lblHarfAdi.Text = harfAdi;
                                txtDuzenleHarfDeger.Text = harfNotu;
                            }
                        }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDuzenleOgrDuzenle.Checked)
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "UPDATE tbl_harfSistemi SET harfNotu=@harfNotu WHERE id=@harfID";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@harfID", harfID);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@harfNotu", float.Parse(txtDuzenleHarfDeger.Text.Trim()));
                    sqlBaglan.sorgu.ExecuteNonQuery();
                    MessageBox.Show("Harfli Not Düzenlendi!");
                }
                else
                {
                    MessageBox.Show("Harfli Notu Düzenlemek İçin Onayınız Gerekmektedir!");
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
                if (MessageBox.Show("Harfli Notu Gerçekten Silmek İstiyor musunuz?", "Öğrenci Otomasyonu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    try
                    {
                        sqlBaglan.BaglantiAc();
                        sqlBaglan.sorgu.Parameters.Clear();
                        sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                        sqlBaglan.sorgu.CommandText = "DELETE FROM tbl_harfSistemi WHERE harfAdi = @harfAdi";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@harfAdi", harfAdi);
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        sqlBaglan.sorgu.ExecuteNonQuery();
                        MessageBox.Show("Harfli Not Silindi!");
                        this.Refresh();
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
                    MessageBox.Show("Harfli Not Silinmedi!");
                }
            }
            else
            {
                MessageBox.Show("Harfli Notu Silmek İçin Onaylamanız Gerekmektedir!");
            }
        }

        private void frmBilgiHarfSisDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
