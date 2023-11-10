namespace WindowsFormsApp1
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
            this.DosyaSecButton = new System.Windows.Forms.Button();
            this.BaglanButton = new System.Windows.Forms.Button();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KlasorKonumuTextBox = new System.Windows.Forms.TextBox();
            this.BaglantiDurumLabel = new System.Windows.Forms.Label();
            this.VeriAktarim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FormAktar = new System.Windows.Forms.Button();
            this.TopluIceriAktarim = new System.Windows.Forms.Button();
            this.DataYedekAlma = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DosyaSecButton
            // 
            this.DosyaSecButton.Location = new System.Drawing.Point(234, 309);
            this.DosyaSecButton.Name = "DosyaSecButton";
            this.DosyaSecButton.Size = new System.Drawing.Size(119, 66);
            this.DosyaSecButton.TabIndex = 0;
            this.DosyaSecButton.Text = "Dosya Seç";
            this.DosyaSecButton.UseVisualStyleBackColor = true;
            this.DosyaSecButton.Click += new System.EventHandler(this.KlasorSecButton_Click);
            // 
            // BaglanButton
            // 
            this.BaglanButton.Location = new System.Drawing.Point(58, 311);
            this.BaglanButton.Name = "BaglanButton";
            this.BaglanButton.Size = new System.Drawing.Size(134, 64);
            this.BaglanButton.TabIndex = 1;
            this.BaglanButton.Text = "Data Bağlan";
            this.BaglanButton.UseVisualStyleBackColor = true;
            this.BaglanButton.Click += new System.EventHandler(this.BaglanButton_Click);
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(193, 45);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(188, 22);
            this.ServerTextBox.TabIndex = 2;
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.Location = new System.Drawing.Point(193, 86);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(188, 22);
            this.DatabaseTextBox.TabIndex = 3;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(193, 131);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(188, 22);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(193, 174);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(188, 22);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ServerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "DataBaseName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // KlasorKonumuTextBox
            // 
            this.KlasorKonumuTextBox.Location = new System.Drawing.Point(193, 267);
            this.KlasorKonumuTextBox.Name = "KlasorKonumuTextBox";
            this.KlasorKonumuTextBox.Size = new System.Drawing.Size(319, 22);
            this.KlasorKonumuTextBox.TabIndex = 10;
            // 
            // BaglantiDurumLabel
            // 
            this.BaglantiDurumLabel.AutoSize = true;
            this.BaglantiDurumLabel.Location = new System.Drawing.Point(190, 226);
            this.BaglantiDurumLabel.Name = "BaglantiDurumLabel";
            this.BaglantiDurumLabel.Size = new System.Drawing.Size(11, 16);
            this.BaglantiDurumLabel.TabIndex = 11;
            this.BaglantiDurumLabel.Text = "-";
            // 
            // VeriAktarim
            // 
            this.VeriAktarim.Location = new System.Drawing.Point(393, 309);
            this.VeriAktarim.Name = "VeriAktarim";
            this.VeriAktarim.Size = new System.Drawing.Size(119, 66);
            this.VeriAktarim.TabIndex = 12;
            this.VeriAktarim.Text = "Scriptleri Dışarı Aktar";
            this.VeriAktarim.UseVisualStyleBackColor = true;
            this.VeriAktarim.Click += new System.EventHandler(this.ScriptAktarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bağlantı Durumu:";
            // 
            // FormAktar
            // 
            this.FormAktar.Location = new System.Drawing.Point(553, 311);
            this.FormAktar.Name = "FormAktar";
            this.FormAktar.Size = new System.Drawing.Size(119, 66);
            this.FormAktar.TabIndex = 14;
            this.FormAktar.Text = "Formları Dışarı Aktar";
            this.FormAktar.UseVisualStyleBackColor = true;
            this.FormAktar.Click += new System.EventHandler(this.FormAktar_Click);
            // 
            // TopluIceriAktarim
            // 
            this.TopluIceriAktarim.Location = new System.Drawing.Point(544, 45);
            this.TopluIceriAktarim.Name = "TopluIceriAktarim";
            this.TopluIceriAktarim.Size = new System.Drawing.Size(119, 66);
            this.TopluIceriAktarim.TabIndex = 15;
            this.TopluIceriAktarim.Text = "Toplu İçeri Aktarım";
            this.TopluIceriAktarim.UseVisualStyleBackColor = true;
            this.TopluIceriAktarim.Click += new System.EventHandler(this.TopluIceriAktarim_Click);
            // 
            // DataYedekAlma
            // 
            this.DataYedekAlma.Location = new System.Drawing.Point(544, 134);
            this.DataYedekAlma.Name = "DataYedekAlma";
            this.DataYedekAlma.Size = new System.Drawing.Size(119, 63);
            this.DataYedekAlma.TabIndex = 16;
            this.DataYedekAlma.Text = "Data Yedek Alma";
            this.DataYedekAlma.UseVisualStyleBackColor = true;
            this.DataYedekAlma.Click += new System.EventHandler(this.DataYedekAlma_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dosya Konumu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataYedekAlma);
            this.Controls.Add(this.TopluIceriAktarim);
            this.Controls.Add(this.FormAktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VeriAktarim);
            this.Controls.Add(this.BaglantiDurumLabel);
            this.Controls.Add(this.KlasorKonumuTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.BaglanButton);
            this.Controls.Add(this.DosyaSecButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Script-Form Aktarım";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DosyaSecButton;
        private System.Windows.Forms.Button BaglanButton;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KlasorKonumuTextBox;
        private System.Windows.Forms.Label BaglantiDurumLabel;
        private System.Windows.Forms.Button VeriAktarim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FormAktar;
        private System.Windows.Forms.Button TopluIceriAktarim;
        private System.Windows.Forms.Button DataYedekAlma;
        private System.Windows.Forms.Label label6;
    }
}

