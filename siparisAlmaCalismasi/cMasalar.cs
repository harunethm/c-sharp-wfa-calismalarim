using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siparisAlmaCalismasi
{
    class cMasalar
    {
        public void masaBilgisi(string masa)
        {
            cGenel.masaNumarası = Convert.ToInt32(masa.Substring(masa.Length - 1, 1));
        }
        public void masaDurumDegistir(int masaNo, int durum)
        {
            cGenel cg = new cGenel();
            SqlConnection bag = new SqlConnection(cg.baglantiMetni);
            SqlCommand komut = new SqlCommand("update masalar set DURUM=@durum where ID=@masano", bag);
            komut.Parameters.AddWithValue("@durum", durum);
            komut.Parameters.AddWithValue("@masano", masaNo);
            if (bag.State == ConnectionState.Closed)
                bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
        }
        public void masaOdenenTutarEkle(int miktar)
        {
            cGenel cg = new cGenel();
            SqlConnection bag = new SqlConnection(cg.baglantiMetni);
            SqlCommand komut = new SqlCommand("update masalar set ODENENTUTAR=@miktar where MASAID=" + cGenel.masaNumarası, bag);
            if (bag.State == ConnectionState.Closed)
                bag.Open();
            komut.Parameters.AddWithValue("@miktar", miktar);
            komut.ExecuteNonQuery();

            decimal tutar = 0;
            komut = new SqlCommand("select ODENENTUTAR from masalar where MASAID=" + cGenel.masaNumarası, bag);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                tutar = Convert.ToDecimal(oku["ODENENTUTAR"]);
            }
            cGenel.odenenMiktar[cGenel.masaNumarası] = tutar;
        }
    }
}
