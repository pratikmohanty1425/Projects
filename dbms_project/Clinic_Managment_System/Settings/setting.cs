using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clinic_Managment_System
{
    public class setting
    {
        public void createfile(string file,int status,string ds,string db,string username=null,string password=null)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + file;
            if (File.Exists(path))
            {
                string s = "";
                if(status==1)
                {
                    s = "Data Source = " + ds + ";Initial cataloge" + db + "Intigrated Security = true ; MultipleActiveResultSets = true;";

                }
                else if(status==0)
                {
                    s = "Data Source = " + ds + ";Initial cataloge" + db + ";User ID="+username+";Password ="+password+" MultipleActiveResultSets = true;";
                
                }
                File.WriteAllText(path, s);
                MessageBox.Show("Test");
                
            }
        }      

    }
}
