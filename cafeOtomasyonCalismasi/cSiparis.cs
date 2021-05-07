using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cafeOtomasyonu
{
    class cSiparis
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _ID;
        private int _AdisyonId;
        private int _UrunId;
        private int _MasaId;
        private int _Adet;
        private int _Durum;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int AdisyonId { get => _AdisyonId; set => _AdisyonId = value; }
        public int UrunId { get => _UrunId; set => _UrunId = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }
        public int Adet { get => _Adet; set => _Adet = value; }
        public int Durum { get => _Durum; set => _Durum = value; } 
        #endregion

        public void siparisGetir(ListView lv, int adisyonId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNAD, FIYAT, satislar.ID, URUNID, satislar.ADET, from satislar Inner join on satislar.URUNID=urunler.ID where ADISYONID = @adisyonId", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["Fiyat"]) * Convert.ToDecimal(dr["ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());

                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                //dr.Close();
                con.Dispose();
                con.Close();
            }
        }

        public bool siparisKaydet(cSiparis bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into satislar(ADISYONID, URUNID, ADET, MASAID) values(@adisyonNo, @urunId, @adet, @masaId)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                cmd.Parameters.Add("@adisyonNo", SqlDbType.Int).Value = bilgiler.AdisyonId;
                cmd.Parameters.Add("@urunId", SqlDbType.Int).Value = bilgiler.UrunId;
                cmd.Parameters.Add("@adet", SqlDbType.Int).Value = bilgiler.Adet;
                cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = bilgiler.MasaId;

                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }

        public void siparisSil(int satisId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("delete from satislar where ID=@satisId", con);
            cmd.Parameters.Add("@satisId", SqlDbType.Int).Value = satisId;

            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }

        public int urunIdAl(int masaId, int adisyonId)
        {           
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select URUNID from satislar where MASAID=@masaNo and ADISYONID=@adisyonId", con);
            SqlCommand cmd2 = new SqlCommand("select count URUNID from satislar where MASAID=@masaNo and ADISYONID=@adisyonId", con);
            
            if (con.State == ConnectionState.Closed)
                con.Open();

            int adet = Convert.ToInt32(cmd2.ExecuteScalar());
            int[] urunId = new int[adet];
            int i = 0;

            cmd.Parameters.Add("@masaNo", SqlDbType.Int).Value = masaId;
            cmd2.Parameters.Add("@masaNo", SqlDbType.Int).Value = masaId;
            cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
            cmd2.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                urunId[i] = Convert.ToInt32(dr["URUNID"]);
                i++;
            }

            con.Dispose();
            con.Close();

            return UrunId;
        }
    }
}