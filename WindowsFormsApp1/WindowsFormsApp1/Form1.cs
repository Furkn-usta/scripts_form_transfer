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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string connectionString = "";
        
        public Form1()
        {
            InitializeComponent();
            DosyaSecButton.Enabled = false;
            VeriAktarim.Enabled = false;
            FormAktar.Enabled = false;
        }


        private string ConvertToEnglishChars(string input)
        {
            // Türkçe karakterleri İngilizce karakterlere dönüştür
            /*
             input = input.Replace("Ç", "C")
                          .Replace("ç", "c")
                          .Replace("Ğ", "G")
                          .Replace("ğ", "g")
                          .Replace("İ", "I")
                          .Replace("ı", "i")
                          .Replace("Ö", "O")
                          .Replace("ö", "o")
                          .Replace("Ş", "S")
                          .Replace("ş", "s")
                          .Replace("Ü", "U")
                          .Replace("ü", "u")
                          .Replace("Ä±", "i")
                          .Replace("ÅŸ", "ş");
            */

            input = input.Replace("Ã–", "Ö")
                          .Replace("Ã¶", "ö")
                         .Replace("Ã¼", "ü")
                         .Replace("Ãœ", "Ü")
                         .Replace("ÄŸ", "ğ")
                         .Replace("Ä", "Ğ")
                         .Replace("Ã‡", "Ç")
                         .Replace("Ã§", "ç")
                         .Replace("ÅŸ", "ş")
                         .Replace("Å", "Ş")
                         .Replace("Ä°", "İ")
                         .Replace("Ä±", "i");

            

            return input;
        }
        
        private void BaglanButton_Click(object sender, EventArgs e)
        {
            string serverName = ServerTextBox.Text;
            string databaseName = DatabaseTextBox.Text;
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            connectionString = $"Server={serverName};Database={databaseName};User Id={username};Password={password};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DosyaSecButton.Enabled = true;
                    DataYedekAlma.Enabled = true;
                    connection.Open();
                    BaglantiDurumLabel.Text = "Bağlantı kuruldu.";
                }
                catch (Exception ex)
                {
                    DosyaSecButton.Enabled = false;
                    VeriAktarim.Enabled = false;
                    BaglantiDurumLabel.Text = "Bağlantı kurulamadı.";
                    MessageBox.Show($"Bağlantı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void KlasorSecButton_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string secilenKlasor = folderBrowserDialog.SelectedPath;
                    KlasorKonumuTextBox.Text = secilenKlasor;

                    VeriAktarim.Enabled = true;
                    FormAktar.Enabled = true;
                }
            }
        }

        private void ScriptAktarButton_Click(object sender, EventArgs e)
        {
            if(KlasorKonumuTextBox.Text.ToString().Trim() == "" || KlasorKonumuTextBox.Text == null)
            {
                MessageBox.Show("Dosya Konumu Seçilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!string.IsNullOrEmpty(connectionString))
            {
                string selectQuery = "select REPLACE(X.Script,'<?xml version=\"1.0\" encoding=\"utf-16\"?>','<?xml version=\"1.0\"?>') [Script]\r\n,X.ScriptName [ScriptName]\r\nfrom \r\n(SELECT isnull(ScriptName,'') [ScriptName] ,cast(isnull(Script,0) as varchar(MAX)) [Script] FROM MD_Script with (nolock))X";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(selectQuery, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        string klasorKonumu = KlasorKonumuTextBox.Text;

                        while (reader.Read())
                        {
                            string script = reader["Script"].ToString();
                            string scriptname = reader["ScriptName"].ToString();
                            // string dosyaAdi = Path.Combine(klasorKonumu, $"Script_{Guid.NewGuid()}.sql");
                            scriptname = ConvertToEnglishChars(scriptname.Trim());
                            script = ConvertToEnglishChars(script);
                            // MessageBox.Show(script.ToString());
                            string dosyaAdi = Path.Combine(klasorKonumu, scriptname.ToString()+".xmlscr");
                            // Veriyi metin dosyasına kaydet
                            File.WriteAllText(dosyaAdi, script);
                        }

                        connection.Close();
                        MessageBox.Show("Veriler başarıyla metin dosyasına aktarıldı.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Veri aktarım hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Önce SQL bağlantısını kurmalısınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormAktar_Click(object sender, EventArgs e)
        {
            if (KlasorKonumuTextBox.Text.ToString().Trim() == "" || KlasorKonumuTextBox.Text == null)
            {
                MessageBox.Show("Dosya Konumu Seçilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (!string.IsNullOrEmpty(connectionString))
            {
                string selectQuery3 = "select isnull(R.RecId,0) RecId,isnull(R.ReportName,'') ReportName ,replace(replace(replace(replace(replace(replace(replace(replace(replace(isnull(R.ReportTitle,''),'/','-'),'\\','-'),':','-'),'*','-'),'?','-'),'\"','-'),'<','-'),'>','-'),'|','-') ReportTitle ,replace(replace(replace(replace(replace(replace(replace(replace(replace(isnull(R.Explanation,''),'/','-'),'\\','-'),':','-'),'*','-'),'?','-'),'\"','-'),'<','-'),'>','-'),'|','-') Explanation  ,case when isnull(R.IsDefault,0)=1 then 'true' else 'false' end IsDefault ,case when isnull(R.InUse,0)=1 then 'true' else 'false' end InUse ,lower(R.UUID) UUID from MD_Report R with (nolock)";

                using (SqlConnection connection3 = new SqlConnection(connectionString))
                {
                    string dosyaAdi = "";
                    string report_name = "";
                    string report_title = "";
                    string rec_id = "";

                    try
                    {

                        // SqlConnection connection3 = new SqlConnection(connectionString);


                        connection3.Open();

                        SqlCommand command3 = new SqlCommand(selectQuery3, connection3);


                        SqlDataReader reader3 = command3.ExecuteReader();
                        string a = "";
                        string b = "";
                        string report = "";
                        string klasorKonumu = KlasorKonumuTextBox.Text;



                        while (reader3.Read())
                        {
                            a = "";
                            b = "";
                            rec_id = reader3["RecId"].ToString();
                            report_name = reader3["ReportName"].ToString();
                            report_title = reader3["ReportTitle"].ToString();
                            string explanation = reader3["Explanation"].ToString();
                            string is_default = reader3["IsDefault"].ToString();
                            string in_use = reader3["InUse"].ToString();
                            string uuid = reader3["UUID"].ToString();
                            string selectQuery1 = "select isnull(Definition,0) from MD_Report with (nolock) where RecId = \'" + rec_id.ToString() + "\' for xml path('')\r\n";
                            string selectQuery2 = "select isnull(Options,0) from MD_Report with (nolock) where RecId = \'" + rec_id.ToString() + "\' for xml path('')\r\n";
                            // MessageBox.Show(selectQuery1.ToString());
                            SqlConnection connection1 = new SqlConnection(connectionString);
                            connection1.Open();
                            SqlConnection connection2 = new SqlConnection(connectionString);
                            connection2.Open();
                            SqlCommand command1 = new SqlCommand(selectQuery1, connection1);
                            SqlCommand command2 = new SqlCommand(selectQuery2, connection2);
                            SqlDataReader reader1 = command1.ExecuteReader();
                            SqlDataReader reader2 = command2.ExecuteReader();

                            while (reader1.Read())
                            {
                                a += reader1[0].ToString();
                            }
                            while (reader2.Read())
                            {
                                b += reader2[0].ToString();
                            }

                            report = "<ReportDefEN>\n\r <MD_Report RecId=\"" + rec_id.ToString() + "\">\n\r";
                            report += "<ReportName>" + report_name.ToString() + "</ReportName>\n\r";
                            report += "<ReportTitle>" + report_title.ToString() + "</ReportTitle>\n\r";
                            report += "<Explanation>" + explanation.ToString() + "</Explanation>\n\r";
                            report += "<Definition>" + a.ToString() + "</Definition>\n\r";
                            report += "<Options>" + b.ToString() + "</Options>\n\r";
                            report += "<IsDefault>" + is_default.ToString() + "</IsDefault>\n\r";
                            report += "<InUse>" + in_use.ToString() + "</InUse>\n\r";
                            report += "<UUID>" + uuid.ToString() + "</UUID>\n\r";
                            report += "</MD_Report > \n </ReportDefEN >";
                            dosyaAdi = Path.Combine(klasorKonumu, report_name.ToString() + "-" + report_title.ToString() + ".xml");
                            File.WriteAllText(dosyaAdi, report);
                            a = "";
                            b = "";
                            connection1.Close();
                            connection2.Close();
                        }


                        connection3.Close();
                        MessageBox.Show("Veriler başarıyla metin dosyasına aktarıldı.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Veri aktarım hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Önce SQL bağlantısını kurmalısınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TopluIceriAktarim_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            
        }

        private void DataYedekAlma_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
    }
