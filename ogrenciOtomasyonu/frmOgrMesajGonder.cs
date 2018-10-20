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
    public partial class frmOgrMesajGonder : Form
    {
        public frmOgrMesajGonder()
        {
            InitializeComponent();
        }

        string OgrNo;
        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        private void frmOgrMesajGonder_Load(object sender, EventArgs e)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                frmOgrSistem frmOgrSistem = new frmOgrSistem();
                OgrNo = frmOgrSistem.OgrenciNo;
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_bolumler bol INNER JOIN tbl_akademisyenler aka ON aka.akaBolum = bol.bolumKodu INNER JOIN tbl_ogrenciler ogr ON ogr.ogrBolum = bol.bolumKodu WHERE ogr.ogrNo=@ogrNo;";
                sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", OgrNo);
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                if (sqlBaglan.dataReader.Read())
                {
                    txtOgrKime.Text = sqlBaglan.dataReader["akaNo"].ToString();
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

        private void btnOgrMesajGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOgrKonu.Text == "" || txtOgrMesaj.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
                }
                else
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_mesajlar (akaNo,ogrNo,konu,mesaj,tarih,durum,nerdenNereye) VALUES (@akaNo,@ogrNo,@konu,@mesaj,@tarih,@durum,@nerdenNereye)";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@akaNo", txtOgrKime.Text);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", OgrNo.ToString());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@konu", txtOgrKonu.Text);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@mesaj", txtOgrMesaj.Text);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@tarih", DateTime.Now);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@durum", 0);
                    sqlBaglan.sorgu.Parameters.AddWithValue("@nerdenNereye", 0); //Gönderirken Hoca 1 Öğrenci 0 Olacak.
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
    }
}
