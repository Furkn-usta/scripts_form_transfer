using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private string connectionString = "";
        public string serverName = "";
       public string databaseName = "";
        public string username = "";
        public string password = "";
        public Form3()
        {
            InitializeComponent();
            BackUpAl.Enabled = false;
            KlasorKonumuTextBox3.Enabled = false;
            DosyaSecButton3.Enabled = false;
        }

        private void BaglanButton3_Click(object sender, EventArgs e)
        {
             serverName = ServerTextBox3.Text;
             databaseName = DatabaseTextBox3.Text;
             username = UsernameTextBox3.Text;
             password = PasswordTextBox3.Text;
            /**/
            connectionString = $"Server={serverName};Database={databaseName};User Id={username};Password={password};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DosyaSecButton3.Enabled = true;
                    KlasorKonumuTextBox3.Enabled = true;
                    DosyaSecButton3.Enabled = true;
                    connection.Open();
                    BaglantiDurumLabel3.Text = "Bağlantı kuruldu.";
                }
                catch (Exception ex)
                {
                    DosyaSecButton3.Enabled = false;
                    BackUpAl.Enabled = false;
                    KlasorKonumuTextBox3.Enabled = false;
                    DosyaSecButton3.Enabled = false;
                    BaglantiDurumLabel3.Text = "Bağlantı kurulamadı.";
                    MessageBox.Show($"Bağlantı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void DosyaSecButton3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string secilenKlasor = folderBrowserDialog.SelectedPath;
                    KlasorKonumuTextBox3.Text = secilenKlasor;
                    BackUpAl.Enabled = true;
                }
            }
        }

        private void BackUpAl_Click(object sender, EventArgs e)
        {
            if (KlasorKonumuTextBox3.Text.ToString().Trim() == "" || KlasorKonumuTextBox3.Text == null)
            {
                MessageBox.Show("Dosya Konumu Seçilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            if (!string.IsNullOrEmpty(connectionString))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string backupCommand = $"BACKUP DATABASE " + databaseName.ToString() + " TO DISK = '" + KlasorKonumuTextBox3.ToString() + "\\" + databaseName.ToString() + "_Backup.bak'";
                       // MessageBox.Show(backupCommand.ToString().Replace("System.Windows.Forms.TextBox, Text: ", ""));
                        SqlCommand cmd = new SqlCommand(backupCommand.ToString().Replace("System.Windows.Forms.TextBox, Text: ", ""), connection);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Veritabanı yedeği başarıyla alındı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı yedeği alınırken bir hata oluştu. Paylaşım Özelliklerini Kontrol Ediniz: \r\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
    }
}
