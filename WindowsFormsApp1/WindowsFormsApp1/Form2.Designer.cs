namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BaglantiDurumLabel2 = new System.Windows.Forms.Label();
            this.ServerTextBox2 = new System.Windows.Forms.TextBox();
            this.DatabaseTextBox2 = new System.Windows.Forms.TextBox();
            this.UsernameTextBox2 = new System.Windows.Forms.TextBox();
            this.PasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.BaglanButton2 = new System.Windows.Forms.Button();
            this.DosyaSecButton2 = new System.Windows.Forms.Button();
            this.DosyaFormSecButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ServerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DataBaseName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bağlantı Durumu:";
            // 
            // BaglantiDurumLabel2
            // 
            this.BaglantiDurumLabel2.AutoSize = true;
            this.BaglantiDurumLabel2.Location = new System.Drawing.Point(195, 168);
            this.BaglantiDurumLabel2.Name = "BaglantiDurumLabel2";
            this.BaglantiDurumLabel2.Size = new System.Drawing.Size(11, 16);
            this.BaglantiDurumLabel2.TabIndex = 5;
            this.BaglantiDurumLabel2.Text = "-";
            // 
            // ServerTextBox2
            // 
            this.ServerTextBox2.Location = new System.Drawing.Point(209, 42);
            this.ServerTextBox2.Name = "ServerTextBox2";
            this.ServerTextBox2.Size = new System.Drawing.Size(175, 22);
            this.ServerTextBox2.TabIndex = 6;
            // 
            // DatabaseTextBox2
            // 
            this.DatabaseTextBox2.Location = new System.Drawing.Point(209, 70);
            this.DatabaseTextBox2.Name = "DatabaseTextBox2";
            this.DatabaseTextBox2.Size = new System.Drawing.Size(175, 22);
            this.DatabaseTextBox2.TabIndex = 7;
            // 
            // UsernameTextBox2
            // 
            this.UsernameTextBox2.Location = new System.Drawing.Point(209, 101);
            this.UsernameTextBox2.Name = "UsernameTextBox2";
            this.UsernameTextBox2.Size = new System.Drawing.Size(175, 22);
            this.UsernameTextBox2.TabIndex = 8;
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.Location = new System.Drawing.Point(209, 134);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.PasswordChar = '*';
            this.PasswordTextBox2.Size = new System.Drawing.Size(175, 22);
            this.PasswordTextBox2.TabIndex = 9;
            // 
            // BaglanButton2
            // 
            this.BaglanButton2.Location = new System.Drawing.Point(34, 248);
            this.BaglanButton2.Name = "BaglanButton2";
            this.BaglanButton2.Size = new System.Drawing.Size(115, 63);
            this.BaglanButton2.TabIndex = 10;
            this.BaglanButton2.Text = "Data Bağlan";
            this.BaglanButton2.UseVisualStyleBackColor = true;
            this.BaglanButton2.Click += new System.EventHandler(this.BaglanButton2_Click);
            // 
            // DosyaSecButton2
            // 
            this.DosyaSecButton2.Location = new System.Drawing.Point(175, 248);
            this.DosyaSecButton2.Name = "DosyaSecButton2";
            this.DosyaSecButton2.Size = new System.Drawing.Size(107, 63);
            this.DosyaSecButton2.TabIndex = 11;
            this.DosyaSecButton2.Text = "Aktarılacak Scriptler";
            this.DosyaSecButton2.UseVisualStyleBackColor = true;
            this.DosyaSecButton2.Click += new System.EventHandler(this.DosyaSecButton2_Click);
            // 
            // DosyaFormSecButton2
            // 
            this.DosyaFormSecButton2.Location = new System.Drawing.Point(308, 248);
            this.DosyaFormSecButton2.Name = "DosyaFormSecButton2";
            this.DosyaFormSecButton2.Size = new System.Drawing.Size(107, 63);
            this.DosyaFormSecButton2.TabIndex = 12;
            this.DosyaFormSecButton2.Text = "Aktarılacak Formlar";
            this.DosyaFormSecButton2.UseVisualStyleBackColor = true;
            this.DosyaFormSecButton2.Click += new System.EventHandler(this.DosyaFormSecButton2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 373);
            this.Controls.Add(this.DosyaFormSecButton2);
            this.Controls.Add(this.DosyaSecButton2);
            this.Controls.Add(this.BaglanButton2);
            this.Controls.Add(this.PasswordTextBox2);
            this.Controls.Add(this.UsernameTextBox2);
            this.Controls.Add(this.DatabaseTextBox2);
            this.Controls.Add(this.ServerTextBox2);
            this.Controls.Add(this.BaglantiDurumLabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
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
        private System.Windows.Forms.Label BaglantiDurumLabel2;
        private System.Windows.Forms.TextBox ServerTextBox2;
        private System.Windows.Forms.TextBox DatabaseTextBox2;
        private System.Windows.Forms.TextBox UsernameTextBox2;
        private System.Windows.Forms.TextBox PasswordTextBox2;
        private System.Windows.Forms.Button BaglanButton2;
        private System.Windows.Forms.Button DosyaSecButton2;
        private System.Windows.Forms.Button DosyaFormSecButton2;
    }
}