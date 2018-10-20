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
    public partial class frmAkaMesajGonder : Form
    {
        public frmAkaMesajGonder()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        string AkaNo;

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            rbtnOgrNo.Checked = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void frmAkaMesajGonder_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtKime.ReadOnly = true;
            frmAkaMesajGecmisi frmAkaMesajGecmisi = new frmAkaMesajGecmisi();
            if (frmAkaMesajGecmisi.OgrNoGonder != "")
            {
                txtKime.Text = frmAkaMesajGecmisi.OgrNoGonder;
                txtKonu.Text = frmAkaMesajGecmisi.konuGonder;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                 if (txtAkaOgrAra.Text == "")
                {
                    MessageBox.Show("Arama Yapılacak Metin Boş Bırakılamaz!");
                }
                else
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    if (rbtnOgrNo.Checked)
                    {
                        sqlBaglan.sorgu.CommandText = "SELECT ogrNo,ogrTC,ogrAdi,ogrSoyadi,ogrSinif,bolumAdi FROM tbl_ogrenciler ogr INNER JOIN tbl_bolumler bol ON bol.bolumKodu = ogr.ogrBolum WHERE ogrNo=@araDeger";
                    }
                    else if (rbtnOgrTC.Checked)
                    {
                        sqlBaglan.sorgu.CommandText = "SELECT ogrNo,ogrTC,ogrAdi,ogrSoyadi,ogrSinif,bolumAdi FROM tbl_ogrenciler ogr INNER JOIN tbl_bolumler bol ON bol.bolumKodu = ogr.ogrBolum WHERE ogrTC=@araDeger";
                    }
                    else if (rbtnOgrAdi.Checked)
                    {
                        sqlBaglan.sorgu.CommandText = "SELECT ogrNo,ogrTC,ogrAdi,ogrSoyadi,ogrSinif,bolumAdi FROM tbl_ogrenciler ogr INNER JOIN tbl_bolumler bol ON bol.bolumKodu = ogr.ogrBolum WHERE ogrAdi=@araDeger";
                    }
                    else if (rbtnOgrSoyadi.Checked)
                    {
                        sqlBaglan.sorgu.CommandText = "SELECT ogrNo,ogrTC,ogrAdi,ogrSoyadi,ogrSinif,bolumAdi FROM tbl_ogrenciler ogr INNER JOIN tbl_bolumler bol ON bol.bolumKodu = ogr.ogrBolum WHERE ogrSoyadi=@araDeger";
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Bir Arama Türü Seçiniz.");
                    }
                    sqlBaglan.sorgu.Parameters.AddWithValue("@araDeger",txtAkaOgrAra.Text);
                    sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
                    DataTable dt = new DataTable();
                    sqlBaglan.da.Fill(dt);
                    dataGridView1.DataSource = dt;
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

        private void txtMesajGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKime.Text == "" && txtKonu.Text == "" && txtMesaj.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
                }
                else
                {
                    frmAkaSistemGiris frmAkaSistemGiris = new frmAkaSistemGiris();
                    AkaNo = frmAkaSistemGiris.AkaNoGonder;
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_mesajlar (ogrNo,akaNo,konu,mesaj,tarih,durum,nerdenNereye) VALUES (@ogrNo,@akaNo,@konu,@mesaj,@tarih,@durum,@nerdenNereye)";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", txtKime.Text);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", AkaNo.ToString());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@konu", txtKonu.Text);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@mesaj", txtMesaj.Text);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@tarih", DateTime.Now);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@durum", 0);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@nerdenNereye", 1); //Gönderirken Hoca 1 Öğrenci 0 Olacak.
                    sqlBaglan.sorgu.ExecuteNonQuery();
                    MessageBox.Show("Mesaj Gönderildi!");
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKime.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            panel1.Visible = false;
            txtKonu.Focus();
        }
    }
}
