
namespace adamAsmaca
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOyuncu = new System.Windows.Forms.GroupBox();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.lblTahminci = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_x = new System.Windows.Forms.Button();
            this.btn_i = new System.Windows.Forms.Button();
            this.btn_b = new System.Windows.Forms.Button();
            this.btn_j = new System.Windows.Forms.Button();
            this.btn_ı = new System.Windows.Forms.Button();
            this.btn_s = new System.Windows.Forms.Button();
            this.btn_ü = new System.Windows.Forms.Button();
            this.btn_z = new System.Windows.Forms.Button();
            this.btn_ş = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.nudHarfSayisi = new System.Windows.Forms.NumericUpDown();
            this.btn_r = new System.Windows.Forms.Button();
            this.btn_ç = new System.Windows.Forms.Button();
            this.btn_ö = new System.Windows.Forms.Button();
            this.btn_m = new System.Windows.Forms.Button();
            this.btn_n = new System.Windows.Forms.Button();
            this.btn_v = new System.Windows.Forms.Button();
            this.btn_h = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKelimeSil = new System.Windows.Forms.Button();
            this.btnKelimeEkle = new System.Windows.Forms.Button();
            this.btn_u = new System.Windows.Forms.Button();
            this.btn_ğ = new System.Windows.Forms.Button();
            this.btn_l = new System.Windows.Forms.Button();
            this.lvSkorTablosu = new System.Windows.Forms.ListView();
            this.columnOyuncu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSkor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbOyun = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_e = new System.Windows.Forms.Button();
            this.gbMahkum = new System.Windows.Forms.GroupBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.gbKlavye = new System.Windows.Forms.GroupBox();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_g = new System.Windows.Forms.Button();
            this.btn_y = new System.Windows.Forms.Button();
            this.btn_p = new System.Windows.Forms.Button();
            this.btn_k = new System.Windows.Forms.Button();
            this.btn_w = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.btn_a = new System.Windows.Forms.Button();
            this.btn_f = new System.Windows.Forms.Button();
            this.btn_t = new System.Windows.Forms.Button();
            this.btn_o = new System.Windows.Forms.Button();
            this.btn_q = new System.Windows.Forms.Button();
            this.gbKelime = new System.Windows.Forms.GroupBox();
            this.gbOyuncu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarfSayisi)).BeginInit();
            this.gbOyun.SuspendLayout();
            this.gbMahkum.SuspendLayout();
            this.gbKlavye.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOyuncu
            // 
            this.gbOyuncu.Controls.Add(this.lblSkor);
            this.gbOyuncu.Controls.Add(this.lblKalanHak);
            this.gbOyuncu.Controls.Add(this.lblTahminci);
            this.gbOyuncu.Controls.Add(this.label2);
            this.gbOyuncu.Controls.Add(this.label1);
            this.gbOyuncu.Controls.Add(this.label8);
            this.gbOyuncu.Location = new System.Drawing.Point(135, 12);
            this.gbOyuncu.Name = "gbOyuncu";
            this.gbOyuncu.Size = new System.Drawing.Size(159, 183);
            this.gbOyuncu.TabIndex = 22;
            this.gbOyuncu.TabStop = false;
            this.gbOyuncu.Text = "Oyuncu";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(11, 149);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(62, 13);
            this.lblSkor.TabIndex = 19;
            this.lblSkor.Text = "güncel skor";
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Location = new System.Drawing.Point(11, 94);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(54, 13);
            this.lblKalanHak.TabIndex = 18;
            this.lblKalanHak.Text = "kalan hak";
            // 
            // lblTahminci
            // 
            this.lblTahminci.AutoSize = true;
            this.lblTahminci.Location = new System.Drawing.Point(11, 39);
            this.lblTahminci.Name = "lblTahminci";
            this.lblTahminci.Size = new System.Drawing.Size(59, 13);
            this.lblTahminci.TabIndex = 17;
            this.lblTahminci.Text = "oyuncu adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Skor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tahmin Eden Oyuncu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kalan Hak : ";
            // 
            // btn_x
            // 
            this.btn_x.Location = new System.Drawing.Point(78, 91);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(30, 30);
            this.btn_x.TabIndex = 25;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_i
            // 
            this.btn_i.Location = new System.Drawing.Point(388, 55);
            this.btn_i.Name = "btn_i";
            this.btn_i.Size = new System.Drawing.Size(30, 30);
            this.btn_i.TabIndex = 23;
            this.btn_i.Text = "İ";
            this.btn_i.UseVisualStyleBackColor = true;
            this.btn_i.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_b
            // 
            this.btn_b.Location = new System.Drawing.Point(186, 91);
            this.btn_b.Name = "btn_b";
            this.btn_b.Size = new System.Drawing.Size(30, 30);
            this.btn_b.TabIndex = 28;
            this.btn_b.Text = "B";
            this.btn_b.UseVisualStyleBackColor = true;
            this.btn_b.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_j
            // 
            this.btn_j.Location = new System.Drawing.Point(244, 55);
            this.btn_j.Name = "btn_j";
            this.btn_j.Size = new System.Drawing.Size(30, 30);
            this.btn_j.TabIndex = 19;
            this.btn_j.Text = "J";
            this.btn_j.UseVisualStyleBackColor = true;
            this.btn_j.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_ı
            // 
            this.btn_ı.Location = new System.Drawing.Point(258, 19);
            this.btn_ı.Name = "btn_ı";
            this.btn_ı.Size = new System.Drawing.Size(30, 30);
            this.btn_ı.TabIndex = 8;
            this.btn_ı.Text = "I";
            this.btn_ı.UseVisualStyleBackColor = true;
            this.btn_ı.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_s
            // 
            this.btn_s.Location = new System.Drawing.Point(64, 55);
            this.btn_s.Name = "btn_s";
            this.btn_s.Size = new System.Drawing.Size(30, 30);
            this.btn_s.TabIndex = 14;
            this.btn_s.Text = "S";
            this.btn_s.UseVisualStyleBackColor = true;
            this.btn_s.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_ü
            // 
            this.btn_ü.Location = new System.Drawing.Point(402, 19);
            this.btn_ü.Name = "btn_ü";
            this.btn_ü.Size = new System.Drawing.Size(30, 30);
            this.btn_ü.TabIndex = 12;
            this.btn_ü.Text = "Ü";
            this.btn_ü.UseVisualStyleBackColor = true;
            this.btn_ü.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_z
            // 
            this.btn_z.Location = new System.Drawing.Point(42, 91);
            this.btn_z.Name = "btn_z";
            this.btn_z.Size = new System.Drawing.Size(30, 30);
            this.btn_z.TabIndex = 24;
            this.btn_z.Text = "Z";
            this.btn_z.UseVisualStyleBackColor = true;
            this.btn_z.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_ş
            // 
            this.btn_ş.Location = new System.Drawing.Point(352, 55);
            this.btn_ş.Name = "btn_ş";
            this.btn_ş.Size = new System.Drawing.Size(30, 30);
            this.btn_ş.TabIndex = 22;
            this.btn_ş.Text = "Ş";
            this.btn_ş.UseVisualStyleBackColor = true;
            this.btn_ş.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(88, 49);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(72, 30);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // nudHarfSayisi
            // 
            this.nudHarfSayisi.Location = new System.Drawing.Point(317, 14);
            this.nudHarfSayisi.Name = "nudHarfSayisi";
            this.nudHarfSayisi.Size = new System.Drawing.Size(73, 20);
            this.nudHarfSayisi.TabIndex = 0;
            // 
            // btn_r
            // 
            this.btn_r.Location = new System.Drawing.Point(114, 19);
            this.btn_r.Name = "btn_r";
            this.btn_r.Size = new System.Drawing.Size(30, 30);
            this.btn_r.TabIndex = 4;
            this.btn_r.Text = "R";
            this.btn_r.UseVisualStyleBackColor = true;
            this.btn_r.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_ç
            // 
            this.btn_ç.Location = new System.Drawing.Point(330, 91);
            this.btn_ç.Name = "btn_ç";
            this.btn_ç.Size = new System.Drawing.Size(30, 30);
            this.btn_ç.TabIndex = 32;
            this.btn_ç.Text = "Ç";
            this.btn_ç.UseVisualStyleBackColor = true;
            this.btn_ç.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_ö
            // 
            this.btn_ö.Location = new System.Drawing.Point(294, 91);
            this.btn_ö.Name = "btn_ö";
            this.btn_ö.Size = new System.Drawing.Size(30, 30);
            this.btn_ö.TabIndex = 31;
            this.btn_ö.Text = "Ö";
            this.btn_ö.UseVisualStyleBackColor = true;
            this.btn_ö.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_m
            // 
            this.btn_m.Location = new System.Drawing.Point(258, 91);
            this.btn_m.Name = "btn_m";
            this.btn_m.Size = new System.Drawing.Size(30, 30);
            this.btn_m.TabIndex = 30;
            this.btn_m.Text = "M";
            this.btn_m.UseVisualStyleBackColor = true;
            this.btn_m.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_n
            // 
            this.btn_n.Location = new System.Drawing.Point(222, 91);
            this.btn_n.Name = "btn_n";
            this.btn_n.Size = new System.Drawing.Size(30, 30);
            this.btn_n.TabIndex = 29;
            this.btn_n.Text = "N";
            this.btn_n.UseVisualStyleBackColor = true;
            this.btn_n.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_v
            // 
            this.btn_v.Location = new System.Drawing.Point(150, 91);
            this.btn_v.Name = "btn_v";
            this.btn_v.Size = new System.Drawing.Size(30, 30);
            this.btn_v.TabIndex = 27;
            this.btn_v.Text = "V";
            this.btn_v.UseVisualStyleBackColor = true;
            this.btn_v.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_h
            // 
            this.btn_h.Location = new System.Drawing.Point(208, 55);
            this.btn_h.Name = "btn_h";
            this.btn_h.Size = new System.Drawing.Size(30, 30);
            this.btn_h.TabIndex = 18;
            this.btn_h.Text = "H";
            this.btn_h.UseVisualStyleBackColor = true;
            this.btn_h.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // btnKelimeSil
            // 
            this.btnKelimeSil.Location = new System.Drawing.Point(169, 49);
            this.btnKelimeSil.Name = "btnKelimeSil";
            this.btnKelimeSil.Size = new System.Drawing.Size(72, 30);
            this.btnKelimeSil.TabIndex = 0;
            this.btnKelimeSil.Text = "Kelime Sil";
            this.btnKelimeSil.UseVisualStyleBackColor = true;
            // 
            // btnKelimeEkle
            // 
            this.btnKelimeEkle.Location = new System.Drawing.Point(247, 49);
            this.btnKelimeEkle.Name = "btnKelimeEkle";
            this.btnKelimeEkle.Size = new System.Drawing.Size(72, 30);
            this.btnKelimeEkle.TabIndex = 0;
            this.btnKelimeEkle.Text = "Kelime Ekle";
            this.btnKelimeEkle.UseVisualStyleBackColor = true;
            // 
            // btn_u
            // 
            this.btn_u.Location = new System.Drawing.Point(222, 19);
            this.btn_u.Name = "btn_u";
            this.btn_u.Size = new System.Drawing.Size(30, 30);
            this.btn_u.TabIndex = 7;
            this.btn_u.Text = "U";
            this.btn_u.UseVisualStyleBackColor = true;
            this.btn_u.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_ğ
            // 
            this.btn_ğ.Location = new System.Drawing.Point(366, 19);
            this.btn_ğ.Name = "btn_ğ";
            this.btn_ğ.Size = new System.Drawing.Size(30, 30);
            this.btn_ğ.TabIndex = 11;
            this.btn_ğ.Text = "Ğ";
            this.btn_ğ.UseVisualStyleBackColor = true;
            this.btn_ğ.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_l
            // 
            this.btn_l.Location = new System.Drawing.Point(316, 55);
            this.btn_l.Name = "btn_l";
            this.btn_l.Size = new System.Drawing.Size(30, 30);
            this.btn_l.TabIndex = 21;
            this.btn_l.Text = "L";
            this.btn_l.UseVisualStyleBackColor = true;
            this.btn_l.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // lvSkorTablosu
            // 
            this.lvSkorTablosu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOyuncu,
            this.columnSkor});
            this.lvSkorTablosu.HideSelection = false;
            this.lvSkorTablosu.Location = new System.Drawing.Point(12, 201);
            this.lvSkorTablosu.Name = "lvSkorTablosu";
            this.lvSkorTablosu.Size = new System.Drawing.Size(324, 85);
            this.lvSkorTablosu.TabIndex = 23;
            this.lvSkorTablosu.UseCompatibleStateImageBehavior = false;
            this.lvSkorTablosu.View = System.Windows.Forms.View.Details;
            // 
            // columnOyuncu
            // 
            this.columnOyuncu.Text = "Oyuncu";
            this.columnOyuncu.Width = 260;
            // 
            // columnSkor
            // 
            this.columnSkor.Text = "Skor";
            // 
            // gbOyun
            // 
            this.gbOyun.Controls.Add(this.label4);
            this.gbOyun.Controls.Add(this.btnKelimeSil);
            this.gbOyun.Controls.Add(this.btnKelimeEkle);
            this.gbOyun.Controls.Add(this.btnBaslat);
            this.gbOyun.Controls.Add(this.label3);
            this.gbOyun.Controls.Add(this.nudHarfSayisi);
            this.gbOyun.Location = new System.Drawing.Point(342, 201);
            this.gbOyun.Name = "gbOyun";
            this.gbOyun.Size = new System.Drawing.Size(396, 85);
            this.gbOyun.TabIndex = 24;
            this.gbOyun.TabStop = false;
            this.gbOyun.Text = "Oyun";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tahmin Edilecek Kelimenin Harf Sayısı (0-Rastgele) :";
            // 
            // btn_e
            // 
            this.btn_e.Location = new System.Drawing.Point(78, 19);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(30, 30);
            this.btn_e.TabIndex = 3;
            this.btn_e.Text = "E";
            this.btn_e.UseVisualStyleBackColor = true;
            this.btn_e.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // gbMahkum
            // 
            this.gbMahkum.Controls.Add(this.lbl_1);
            this.gbMahkum.Controls.Add(this.lbl_2);
            this.gbMahkum.Controls.Add(this.lbl_5);
            this.gbMahkum.Controls.Add(this.lbl_3);
            this.gbMahkum.Controls.Add(this.lbl_4);
            this.gbMahkum.Controls.Add(this.lbl_6);
            this.gbMahkum.Location = new System.Drawing.Point(12, 12);
            this.gbMahkum.Name = "gbMahkum";
            this.gbMahkum.Size = new System.Drawing.Size(117, 183);
            this.gbMahkum.TabIndex = 19;
            this.gbMahkum.TabStop = false;
            this.gbMahkum.Text = "Asılan Mahkum";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_1.Location = new System.Drawing.Point(55, 126);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(38, 55);
            this.lbl_1.TabIndex = 11;
            this.lbl_1.Text = "\\";
            this.lbl_1.Visible = false;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_2.Location = new System.Drawing.Point(20, 126);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(38, 55);
            this.lbl_2.TabIndex = 10;
            this.lbl_2.Text = "/";
            this.lbl_2.Visible = false;
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_5.Location = new System.Drawing.Point(36, 72);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(37, 55);
            this.lbl_5.TabIndex = 9;
            this.lbl_5.Text = "|";
            this.lbl_5.Visible = false;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_3.Location = new System.Drawing.Point(65, 71);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(38, 55);
            this.lbl_3.TabIndex = 8;
            this.lbl_3.Text = "\\";
            this.lbl_3.Visible = false;
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_4.Location = new System.Drawing.Point(11, 71);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(38, 55);
            this.lbl_4.TabIndex = 7;
            this.lbl_4.Text = "/";
            this.lbl_4.Visible = false;
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.BackColor = System.Drawing.Color.Transparent;
            this.lbl_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_6.Location = new System.Drawing.Point(20, 16);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(62, 55);
            this.lbl_6.TabIndex = 6;
            this.lbl_6.Text = "O";
            this.lbl_6.Visible = false;
            // 
            // gbKlavye
            // 
            this.gbKlavye.Controls.Add(this.btn_x);
            this.gbKlavye.Controls.Add(this.btn_i);
            this.gbKlavye.Controls.Add(this.btn_b);
            this.gbKlavye.Controls.Add(this.btn_j);
            this.gbKlavye.Controls.Add(this.btn_ı);
            this.gbKlavye.Controls.Add(this.btn_s);
            this.gbKlavye.Controls.Add(this.btn_ü);
            this.gbKlavye.Controls.Add(this.btn_z);
            this.gbKlavye.Controls.Add(this.btn_ş);
            this.gbKlavye.Controls.Add(this.btn_r);
            this.gbKlavye.Controls.Add(this.btn_ç);
            this.gbKlavye.Controls.Add(this.btn_ö);
            this.gbKlavye.Controls.Add(this.btn_m);
            this.gbKlavye.Controls.Add(this.btn_n);
            this.gbKlavye.Controls.Add(this.btn_v);
            this.gbKlavye.Controls.Add(this.btn_h);
            this.gbKlavye.Controls.Add(this.btn_u);
            this.gbKlavye.Controls.Add(this.btn_ğ);
            this.gbKlavye.Controls.Add(this.btn_l);
            this.gbKlavye.Controls.Add(this.btn_e);
            this.gbKlavye.Controls.Add(this.btn_c);
            this.gbKlavye.Controls.Add(this.btn_g);
            this.gbKlavye.Controls.Add(this.btn_y);
            this.gbKlavye.Controls.Add(this.btn_p);
            this.gbKlavye.Controls.Add(this.btn_k);
            this.gbKlavye.Controls.Add(this.btn_w);
            this.gbKlavye.Controls.Add(this.btn_d);
            this.gbKlavye.Controls.Add(this.btn_a);
            this.gbKlavye.Controls.Add(this.btn_f);
            this.gbKlavye.Controls.Add(this.btn_t);
            this.gbKlavye.Controls.Add(this.btn_o);
            this.gbKlavye.Controls.Add(this.btn_q);
            this.gbKlavye.Location = new System.Drawing.Point(300, 70);
            this.gbKlavye.Name = "gbKlavye";
            this.gbKlavye.Size = new System.Drawing.Size(438, 125);
            this.gbKlavye.TabIndex = 21;
            this.gbKlavye.TabStop = false;
            this.gbKlavye.Text = "Klavye";
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(114, 91);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(30, 30);
            this.btn_c.TabIndex = 26;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_g
            // 
            this.btn_g.Location = new System.Drawing.Point(172, 55);
            this.btn_g.Name = "btn_g";
            this.btn_g.Size = new System.Drawing.Size(30, 30);
            this.btn_g.TabIndex = 17;
            this.btn_g.Text = "G";
            this.btn_g.UseVisualStyleBackColor = true;
            this.btn_g.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_y
            // 
            this.btn_y.Location = new System.Drawing.Point(186, 19);
            this.btn_y.Name = "btn_y";
            this.btn_y.Size = new System.Drawing.Size(30, 30);
            this.btn_y.TabIndex = 6;
            this.btn_y.Text = "Y";
            this.btn_y.UseVisualStyleBackColor = true;
            this.btn_y.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_p
            // 
            this.btn_p.Location = new System.Drawing.Point(330, 19);
            this.btn_p.Name = "btn_p";
            this.btn_p.Size = new System.Drawing.Size(30, 30);
            this.btn_p.TabIndex = 10;
            this.btn_p.Text = "P";
            this.btn_p.UseVisualStyleBackColor = true;
            this.btn_p.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_k
            // 
            this.btn_k.Location = new System.Drawing.Point(280, 55);
            this.btn_k.Name = "btn_k";
            this.btn_k.Size = new System.Drawing.Size(30, 30);
            this.btn_k.TabIndex = 20;
            this.btn_k.Text = "K";
            this.btn_k.UseVisualStyleBackColor = true;
            this.btn_k.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_w
            // 
            this.btn_w.Location = new System.Drawing.Point(42, 19);
            this.btn_w.Name = "btn_w";
            this.btn_w.Size = new System.Drawing.Size(30, 30);
            this.btn_w.TabIndex = 2;
            this.btn_w.Text = "W";
            this.btn_w.UseVisualStyleBackColor = true;
            this.btn_w.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_d
            // 
            this.btn_d.Location = new System.Drawing.Point(100, 55);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(30, 30);
            this.btn_d.TabIndex = 15;
            this.btn_d.Text = "D";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_a
            // 
            this.btn_a.Location = new System.Drawing.Point(28, 55);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(30, 30);
            this.btn_a.TabIndex = 13;
            this.btn_a.Text = "A";
            this.btn_a.UseVisualStyleBackColor = true;
            this.btn_a.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_f
            // 
            this.btn_f.Location = new System.Drawing.Point(136, 55);
            this.btn_f.Name = "btn_f";
            this.btn_f.Size = new System.Drawing.Size(30, 30);
            this.btn_f.TabIndex = 16;
            this.btn_f.Text = "F";
            this.btn_f.UseVisualStyleBackColor = true;
            this.btn_f.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_t
            // 
            this.btn_t.Location = new System.Drawing.Point(150, 19);
            this.btn_t.Name = "btn_t";
            this.btn_t.Size = new System.Drawing.Size(30, 30);
            this.btn_t.TabIndex = 5;
            this.btn_t.Text = "T";
            this.btn_t.UseVisualStyleBackColor = true;
            this.btn_t.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_o
            // 
            this.btn_o.Location = new System.Drawing.Point(294, 19);
            this.btn_o.Name = "btn_o";
            this.btn_o.Size = new System.Drawing.Size(30, 30);
            this.btn_o.TabIndex = 9;
            this.btn_o.Text = "O";
            this.btn_o.UseVisualStyleBackColor = true;
            this.btn_o.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // btn_q
            // 
            this.btn_q.Location = new System.Drawing.Point(6, 19);
            this.btn_q.Name = "btn_q";
            this.btn_q.Size = new System.Drawing.Size(30, 30);
            this.btn_q.TabIndex = 1;
            this.btn_q.Text = "Q";
            this.btn_q.UseVisualStyleBackColor = true;
            this.btn_q.Click += new System.EventHandler(this.Klavye_Click);
            // 
            // gbKelime
            // 
            this.gbKelime.Location = new System.Drawing.Point(300, 12);
            this.gbKelime.Name = "gbKelime";
            this.gbKelime.Size = new System.Drawing.Size(438, 52);
            this.gbKelime.TabIndex = 20;
            this.gbKelime.TabStop = false;
            this.gbKelime.Text = "Tahmin Edilecek Kelime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 295);
            this.Controls.Add(this.gbOyuncu);
            this.Controls.Add(this.lvSkorTablosu);
            this.Controls.Add(this.gbOyun);
            this.Controls.Add(this.gbMahkum);
            this.Controls.Add(this.gbKlavye);
            this.Controls.Add(this.gbKelime);
            this.Name = "Form1";
            this.Text = "Adam Asmaca";
            this.gbOyuncu.ResumeLayout(false);
            this.gbOyuncu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarfSayisi)).EndInit();
            this.gbOyun.ResumeLayout(false);
            this.gbOyun.PerformLayout();
            this.gbMahkum.ResumeLayout(false);
            this.gbMahkum.PerformLayout();
            this.gbKlavye.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOyuncu;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Label lblTahminci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button btn_i;
        private System.Windows.Forms.Button btn_b;
        private System.Windows.Forms.Button btn_j;
        private System.Windows.Forms.Button btn_ı;
        private System.Windows.Forms.Button btn_s;
        private System.Windows.Forms.Button btn_ü;
        private System.Windows.Forms.Button btn_z;
        private System.Windows.Forms.Button btn_ş;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.NumericUpDown nudHarfSayisi;
        private System.Windows.Forms.Button btn_r;
        private System.Windows.Forms.Button btn_ç;
        private System.Windows.Forms.Button btn_ö;
        private System.Windows.Forms.Button btn_m;
        private System.Windows.Forms.Button btn_n;
        private System.Windows.Forms.Button btn_v;
        private System.Windows.Forms.Button btn_h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKelimeSil;
        private System.Windows.Forms.Button btnKelimeEkle;
        private System.Windows.Forms.Button btn_u;
        private System.Windows.Forms.Button btn_ğ;
        private System.Windows.Forms.Button btn_l;
        private System.Windows.Forms.ListView lvSkorTablosu;
        private System.Windows.Forms.ColumnHeader columnOyuncu;
        private System.Windows.Forms.ColumnHeader columnSkor;
        private System.Windows.Forms.GroupBox gbOyun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_e;
        private System.Windows.Forms.GroupBox gbMahkum;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.GroupBox gbKlavye;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_g;
        private System.Windows.Forms.Button btn_y;
        private System.Windows.Forms.Button btn_p;
        private System.Windows.Forms.Button btn_k;
        private System.Windows.Forms.Button btn_w;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Button btn_a;
        private System.Windows.Forms.Button btn_f;
        private System.Windows.Forms.Button btn_t;
        private System.Windows.Forms.Button btn_o;
        private System.Windows.Forms.Button btn_q;
        private System.Windows.Forms.GroupBox gbKelime;
    }
}

