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
    public partial class frmBilgiHarfSisEkle : Form
    {
        public frmBilgiHarfSisEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglan = new SqlBaglantisi();

        private void frmBilgiHarfSisEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHarfEkle_Click(object sender, EventArgs e)
        {
            if (txtharfAdi.Text == "" || txtharfDegeri.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakamazsınız. Lütfen Tekrardan Kontrol Ediniz.");
            }
            else
            {
                try
                {
                    sqlBaglan.BaglantiAc();
                    sqlBaglan.sorgu.Parameters.Clear();
                    sqlBaglan.sorgu.Connection = sqlBaglan.baglan;
                    sqlBaglan.sorgu.CommandText = "INSERT INTO tbl_harfSistemi (harfAdi,harfNotu) VALUES (@harfAdi, @harfNotu)";
                    sqlBaglan.sorgu.Parameters.AddWithValue("@harfAdi", txtharfAdi.Text.Trim());
                    sqlBaglan.sorgu.Parameters.AddWithValue("@harfNotu", txtharfDegeri.Text.Trim());
                    sqlBaglan.sorgu.ExecuteNonQuery();
                    MessageBox.Show("Harfli Not Kaydı Başarılı!");
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
}
