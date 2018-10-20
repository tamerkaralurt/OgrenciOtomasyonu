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
    public partial class frmAkaDevamsizlikGirme : Form
    {
        public frmAkaDevamsizlikGirme()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        string AkaNoAl;

        private void btnDevamGir_Click(object sender, EventArgs e)
        {
            if (cboxDevamsizlik.Checked)
            {
                try
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (item.Cells[4].Value.Equals("GELDI") || item.Cells[4].Value.Equals("GELMEDI"))
                        {
                            sqlBaglan.sorgu.Parameters.Clear();
                            sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_devamsizlik (ogrNo,dersKodu,devamTarih,akaNo,devam) VALUES (@ogrNo,@dersKodu,@devamTarih,@akaNo,@devam)";
                            sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", item.Cells[0].Value);
                            sqlBaglan.sorgu.Parameters.AddWithValue("@dersKodu", comboxDersSec.SelectedValue.ToString().Trim());
                            sqlBaglan.sorgu.Parameters.AddWithValue("@devamTarih", item.Cells[3].Value);
                            sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", AkaNoAl);
                            sqlBaglan.sorgu.Parameters.AddWithValue("@devam", item.Cells[4].Value);
                            sqlBaglan.sorgu.ExecuteNonQuery();
                            MessageBox.Show("Devamsızlıklar Girildi.");
                            dataGridView1.Rows.Clear();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Devamsızlıkları Tekrar Kontrol Ediniz. Girilmeyen Öğrenci Mevcut.");
                }
                finally
                {
                    sqlBaglan.BaglantiKapat();
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu1.Parameters.Clear();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Devamsızlıkları Kontrol Ederek Onaylayınız..");
            }
        }

        private void frmAkaDevamsizlikGirme_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Dock = DockStyle.None;
                panel1.Dock = DockStyle.Fill;
                if (panel1.Visible == true)
                {
                    frmAkaSistemGiris frmAkaSistemGiris = new frmAkaSistemGiris();
                    AkaNoAl = frmAkaSistemGiris.AkaNoGonder;
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_dersler ders INNER JOIN tbl_dersAkademisyen dersAka ON dersAka.dersKodu = ders.dersKodu WHERE dersAka.akaNo=@akaNo";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", AkaNoAl);
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
                    DataSet ds1 = new DataSet();
                    sqlBaglan.da.Fill(ds1);
                    comboxDersSec.Text = "Ders Seçiniz";
                    comboxDersSec.DataSource = ds1.Tables[0];
                    comboxDersSec.DisplayMember = "dersAdi";
                    comboxDersSec.ValueMember = "dersKodu";
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

        private void btnDersSec_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Dock = DockStyle.Top;
                panel1.Dock = DockStyle.None;
                panel1.Visible = false;
                dataGridView1.Enabled = true;
                cboxDevamsizlik.Enabled = true;
                btnDevamGir.Enabled = true;
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_dersOnay do INNER JOIN tbl_ogrenciler ogr ON ogr.ogrNO = do.ogrNo INNER JOIN tbl_dersler ders ON ders.dersKodu = do.dersKodu WHERE do.dersKodu=@dersKodu";
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.Parameters.AddWithValue("@dersKodu", comboxDersSec.SelectedValue.ToString().Trim());
                DataTable dt = new DataTable();
                sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
                sqlBaglan.sorgu.ExecuteNonQuery();
                sqlBaglan.da.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ogrNo"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["ogrAdi"].ToString() + " " +item["ogrSoyadi"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["ogrSinif"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = dateTimePicker1.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
