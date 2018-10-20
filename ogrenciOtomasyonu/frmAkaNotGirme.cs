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
    public partial class frmAkaNotGirme : Form
    {
        public frmAkaNotGirme()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        string AkaNoAl;
        public static string dersSinifGonder, dersBolumGonder, dersKoduGonder;

        private void frmAkaNotGirme_Load(object sender, EventArgs e)
        {
            try
            {
                frmAkaSistemGiris frmAkaSistemGiris = new frmAkaSistemGiris();
                AkaNoAl = frmAkaSistemGiris.AkaNoGonder;
                SinifCek();
                comBoxHangiNot.Text = "BİR NOT TÜRÜ SEÇİNİZ";
                comBoxHangiNot.Items.Add("VIZE");
                comBoxHangiNot.Items.Add("FINAL");
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

        private void OgrenciCek()
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.CommandText = "";
                sqlBaglan.sorgu.Parameters.AddWithValue("","");
                sqlBaglan.sorgu.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
                sqlBaglan.da.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ogrNo"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["ogrAdi"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["ogrSoyadi"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["dersVize"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["dersFinal"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item["dersOrt"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = "";
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
                sqlBaglan.sorgu1.Parameters.Clear();
            }
        }

        private void SinifCek()
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.CommandText = "SELECT bol.bolumKodu,bol.bolumAdi,ders.dersSinif,ders.dersKodu,ders.dersAdi FROM tbl_bolumler bol LEFT JOIN( SELECT ders.dersSinif,ders.dersBolum,ders.dersAdi,ders.dersKodu FROM tbl_dersler ders GROUP BY ders.dersAdi,ders.dersKodu,ders.dersBolum,ders.dersSinif ) ders ON ders.dersBolum = bol.bolumKodu LEFT JOIN( SELECT aka.akaNo,aka.akaBolum FROM tbl_akademisyenler aka GROUP BY aka.akaNo,aka.akaBolum ) aka ON aka.akaBolum = bol.bolumKodu WHERE aka.akaNo = @akaNo ORDER BY ders.dersBolum,ders.dersSinif";
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo",AkaNoAl);
                sqlBaglan.sorgu.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
                sqlBaglan.da.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["bolumKodu"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["bolumAdi"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["dersSinif"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["dersKodu"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["dersAdi"].ToString();
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
                sqlBaglan.sorgu1.Parameters.Clear();
            }
        }

        private void btnSinifNotGir_Click(object sender, EventArgs e)
        {
            try
            {
                if (comBoxHangiNot.Text.Equals("VIZE"))
                {
                    dersSinifGonder = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                    dersBolumGonder = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    dersKoduGonder = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    frmAkaNotVizeGir frmAkaNotVizeGir = new frmAkaNotVizeGir();
                    frmAkaNotVizeGir.Show();
                }
                else if (comBoxHangiNot.Text.Equals("FINAL"))
                {
                    dersSinifGonder = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                    dersBolumGonder = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    dersKoduGonder = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    frmAkaNotFinalGir frmAkaNotFinalGir = new frmAkaNotFinalGir();
                    frmAkaNotFinalGir.Show();
                }
                else
                {
                    MessageBox.Show("LÜTFEN GİRİLECEK BİR NOT TÜRÜ SEÇİNİZ - ( VIZE - FINAL )");
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
                sqlBaglan.sorgu1.Parameters.Clear();
            }
        }
    }
}
