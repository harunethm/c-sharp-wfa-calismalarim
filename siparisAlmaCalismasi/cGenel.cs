using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace siparisAlmaCalismasi
{
    class cGenel
    {
        public string baglantiMetni = "Server=DESKTOP-BFA0CC4;Database=denemev1.0;Trusted_Connection=True";

        public static int masaNumarası;
        public static decimal[] odenenMiktar = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public void lvYaz(ListView lv, int kategoriId)
        {
            cGenel cg = new cGenel();
            SqlConnection bag = new SqlConnection(cg.baglantiMetni);
            SqlCommand komut = new SqlCommand("select * from urunler where KATEGORIID=@kategoriId", bag);

            if (bag.State == ConnectionState.Closed)
                bag.Open();


            komut.Parameters.Add("@kategoriId", SqlDbType.Int).Value = kategoriId;

            SqlDataReader okuma = komut.ExecuteReader();
            int i = 0;
            lv.Items.Clear();
            while (okuma.Read())
            {
                //ad, fiyat, kategori id, id
                lv.Items.Add(okuma["URUNAD"].ToString());
                lv.Items[i].SubItems.Add(okuma["FIYAT"].ToString());
                lv.Items[i].SubItems.Add(okuma["ID"].ToString());
                lv.Items[i].SubItems.Add(okuma["KATEGORIID"].ToString());
                i++;
            }
        }
        public bool giris(string kullaniciAdi, string sifre)
        {
            bool a = false;
            cGenel gnl = new cGenel();
            SqlConnection baglanti = new SqlConnection(gnl.baglantiMetni);
            SqlCommand komut = new SqlCommand("select PAROLA from personeller where KULLANICIADI=@kullaniciadi", baglanti);
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut.Parameters.Add("@kullaniciadi", SqlDbType.NVarChar).Value = kullaniciAdi;
            SqlDataReader oku = komut.ExecuteReader();
            string dogruSifre = "";
            while (oku.Read())
            {
                dogruSifre = oku["PAROLA"].ToString();
            }
            if (sifre == dogruSifre)
            {
                a = true;
            }
            else
                MessageBox.Show("Şifre Yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return a;
        }
    }
}
