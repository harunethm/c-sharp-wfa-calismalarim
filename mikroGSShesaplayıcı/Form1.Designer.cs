namespace mikroGSShesaplayıcı
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.istenenGecikmeTurler = new System.Windows.Forms.GroupBox();
            this.pikosaniye = new System.Windows.Forms.RadioButton();
            this.nanosaniye = new System.Windows.Forms.RadioButton();
            this.saniye = new System.Windows.Forms.RadioButton();
            this.milisaniye = new System.Windows.Forms.RadioButton();
            this.mikrosaniye = new System.Windows.Forms.RadioButton();
            this.frekansTurler = new System.Windows.Forms.GroupBox();
            this.terahertz = new System.Windows.Forms.RadioButton();
            this.kilohertz = new System.Windows.Forms.RadioButton();
            this.megahertz = new System.Windows.Forms.RadioButton();
            this.gigahertz = new System.Windows.Forms.RadioButton();
            this.hertz = new System.Windows.Forms.RadioButton();
            this.txtIstenenGecikme = new System.Windows.Forms.TextBox();
            this.txtFrekans = new System.Windows.Forms.TextBox();
            this.istenenGecikmeTurler.SuspendLayout();
            this.frekansTurler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "istenen gecikme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "frekans";
            // 
            // sonuc
            // 
            this.sonuc.Location = new System.Drawing.Point(307, 43);
            this.sonuc.Multiline = true;
            this.sonuc.Name = "sonuc";
            this.sonuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sonuc.Size = new System.Drawing.Size(229, 145);
            this.sonuc.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // istenenGecikmeTurler
            // 
            this.istenenGecikmeTurler.Controls.Add(this.pikosaniye);
            this.istenenGecikmeTurler.Controls.Add(this.nanosaniye);
            this.istenenGecikmeTurler.Controls.Add(this.saniye);
            this.istenenGecikmeTurler.Controls.Add(this.milisaniye);
            this.istenenGecikmeTurler.Controls.Add(this.mikrosaniye);
            this.istenenGecikmeTurler.Location = new System.Drawing.Point(12, 52);
            this.istenenGecikmeTurler.Name = "istenenGecikmeTurler";
            this.istenenGecikmeTurler.Size = new System.Drawing.Size(113, 136);
            this.istenenGecikmeTurler.TabIndex = 14;
            this.istenenGecikmeTurler.TabStop = false;
            // 
            // pikosaniye
            // 
            this.pikosaniye.AutoSize = true;
            this.pikosaniye.Location = new System.Drawing.Point(6, 111);
            this.pikosaniye.Name = "pikosaniye";
            this.pikosaniye.Size = new System.Drawing.Size(89, 17);
            this.pikosaniye.TabIndex = 14;
            this.pikosaniye.Text = "pikosaniye-ps";
            this.pikosaniye.UseVisualStyleBackColor = true;
            this.pikosaniye.CheckedChanged += new System.EventHandler(this.rb_cc);
            // 
            // nanosaniye
            // 
            this.nanosaniye.AutoSize = true;
            this.nanosaniye.Location = new System.Drawing.Point(6, 88);
            this.nanosaniye.Name = "nanosaniye";
            this.nanosaniye.Size = new System.Drawing.Size(93, 17);
            this.nanosaniye.TabIndex = 13;
            this.nanosaniye.Text = "nanosaniye-ns";
            this.nanosaniye.UseVisualStyleBackColor = true;
            this.nanosaniye.CheckedChanged += new System.EventHandler(this.rb_cc);
            // 
            // saniye
            // 
            this.saniye.AutoSize = true;
            this.saniye.Checked = true;
            this.saniye.Location = new System.Drawing.Point(6, 19);
            this.saniye.Name = "saniye";
            this.saniye.Size = new System.Drawing.Size(63, 17);
            this.saniye.TabIndex = 12;
            this.saniye.TabStop = true;
            this.saniye.Text = "saniye-s";
            this.saniye.UseVisualStyleBackColor = true;
            this.saniye.CheckedChanged += new System.EventHandler(this.rb_cc);
            // 
            // milisaniye
            // 
            this.milisaniye.AutoSize = true;
            this.milisaniye.Location = new System.Drawing.Point(6, 42);
            this.milisaniye.Name = "milisaniye";
            this.milisaniye.Size = new System.Drawing.Size(85, 17);
            this.milisaniye.TabIndex = 11;
            this.milisaniye.Text = "milisaniye-ms";
            this.milisaniye.UseVisualStyleBackColor = true;
            this.milisaniye.CheckedChanged += new System.EventHandler(this.rb_cc);
            // 
            // mikrosaniye
            // 
            this.mikrosaniye.AutoSize = true;
            this.mikrosaniye.Location = new System.Drawing.Point(6, 65);
            this.mikrosaniye.Name = "mikrosaniye";
            this.mikrosaniye.Size = new System.Drawing.Size(97, 17);
            this.mikrosaniye.TabIndex = 10;
            this.mikrosaniye.Text = "mikrosaniye-Ms";
            this.mikrosaniye.UseVisualStyleBackColor = true;
            this.mikrosaniye.CheckedChanged += new System.EventHandler(this.rb_cc);
            // 
            // frekansTurler
            // 
            this.frekansTurler.Controls.Add(this.terahertz);
            this.frekansTurler.Controls.Add(this.kilohertz);
            this.frekansTurler.Controls.Add(this.megahertz);
            this.frekansTurler.Controls.Add(this.gigahertz);
            this.frekansTurler.Controls.Add(this.hertz);
            this.frekansTurler.Location = new System.Drawing.Point(160, 52);
            this.frekansTurler.Name = "frekansTurler";
            this.frekansTurler.Size = new System.Drawing.Size(109, 136);
            this.frekansTurler.TabIndex = 15;
            this.frekansTurler.TabStop = false;
            // 
            // terahertz
            // 
            this.terahertz.AutoSize = true;
            this.terahertz.Location = new System.Drawing.Point(6, 111);
            this.terahertz.Name = "terahertz";
            this.terahertz.Size = new System.Drawing.Size(83, 17);
            this.terahertz.TabIndex = 13;
            this.terahertz.Text = "terahertz-thz";
            this.terahertz.UseVisualStyleBackColor = true;
            this.terahertz.CheckedChanged += new System.EventHandler(this.rb_cc_frekans);
            // 
            // kilohertz
            // 
            this.kilohertz.AutoSize = true;
            this.kilohertz.Location = new System.Drawing.Point(6, 42);
            this.kilohertz.Name = "kilohertz";
            this.kilohertz.Size = new System.Drawing.Size(84, 17);
            this.kilohertz.TabIndex = 12;
            this.kilohertz.Text = "kilohertz-khz";
            this.kilohertz.UseVisualStyleBackColor = true;
            this.kilohertz.CheckedChanged += new System.EventHandler(this.rb_cc_frekans);
            // 
            // megahertz
            // 
            this.megahertz.AutoSize = true;
            this.megahertz.Location = new System.Drawing.Point(6, 65);
            this.megahertz.Name = "megahertz";
            this.megahertz.Size = new System.Drawing.Size(96, 17);
            this.megahertz.TabIndex = 11;
            this.megahertz.Text = "megahertz-mhz";
            this.megahertz.UseVisualStyleBackColor = true;
            this.megahertz.CheckedChanged += new System.EventHandler(this.rb_cc_frekans);
            // 
            // gigahertz
            // 
            this.gigahertz.AutoSize = true;
            this.gigahertz.Location = new System.Drawing.Point(6, 88);
            this.gigahertz.Name = "gigahertz";
            this.gigahertz.Size = new System.Drawing.Size(88, 17);
            this.gigahertz.TabIndex = 10;
            this.gigahertz.Text = "gigahertz-ghz";
            this.gigahertz.UseVisualStyleBackColor = true;
            this.gigahertz.CheckedChanged += new System.EventHandler(this.rb_cc_frekans);
            // 
            // hertz
            // 
            this.hertz.AutoSize = true;
            this.hertz.Checked = true;
            this.hertz.Location = new System.Drawing.Point(6, 19);
            this.hertz.Name = "hertz";
            this.hertz.Size = new System.Drawing.Size(62, 17);
            this.hertz.TabIndex = 9;
            this.hertz.TabStop = true;
            this.hertz.Text = "hertz-hz";
            this.hertz.UseVisualStyleBackColor = true;
            this.hertz.CheckedChanged += new System.EventHandler(this.rb_cc_frekans);
            // 
            // txtIstenenGecikme
            // 
            this.txtIstenenGecikme.Location = new System.Drawing.Point(12, 26);
            this.txtIstenenGecikme.Name = "txtIstenenGecikme";
            this.txtIstenenGecikme.Size = new System.Drawing.Size(113, 20);
            this.txtIstenenGecikme.TabIndex = 16;
            // 
            // txtFrekans
            // 
            this.txtFrekans.Location = new System.Drawing.Point(160, 26);
            this.txtFrekans.Name = "txtFrekans";
            this.txtFrekans.Size = new System.Drawing.Size(109, 20);
            this.txtFrekans.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 218);
            this.Controls.Add(this.txtFrekans);
            this.Controls.Add(this.txtIstenenGecikme);
            this.Controls.Add(this.frekansTurler);
            this.Controls.Add(this.istenenGecikmeTurler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.istenenGecikmeTurler.ResumeLayout(false);
            this.istenenGecikmeTurler.PerformLayout();
            this.frekansTurler.ResumeLayout(false);
            this.frekansTurler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox istenenGecikmeTurler;
        private System.Windows.Forms.RadioButton pikosaniye;
        private System.Windows.Forms.RadioButton nanosaniye;
        private System.Windows.Forms.RadioButton saniye;
        private System.Windows.Forms.RadioButton milisaniye;
        private System.Windows.Forms.RadioButton mikrosaniye;
        private System.Windows.Forms.GroupBox frekansTurler;
        private System.Windows.Forms.RadioButton terahertz;
        private System.Windows.Forms.RadioButton kilohertz;
        private System.Windows.Forms.RadioButton megahertz;
        private System.Windows.Forms.RadioButton gigahertz;
        private System.Windows.Forms.RadioButton hertz;
        private System.Windows.Forms.TextBox txtIstenenGecikme;
        private System.Windows.Forms.TextBox txtFrekans;
    }
}

