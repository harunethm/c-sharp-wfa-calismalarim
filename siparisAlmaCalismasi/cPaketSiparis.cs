using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siparisAlmaCalismasi
{
    class cPaketSiparis
    {
        public void siparisVer(int urunId, int adet, string aciklama, string adSoyad, string telNo, string adres)
        {
            cGenel cg = new cGenel();
            SqlConnection bag = new SqlConnection(cg.baglantiMetni);
            SqlCommand komut = new SqlCommand("insert into paketSiparis (URUNID, ADET, ACIKLAMA, M_ADSOYAD, M_TELEFONNO, M_ADRES) values (@urunId, @adet, @aciklama, @adSoyad, @telNo, @adres)", bag);
            komut.Parameters.AddWithValue("urunId", urunId);
            komut.Parameters.AddWithValue("adet", adet);
            komut.Parameters.AddWithValue("aciklama", aciklama);
            komut.Parameters.AddWithValue("adSoyad", adSoyad);
            komut.Parameters.AddWithValue("telNo", telNo);
            komut.Parameters.AddWithValue("adres", adres);
            if (bag.State == ConnectionState.Closed)
                bag.Open();
            komut.ExecuteNonQuery();
            komut.Dispose();
            bag.Close();
        }
    }
}
