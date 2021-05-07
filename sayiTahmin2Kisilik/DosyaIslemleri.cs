using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiTahmin2Kisilik
{
    class DosyaIslemleri
    {
        public int Oku_skor(int oyuncu)
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\skorTablosu.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            String metin = sr.ReadToEnd();

            sr.Close();
            return Convert.ToInt32(metin.Substring(metin.IndexOf("oyuncu:" + oyuncu + "_skor:")));
        }

        internal void Yaz_skor(string oyuncu, int skor)
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\skorTablosu.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);

            if (sr.ReadToEnd().Contains("oyuncu:" + oyuncu))
            {
                string str = sr.ReadToEnd();
                string[] oyuncular = str.Split(';');
                int eskiSkor = 0;
                foreach (string p in oyuncular)
                {
                    if (p.Contains("oyuncu:" + oyuncu))
                        eskiSkor = Convert.ToInt32(p.Substring(p.IndexOf("_skor:") + 6));
                }
                str = str.Replace("oyuncu:" + oyuncu + "_skor:" + eskiSkor + ";", "oyuncu:" + oyuncu + "_skor:" + (eskiSkor + skor) + ";");
                sw.Write(str);

            }
            else
            {
                sw.WriteLine("oyuncu:" + oyuncu + "_skor:" + skor + ";");
            }
            try
            {
                sw.Flush();
                sr.Close();
                sw.Close();
            }
            catch
            {

            }
        }
    }
}
