using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siparisAlmaCalismasi
    class cSiparisler
    {
        public void siparisEkle(int urunId, int adet, string fiyat, string aciklama)
        {
            cGenel cg = new cGenel();
            SqlConnection bag = new SqlConnection(cg.baglantiMetni);
            SqlCommand komut = new SqlCommand("select * from satislar where MASAID=" + cGenel.masaNumarası + " and URUNID=" + urunId, bag);
            if (bag.State == ConnectionState.Closed)
                bag.Open();
            int sayi = Convert.ToInt32(komut.ExecuteScalar());
            if (sayi > 0)
            {
                //bu ürün daha önce bu masada varsa güncelleme yapılır
                if (fiyat.Contains(","))
                {
                    fiyat = fiyat.Insert(fiyat.IndexOf(",") + 1, ".");
                    fiyat = fiyat.Remove(fiyat.IndexOf(","), 1);
                }
                komut = new SqlCommand("update satislar set ADET=" + adet + ", FIYAT=" + fiyat + " where MASAID=" + cGenel.masaNumarası + " and URUNID=" + urunId, bag);
                if (bag.State == ConnectionState.Closed)
                    bag.Open();
                komut.ExecuteNonQuery();
            }
            else
            {
                //masaya bu ürün ilk defa eklenir
                while (fiyat.Contains(","))
                {
                    fiyat = fiyat.Insert(fiyat.IndexOf(",") + 1, ".");
                    fiyat = fiyat.Remove(fiyat.IndexOf(","), 1);
                }
                komut = new SqlCommand("insert into satislar (ADISYONID, MASAID, URUNID, FIYAT, ADET, ACIKLAMA) values (" + cGenel.masaNumarası + "," + cGenel.masaNumarası + "," + urunId + "," + fiyat + "," + adet + ",'" + aciklama + "')", bag);
                if (bag.State == ConnectionState.Closed)
                    bag.Open();
                komut.ExecuteNonQuery();
            }
            komut.Dispose();
            bag.Close();
        }
        public void siparisSil(int urunId)
        {
            cGenel cg = new cGenel();
            SqlConnection bag = new SqlConnection(cg.baglantiMetni);
            SqlCommand komut = new SqlCommand("delete from satislar where URUNID=" + urunId + " and MASAID=" + cGenel.masaNumarası, bag);
            if (bag.State == ConnectionState.Closed)
                bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
        }
        public int borcCek()
        {
            int borc = 0;
            cGenel cg = new cGenel();
            SqlConnection bag = new SqlConnection(cg.baglantiMetni);
            SqlCommand komut = new SqlCommand("select sum(FIYAT) as BORC from satislar where MASAID=" + cGenel.masaNumarası, bag);
            if (bag.State == ConnectionState.Closed)
                bag.Open();
            SqlDataReader okuma = komut.ExecuteReader();
            while (okuma.Read())
                borc = okuma["BORC"] != DBNull.Value ? Convert.ToInt32(okuma["BORC"]) : 0;
            borc -= (int)cGenel.odenenMiktar[cGenel.masaNumarası];
            okuma.Close();
            bag.Close();
            return borc;
        }
    }
}