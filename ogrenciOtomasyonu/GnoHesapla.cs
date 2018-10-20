using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciOtomasyonu
{
    class GnoHesapla
    {
        public SqlBaglantisi sqlBaglan;
        public float ogrGnoEski = 0;
        public float ogrGnoYeni = 0;
        public GnoHesapla()//GnoHesapla Çağırıldığında İlk Çalışacak Foksiyon
        {
            try
            {
                sqlBaglan = new SqlBaglantisi();
                sqlBaglan.BaglantiAc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        public void HesaplaGno(int ogrNo){
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu1.Parameters.Clear();
                sqlBaglan.sorgu.CommandText = "SELECT ogrGNO FROM tbl_ogrenciler WHERE ogrNo = @ogrNo";
                sqlBaglan.sorgu.Parameters.AddWithValue("@ogrNo", ogrNo);
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                if (sqlBaglan.dataReader.Read())
                {
                    ogrGnoEski = float.Parse(sqlBaglan.dataReader["ogrGNO"].ToString());
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu1.Parameters.Clear();
                    sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.dataReader.Close();
                    sqlBaglan.sorgu1.CommandText = "SELECT (SUM(dersler.dersKredi * harf.harfNotu)/SUM(dersler.dersKredi)) AS GNO FROM tbl_ogrenciler ogrenci INNER JOIN tbl_notlar notlar ON notlar.ogrNo = ogrenci.ogrNo INNER JOIN tbl_dersler dersler ON dersler.dersKodu = notlar.dersKodu INNER JOIN tbl_harfSistemi harf ON harf.id = notlar.dersHarfID WHERE ogrenci.ogrNo = @ogrNo";
                    sqlBaglan.sorgu1.Parameters.AddWithValue("@ogrNo", ogrNo);
                    sqlBaglan.da.SelectCommand = sqlBaglan.sorgu1;
                    DataTable dt = new DataTable();
                    sqlBaglan.da.Fill(dt);

                    ogrGnoYeni = float.Parse(dt.Rows[0]["GNO"].ToString());
                    MessageBox.Show(ogrGnoYeni.ToString());
                    if (!ogrGnoYeni.Equals(ogrGnoEski))
                    {
                        try
                        {
                            sqlBaglan.sorgu1.Parameters.Clear();
                            sqlBaglan.sorgu1.Connection = sqlBaglan.baglan;
                            sqlBaglan.sorgu1.CommandText = "UPDATE tbl_ogrenciler SET ogrGNO = @ogrGNO WHERE ogrNo = @ogrNo";
                            sqlBaglan.sorgu1.Parameters.AddWithValue("@ogrGNO", ogrGnoYeni);
                            sqlBaglan.sorgu1.Parameters.AddWithValue("@ogrNo",ogrNo);
                            sqlBaglan.sorgu1.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
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
            }
        }
    }
}
