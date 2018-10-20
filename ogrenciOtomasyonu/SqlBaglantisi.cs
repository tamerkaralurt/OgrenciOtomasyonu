using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using NUnit.Framework;

namespace ogrenciOtomasyonu
{
    class SqlBaglantisi
    {
        public SqlConnection baglan = null;
        public string connectionString = null;
        public SqlCommand sorgu = null;
        public SqlDataReader dataReader = null;
        public SqlCommand sorgu1 = null;
        public SqlDataAdapter da = null;
        public SqlCommandBuilder sorgub = null;

        public SqlBaglantisi(){
            try
            {
                connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Dropbox\Ogrenci Otomasyonu Team Folder\ogrenciOtomasyonu\SqlOtomasyon.mdf;Integrated Security=True;Connect Timeout=30";
                baglan = new SqlConnection(connectionString);
                sorgu = new SqlCommand();
                sorgu1 = new SqlCommand();
                da = new SqlDataAdapter();
                sorgub = new SqlCommandBuilder();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BaglantiAc(){
            try
            {
                if (baglan.State == ConnectionState.Closed) { baglan.Open(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BaglantiKapat(){
            try
            {
                if (baglan.State == ConnectionState.Open) { baglan.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
