
namespace siparisAlmaCalismasi
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
            this.btnOde = new System.Windows.Forms.Button();
            this.txtKalanBorc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.chSiparislerKategoriId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSiparislerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSiparislerAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSiparislerFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSiparislerAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBorcOdeme = new System.Windows.Forms.TextBox();
            this.chSiparislerAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.chKategoriId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvIcindekiler = new System.Windows.Forms.ListView();
            this.btnTatlı = new System.Windows.Forms.Button();
            this.btnIcecek = new System.Windows.Forms.Button();
            this.btnKahvaltı = new System.Windows.Forms.Button();
            this.btnYemek = new System.Windows.Forms.Button();
            this.lvSiparisler = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMakarna = new System.Windows.Forms.Button();
            this.btnPaketSiparis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(356, 335);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(168, 25);
            this.btnOde.TabIndex = 27;
            this.btnOde.Text = "ÖDE";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.BtnOde_Click);
            // 
            // txtKalanBorc
            // 
            this.txtKalanBorc.Enabled = false;
            this.txtKalanBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKalanBorc.Location = new System.Drawing.Point(356, 279);
            this.txtKalanBorc.Name = "txtKalanBorc";
            this.txtKalanBorc.Size = new System.Drawing.Size(168, 22);
            this.txtKalanBorc.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(356, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "ADET :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(356, 57);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(168, 151);
            this.txtAciklama.TabIndex = 20;
            this.txtAciklama.Text = "Açıklama Giriniz...";
            this.txtAciklama.Enter += new System.EventHandler(this.TxtAciklama_Enter);
            this.txtAciklama.Leave += new System.EventHandler(this.TxtAciklama_Leave);
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.AutoSize = true;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.Location = new System.Drawing.Point(527, 7);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(76, 16);
            this.lblMasaNo.TabIndex = 17;
            this.lblMasaNo.Text = "MASA NO";
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(636, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(54, 24);
            this.btnGeri.TabIndex = 22;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(696, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(54, 24);
            this.btnCikis.TabIndex = 23;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // chSiparislerKategoriId
            // 
            this.chSiparislerKategoriId.Text = "Kategori ID";
            // 
            // chSiparislerId
            // 
            this.chSiparislerId.Text = "ID";
            // 
            // chSiparislerAciklama
            // 
            this.chSiparislerAciklama.Text = "Açıklama";
            // 
            // chSiparislerFiyat
            // 
            this.chSiparislerFiyat.Text = "Fiyat";
            this.chSiparislerFiyat.Width = 50;
            // 
            // chSiparislerAdet
            // 
            this.chSiparislerAdet.Text = "Adet";
            this.chSiparislerAdet.Width = 50;
            // 
            // txtBorcOdeme
            // 
            this.txtBorcOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBorcOdeme.Location = new System.Drawing.Point(356, 307);
            this.txtBorcOdeme.Name = "txtBorcOdeme";
            this.txtBorcOdeme.Size = new System.Drawing.Size(168, 22);
            this.txtBorcOdeme.TabIndex = 26;
            // 
            // chSiparislerAd
            // 
            this.chSiparislerAd.Text = "Ad";
            this.chSiparislerAd.Width = 120;
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(419, 31);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(105, 22);
            this.nudAdet.TabIndex = 18;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chKategoriId
            // 
            this.chKategoriId.Text = "Kategori ID";
            // 
            // chId
            // 
            this.chId.Text = "ID";
            // 
            // chFiyat
            // 
            this.chFiyat.Text = "Fiyat";
            this.chFiyat.Width = 50;
            // 
            // chAd
            // 
            this.chAd.Text = "Ad";
            this.chAd.Width = 170;
            // 
            // lvIcindekiler
            // 
            this.lvIcindekiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAd,
            this.chFiyat,
            this.chId,
            this.chKategoriId});
            this.lvIcindekiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvIcindekiler.FullRowSelect = true;
            this.lvIcindekiler.GridLines = true;
            this.lvIcindekiler.HideSelection = false;
            this.lvIcindekiler.Location = new System.Drawing.Point(130, 31);
            this.lvIcindekiler.MultiSelect = false;
            this.lvIcindekiler.Name = "lvIcindekiler";
            this.lvIcindekiler.Scrollable = false;
            this.lvIcindekiler.Size = new System.Drawing.Size(220, 329);
            this.lvIcindekiler.TabIndex = 19;
            this.lvIcindekiler.UseCompatibleStateImageBehavior = false;
            this.lvIcindekiler.View = System.Windows.Forms.View.Details;
            this.lvIcindekiler.DoubleClick += new System.EventHandler(this.LvIcindekiler_DoubleClick);
            // 
            // btnTatlı
            // 
            this.btnTatlı.Location = new System.Drawing.Point(6, 217);
            this.btnTatlı.Name = "btnTatlı";
            this.btnTatlı.Size = new System.Drawing.Size(100, 60);
            this.btnTatlı.TabIndex = 3;
            this.btnTatlı.Text = "Tatlı";
            this.btnTatlı.UseVisualStyleBackColor = true;
            this.btnTatlı.Click += new System.EventHandler(this.BtnTatlı_Click);
            // 
            // btnIcecek
            // 
            this.btnIcecek.Location = new System.Drawing.Point(6, 283);
            this.btnIcecek.Name = "btnIcecek";
            this.btnIcecek.Size = new System.Drawing.Size(100, 60);
            this.btnIcecek.TabIndex = 4;
            this.btnIcecek.Text = "İçecek";
            this.btnIcecek.UseVisualStyleBackColor = true;
            this.btnIcecek.Click += new System.EventHandler(this.BtnIcecek_Click);
            // 
            // btnKahvaltı
            // 
            this.btnKahvaltı.Location = new System.Drawing.Point(6, 151);
            this.btnKahvaltı.Name = "btnKahvaltı";
            this.btnKahvaltı.Size = new System.Drawing.Size(100, 60);
            this.btnKahvaltı.TabIndex = 2;
            this.btnKahvaltı.Text = "Kahvaltı";
            this.btnKahvaltı.UseVisualStyleBackColor = true;
            this.btnKahvaltı.Click += new System.EventHandler(this.BtnKahvaltı_Click);
            // 
            // btnYemek
            // 
            this.btnYemek.Location = new System.Drawing.Point(6, 85);
            this.btnYemek.Name = "btnYemek";
            this.btnYemek.Size = new System.Drawing.Size(100, 60);
            this.btnYemek.TabIndex = 1;
            this.btnYemek.Text = "Yemek";
            this.btnYemek.UseVisualStyleBackColor = true;
            this.btnYemek.Click += new System.EventHandler(this.BtnYemek_Click);
            // 
            // lvSiparisler
            // 
            this.lvSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSiparislerAd,
            this.chSiparislerAdet,
            this.chSiparislerFiyat,
            this.chSiparislerAciklama,
            this.chSiparislerId,
            this.chSiparislerKategoriId});
            this.lvSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvSiparisler.FullRowSelect = true;
            this.lvSiparisler.GridLines = true;
            this.lvSiparisler.HideSelection = false;
            this.lvSiparisler.Location = new System.Drawing.Point(530, 31);
            this.lvSiparisler.MultiSelect = false;
            this.lvSiparisler.Name = "lvSiparisler";
            this.lvSiparisler.Size = new System.Drawing.Size(220, 329);
            this.lvSiparisler.TabIndex = 21;
            this.lvSiparisler.UseCompatibleStateImageBehavior = false;
            this.lvSiparisler.View = System.Windows.Forms.View.Details;
            this.lvSiparisler.DoubleClick += new System.EventHandler(this.LvSiparisler_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTatlı);
            this.groupBox1.Controls.Add(this.btnIcecek);
            this.groupBox1.Controls.Add(this.btnKahvaltı);
            this.groupBox1.Controls.Add(this.btnYemek);
            this.groupBox1.Controls.Add(this.btnMakarna);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 348);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // btnMakarna
            // 
            this.btnMakarna.Location = new System.Drawing.Point(6, 19);
            this.btnMakarna.Name = "btnMakarna";
            this.btnMakarna.Size = new System.Drawing.Size(100, 60);
            this.btnMakarna.TabIndex = 0;
            this.btnMakarna.Text = "Makarna";
            this.btnMakarna.UseVisualStyleBackColor = true;
            this.btnMakarna.Click += new System.EventHandler(this.BtnMakarna_Click);
            // 
            // btnPaketSiparis
            // 
            this.btnPaketSiparis.Location = new System.Drawing.Point(406, 229);
            this.btnPaketSiparis.Name = "btnPaketSiparis";
            this.btnPaketSiparis.Size = new System.Drawing.Size(75, 23);
            this.btnPaketSiparis.TabIndex = 28;
            this.btnPaketSiparis.Text = "paket siparis";
            this.btnPaketSiparis.UseVisualStyleBackColor = true;
            this.btnPaketSiparis.Click += new System.EventHandler(this.btnPaketSiparis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 368);
            this.Controls.Add(this.btnPaketSiparis);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.txtKalanBorc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtBorcOdeme);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.lvIcindekiler);
            this.Controls.Add(this.lvSiparisler);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.TextBox txtKalanBorc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ColumnHeader chSiparislerKategoriId;
        private System.Windows.Forms.ColumnHeader chSiparislerId;
        private System.Windows.Forms.ColumnHeader chSiparislerAciklama;
        private System.Windows.Forms.ColumnHeader chSiparislerFiyat;
        private System.Windows.Forms.ColumnHeader chSiparislerAdet;
        private System.Windows.Forms.TextBox txtBorcOdeme;
        private System.Windows.Forms.ColumnHeader chSiparislerAd;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ColumnHeader chKategoriId;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chFiyat;
        private System.Windows.Forms.ColumnHeader chAd;
        private System.Windows.Forms.ListView lvIcindekiler;
        private System.Windows.Forms.Button btnTatlı;
        private System.Windows.Forms.Button btnIcecek;
        private System.Windows.Forms.Button btnKahvaltı;
        private System.Windows.Forms.Button btnYemek;
        private System.Windows.Forms.ListView lvSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMakarna;
        private System.Windows.Forms.Button btnPaketSiparis;
    }
}

