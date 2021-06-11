using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver.Core;
using System.Configuration;

namespace Clinic_Managment_System
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cms_connect";
            if (File.Exists(path))
            {
                LoginWindow lw = new LoginWindow();
                MainClass.showWindow(lw, MDI.ActiveForm);
            }
            else
            {

                SettingWindow lw = new SettingWindow();
                MainClass.showWindow(lw, MDI.ActiveForm);
            }

            //if (ConfigurationManager.ConnectionStrings["con"].ConnectionString == "")
            //{
            //    SettingWindow lw = new SettingWindow();
            //    MainClass.showWindow(lw, MDI.ActiveForm);
            //}
            //else
            //{
            //    LoginWindow lw = new LoginWindow();
            //    MainClass.showWindow(lw, MDI.ActiveForm);
            //}
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingWindow lw = new SettingWindow();
            MainClass.showWindow(lw, MDI.ActiveForm);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            MainClass.showWindow(lw, MDI.ActiveForm);
        }
    }
}
