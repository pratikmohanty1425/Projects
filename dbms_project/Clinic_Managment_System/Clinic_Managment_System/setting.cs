using System;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Data.SqlClient;

namespace Clinic_Managment_System
{
    public class setting
    {
        public static void createfile(string file, int status, string ds, string db, string username = null, string password = null)
        {

            //string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + file;

            //string s = "";
            //if (status == 1)
            //{
            //    s = "Data Source = " + ds + ";Initial catalog=" + db + "Intigrated Security = true ; MultipleActiveResultSets=true;";
            //    SettingWindow.updateconfigfile(s,path);

            //}
            //else if (status == 0)
            //{
            //    s = "Data Source = " + ds + ";Initial catalog=" + db + ";User ID=" + username + ";Password =" + password + " MultipleActiveResultSets=true;";
            //    SettingWindow.updateconfigfile(s,path);
            //}
            ////File.WriteAllText(path, s);

            ////MainClass.ShowMessage("Settings Saved Successfully.", "success");
        }   
        
        
    }
}
