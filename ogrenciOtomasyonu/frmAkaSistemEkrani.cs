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
    public partial class frmAkaSistemEkrani : Form
    {
        public frmAkaSistemEkrani()
        {
            InitializeComponent();
        }

        string AkaNoAl;
        string AkaBolAl;
        string deger;
        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        private void frmAkaSistemEkrani_Load(object sender, EventArgs e)
        {
            frmAkaSistemGiris frmAkaSistemGiris = new frmAkaSistemGiris();
            AkaNoAl = frmAkaSistemGiris.AkaNoGonder;
            AkaBolAl = frmAkaSistemGiris.AkaBolGonder;
            toolStripStatusLabel1.Text = AkaNoAl;
            mesajVarmi(AkaNoAl);
            timerMesaj.Enabled = false;
            onaylanacakCagir();
            Ayarlar();
        }

        private void Ayarlar()
        {
            sqlBaglan.BaglantiAc();
            sqlBaglan.sorgu.Parameters.Clear();
            sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_ayarlar";
            sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
            try
            {
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                if (sqlBaglan.dataReader.Read())
                {
                    if (sqlBaglan.dataReader["dersOnay"].Equals(0)) tabDersOnay.Enabled = false;
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

        private void onaylanacakCagir()
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_ogrenciler ogr INNER JOIN tbl_bolumler bol ON bol.bolumKodu = ogr.ogrBolum INNER JOIN tbl_akademisyenler aka ON aka.akaBolum = bolumKodu INNER JOIN tbl_dersOnay do ON do.ogrNo = ogr.ogrNo INNER JOIN tbl_dersler dd ON dd.dersKodu = do.dersKodu WHERE do.dersOnay=0 AND do.dersDurum!=1 AND bol.bolumKodu = @akaBol AND aka.akaNo=@AkaNo";
                sqlBaglan.sorgu.Parameters.AddWithValue("@AkaNo", AkaNoAl);
                sqlBaglan.sorgu.Parameters.AddWithValue("@akaBol", AkaBolAl);
                sqlBaglan.sorgu.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
                sqlBaglan.da.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = false;
                    if (item["dersDurum"].Equals(0))
                    {
                        deger = "ILK DEFA";
                    }
                    else if (item["dersDurum"].Equals(2))
                    {
                        deger = "ALTTAN";
                    }
                    dataGridView1.Rows[n].Cells[1].Value = item["ogrNo"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["ogrAdi"].ToString() + " " + item["ogrSoyadi"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["dersKodu"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["dersAdi"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = deger.ToString();
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

        private void mesajGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAkaMesajGonder frmAkaMesajGonder = new frmAkaMesajGonder();
                frmAkaMesajGonder.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eskiMesajlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAkaMesajGecmisi frmAkaMesajGecmisi = new frmAkaMesajGecmisi();
                frmAkaMesajGecmisi.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mesajVarmi(string AkaNoAL)
        {
            try
            {
                frmAkaMesajGecmisi frmAkaMesajGecmisi = new frmAkaMesajGecmisi();
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_mesajlar WHERE akaNo=@akaNo AND durum = 0 AND nerdenNereye=0";
                sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", AkaNoAL);
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                if (sqlBaglan.dataReader.Read())
                {
                    if (frmAkaMesajGecmisi.Visible == false)
                    {
                        if (MessageBox.Show("Mesajınız Var! Okumak İster misiniz?", "Mesaj Var", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            frmAkaMesajGecmisi.Show();
                        }
                    }
                    sqlBaglan.dataReader.Close();
                    sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                    while (sqlBaglan.dataReader.Read())
                    {
                        int n = dataGridView3.Rows.Add();
                        dataGridView3.Rows[n].Cells[0].Value = sqlBaglan.dataReader["konu"].ToString();
                        dataGridView3.Rows[n].Cells[1].Value = sqlBaglan.dataReader["tarih"].ToString(); 
                    }
                }
                else
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = "Yeni Mesaj Bulunmamaktadır. ";
                    dataGridView3.Rows[n].Cells[1].Value = "Eski Mesajlarınızı Mesajlar -> Mesaj Geçmişi 'nden Bakabilirsiniz..";
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
                sqlBaglan.dataReader.Close();
            }
        }

        private void timerMesaj_Tick(object sender, EventArgs e)
        {
            mesajVarmi(AkaNoAl);
            sqlBaglan.dataReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (bool.Parse(item.Cells[0].Value.ToString()))
                        {
                            sqlBaglan.BaglantiAc();
                            sqlBaglan.sorgu.Parameters.Clear();
                            if (item.Cells[5].Value.Equals("ILK DEFA"))
                            {
                                deger = "0";
                            }
                            else if (item.Cells[5].Value.Equals("ALTTAN"))
                            {
                                deger = "2";
                            }
                            sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                            sqlBaglan.sorgu.CommandText = "UPDATE tbl_dersOnay SET dersOnay=1 WHERE ogrNo=@ogrNo";
                            sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", item.Cells[1].Value);
                            sqlBaglan.sorgu.ExecuteNonQuery();

                        }
                    }
                    MessageBox.Show("Dersler Onaylandı!");
                }
                else
                {
                    MessageBox.Show("Ders Onayı İçin Seçilecek Ders Bulunmamaktadır.");
                }
                dataGridView1.Rows.Clear();
                onaylanacakCagir();
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

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void notGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAkaNotGirme frmAkaNotGirme = new frmAkaNotGirme();
            frmAkaNotGirme.Show();
        }

        private void frmAkaSistemEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void devamsızlıkGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAkaDevamsizlikGirme frmAkaDevamsizlikGirme = new frmAkaDevamsizlikGirme();
            frmAkaDevamsizlikGirme.Show();
        }
    }
}
