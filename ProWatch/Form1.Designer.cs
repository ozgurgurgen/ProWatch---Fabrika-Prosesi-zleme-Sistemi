namespace ProWatch
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
            this.IptalButonu = new System.Windows.Forms.Button();
            this.GirisButonu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ParolaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IptalButonu
            // 
            this.IptalButonu.BackColor = System.Drawing.Color.OrangeRed;
            this.IptalButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IptalButonu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IptalButonu.ForeColor = System.Drawing.Color.White;
            this.IptalButonu.Location = new System.Drawing.Point(54, 323);
            this.IptalButonu.Name = "IptalButonu";
            this.IptalButonu.Size = new System.Drawing.Size(245, 37);
            this.IptalButonu.TabIndex = 4;
            this.IptalButonu.Text = "İptal";
            this.IptalButonu.UseVisualStyleBackColor = false;
            this.IptalButonu.Click += new System.EventHandler(this.IptalButonu_Click);
            // 
            // GirisButonu
            // 
            this.GirisButonu.BackColor = System.Drawing.Color.SeaGreen;
            this.GirisButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisButonu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirisButonu.ForeColor = System.Drawing.Color.White;
            this.GirisButonu.Location = new System.Drawing.Point(54, 280);
            this.GirisButonu.Name = "GirisButonu";
            this.GirisButonu.Size = new System.Drawing.Size(245, 37);
            this.GirisButonu.TabIndex = 3;
            this.GirisButonu.Text = "Giriş Yap";
            this.GirisButonu.UseVisualStyleBackColor = false;
            this.GirisButonu.Click += new System.EventHandler(this.GirisButonu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Parola";
            // 
            // ParolaTextBox
            // 
            this.ParolaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.ParolaTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParolaTextBox.ForeColor = System.Drawing.Color.White;
            this.ParolaTextBox.Location = new System.Drawing.Point(54, 230);
            this.ParolaTextBox.MaximumSize = new System.Drawing.Size(245, 30);
            this.ParolaTextBox.MinimumSize = new System.Drawing.Size(245, 30);
            this.ParolaTextBox.Name = "ParolaTextBox";
            this.ParolaTextBox.Size = new System.Drawing.Size(245, 30);
            this.ParolaTextBox.TabIndex = 2;
            this.ParolaTextBox.UseSystemPasswordChar = true;
            this.ParolaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KullaniciAdiTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // KullaniciAdiTextBox
            // 
            this.KullaniciAdiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.KullaniciAdiTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciAdiTextBox.ForeColor = System.Drawing.Color.White;
            this.KullaniciAdiTextBox.Location = new System.Drawing.Point(54, 174);
            this.KullaniciAdiTextBox.MaximumSize = new System.Drawing.Size(245, 30);
            this.KullaniciAdiTextBox.MinimumSize = new System.Drawing.Size(245, 30);
            this.KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            this.KullaniciAdiTextBox.Size = new System.Drawing.Size(245, 30);
            this.KullaniciAdiTextBox.TabIndex = 1;
            this.KullaniciAdiTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KullaniciAdiTextBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.IptalButonu);
            this.Controls.Add(this.GirisButonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParolaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KullaniciAdiTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KullaniciAdiTextBox_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IptalButonu;
        private System.Windows.Forms.Button GirisButonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ParolaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KullaniciAdiTextBox;
    }
}

