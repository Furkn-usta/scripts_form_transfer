namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BaglantiDurumLabel3 = new System.Windows.Forms.Label();
            this.ServerTextBox3 = new System.Windows.Forms.TextBox();
            this.DatabaseTextBox3 = new System.Windows.Forms.TextBox();
            this.UsernameTextBox3 = new System.Windows.Forms.TextBox();
            this.PasswordTextBox3 = new System.Windows.Forms.TextBox();
            this.KlasorKonumuTextBox3 = new System.Windows.Forms.TextBox();
            this.BaglanButton3 = new System.Windows.Forms.Button();
            this.DosyaSecButton3 = new System.Windows.Forms.Button();
            this.BackUpAl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ServerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DataBaseName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bağlantı Durumu:";
            // 
            // BaglantiDurumLabel3
            // 
            this.BaglantiDurumLabel3.AutoSize = true;
            this.BaglantiDurumLabel3.Location = new System.Drawing.Point(203, 205);
            this.BaglantiDurumLabel3.Name = "BaglantiDurumLabel3";
            this.BaglantiDurumLabel3.Size = new System.Drawing.Size(11, 16);
            this.BaglantiDurumLabel3.TabIndex = 5;
            this.BaglantiDurumLabel3.Text = "-";
            // 
            // ServerTextBox3
            // 
            this.ServerTextBox3.Location = new System.Drawing.Point(206, 47);
            this.ServerTextBox3.Name = "ServerTextBox3";
            this.ServerTextBox3.Size = new System.Drawing.Size(180, 22);
            this.ServerTextBox3.TabIndex = 6;
            // 
            // DatabaseTextBox3
            // 
            this.DatabaseTextBox3.Location = new System.Drawing.Point(206, 83);
            this.DatabaseTextBox3.Name = "DatabaseTextBox3";
            this.DatabaseTextBox3.Size = new System.Drawing.Size(180, 22);
            this.DatabaseTextBox3.TabIndex = 7;
            // 
            // UsernameTextBox3
            // 
            this.UsernameTextBox3.Location = new System.Drawing.Point(206, 123);
            this.UsernameTextBox3.Name = "UsernameTextBox3";
            this.UsernameTextBox3.Size = new System.Drawing.Size(180, 22);
            this.UsernameTextBox3.TabIndex = 8;
            // 
            // PasswordTextBox3
            // 
            this.PasswordTextBox3.Location = new System.Drawing.Point(206, 164);
            this.PasswordTextBox3.Name = "PasswordTextBox3";
            this.PasswordTextBox3.PasswordChar = '*';
            this.PasswordTextBox3.Size = new System.Drawing.Size(180, 22);
            this.PasswordTextBox3.TabIndex = 9;
            // 
            // KlasorKonumuTextBox3
            // 
            this.KlasorKonumuTextBox3.Location = new System.Drawing.Point(177, 253);
            this.KlasorKonumuTextBox3.Name = "KlasorKonumuTextBox3";
            this.KlasorKonumuTextBox3.Size = new System.Drawing.Size(333, 22);
            this.KlasorKonumuTextBox3.TabIndex = 10;
            // 
            // BaglanButton3
            // 
            this.BaglanButton3.Location = new System.Drawing.Point(53, 319);
            this.BaglanButton3.Name = "BaglanButton3";
            this.BaglanButton3.Size = new System.Drawing.Size(117, 66);
            this.BaglanButton3.TabIndex = 11;
            this.BaglanButton3.Text = "Data Bağlan";
            this.BaglanButton3.UseVisualStyleBackColor = true;
            this.BaglanButton3.Click += new System.EventHandler(this.BaglanButton3_Click);
            // 
            // DosyaSecButton3
            // 
            this.DosyaSecButton3.Location = new System.Drawing.Point(206, 319);
            this.DosyaSecButton3.Name = "DosyaSecButton3";
            this.DosyaSecButton3.Size = new System.Drawing.Size(117, 66);
            this.DosyaSecButton3.TabIndex = 12;
            this.DosyaSecButton3.Text = "Dosya Konumu Seç";
            this.DosyaSecButton3.UseVisualStyleBackColor = true;
            this.DosyaSecButton3.Click += new System.EventHandler(this.DosyaSecButton3_Click);
            // 
            // BackUpAl
            // 
            this.BackUpAl.Location = new System.Drawing.Point(357, 319);
            this.BackUpAl.Name = "BackUpAl";
            this.BackUpAl.Size = new System.Drawing.Size(117, 66);
            this.BackUpAl.TabIndex = 13;
            this.BackUpAl.Text = "BackUp Al";
            this.BackUpAl.UseVisualStyleBackColor = true;
            this.BackUpAl.Click += new System.EventHandler(this.BackUpAl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dosya Konumu:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 449);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BackUpAl);
            this.Controls.Add(this.DosyaSecButton3);
            this.Controls.Add(this.BaglanButton3);
            this.Controls.Add(this.KlasorKonumuTextBox3);
            this.Controls.Add(this.PasswordTextBox3);
            this.Controls.Add(this.UsernameTextBox3);
            this.Controls.Add(this.DatabaseTextBox3);
            this.Controls.Add(this.ServerTextBox3);
            this.Controls.Add(this.BaglantiDurumLabel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Script-Form Aktarım";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BaglantiDurumLabel3;
        private System.Windows.Forms.TextBox ServerTextBox3;
        private System.Windows.Forms.TextBox DatabaseTextBox3;
        private System.Windows.Forms.TextBox UsernameTextBox3;
        private System.Windows.Forms.TextBox PasswordTextBox3;
        private System.Windows.Forms.TextBox KlasorKonumuTextBox3;
        private System.Windows.Forms.Button BaglanButton3;
        private System.Windows.Forms.Button DosyaSecButton3;
        private System.Windows.Forms.Button BackUpAl;
        private System.Windows.Forms.Label label6;
    }
}