using cafeOtomasyonu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeOtomasyonCalismasi
{
    class cAdisyon
    {

        #region Fields
        private int _ID;
        private int _PersonelId;
        private int _MasaId;
        private decimal _Tutar;
        private int _ServisTurNo;
        private DateTime _Tarih;
        private bool _Durum;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public int ServisTurNo { get => _ServisTurNo; set => _ServisTurNo = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public bool Durum { get => _Durum; set => _Durum = value; }
        #endregion
        cGenel gnl = new cGenel();

        public int adisyondanAl(int masaId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID from adisyonlar where MASAID=@masaId order by ID desc", con);

            cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = masaId;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                masaId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Close();
            }

            return masaId;
        }

        public bool adisyonaYazYeni(cAdisyon bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into adisyonlar(SERVISTURNO, TARIH, PERSONELID, MASAID, DURUM) values(@servisTurNo, @tarih, @personelId, @masaId, @durum)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                cmd.Parameters.Add("@tarih", SqlDbType.DateTime).Value = bilgiler.Tarih;
                cmd.Parameters.Add("@servisTurNo", SqlDbType.Int).Value = bilgiler.ServisTurNo;
                cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = bilgiler.PersonelId;
                cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = bilgiler.MasaId;
                cmd.Parameters.Add("@durum", SqlDbType.Int).Value = 0;

                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
    }
}
