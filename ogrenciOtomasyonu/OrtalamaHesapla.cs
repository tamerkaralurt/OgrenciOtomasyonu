using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciOtomasyonu
{
    class OrtalamaHesapla
    {
        string HarfliNott, harfIDsi;
        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        public string harfID(string HarfliNott)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_harfSistemi WHERE harfAdi = @harfAdi";
                sqlBaglan.sorgu.Parameters.AddWithValue("@harfAdi", HarfliNott);
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();
                if (sqlBaglan.dataReader.Read())
                {
                    harfIDsi = sqlBaglan.dataReader["id"].ToString();
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

            return harfIDsi;
        }

        public string HarfliNotu(double ortalama)
        {

            if (ortalama<=100 && ortalama>=90)
            {
                HarfliNott = "AA";
            }
            else if (ortalama<=89 && ortalama>=85)
            {
                HarfliNott = "BA";
            }
            else if (ortalama<=84 && ortalama>=80)
            {
                HarfliNott = "BB";
            }
            else if (ortalama<=79 && ortalama>=75)
            {
                HarfliNott = "CB";
            }
            else if (ortalama<=74 && ortalama>=65)
            {
                HarfliNott = "CC";
            }
            else if (ortalama<=64 && ortalama>=60)
            {
                HarfliNott = "DC";
            }
            else if (ortalama<=59 && ortalama>=55)
            {
                HarfliNott = "DD";
            }
            else if (ortalama<=54 && ortalama>=50)
            {
                HarfliNott = "FD";
            }
            else if (ortalama<=49 && ortalama>=0)
            {
                HarfliNott = "FF";
            }
            else
            {
                HarfliNott = "FF";
            }

            return HarfliNott;
        }
    }
}
