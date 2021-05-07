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
    class cUrunCesitleri
    {
        cGenel gnl = new cGenel();

        #region fields and properties
        private int _UrunTurNo;
        private string _KategoriAd;
        private string _Aciklama;

        public int UrunTurNo { get => _UrunTurNo; set => _UrunTurNo = value; }
        public string KategoriAd { get => _KategoriAd; set => _KategoriAd = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; } 
        #endregion

        public void urunTipiAl(ListView cesitler, Button btn)
        {
            cesitler.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNAD, FIYAT, urunler.ID From kategoriler Inner join urunler on kategoriler.ID = urunler.KATEGORIID where urunler.KATEGORIID=@KATEGORIID", con);

            cmd.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = btn.Name.Substring(btn.Name.Length - 1, 1);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while(dr.Read())
            {
                cesitler.Items.Add(dr["URUNAD"].ToString());
                cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
    
        }
    }
}
