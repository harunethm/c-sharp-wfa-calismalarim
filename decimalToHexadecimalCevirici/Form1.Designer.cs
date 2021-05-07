
namespace decimalToHexadecimalCevirici
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
            this.button = new System.Windows.Forms.Button();
            this.metingirdi = new System.Windows.Forms.TextBox();
            this.metincikti = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(11, 38);
            this.button.Margin = new System.Windows.Forms.Padding(2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(150, 65);
            this.button.TabIndex = 4;
            this.button.Text = "HEXADEİMAL\'E ÇEVİR";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // metingirdi
            // 
            this.metingirdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metingirdi.Location = new System.Drawing.Point(11, 11);
            this.metingirdi.Margin = new System.Windows.Forms.Padding(2);
            this.metingirdi.Name = "metingirdi";
            this.metingirdi.Size = new System.Drawing.Size(151, 23);
            this.metingirdi.TabIndex = 2;
            // 
            // metincikti
            // 
            this.metincikti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metincikti.Location = new System.Drawing.Point(11, 107);
            this.metincikti.Margin = new System.Windows.Forms.Padding(2);
            this.metincikti.Name = "metincikti";
            this.metincikti.Size = new System.Drawing.Size(151, 23);
            this.metincikti.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 138);
            this.Controls.Add(this.button);
            this.Controls.Add(this.metingirdi);
            this.Controls.Add(this.metincikti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox metingirdi;
        private System.Windows.Forms.TextBox metincikti;
    }
}

