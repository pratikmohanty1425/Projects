using System;
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
    public partial class LoginWindow : sample
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (passwordtext.Text == "")
            {
                passwordtext.BackColor = Color.Red;
            }
            else
            {
                passwordtext.BackColor = Color.White;
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            //if (MainClass.checkControls(leftpanel).Count > 0)
            //{
            //    MainClass.ShowMessage("Fields with RED are mandatory", "error");
            //}
            ////else if(usertext.Text=="admin"&&passwordtext.Text=="1234")
            ////{
            ////    HomeScreen hm = new HomeScreen();
            ////    MainClass.showWindow(hm, MDI.ActiveForm);
            ////}
            //else
            //{
            //    Hashtable ht = new Hashtable();
            //    ht.Add("@username", usertext.Text);
            //    ht.Add("@pass", passwordtext.Text);

            //    if (Login.getlogindetails("st_getAuthenticationDetails", ht))
            //    {
            //        HomeScreen hm = new HomeScreen();
            //        MainClass.showWindow(hm, MDI.ActiveForm);
            //    }
            //    else
            //    {

            //    }

            //}
            ////undo it later
            HomeScreen hm = new HomeScreen();
            MainClass.showWindow(hm, MDI.ActiveForm);

        }

        private void usertext_TextChanged(object sender, EventArgs e)
        {
            if (usertext.Text == "")
            {
                usertext.BackColor = Color.Red;
            }
            else
            {
                usertext.BackColor = Color.White;
            }
        }
    }
}
