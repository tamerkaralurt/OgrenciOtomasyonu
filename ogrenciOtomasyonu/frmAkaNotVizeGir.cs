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
    public partial class frmAkaNotVizeGir : Form
    {
        public frmAkaNotVizeGir()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        string dersSinifAl, dersBolumAl,dersKoduAl;
        //string dersFinal,dersVize;

        private void frmAkaNotVizeGir_Load(object sender, EventArgs e)
        {
            try
            {
                frmAkaNotGirme frmAkaNotGirme = new frmAkaNotGirme();
                dersSinifAl = frmAkaNotGirme.dersSinifGonder;
                dersBolumAl = frmAkaNotGirme.dersBolumGonder;
                dersKoduAl = frmAkaNotGirme.dersKoduGonder;
                OgrenciCeK();
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

        private void OgrenciCeK()
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.CommandText = "SELECT ogr.ogrNo,ogr.ogrAdi + ' ' + ogr.ogrSoyadi AS adiSoyadi,ogr.ogrSinif,ders.dersKodu,ders.dersAdi,nott.dersVize,nott.dersFinal FROM tbl_notlar nott INNER JOIN tbl_ogrenciler ogr ON ogr.ogrNo = nott.ogrNo INNER JOIN tbl_dersler ders ON ders.dersKodu = nott.dersKodu WHERE ogr.ogrBolum = @ogrBolum AND ogr.ogrSinif = @ogrSinif AND ders.dersKodu = @dersKodu";
                sqlBaglan.sorgu.Parameters.AddWithValue("@ogrBolum", dersBolumAl);
                sqlBaglan.sorgu.Parameters.AddWithValue("@ogrSinif", int.Parse(dersSinifAl));
                sqlBaglan.sorgu.Parameters.AddWithValue("@dersKodu", dersKoduAl);
                sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
                DataTable dt = new DataTable();
                sqlBaglan.sorgu.ExecuteNonQuery();
                sqlBaglan.da.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ogrNo"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["adiSoyadi"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["ogrSinif"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["dersKodu"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["dersAdi"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item["dersVize"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlBaglan.BaglantiKapat();
                sqlBaglan.sorgu.Parameters.Clear();
            }
        }

        private void btnVizeGir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxVizeOnay.Checked)
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;

                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_notlar WHERE ogrNo=@ogrNo AND dersKodu=@dersKodu";
                        sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", item.Cells[0].Value);
                        sqlBaglan.sorgu.Parameters.AddWithValue("@dersKodu", item.Cells[3].Value);
                        sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                        if (!sqlBaglan.dataReader.Read()) //Eğer Değer Dönüyorsa Öğrencinin Daha Önce Notu Vardır. Update Komutuna Yönlendir.
                        {
                            sqlBaglan.sorgu.Parameters.Clear();
                            sqlBaglan.dataReader.Close();
                            if (Convert.ToDouble(item.Cells[5].Value.ToString()) >= 0 && Convert.ToDouble(item.Cells[5].Value.ToString()) <= 100)
                            {
                                sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_notlar (ogrNo,dersKodu,dersVize) VALUES (@ogrNo,@dersKodu,@dersVize)";
                                sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", item.Cells[0].Value);
                                sqlBaglan.sorgu.Parameters.AddWithValue("@dersKodu", item.Cells[3].Value);
                                sqlBaglan.sorgu.Parameters.AddWithValue("@dersVize", item.Cells[5].Value);
                                sqlBaglan.sorgu.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("LÜTFEN 0 ile 100 Arasında Bir Değer Giriniz!");
                            }
                        }
                        else
                        {
                            sqlBaglan.sorgu.Parameters.Clear();
                            sqlBaglan.dataReader.Close();
                            if (Convert.ToDouble(item.Cells[5].Value.ToString()) >= 0 && Convert.ToDouble(item.Cells[5].Value.ToString()) <= 100)
                            {
                                sqlBaglan.sorgu.CommandText = "UPDATE tbl_notlar SET dersVize=@dersVize WHERE ogrNo=@ogrNo AND dersKodu=@dersKodu";
                                sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", item.Cells[0].Value);
                                sqlBaglan.sorgu.Parameters.AddWithValue("@dersKodu", item.Cells[3].Value);
                                sqlBaglan.sorgu.Parameters.AddWithValue("@dersVize", item.Cells[5].Value);
                                sqlBaglan.sorgu.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("LÜTFEN 0 ile 100 Arasında Bir Değer Giriniz!");
                            }
                        }
                    }
                    MessageBox.Show("Vize Notları Eklendi!");
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Lütfen İşlemi Onaylayınız!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlBaglan.BaglantiKapat();
                sqlBaglan.sorgu.Parameters.Clear();
            }
        }
    }
}
