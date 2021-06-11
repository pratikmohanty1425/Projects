//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MongoDB;
//using MongoDB.Bson;
//using System.Windows.Forms;
//using System.Data;
//using MongoDB.Driver;
//using System.Data.SqlClient;
//using Clinic_Managment_System;

//namespace Clinic_Managment_System
//{
//    public class crud
//    {
//        public static int iud(string proc, ListBox lb1, ListBox lb2)
//        {
//            int res = 0;
//            try
//            {
//                //MongoCommand cmd = new MongoCommand();
//                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                for (int i = 0; i < lb1.Items.Count; i++)
//                {
//                    cmd.Parameters.AddWithValue(lb1.Items[i].ToString(), lb2.Items[0]);
//                }
//                MainClass.con.Open();
//                res = cmd.ExecuteNonQuery();
//                MainClass.con.Close();
//            }
//            catch (Exception ex)
//            {

//                MainClass.con.Close();
//                MainClass.ShowMessage(ex.Message, "error");

//            }
//            return res;
//        }
//    }
//}
