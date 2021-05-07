
namespace siparisAlmaCalismasi
{
    partial class formPaketServis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnIcecek = new System.Windows.Forms.Button();
            this.lvSiparisler = new System.Windows.Forms.ListView();
            this.chSiparislerAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSiparislerAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSiparislerFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSiparislerAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSiparislerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSiparislerKategoriId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTatlı = new System.Windows.Forms.Button();
            this.btnKahvaltı = new System.Windows.Forms.Button();
            this.btnYemek = new System.Windows.Forms.Button();
            this.btnMakarna = new System.Windows.Forms.Button();
            this.chAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKategoriId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lvIcindekiler = new System.Windows.Forms.ListView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisVer.Location = new System.Drawing.Point(582, 295);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(219, 60);
            this.btnSiparisVer.TabIndex = 37;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(6, 98);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(207, 86);
            this.txtAdres.TabIndex = 0;
            this.txtAdres.Text = "Adres";
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(6, 70);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(207, 22);
            this.txtTelefonNo.TabIndex = 0;
            this.txtTelefonNo.Text = "Telefon No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.txtTelefonNo);
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(582, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 190);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişisel Bilgiler";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(6, 42);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(207, 22);
            this.txtAdSoyad.TabIndex = 0;
            this.txtAdSoyad.Text = "Ad Soyad";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.SystemColors.Window;
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(582, 33);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(219, 60);
            this.txtAciklama.TabIndex = 35;
            this.txtAciklama.Text = "Açıklama Giriniz...";
            // 
            // btnIcecek
            // 
            this.btnIcecek.Location = new System.Drawing.Point(6, 283);
            this.btnIcecek.Name = "btnIcecek";
            this.btnIcecek.Size = new System.Drawing.Size(100, 60);
            this.btnIcecek.TabIndex = 4;
            this.btnIcecek.Text = "İçecek";
            this.btnIcecek.UseVisualStyleBackColor = true;
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
            this.lvSiparisler.Location = new System.Drawing.Point(356, 33);
            this.lvSiparisler.MultiSelect = false;
            this.lvSiparisler.Name = "lvSiparisler";
            this.lvSiparisler.Scrollable = false;
            this.lvSiparisler.Size = new System.Drawing.Size(220, 322);
            this.lvSiparisler.TabIndex = 31;
            this.lvSiparisler.UseCompatibleStateImageBehavior = false;
            this.lvSiparisler.View = System.Windows.Forms.View.Details;
            // 
            // chSiparislerAd
            // 
            this.chSiparislerAd.Text = "Ad";
            this.chSiparislerAd.Width = 120;
            // 
            // chSiparislerAdet
            // 
            this.chSiparislerAdet.Text = "Adet";
            this.chSiparislerAdet.Width = 50;
            // 
            // chSiparislerFiyat
            // 
            this.chSiparislerFiyat.Text = "Fiyat";
            this.chSiparislerFiyat.Width = 50;
            // 
            // chSiparislerAciklama
            // 
            this.chSiparislerAciklama.Text = "Açıklama";
            // 
            // chSiparislerId
            // 
            this.chSiparislerId.Text = "ID";
            // 
            // chSiparislerKategoriId
            // 
            this.chSiparislerKategoriId.Text = "Kategori ID";
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
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // btnTatlı
            // 
            this.btnTatlı.Location = new System.Drawing.Point(6, 217);
            this.btnTatlı.Name = "btnTatlı";
            this.btnTatlı.Size = new System.Drawing.Size(100, 60);
            this.btnTatlı.TabIndex = 3;
            this.btnTatlı.Text = "Tatlı";
            this.btnTatlı.UseVisualStyleBackColor = true;
            // 
            // btnKahvaltı
            // 
            this.btnKahvaltı.Location = new System.Drawing.Point(6, 151);
            this.btnKahvaltı.Name = "btnKahvaltı";
            this.btnKahvaltı.Size = new System.Drawing.Size(100, 60);
            this.btnKahvaltı.TabIndex = 2;
            this.btnKahvaltı.Text = "Kahvaltı";
            this.btnKahvaltı.UseVisualStyleBackColor = true;
            // 
            // btnYemek
            // 
            this.btnYemek.Location = new System.Drawing.Point(6, 85);
            this.btnYemek.Name = "btnYemek";
            this.btnYemek.Size = new System.Drawing.Size(100, 60);
            this.btnYemek.TabIndex = 1;
            this.btnYemek.Text = "Yemek";
            this.btnYemek.UseVisualStyleBackColor = true;
            // 
            // btnMakarna
            // 
            this.btnMakarna.Location = new System.Drawing.Point(6, 21);
            this.btnMakarna.Name = "btnMakarna";
            this.btnMakarna.Size = new System.Drawing.Size(100, 60);
            this.btnMakarna.TabIndex = 0;
            this.btnMakarna.Text = "Makarna";
            this.btnMakarna.UseVisualStyleBackColor = true;
            // 
            // chAd
            // 
            this.chAd.Text = "Ad";
            this.chAd.Width = 170;
            // 
            // chFiyat
            // 
            this.chFiyat.Text = "Fiyat";
            this.chFiyat.Width = 50;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            // 
            // chKategoriId
            // 
            this.chKategoriId.Text = "Kategori ID";
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(245, 333);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(105, 22);
            this.nudAdet.TabIndex = 29;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(182, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "ADET :";
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(687, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(54, 24);
            this.btnGeri.TabIndex = 32;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(747, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(54, 24);
            this.btnCikis.TabIndex = 33;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
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
            this.lvIcindekiler.Location = new System.Drawing.Point(130, 33);
            this.lvIcindekiler.MultiSelect = false;
            this.lvIcindekiler.Name = "lvIcindekiler";
            this.lvIcindekiler.Scrollable = false;
            this.lvIcindekiler.Size = new System.Drawing.Size(220, 294);
            this.lvIcindekiler.TabIndex = 30;
            this.lvIcindekiler.UseCompatibleStateImageBehavior = false;
            this.lvIcindekiler.View = System.Windows.Forms.View.Details;
            // 
            // formPaketServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 362);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lvSiparisler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lvIcindekiler);
            this.Name = "formPaketServis";
            this.Text = "formPaketServis";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnIcecek;
        private System.Windows.Forms.ListView lvSiparisler;
        private System.Windows.Forms.ColumnHeader chSiparislerAd;
        private System.Windows.Forms.ColumnHeader chSiparislerAdet;
        private System.Windows.Forms.ColumnHeader chSiparislerFiyat;
        private System.Windows.Forms.ColumnHeader chSiparislerAciklama;
        private System.Windows.Forms.ColumnHeader chSiparislerId;
        private System.Windows.Forms.ColumnHeader chSiparislerKategoriId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTatlı;
        private System.Windows.Forms.Button btnKahvaltı;
        private System.Windows.Forms.Button btnYemek;
        private System.Windows.Forms.Button btnMakarna;
        private System.Windows.Forms.ColumnHeader chAd;
        private System.Windows.Forms.ColumnHeader chFiyat;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chKategoriId;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListView lvIcindekiler;
    }
}