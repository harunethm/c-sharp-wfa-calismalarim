
namespace cafeOtomasyonCalismasi
{
    partial class formGiris
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKullanıcıAdı = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(496, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "KULLANICI ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(496, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ŞİFRE";
            // 
            // cbKullanıcıAdı
            // 
            this.cbKullanıcıAdı.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKullanıcıAdı.FormattingEnabled = true;
            this.cbKullanıcıAdı.Location = new System.Drawing.Point(499, 260);
            this.cbKullanıcıAdı.Name = "cbKullanıcıAdı";
            this.cbKullanıcıAdı.Size = new System.Drawing.Size(201, 23);
            this.cbKullanıcıAdı.TabIndex = 5;
            this.cbKullanıcıAdı.SelectedIndexChanged += new System.EventHandler(this.CbKullanıcıAdı_SelectedIndexChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(498, 304);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(201, 21);
            this.txtSifre.TabIndex = 6;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(602, 331);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(98, 27);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(498, 331);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(98, 27);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // formGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKullanıcıAdı);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Name = "formGiris";
            this.Text = "Cafe Otomasyonu";
            this.Load += new System.EventHandler(this.formGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKullanıcıAdı;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGiris;
    }
}

