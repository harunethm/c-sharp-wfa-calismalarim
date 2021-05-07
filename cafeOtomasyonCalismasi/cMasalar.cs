using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeOtomasyonu
{
    class cMasalar
    {
        #region Fields
        private int _ID;
        private int _Kapasite;
        private int _ServisTuru;
        private int _Durum;
        private int _Onay;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int Kapasite { get => _Kapasite; set => _Kapasite = value; }
        public int ServisTuru { get => _ServisTuru; set => _ServisTuru = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int Onay { get => _Onay; set => _Onay = value; }
        #endregion


        cGenel gnl = new cGenel();

        public string SessionSum(int state, string masaId)
        {
            string dt = "";

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select TARIH, MASAID from adisyonlar Right Join masalar on adisyonlar.MASAID=masalar.ID where masalar.DURUM=@durum and adisyonlar.DURUM=0 and masalar.ID=@masaId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Convert.ToInt32(masaId);

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                    dt = Convert.ToDateTime(dr["TARIH"]).ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }

        public int masaNoAl(string MasaNo)
        {
            return Convert.ToInt32(MasaNo.Substring(MasaNo.Length - 1, 1));
        }

        public bool masaDurumAl(int buttonName, int durum)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select DURUM from masalar Where ID=@tableId and DURUM=@durum", con);

            cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = buttonName;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = durum;

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string denek = Convert.ToString(cmd.ExecuteScalar());
                sonuc = Convert.ToBoolean(cmd.ExecuteScalar());
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

        public void masaDurumDegistir(string buttonName, int durum)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update masalar set DURUM=@durum where ID=@masaNo", con);

            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = durum;
            cmd.Parameters.Add("@masaNo", SqlDbType.Int).Value = buttonName.Substring(buttonName.Length - 1, 1);
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
    }
}
