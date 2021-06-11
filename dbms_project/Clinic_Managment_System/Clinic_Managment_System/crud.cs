using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MongoDB;
//using MongoDB.Bson;
using System.Windows.Forms;
using System.Data;
//using MongoDB.Driver;
using System.Data.SqlClient;
using Clinic_Managment_System;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace Clinic_Managment_System
{
    public class crud
    {

        public static bool checkExitance(string proc,Hashtable ht)
        {
            bool check2 = false;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    check2 = true;
                }
                else
                {
                    check2 = false;

                }
                MainClass.con.Close();
            }
            catch(Exception)
            {
                MainClass.con.Close();
            }

            return check2;
        }

        public static object getlastID(string proc)
        {
            object o = null;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                o = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMessage(ex.Message, "error");
            }
            return o;
        }

        public static void loadlist(string proc,ComboBox cb,string valuemember,string displaymember,Hashtable ht)//change null later
        { 
            try
            {
                cb.Items.Clear();
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = displaymember;
                cb.ValueMember = valuemember;
                cb.DataSource = dt;
                cb.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MainClass.ShowMessage(ex.Message, "error");
            }
        }

        public static int i = 0;
        public static int getturnno(string proc,Hashtable ht)//change null later
        {
            int turnno=0;
            try
            {
                //cb.Items.Clear();
                i++;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if(i>1)
                {
                    MainClass.con.Close();
                }
                else
                {
                    MainClass.con.Open();
                    turnno = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    MainClass.con.Close();

                }
            }
            catch (Exception ex)
            {
                MainClass.ShowMessage(ex.Message, "error");
                MainClass.con.Close();
            }
            return turnno;
        }

        public static int iud(string proc,Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(),item.Value);
                }
                                
                MainClass.con.Open();
                res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMessage(ex.Message, "error");
                
            }
            return res;
        }

        public static void loadData(string proc, DataGridView gv, ListBox lb, Hashtable ht = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (ht != null)
                {
                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
                int count = 0;
                foreach(DataGridViewRow row in gv.Rows)
                {
                    count++;
                    row.Cells[0].Value = count;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void showreport(string proc,ReportDocument rd,string reportname,Hashtable ht,CrystalReportViewer cr)
        {
            try
            {
                 
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 

                da.Fill(dt);
                rd.Load(@"E:\dbms_project\Clinic_Managment_System\Clinic_Managment_System\bin\Debug\Reports\prescription.rpt");

                //rd.Load(Application.StartupPath + "\\Reports\\" + reportname+ ".rpt");

                rd.SetDataSource(dt);

                cr.ReportSource = rd;

                cr.RefreshReport();
            }
            catch(Exception e)
            {
                if(rd!=null)
                {
                    rd.Close();
                }
                MessageBox.Show(e.Message);
            }
        }
    }



}
