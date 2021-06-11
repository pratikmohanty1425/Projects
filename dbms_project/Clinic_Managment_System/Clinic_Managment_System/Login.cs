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
    public class Login
    {
        /// <summary>
        /// all types of variables 
        /// </summary>
        private static int userID, roleID;
        private static string name;
        private static string role;

        /// <summary>
        /// member functions 
        /// </summary>
        public static string NAME
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;   ////while login it will store the name for a while for checking
            }
        }

        public static string ROLE
        {
            get
            {
                return role;
            }
            private set
            {
                role = value;   ////while login it will store the role for a while for checking
            }
        }
        public static int USERID
        {
            get
            {
                return userID;
            }
            private set
            {
                userID = value;   ////while login it will store the role for a while for checking
            }
        }
        public static int ROLEID
        {
            get
            {
                return roleID;
            }
            private set
            {
                roleID = value;   ////while login it will store the role for a while for checking
            }
        }


        /*//////////////////////////////////////////!!!DETAILS!!!////////////////////////////////////////////////////////*/

        public static bool getlogindetails(string proc, Hashtable ht)
        {
            bool check = false;

            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    check = true;
                    while (dr.Read())
                    {
                        USERID = Convert.ToInt32(dr[0].ToString());
                        NAME = dr[1].ToString();

                        ROLEID = Convert.ToInt32(dr[2].ToString());
                        ROLE = dr[3].ToString();
                    }
                }
                else
                {
                    check = false;
                    MainClass.ShowMessage("invalid username or password.", "error");
                }

                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMessage(ex.Message, "error");
            }

            return check;
        }
    }
}
