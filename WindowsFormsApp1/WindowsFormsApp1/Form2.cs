using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Collections;
using System.ComponentModel.Design;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private string connectionString = "";

        public Form2()
        {
            InitializeComponent();
            DosyaSecButton2.Enabled = false;
            DosyaFormSecButton2.Enabled = false;

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
                         .Replace("Ä±", "i")
                         .Replace("�", "-");


            return input;
        }
        private void BaglanButton2_Click(object sender, EventArgs e)
        {
            string serverName = ServerTextBox2.Text;
            string databaseName = DatabaseTextBox2.Text;
            string username = UsernameTextBox2.Text;
            string password = PasswordTextBox2.Text;

            connectionString = $"Server={serverName};Database={databaseName};User Id={username};Password={password};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    BaglantiDurumLabel2.Text = "Bağlantı kuruldu.";
                    DosyaSecButton2.Enabled = true;
                    DosyaFormSecButton2.Enabled = true;
                }
                catch (Exception ex)
                {
                    DosyaSecButton2.Enabled = false;
                    DosyaFormSecButton2.Enabled = false;
                    BaglantiDurumLabel2.Text = "Bağlantı kurulamadı.";
                    MessageBox.Show($"Bağlantı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        string selectQuery1 = "";
        string selectQuery2 = "";
        string selectQuery3 = "";
        string selectQuery4 = "";
        string name_ = "";
        string binary_ = "";
        string binary2_ = "";
        string form_ = "";
        private void DosyaSecButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "XMLSCR Dosyaları (*.xmlscr)|*.xmlscr";
            openFileDialog.Title = "XMLSCR Dosyalarını Seç";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Kullanıcı seçtiği XML dosyalarını openFileDialog.FileNames ile alabilir.
                foreach (string dosyaYolu in openFileDialog.FileNames)
                {
                    // Dosya yolu ile işlem yapabilirsiniz.
                    //MessageBox.Show("Seçilen Dosya: " + dosyaYolu);
                    try
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(dosyaYolu);

                        string icerik = xmlDoc.InnerXml;
                        icerik = ConvertToEnglishChars(icerik);

                        //MessageBox.Show(icerik.ToString());
                        selectQuery1 = "declare @deneme nvarchar (max) ";
                        selectQuery1 += " set @deneme=\'" + dosyaYolu.ToString() + "\' ";
                        selectQuery1 += " select isnull(replace(reverse(substring(reverse(@deneme),0,charindex('\\',reverse(@deneme)))),'.xmlscr',''),'isimsiz') [Name] ";

                        using (SqlConnection connection1 = new SqlConnection(connectionString))
                        {
                            try
                            {
                                connection1.Open();
                                SqlCommand command1 = new SqlCommand(selectQuery1, connection1);
                                SqlDataReader reader1 = command1.ExecuteReader();
                                while (reader1.Read())
                                {
                                    name_ = reader1["Name"].ToString();
                                    selectQuery2 = "declare @bnry varbinary(max) ";
                                    selectQuery2 += " set @bnry=cast(\'" + icerik.ToString().Replace("\'", "\''") + "\' as varbinary(max)) ";
                                    selectQuery2 += " select @bnry [binary_] ";
                                    selectQuery2 += " insert into MD_Script(Priority,ScriptName,Description,Script,InUse,UUID) ";
                                    selectQuery2 += " Values(0,\'" + name_.ToString() + "\',\'" + name_.ToString() + "\',@bnry,\'1\',null)";

                                    // MessageBox.Show(selectQuery2.ToString());
                                    SqlConnection connection2 = new SqlConnection(connectionString);
                                    connection2.Open();
                                    SqlCommand command2 = new SqlCommand(selectQuery2, connection2);
                                    SqlDataReader reader2 = command2.ExecuteReader();
                                    while (reader2.Read())
                                    {
                                        binary_ = reader2[0].ToString();
                                    }
                                    connection2.Close();

                                }
                                /*
                                MessageBox.Show(name_.ToString());
                                MessageBox.Show(selectQuery2.ToString());
                                */
                                connection1.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Script aktarım hatası.!: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("XMLSCR dosyasını okurken bir hata oluştu.!: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Scriptler başarıyla içeriye aktarıldı.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        string reportName_ = "-";
        string reportTitle_ = "-";
        string explanation_ = "-";
        string definition_ = "-";
        string options_ = "-";
        string is_default_ = "-";
        string in_use_ = "-";
        string uuid_ = "-";
        int isdef = 0;
        int inuse = 0;
        private void DosyaFormSecButton2_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "XML Dosyaları (*.xml)|*.xml";
            openFileDialog.Title = "XML Dosyalarını Seç";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Kullanıcı seçtiği XML dosyalarını openFileDialog.FileNames ile alabilir.
                foreach (string dosyaYolu in openFileDialog.FileNames)
                {
                    //MessageBox.Show(dosyaYolu.ToString());
                    try
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(dosyaYolu);

                        string icerik = xmlDoc.InnerXml;

                        XmlNode reportName = xmlDoc.SelectSingleNode("/ReportDefEN/MD_Report/ReportName");

                        XmlNode reportTitle = xmlDoc.SelectSingleNode("/ReportDefEN/MD_Report/ReportTitle");

                        XmlNode explanation = xmlDoc.SelectSingleNode("/ReportDefEN/MD_Report/Explanation");

                        XmlNode definition = xmlDoc.SelectSingleNode("/ReportDefEN/MD_Report/Definition");

                        XmlNode options = xmlDoc.SelectSingleNode("/ReportDefEN/MD_Report/Options");

                        XmlNode is_default = xmlDoc.SelectSingleNode("/ReportDefEN/MD_Report/IsDefault");

                        XmlNode in_use = xmlDoc.SelectSingleNode("/ReportDefEN/MD_Report/InUse");

                        XmlNode uuid = xmlDoc.SelectSingleNode("/ReportDefEN/MD_Report/UUID");

                        if (reportName != null)
                        {
                            reportName_ = reportName.InnerText;
                            // MessageBox.Show("Rapor Adı :"+reportName_);
                        }

                        if (reportTitle != null)
                        {
                            reportTitle_ = reportTitle.InnerText;
                            // MessageBox.Show("Rapor Başlığı :" + reportTitle_);
                        }
                        if (explanation != null)
                        {
                            explanation_ = explanation.InnerText;
                            // MessageBox.Show("Rapor Açıklama :" + explanation_);
                        }

                        if (definition != null)
                        {
                            definition_ = definition.InnerText;
                            //  MessageBox.Show("Rapor Hedef :" + definition_);
                        }

                        if (options != null)
                        {
                            options_ = options.InnerText;
                            // MessageBox.Show("Rapor Opsiyon :" + options_);
                        }
                        if (is_default != null)
                        {
                            is_default_ = is_default.InnerText;
                            //  MessageBox.Show("Rapor Default :" + is_default_);
                            if (is_default_ == "true")
                                isdef = 1;
                            else
                                isdef = 0;
                        }

                        if (in_use != null)
                        {
                            in_use_ = in_use.InnerText;
                            if (in_use_ == "true")
                                inuse = 1;
                            else
                                inuse = 0;
                            // MessageBox.Show("Rapor InUse :" + in_use_);
                        }

                        if (uuid != null)
                        {
                            uuid_ = uuid.InnerText;
                            //  MessageBox.Show("Rapor UUID :" + uuid_);
                        }
                        //MessageBox.Show(definition_.Substring(0,500));



                        icerik = icerik.Replace("'", "''"); // Tek tırnakları escape et
                       
                        selectQuery4 = "DECLARE @XmlDataDefinition xml";
                        selectQuery4 += " DECLARE @XmlDataOptions xml";
                        selectQuery4 += " DECLARE @BinaryDataDefinition VARBINARY(MAX)";
                        selectQuery4 += " DECLARE @BinaryDataOptions VARBINARY(MAX)";
                        selectQuery4 += " SET @XmlDataDefinition = '" + definition_ + "'";
                        selectQuery4 += " SET @XmlDataOptions = '" + options_ + "'";
                        selectQuery4 += " SET @BinaryDataDefinition = @XmlDataDefinition.value('xs:base64Binary(.)', 'VARBINARY(MAX)')";
                        selectQuery4 += " SET @BinaryDataOptions = @XmlDataOptions.value('xs:base64Binary(.)', 'VARBINARY(MAX)')";                       
                        selectQuery4 += "insert into MD_Report(CompanyId, WorkplaceId, WarehouseId, UserId, DepartmentId, ProductCode, Module, ItemCode ";
                        selectQuery4 += ", SubItemCode, ReportName, ReportTitle, Explanation, Definition, Options, Condition, Query, FilterId, IsDefault ";
                        selectQuery4 += ", IsUserDefined, InUse, InsertedAt, InsertedBy, UpdatedAt, UpdatedBy, IsDeleted, DeletedAt, DeletedBy, MailGroupCode, UUID) ";
                        selectQuery4 += " Values(null,null,null,null,null,null,null,null,null,'" + reportName_ + "','" + reportTitle_ + "','" + explanation_ + "'";
                        selectQuery4 += " ,cast(@BinaryDataDefinition as varbinary(max))";
                        selectQuery4 += " ,cast(@BinaryDataOptions as varbinary(max))";
                        selectQuery4 += " ,null,null,null,'" + isdef + "',null,'" + inuse + "',GetDate(),'1',GetDate(),1,null,null,null,null";
                        selectQuery4 += " ,'" + uuid_.ToString().ToUpper() + "')";
                        using (SqlConnection connection4 = new SqlConnection(connectionString))
                            try
                            {
                                connection4.Open();
                                SqlCommand command4 = new SqlCommand(selectQuery4, connection4);
                                SqlDataReader reader4 = command4.ExecuteReader();
                                while (reader4.Read())
                                {
                                    form_ = reader4[0].ToString();
                                }
                                connection4.Close();
                            }

                            //  MessageBox.Show(selectQuery4.ToString());
                            catch (Exception ex)
                            {
                                MessageBox.Show($"XML aktarım hatası.!: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("XML dosyasını okurken bir hata oluştu.!: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("XML dosyaları başarıyla içeriye aktarıldı.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

      
    }
    } 

                   
                      
                
               
            

        
    

