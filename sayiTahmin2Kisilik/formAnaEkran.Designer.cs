
namespace sayiTahmin2Kisilik
{
    partial class formAnaEkran
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
            this.components = new System.ComponentModel.Container();
            this.skor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.rtxtTahminSayisi = new System.Windows.Forms.RichTextBox();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.lblTahminEdenOyuncu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKalanHamleSayisi = new System.Windows.Forms.Label();
            this.lblKalanSüre = new System.Windows.Forms.Label();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lvSkorBoard = new System.Windows.Forms.ListView();
            this.txtTahminSayisi = new System.Windows.Forms.MaskedTextBox();
            this.btn_Dene = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // skor
            // 
            this.skor.Text = "Skor";
            this.skor.Width = 100;
            // 
            // isim
            // 
            this.isim.Text = "İsim";
            this.isim.Width = 340;
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // rtxtTahminSayisi
            // 
            this.rtxtTahminSayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTahminSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtTahminSayisi.Location = new System.Drawing.Point(12, 12);
            this.rtxtTahminSayisi.MaxLength = 3;
            this.rtxtTahminSayisi.Multiline = false;
            this.rtxtTahminSayisi.Name = "rtxtTahminSayisi";
            this.rtxtTahminSayisi.Size = new System.Drawing.Size(162, 26);
            this.rtxtTahminSayisi.TabIndex = 40;
            this.rtxtTahminSayisi.Text = "";
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Location = new System.Drawing.Point(384, 15);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(75, 23);
            this.btnAyarlar.TabIndex = 61;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // lblTahminEdenOyuncu
            // 
            this.lblTahminEdenOyuncu.AutoSize = true;
            this.lblTahminEdenOyuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahminEdenOyuncu.Location = new System.Drawing.Point(180, 78);
            this.lblTahminEdenOyuncu.Name = "lblTahminEdenOyuncu";
            this.lblTahminEdenOyuncu.Size = new System.Drawing.Size(65, 20);
            this.lblTahminEdenOyuncu.TabIndex = 53;
            this.lblTahminEdenOyuncu.Text = "Player 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(180, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Kalan Hamle Sayısı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(180, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Bir Sonraki Hamleye Kalan Süre : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(180, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tahmin Eden Oyuncu : ";
            // 
            // lblKalanHamleSayisi
            // 
            this.lblKalanHamleSayisi.AutoSize = true;
            this.lblKalanHamleSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanHamleSayisi.Location = new System.Drawing.Point(180, 190);
            this.lblKalanHamleSayisi.Name = "lblKalanHamleSayisi";
            this.lblKalanHamleSayisi.Size = new System.Drawing.Size(18, 20);
            this.lblKalanHamleSayisi.TabIndex = 47;
            this.lblKalanHamleSayisi.Text = "1";
            // 
            // lblKalanSüre
            // 
            this.lblKalanSüre.AutoSize = true;
            this.lblKalanSüre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanSüre.Location = new System.Drawing.Point(180, 134);
            this.lblKalanSüre.Name = "lblKalanSüre";
            this.lblKalanSüre.Size = new System.Drawing.Size(49, 20);
            this.lblKalanSüre.TabIndex = 45;
            this.lblKalanSüre.Text = "00.00";
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(124, 156);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(50, 50);
            this.btn_9.TabIndex = 57;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(124, 100);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(50, 50);
            this.btn_6.TabIndex = 54;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(124, 44);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(50, 50);
            this.btn_3.TabIndex = 46;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(369, 232);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(90, 30);
            this.btnBaslat.TabIndex = 39;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lvSkorBoard
            // 
            this.lvSkorBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.isim,
            this.skor});
            this.lvSkorBoard.Enabled = false;
            this.lvSkorBoard.HideSelection = false;
            this.lvSkorBoard.Location = new System.Drawing.Point(12, 268);
            this.lvSkorBoard.Name = "lvSkorBoard";
            this.lvSkorBoard.Size = new System.Drawing.Size(447, 89);
            this.lvSkorBoard.TabIndex = 44;
            this.lvSkorBoard.UseCompatibleStateImageBehavior = false;
            this.lvSkorBoard.View = System.Windows.Forms.View.Details;
            // 
            // txtTahminSayisi
            // 
            this.txtTahminSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTahminSayisi.Location = new System.Drawing.Point(180, 12);
            this.txtTahminSayisi.Mask = "0000";
            this.txtTahminSayisi.Name = "txtTahminSayisi";
            this.txtTahminSayisi.Size = new System.Drawing.Size(162, 26);
            this.txtTahminSayisi.TabIndex = 41;
            this.txtTahminSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTahminSayisi.ValidatingType = typeof(int);
            // 
            // btn_Dene
            // 
            this.btn_Dene.Location = new System.Drawing.Point(124, 212);
            this.btn_Dene.Name = "btn_Dene";
            this.btn_Dene.Size = new System.Drawing.Size(50, 50);
            this.btn_Dene.TabIndex = 59;
            this.btn_Dene.Text = "Dene";
            this.btn_Dene.UseVisualStyleBackColor = true;
            this.btn_Dene.Click += new System.EventHandler(this.btn_Dene_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(12, 212);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(50, 50);
            this.btn_Sil.TabIndex = 60;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(68, 212);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(50, 50);
            this.btn_0.TabIndex = 58;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(68, 156);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(50, 50);
            this.btn_8.TabIndex = 56;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(68, 100);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(50, 50);
            this.btn_5.TabIndex = 52;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(68, 44);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(50, 50);
            this.btn_2.TabIndex = 43;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 156);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(50, 50);
            this.btn_7.TabIndex = 55;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(12, 100);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(50, 50);
            this.btn_4.TabIndex = 48;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 44);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(50, 50);
            this.btn_1.TabIndex = 42;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(180, 228);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 34);
            this.textBox1.TabIndex = 62;
            this.textBox1.Text = "rakam; mavi ise yeri doğru, kırmızı ise yeri yanlış, siyah ise içerilmiyor";
            // 
            // formAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 365);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtxtTahminSayisi);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.lblTahminEdenOyuncu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKalanHamleSayisi);
            this.Controls.Add(this.lblKalanSüre);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lvSkorBoard);
            this.Controls.Add(this.txtTahminSayisi);
            this.Controls.Add(this.btn_Dene);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_1);
            this.Name = "formAnaEkran";
            this.Text = "formAnaEkran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader skor;
        private System.Windows.Forms.ColumnHeader isim;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.RichTextBox rtxtTahminSayisi;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Label lblTahminEdenOyuncu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKalanHamleSayisi;
        private System.Windows.Forms.Label lblKalanSüre;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.ListView lvSkorBoard;
        private System.Windows.Forms.MaskedTextBox txtTahminSayisi;
        private System.Windows.Forms.Button btn_Dene;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TextBox textBox1;
    }
}