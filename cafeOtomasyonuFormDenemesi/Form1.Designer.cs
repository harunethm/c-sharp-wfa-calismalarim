
namespace cafeOtomasyonuFormDenemesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDownIcecek = new System.Windows.Forms.NumericUpDown();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numericUpDownYiyecek = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonOde = new System.Windows.Forms.Button();
            this.radioButtonNakit = new System.Windows.Forms.RadioButton();
            this.radioButtonKrediKarti = new System.Windows.Forms.RadioButton();
            this.textBoxKalanBorc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTahsilEdilen = new System.Windows.Forms.TextBox();
            this.textBoxBorc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonTumunuSec = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxMasaNo = new System.Windows.Forms.TextBox();
            this.comboBoxIcecek = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxYiyecek = new System.Windows.Forms.ComboBox();
            this.buttonMasaNo5 = new System.Windows.Forms.Button();
            this.buttonMasaNo9 = new System.Windows.Forms.Button();
            this.buttonMasaNo8 = new System.Windows.Forms.Button();
            this.buttonMasaNo6 = new System.Windows.Forms.Button();
            this.buttonMasaNo7 = new System.Windows.Forms.Button();
            this.buttonMasaNo2 = new System.Windows.Forms.Button();
            this.buttonMasaNo4 = new System.Windows.Forms.Button();
            this.buttonMasaNo1 = new System.Windows.Forms.Button();
            this.buttonMasaNo3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIcecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYiyecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownIcecek
            // 
            this.numericUpDownIcecek.Location = new System.Drawing.Point(450, 220);
            this.numericUpDownIcecek.Name = "numericUpDownIcecek";
            this.numericUpDownIcecek.Size = new System.Drawing.Size(235, 20);
            this.numericUpDownIcecek.TabIndex = 67;
            this.numericUpDownIcecek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 120;
            // 
            // numericUpDownYiyecek
            // 
            this.numericUpDownYiyecek.Location = new System.Drawing.Point(450, 130);
            this.numericUpDownYiyecek.Name = "numericUpDownYiyecek";
            this.numericUpDownYiyecek.Size = new System.Drawing.Size(235, 20);
            this.numericUpDownYiyecek.TabIndex = 66;
            this.numericUpDownYiyecek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(694, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(232, 233);
            this.listView1.TabIndex = 65;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(447, -2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Sipariş";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(460, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Ödeme";
            // 
            // buttonOde
            // 
            this.buttonOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOde.Location = new System.Drawing.Point(555, 392);
            this.buttonOde.Name = "buttonOde";
            this.buttonOde.Size = new System.Drawing.Size(128, 22);
            this.buttonOde.TabIndex = 50;
            this.buttonOde.Text = "Öde";
            this.buttonOde.UseVisualStyleBackColor = true;
            // 
            // radioButtonNakit
            // 
            this.radioButtonNakit.AutoSize = true;
            this.radioButtonNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNakit.Location = new System.Drawing.Point(689, 365);
            this.radioButtonNakit.Name = "radioButtonNakit";
            this.radioButtonNakit.Size = new System.Drawing.Size(62, 20);
            this.radioButtonNakit.TabIndex = 48;
            this.radioButtonNakit.TabStop = true;
            this.radioButtonNakit.Text = "Nakit";
            this.radioButtonNakit.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrediKarti
            // 
            this.radioButtonKrediKarti.AutoSize = true;
            this.radioButtonKrediKarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrediKarti.Location = new System.Drawing.Point(689, 339);
            this.radioButtonKrediKarti.Name = "radioButtonKrediKarti";
            this.radioButtonKrediKarti.Size = new System.Drawing.Size(97, 20);
            this.radioButtonKrediKarti.TabIndex = 47;
            this.radioButtonKrediKarti.TabStop = true;
            this.radioButtonKrediKarti.Text = "Kredi Kartı";
            this.radioButtonKrediKarti.UseVisualStyleBackColor = true;
            // 
            // textBoxKalanBorc
            // 
            this.textBoxKalanBorc.Enabled = false;
            this.textBoxKalanBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKalanBorc.Location = new System.Drawing.Point(555, 420);
            this.textBoxKalanBorc.Name = "textBoxKalanBorc";
            this.textBoxKalanBorc.Size = new System.Drawing.Size(128, 22);
            this.textBoxKalanBorc.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Kalan Borç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Tahsil Edilen";
            // 
            // textBoxTahsilEdilen
            // 
            this.textBoxTahsilEdilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTahsilEdilen.Location = new System.Drawing.Point(555, 364);
            this.textBoxTahsilEdilen.Name = "textBoxTahsilEdilen";
            this.textBoxTahsilEdilen.Size = new System.Drawing.Size(128, 22);
            this.textBoxTahsilEdilen.TabIndex = 45;
            // 
            // textBoxBorc
            // 
            this.textBoxBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBorc.Location = new System.Drawing.Point(555, 336);
            this.textBoxBorc.Name = "textBoxBorc";
            this.textBoxBorc.Size = new System.Drawing.Size(128, 22);
            this.textBoxBorc.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Borç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Adet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Adet";
            // 
            // buttonTumunuSec
            // 
            this.buttonTumunuSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTumunuSec.Location = new System.Drawing.Point(694, 249);
            this.buttonTumunuSec.Name = "buttonTumunuSec";
            this.buttonTumunuSec.Size = new System.Drawing.Size(114, 36);
            this.buttonTumunuSec.TabIndex = 53;
            this.buttonTumunuSec.Text = "Tümünü Seç";
            this.buttonTumunuSec.UseVisualStyleBackColor = true;
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSil.Location = new System.Drawing.Point(812, 249);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(114, 36);
            this.buttonSil.TabIndex = 41;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEkle.Location = new System.Drawing.Point(448, 248);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(235, 36);
            this.buttonEkle.TabIndex = 39;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            // 
            // textBoxMasaNo
            // 
            this.textBoxMasaNo.Enabled = false;
            this.textBoxMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMasaNo.Location = new System.Drawing.Point(450, 35);
            this.textBoxMasaNo.Name = "textBoxMasaNo";
            this.textBoxMasaNo.Size = new System.Drawing.Size(235, 22);
            this.textBoxMasaNo.TabIndex = 52;
            this.textBoxMasaNo.Text = "Masa Numarası";
            // 
            // comboBoxIcecek
            // 
            this.comboBoxIcecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIcecek.FormattingEnabled = true;
            this.comboBoxIcecek.Location = new System.Drawing.Point(450, 174);
            this.comboBoxIcecek.Name = "comboBoxIcecek";
            this.comboBoxIcecek.Size = new System.Drawing.Size(235, 24);
            this.comboBoxIcecek.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "İçecek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Yiyecek";
            // 
            // comboBoxYiyecek
            // 
            this.comboBoxYiyecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYiyecek.FormattingEnabled = true;
            this.comboBoxYiyecek.Location = new System.Drawing.Point(450, 84);
            this.comboBoxYiyecek.Name = "comboBoxYiyecek";
            this.comboBoxYiyecek.Size = new System.Drawing.Size(235, 24);
            this.comboBoxYiyecek.TabIndex = 33;
            // 
            // buttonMasaNo5
            // 
            this.buttonMasaNo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasaNo5.Location = new System.Drawing.Point(118, 96);
            this.buttonMasaNo5.Name = "buttonMasaNo5";
            this.buttonMasaNo5.Size = new System.Drawing.Size(29, 26);
            this.buttonMasaNo5.TabIndex = 46;
            this.buttonMasaNo5.Text = "5";
            this.buttonMasaNo5.UseVisualStyleBackColor = true;
            // 
            // buttonMasaNo9
            // 
            this.buttonMasaNo9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasaNo9.Location = new System.Drawing.Point(-51, 351);
            this.buttonMasaNo9.Name = "buttonMasaNo9";
            this.buttonMasaNo9.Size = new System.Drawing.Size(29, 26);
            this.buttonMasaNo9.TabIndex = 44;
            this.buttonMasaNo9.Text = "9";
            this.buttonMasaNo9.UseVisualStyleBackColor = true;
            // 
            // buttonMasaNo8
            // 
            this.buttonMasaNo8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasaNo8.Location = new System.Drawing.Point(-44, 89);
            this.buttonMasaNo8.Name = "buttonMasaNo8";
            this.buttonMasaNo8.Size = new System.Drawing.Size(29, 26);
            this.buttonMasaNo8.TabIndex = 42;
            this.buttonMasaNo8.Text = "8";
            this.buttonMasaNo8.UseVisualStyleBackColor = true;
            // 
            // buttonMasaNo6
            // 
            this.buttonMasaNo6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasaNo6.Location = new System.Drawing.Point(312, 343);
            this.buttonMasaNo6.Name = "buttonMasaNo6";
            this.buttonMasaNo6.Size = new System.Drawing.Size(29, 26);
            this.buttonMasaNo6.TabIndex = 40;
            this.buttonMasaNo6.Text = "6";
            this.buttonMasaNo6.UseVisualStyleBackColor = true;
            // 
            // buttonMasaNo7
            // 
            this.buttonMasaNo7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasaNo7.Location = new System.Drawing.Point(134, 343);
            this.buttonMasaNo7.Name = "buttonMasaNo7";
            this.buttonMasaNo7.Size = new System.Drawing.Size(29, 26);
            this.buttonMasaNo7.TabIndex = 38;
            this.buttonMasaNo7.Text = "7";
            this.buttonMasaNo7.UseVisualStyleBackColor = true;
            // 
            // buttonMasaNo2
            // 
            this.buttonMasaNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasaNo2.Location = new System.Drawing.Point(338, 150);
            this.buttonMasaNo2.Name = "buttonMasaNo2";
            this.buttonMasaNo2.Size = new System.Drawing.Size(29, 26);
            this.buttonMasaNo2.TabIndex = 37;
            this.buttonMasaNo2.Text = "2";
            this.buttonMasaNo2.UseVisualStyleBackColor = true;
            // 
            // buttonMasaNo4
            // 
            this.buttonMasaNo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasaNo4.Location = new System.Drawing.Point(247, 128);
            this.buttonMasaNo4.Name = "buttonMasaNo4";
            this.buttonMasaNo4.Size = new System.Drawing.Size(29, 26);
            this.buttonMasaNo4.TabIndex = 35;
            this.buttonMasaNo4.Text = "4";
            this.buttonMasaNo4.UseVisualStyleBackColor = true;
            // 
            // buttonMasaNo1
            // 
            this.buttonMasaNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasaNo1.Location = new System.Drawing.Point(338, 60);
            this.buttonMasaNo1.Name = "buttonMasaNo1";
            this.buttonMasaNo1.Size = new System.Drawing.Size(29, 26);
            this.buttonMasaNo1.TabIndex = 34;
            this.buttonMasaNo1.Text = "1";
            this.buttonMasaNo1.UseVisualStyleBackColor = true;
            // 
            // buttonMasaNo3
            // 
            this.buttonMasaNo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasaNo3.Location = new System.Drawing.Point(231, 60);
            this.buttonMasaNo3.Name = "buttonMasaNo3";
            this.buttonMasaNo3.Size = new System.Drawing.Size(29, 26);
            this.buttonMasaNo3.TabIndex = 32;
            this.buttonMasaNo3.Text = "3";
            this.buttonMasaNo3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-131, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 455);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(442, 312);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(489, 141);
            this.textBox2.TabIndex = 60;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(689, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 290);
            this.textBox1.TabIndex = 63;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(442, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 290);
            this.textBox3.TabIndex = 62;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 456);
            this.Controls.Add(this.numericUpDownIcecek);
            this.Controls.Add(this.numericUpDownYiyecek);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonOde);
            this.Controls.Add(this.radioButtonNakit);
            this.Controls.Add(this.radioButtonKrediKarti);
            this.Controls.Add(this.textBoxKalanBorc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTahsilEdilen);
            this.Controls.Add(this.textBoxBorc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonTumunuSec);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxMasaNo);
            this.Controls.Add(this.comboBoxIcecek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxYiyecek);
            this.Controls.Add(this.buttonMasaNo5);
            this.Controls.Add(this.buttonMasaNo9);
            this.Controls.Add(this.buttonMasaNo8);
            this.Controls.Add(this.buttonMasaNo6);
            this.Controls.Add(this.buttonMasaNo7);
            this.Controls.Add(this.buttonMasaNo2);
            this.Controls.Add(this.buttonMasaNo4);
            this.Controls.Add(this.buttonMasaNo1);
            this.Controls.Add(this.buttonMasaNo3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.Text = "cafeForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIcecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYiyecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownIcecek;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.NumericUpDown numericUpDownYiyecek;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonOde;
        private System.Windows.Forms.RadioButton radioButtonNakit;
        private System.Windows.Forms.RadioButton radioButtonKrediKarti;
        private System.Windows.Forms.TextBox textBoxKalanBorc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTahsilEdilen;
        private System.Windows.Forms.TextBox textBoxBorc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonTumunuSec;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxMasaNo;
        private System.Windows.Forms.ComboBox comboBoxIcecek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxYiyecek;
        private System.Windows.Forms.Button buttonMasaNo5;
        private System.Windows.Forms.Button buttonMasaNo9;
        private System.Windows.Forms.Button buttonMasaNo8;
        private System.Windows.Forms.Button buttonMasaNo6;
        private System.Windows.Forms.Button buttonMasaNo7;
        private System.Windows.Forms.Button buttonMasaNo2;
        private System.Windows.Forms.Button buttonMasaNo4;
        private System.Windows.Forms.Button buttonMasaNo1;
        private System.Windows.Forms.Button buttonMasaNo3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

