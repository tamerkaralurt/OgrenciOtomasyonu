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
    public partial class frmOgrSistemEkrani : Form
    {
        public frmOgrSistemEkrani()
        {
            InitializeComponent();
        }

        string OgrNo;
        string OgrSinif;
        Double ogrGNO;
        string deger;
        string AkaNo;

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        private void frmOgrSistemEkrani_Load(object sender, EventArgs e)
        {
            try
            {
                frmOgrSistem frmOgrSistem = new frmOgrSistem();
                OgrNo = frmOgrSistem.OgrenciNo;
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.CommandText = "SELECT ogr.ogrAdi,ogr.ogrSoyadi,ogr.ogrGNO,ogr.ogrSinif,bol.bolumAdi FROM tbl_ogrenciler ogr INNER JOIN tbl_bolumler bol ON bol.bolumKodu = ogr.ogrBolum WHERE ogr.ogrNo = @ogrNo"; // WHERE ogr.ogrNo = '2016103001'
                sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", OgrNo);
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                if (sqlBaglan.dataReader.Read())
                {
                    ogrGNO = Convert.ToDouble(sqlBaglan.dataReader["ogrGNO"]);
                    OgrSinif = sqlBaglan.dataReader["ogrSinif"].ToString();
                    lblOgrNo.Text = OgrNo;
                    lblOgrAdi.Text = sqlBaglan.dataReader["ogrAdi"].ToString();
                    lblOgrSoyad.Text = sqlBaglan.dataReader["ogrSoyadi"].ToString();
                    lblOgrGNO.Text = Math.Round(ogrGNO, 2).ToString(); //2,3486459551345 -> 2,34
                    lblSinif.Text = OgrSinif;
                    lblBolum.Text = sqlBaglan.dataReader["bolumAdi"].ToString();

                    sqlBaglan.dataReader.Close();
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.da.Dispose();
                    sqlBaglan.sorgu.CommandText = "SELECT ders.dersKodu,ders.dersAdi,ders.dersKredi,nott.dersVize,nott.dersFinal,nott.dersOrt,harf.harfAdi FROM tbl_ogrenciler ogr INNER JOIN tbl_bolumler bol ON bol.bolumKodu = ogr.ogrBolum INNER JOIN tbl_notlar nott ON nott.ogrNo = ogr.ogrNo INNER JOIN tbl_harfSistemi harf ON harf.id = nott.dersHarfID INNER JOIN tbl_dersler ders ON ders.dersKodu = nott.dersKodu WHERE ogr.ogrNo = @ogrNo AND ders.dersSinif= @dersSinif";
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", OgrNo);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@dersSinif", OgrSinif);
                    sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
                    sqlBaglan.sorgu.ExecuteNonQuery();
                    DataTable dtt = new DataTable();
                    sqlBaglan.da.Fill(dtt);

                    foreach (DataRow item in dtt.Rows)
                    {
                        int n = dataGridView2.Rows.Add();
                        dataGridView2.Rows[n].Cells[0].Value = item["dersKodu"].ToString();
                        dataGridView2.Rows[n].Cells[1].Value = item["dersAdi"].ToString();
                        dataGridView2.Rows[n].Cells[2].Value = item["dersVize"].ToString();
                        dataGridView2.Rows[n].Cells[3].Value = item["dersFinal"].ToString();
                        dataGridView2.Rows[n].Cells[4].Value = item["dersOrt"].ToString();
                        dataGridView2.Rows[n].Cells[5].Value = item["dersKredi"].ToString();
                        dataGridView2.Rows[n].Cells[6].Value = item["harfAdi"].ToString();
                    }
                    /*Ders Kaydı Kısmı Doluyor*/
                    dersKaydi();
                    /*Ders Kaydı Kısmı Doluyor Son*/
                    Ayarlar();
                    devamsizlik();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    if (sqlBaglan.dataReader["dersKayit"].Equals(0)) tpDersKayit.Enabled = false;
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

        private void dersKaydi()
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu1.Parameters.Clear();
                sqlBaglan.dataReader.Close();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu1.CommandText = "SELECT * FROM tbl_dersOnay WHERE ogrNo = @ogrNo"; //Öğrenci okulda hiç ders aldı mı? Almadıysa 1.sınıfta ve güz döneminde.
                sqlBaglan.sorgu1.Parameters.AddWithValue("@ogrNo", OgrNo);
                sqlBaglan.dataReader = sqlBaglan.sorgu1.ExecuteReader();
                if (!sqlBaglan.dataReader.Read() && OgrSinif == "1") //DersOnay tablosunda hiç veri yoksa ( 0 ) ve Öğrenci 1.sınıfsa
                {
                    sqlBaglan.sorgu.CommandText = "SELECT ders.dersKodu,ders.dersAdi,ders.dersKredi,ders.dersSinif,ders.dersSecmeli,aka.akaNo,bolumKodu FROM tbl_dersler ders INNER JOIN tbl_ogrenciler ogr ON ders.dersSinif = ogr.ogrSinif INNER JOIN tbl_bolumler bol ON bol.bolumKodu = ogr.ogrBolum INNER JOIN tbl_akademisyenler aka ON aka.akaBolum = bol.bolumKodu WHERE ogr.ogrNo = @OgrNo AND ders.dersSinif=@OgrSinif";
                }
                else if (sqlBaglan.dataReader.Read() && OgrSinif != "1") //DersOnay tablosunda veri varsa ( 1 ) ve Öğrenci 1 sınıf değilse
                {
                    sqlBaglan.sorgu.CommandText = "SELECT ders.dersKodu,ders.dersAdi,ders.dersKredi,ders.dersSinif,ders.dersSecmeli,aka.akaNo,bolumKodu FROM tbl_dersler ders INNER JOIN tbl_ogrenciler ogr ON ders.dersSinif = ogr.ogrSinif INNER JOIN tbl_bolumler bol ON bol.bolumKodu = ogr.ogrBolum INNER JOIN tbl_akademisyenler aka ON aka.akaBolum = bol.bolumKodu INNER JOIN tbl_dersOnay do ON do.dersKodu = ders.dersKodu  WHERE ogr.ogrNo = @OgrNo AND do.dersDurum<>1 AND ders.dersSinif=@OgrSinif"; // <> => !=
                }
                else
                {
                    sqlBaglan.sorgu.CommandText = "SELECT ders.dersKodu,ders.dersAdi,ders.dersKredi,ders.dersSinif,ders.dersSecmeli,aka.akaNo,bolumKodu FROM tbl_dersler ders INNER JOIN tbl_ogrenciler ogr ON ders.dersSinif = ogr.ogrSinif INNER JOIN tbl_bolumler bol ON bol.bolumKodu = ogr.ogrBolum INNER JOIN tbl_akademisyenler aka ON aka.akaBolum = bol.bolumKodu INNER JOIN tbl_dersOnay do ON do.dersKodu = ders.dersKodu WHERE ogr.ogrNo = @OgrNo AND do.dersDurum<>1 AND ders.dersSinif=@OgrSinif AND do.dersDurum<>0";
                }
                sqlBaglan.dataReader.Close();
                sqlBaglan.sorgu.Parameters.AddWithValue("@OgrNo", OgrNo);
                sqlBaglan.sorgu.Parameters.AddWithValue("@OgrSinif", OgrSinif);
                sqlBaglan.da.SelectCommand = sqlBaglan.sorgu;
                sqlBaglan.sorgu.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sqlBaglan.da.Fill(dt);

                foreach (DataRow item in dt.Rows) //For Döngüsü Gibi
                {
                    int n = dataGridView1.Rows.Add();
                    if (item["dersSecmeli"].Equals(0))
                    {
                        deger = "ZORUNLU";
                    }
                    else if (item["dersSecmeli"].Equals(2))
                    {
                        deger = "SECMELI";
                    }
                    else if (item["dersSecmeli"].Equals(1))
                    {
                        deger = "MUAF";
                    }
                    AkaNo = item["akaNo"].ToString();
                    dataGridView1.Rows[n].Cells[0].Value = false;
                    dataGridView1.Rows[n].Cells[1].Value = item["dersKodu"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["dersAdi"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["dersKredi"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["dersSinif"].ToString();
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
                sqlBaglan.sorgu1.Parameters.Clear();
            }
        }

        private void frmOgrSistemEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void mesajGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrMesajGonder frmOgrMesajGonder = new frmOgrMesajGonder();
            frmOgrMesajGonder.Show();
        }

        private void mesajGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrMesajGecmisi frmOgrMesajGecmisi = new frmOgrMesajGecmisi();
            frmOgrMesajGecmisi.Show();
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (bool.Parse(item.Cells[0].Value.ToString())) //Convert.Boolean => bool.Parse //Bool = true yada false;
                        {
                            sqlBaglan.BaglantiAc();
                            sqlBaglan.sorgu.Parameters.Clear();
                            if (item.Cells[5].Value.Equals("ZORUNLU"))
                            {
                                deger = "0";
                            }
                            else if (item.Cells[5].Value.Equals("SECMELI"))
                            {
                                deger = "2";
                            }
                            else if (item.Cells[5].Value.Equals("MUAF"))
                            {
                                deger = "1";
                            }
                            sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                            sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_dersOnay (ogrNo,akaNo,dersKodu,dersOnay,dersDurum) VALUES (@ogrNo,@akaNo,@dersKodu,@dersOnay,@dersDurum)";
                            sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", OgrNo);
                            sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", AkaNo);
                            sqlBaglan.sorgu.Parameters.AddWithValue("@dersKodu", item.Cells[1].Value);
                            sqlBaglan.sorgu.Parameters.AddWithValue("@dersOnay", 0);
                            sqlBaglan.sorgu.Parameters.AddWithValue("@dersDurum", deger);
                            sqlBaglan.sorgu.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Dersler Seçildi ve Danışman Onayı Bekliyor.");
                }
                else
                {
                    MessageBox.Show("Ders Kaydı İçin Seçilecek Ders Bulunmamaktadır.");
                }
                dataGridView1.Rows.Clear();
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
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void devamsizlik() 
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.CommandText = "SELECT ders.dersAdi,ders.dersKodu,aka.akaAdi + ' ' + akaSoyadi AS adiSoyadi,devam.devamTarih,devam.devam AS devam FROM tbl_devamsizlik devam INNER JOIN tbl_dersler ders ON devam.dersKodu = ders.dersKodu INNER JOIN tbl_akademisyenler aka ON devam.akaNo = aka.akaNo WHERE devam.ogrNo = @ogrNo";
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo",OgrNo);
                sqlBaglan.sorgu.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sqlBaglan.da.Fill(dt);

                foreach (DataRow item in dt.Rows) //For Döngüsü Gibi
                {
                    if (item["devam"].Equals("GELMEDI"))
                    {
                        int n = dataGridView3.Rows.Add();
                        dataGridView3.Rows[n].Cells[0].Value = item["dersKodu"].ToString();
                        dataGridView3.Rows[n].Cells[1].Value = item["dersAdi"].ToString();
                        dataGridView3.Rows[n].Cells[2].Value = item["adiSoyadi"].ToString();
                        dataGridView3.Rows[n].Cells[3].Value = item["devamTarih"].ToString();
                        dataGridView3.Rows[n].Cells[4].Value = item["devam"].ToString();
                    }
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
