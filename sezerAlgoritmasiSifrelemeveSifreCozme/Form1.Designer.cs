
namespace sezerAlgoritmasiSifrelemeveSifreCozme
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MetinKod = new System.Windows.Forms.TextBox();
            this.ButtonCevir = new System.Windows.Forms.Button();
            this.ButtonCoz = new System.Windows.Forms.RadioButton();
            this.ButtonSifrele = new System.Windows.Forms.RadioButton();
            this.MetinCikti = new System.Windows.Forms.TextBox();
            this.MetinGirdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ÇIKTI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "METİN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "KOD :";
            // 
            // MetinKod
            // 
            this.MetinKod.Location = new System.Drawing.Point(50, 78);
            this.MetinKod.Margin = new System.Windows.Forms.Padding(2);
            this.MetinKod.Name = "MetinKod";
            this.MetinKod.Size = new System.Drawing.Size(49, 20);
            this.MetinKod.TabIndex = 12;
            // 
            // ButtonCevir
            // 
            this.ButtonCevir.Location = new System.Drawing.Point(11, 101);
            this.ButtonCevir.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCevir.Name = "ButtonCevir";
            this.ButtonCevir.Size = new System.Drawing.Size(233, 38);
            this.ButtonCevir.TabIndex = 11;
            this.ButtonCevir.Text = "ÇEVİR";
            this.ButtonCevir.UseVisualStyleBackColor = true;
            this.ButtonCevir.Click += new System.EventHandler(this.ButtonCevir_Click);
            // 
            // ButtonCoz
            // 
            this.ButtonCoz.AutoSize = true;
            this.ButtonCoz.Location = new System.Drawing.Point(114, 79);
            this.ButtonCoz.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCoz.Name = "ButtonCoz";
            this.ButtonCoz.Size = new System.Drawing.Size(47, 17);
            this.ButtonCoz.TabIndex = 10;
            this.ButtonCoz.TabStop = true;
            this.ButtonCoz.Text = "ÇÖZ";
            this.ButtonCoz.UseVisualStyleBackColor = true;
            // 
            // ButtonSifrele
            // 
            this.ButtonSifrele.AutoSize = true;
            this.ButtonSifrele.Location = new System.Drawing.Point(168, 79);
            this.ButtonSifrele.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSifrele.Name = "ButtonSifrele";
            this.ButtonSifrele.Size = new System.Drawing.Size(69, 17);
            this.ButtonSifrele.TabIndex = 9;
            this.ButtonSifrele.TabStop = true;
            this.ButtonSifrele.Text = "ŞİFRELE";
            this.ButtonSifrele.UseVisualStyleBackColor = true;
            // 
            // MetinCikti
            // 
            this.MetinCikti.Location = new System.Drawing.Point(11, 158);
            this.MetinCikti.Margin = new System.Windows.Forms.Padding(2);
            this.MetinCikti.Multiline = true;
            this.MetinCikti.Name = "MetinCikti";
            this.MetinCikti.Size = new System.Drawing.Size(234, 49);
            this.MetinCikti.TabIndex = 7;
            // 
            // MetinGirdi
            // 
            this.MetinGirdi.Location = new System.Drawing.Point(11, 26);
            this.MetinGirdi.Margin = new System.Windows.Forms.Padding(2);
            this.MetinGirdi.Multiline = true;
            this.MetinGirdi.Name = "MetinGirdi";
            this.MetinGirdi.Size = new System.Drawing.Size(234, 49);
            this.MetinGirdi.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MetinKod);
            this.Controls.Add(this.ButtonCevir);
            this.Controls.Add(this.ButtonCoz);
            this.Controls.Add(this.ButtonSifrele);
            this.Controls.Add(this.MetinCikti);
            this.Controls.Add(this.MetinGirdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MetinKod;
        private System.Windows.Forms.Button ButtonCevir;
        private System.Windows.Forms.RadioButton ButtonCoz;
        private System.Windows.Forms.RadioButton ButtonSifrele;
        private System.Windows.Forms.TextBox MetinCikti;
        private System.Windows.Forms.TextBox MetinGirdi;
    }
}

