using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;
using System.IO;

namespace Clinic_Managment_System
{
    public partial class SettingWindow : sample
    {
        string connection;
        public SettingWindow()
        {
            InitializeComponent();
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveConnection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cms_connect";
            File.WriteAllText(path, connection);
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                UserIDText.AllowDrop = true;
                PasswordText.AllowDrop = true;
                 
                if (MainClass.checkControls(leftpanel).Count > 0)
                {
                    MainClass.ShowMessage("Fields with red color are mandatory .", "error");
                }
                else
                {
                    //setting.createfile("\\cms_connect", 1, SourceText.Text, DBText.Text);

                    connection= "Data Source = " + SourceText.Text + 
                                ";Initial catalog=" + DBText.Text + 
                                ";Intigrated Security=true;MultipleActiveResultSets=true;";
                    saveConnection();
                    //updateconfigfile(connection);
                    //DialogResult dr = MessageBox.Show("Settingd saved successfully...");
                    //if (dr == DialogResult.OK)
                    //{
                    //    LoginWindow lw = new LoginWindow();
                    //    MainClass.showWindow(lw, this, MDI.ActiveForm);
                    //}
                    MainClass.ShowMessage("Settings Saved Successfully.", "success");
                    LoginWindow lw = new LoginWindow();
                    MainClass.showWindow(lw, this, MDI.ActiveForm);
                }
            }
            else
            {
                UserIDText.AllowDrop = false;
                PasswordText.AllowDrop = false;
                if (MainClass.checkControls(leftpanel).Count > 0)
                {
                    MainClass.ShowMessage("Fields with red color are mandatory .", "error");
                }
                else
                {
                    //setting.createfile("\\cms_connect", 0, SourceText.Text, DBText.Text,UserIDText.Text,PasswordText.Text);

                    connection = "Data Source = " + SourceText.Text + 
                                ";Initial catalog=" + DBText.Text + 
                                ";User ID=" + UserIDText.Text + 
                                ";Password =" + PasswordText.Text + 
                                ";MultipleActiveResultSets=true;";
                    saveConnection();
                    //updateconfigfile(connection);
                    //DialogResult dr = MessageBox.Show("Settingd saved successfully...");
                    //if (dr == DialogResult.OK)
                    //{
                    //    LoginWindow lw = new LoginWindow();
                    //    MainClass.showWindow(lw, this, MDI.ActiveForm);
                    //}
                    MainClass.ShowMessage("Settings Saved Successfully.", "success");
                    LoginWindow lw = new LoginWindow();
                    MainClass.showWindow(lw, this, MDI.ActiveForm);
                }
            }

            
        }
        
        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if(isCB.Checked)
            {
                UserIDText.Enabled = false;
                PasswordText.Enabled = false;
                UserIDText.Text = "";
                PasswordText.Text = "";
            }
            else
            {
                UserIDText.Enabled = true;
                PasswordText.Enabled = true;
            }

        }

        public static void updateconfigfile(string con)//, string path)
        {
            XmlDocument XmlDoc = new XmlDocument();//update the config file

            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);//it will load the confg file
            foreach (XmlElement xmlElement in XmlDoc.DocumentElement)
            {
                if (xmlElement.Name == "connectionString")
                {
                    xmlElement.FirstChild.Attributes[1].Value = con;//setting connection 
                }
            }
            //File.WriteAllText(path,s);
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);//writing the connection string config file
            ConfigurationManager.RefreshSection("connectionString");

            //MainClass.ShowMessage("Settings Saved Successfully.", "success");
        }

        private void SourceText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DBText_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
