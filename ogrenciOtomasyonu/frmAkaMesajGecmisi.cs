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
    public partial class frmAkaMesajGecmisi : Form
    {
        public frmAkaMesajGecmisi()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        string AkaNo;
        public static string OgrNoGonder;
        public static string konuGonder;
        string durum;
        string kimden;

        private void MesajCek()
        {
            try
            {
                dataGridView1.Rows.Clear();
                frmAkaSistemGiris frmAkaSistemGiris = new frmAkaSistemGiris();
                AkaNo = frmAkaSistemGiris.AkaNoGonder;
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.CommandText = "SELECT akaNo,ogrNo,konu,mesaj,tarih,durum,nerdenNereye,id FROM tbl_mesajlar WHERE akaNo=@akaNo ORDER BY tarih DESC";
                sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", AkaNo);
                sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
                sqlBaglan.sorgu.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sqlBaglan.da.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    if (item["durum"].ToString().Equals("1")) { durum = "OKUNDU"; } else { durum = "OKUNMADI"; };
                    if (item["nerdenNereye"].ToString().Equals("1")) { kimden = "HOCADAN"; } else { kimden = "ÖĞRENCİDEN"; };
                    dataGridView1.Rows[n].Cells[0].Value = item["akaNo"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["ogrNo"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["konu"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["mesaj"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["tarih"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = durum;
                    dataGridView1.Rows[n].Cells[6].Value = kimden;
                    dataGridView1.Rows[n].Cells[7].Value = item["id"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAkaMesajGecmisi_Load(object sender, EventArgs e)
        {
            MesajCek();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panel1.Visible = true;
                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value.ToString() == "1")
                {
                    lblKimden.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    lblKime.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    txtMesaj.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    lblDurum.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                    lblTarih.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                    lblKonu.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    lblKimden.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    lblKime.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    txtMesaj.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    lblDurum.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                    lblTarih.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                    lblKonu.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.CommandText = "UPDATE tbl_mesajlar SET durum=1 WHERE nerdenNereye=0 AND id=@id;";
                sqlBaglan.sorgu.Parameters.AddWithValue("@id",dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[7].Value.ToString());
                sqlBaglan.sorgu.ExecuteNonQuery();
                MesajCek();
                dataGridView1.Refresh();
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

        private void timerMesaj_Tick(object sender, EventArgs e)
        {
            MesajCek();
        }

        private void frmAkaMesajGecmisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrNoGonder = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
            konuGonder = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
            frmAkaMesajGonder frmAkaMesajGonder = new frmAkaMesajGonder();
            frmAkaMesajGonder.Show();
        }
    }
}
