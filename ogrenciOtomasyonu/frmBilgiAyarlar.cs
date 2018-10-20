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
    public partial class frmBilgiAyarlar : Form
    {
        
        public frmBilgiAyarlar()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();
        public static string bilgiNoAdi;

        private void btnAyarGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.CommandText = "UPDATE tbl_ayarlar SET ogrKayit = @ogrKayit, akaKayit = @akaKayit, bilgiKayit = @bilgiKayit, ogrGiris = @ogrGiris, akaGiris = @akaGiris, dersOnay = @dersOnay, dersKayit = @dersKayit";
                int OgrenciGiris = (cboxOgrGiris.Text.Equals("Açık")) ? 1 : 0;
                int AkademisyenGiris = (cboxAkaGiris.Text.Equals("Açık")) ? 1 : 0;
                int OgrenciKayit = (cboxOgrKayit.Text.Equals("Açık")) ? 1 : 0;
                int AkademisyenKayit = (cboxAkaKayit.Text.Equals("Açık")) ? 1 : 0;
                int BilgiKayit = (cboxBilgiKayit.Text.Equals("Açık")) ? 1 : 0;
                int DersOnay = (cboxDersOnay.Text.Equals("Açık")) ? 1 : 0;
                int DersKayit = (cboxDersKayit.Text.Equals("Açık")) ? 1 : 0;

                sqlBaglan.sorgu.Parameters.AddWithValue("@ogrKayit", OgrenciKayit);
                sqlBaglan.sorgu.Parameters.AddWithValue("@akaKayit", AkademisyenKayit);
                sqlBaglan.sorgu.Parameters.AddWithValue("@bilgiKayit", BilgiKayit);
                sqlBaglan.sorgu.Parameters.AddWithValue("@ogrGiris", OgrenciGiris);
                sqlBaglan.sorgu.Parameters.AddWithValue("@akaGiris", AkademisyenGiris);
                sqlBaglan.sorgu.Parameters.AddWithValue("@dersOnay", DersOnay);
                sqlBaglan.sorgu.Parameters.AddWithValue("@dersKayit", DersKayit);

                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.sorgu.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlBaglan.BaglantiKapat();
            }
            
            this.Close();
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            try
            {
                sqlBaglan.BaglantiAc();
                sqlBaglan.sorgu.Parameters.Clear();
                sqlBaglan.sorgu.CommandText = "SELECT * FROM tbl_ayarlar";
                sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                sqlBaglan.dataReader = sqlBaglan.sorgu.ExecuteReader();

                if (sqlBaglan.dataReader.Read())
                {
                    string akaGiris = (sqlBaglan.dataReader["akaGiris"].Equals(1)) ? "Açık" : "Kapalı";
                    string ogrGiris = (sqlBaglan.dataReader["ogrGiris"].Equals(1)) ? "Açık" : "Kapalı";
                    string ogrKayit = (sqlBaglan.dataReader["ogrKayit"].Equals(1)) ? "Açık" : "Kapalı";
                    string akaKayit = (sqlBaglan.dataReader["akaKayit"].Equals(1)) ? "Açık" : "Kapalı";
                    string bilgiKayit = (sqlBaglan.dataReader["bilgiKayit"].Equals(1)) ? "Açık" : "Kapalı";
                    string DersOnay = (sqlBaglan.dataReader["dersOnay"].Equals(1)) ? "Açık" : "Kapalı";
                    string DersKayit = (sqlBaglan.dataReader["dersKayit"].Equals(1)) ? "Açık" : "Kapalı";

                    string akaGiris1 = (!sqlBaglan.dataReader["akaGiris"].Equals(1)) ? "Açık" : "Kapalı";
                    string ogrGiris1 = (!sqlBaglan.dataReader["ogrGiris"].Equals(1)) ? "Açık" : "Kapalı";
                    string ogrKayit1 = (!sqlBaglan.dataReader["ogrKayit"].Equals(1)) ? "Açık" : "Kapalı";
                    string akaKayit1 = (!sqlBaglan.dataReader["akaKayit"].Equals(1)) ? "Açık" : "Kapalı";
                    string bilgiKayit1 = (!sqlBaglan.dataReader["bilgiKayit"].Equals(1)) ? "Açık" : "Kapalı";
                    string DersOnay1 = (!sqlBaglan.dataReader["dersOnay"].Equals(1)) ? "Açık" : "Kapalı";
                    string DersKayit1 = (!sqlBaglan.dataReader["dersKayit"].Equals(1)) ? "Açık" : "Kapalı";

                    cboxAkaGiris.Items.Add(akaGiris);
                    cboxOgrGiris.Items.Add(ogrGiris);
                    cboxOgrKayit.Items.Add(ogrKayit);
                    cboxAkaKayit.Items.Add(akaKayit);
                    cboxBilgiKayit.Items.Add(bilgiKayit);
                    cboxDersOnay.Items.Add(DersOnay);
                    cboxDersKayit.Items.Add(DersKayit);

                    cboxAkaGiris.Items.Add(akaGiris1);
                    cboxOgrGiris.Items.Add(ogrGiris1);
                    cboxOgrKayit.Items.Add(ogrKayit1);
                    cboxAkaKayit.Items.Add(akaKayit1);
                    cboxBilgiKayit.Items.Add(bilgiKayit1);
                    cboxDersOnay.Items.Add(DersOnay1);
                    cboxDersKayit.Items.Add(DersKayit1);

                    cboxAkaGiris.Text = akaGiris;
                    cboxOgrGiris.Text = ogrGiris;
                    cboxOgrKayit.Text = ogrKayit;
                    cboxAkaKayit.Text = akaKayit;
                    cboxBilgiKayit.Text = bilgiKayit;
                    cboxDersOnay.Text = DersOnay;
                    cboxDersKayit.Text = DersKayit;
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
