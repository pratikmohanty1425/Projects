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
    class MainClass
    {
        public static void sno(DataGridView gv, string snogv)
        {
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[snogv].Value = count;
            }
             
        }

        /*///////////////////////////////////////////!!!VARIABLES!!!////////////////////////////////////////////////////*/

        public static string path;

        /*/////////////////////////////////////////////!!!SQL CONNECTION STRING!!!////////////////////////////////////////*/
        private static string connectionString()
        {

            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cms_connect";
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
                
            }
            else
            {
                return "";
            }
        }

        public static SqlConnection con = new SqlConnection(connectionString());

        /*/////////////////////////////////////////////!!!WINDOWS VIEWS!!!/////////////////////////////////////////////////*/
        
        public static void showWindow(Form openWin ,Form MDI)
        {
            
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
         
        }

        public static void showWindow(Form openWin,Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();

        }

        public static void ShowMessage(string msg, string type)///done some changes in making E to e
        {
            if (type == "success")
            {
                MessageBox.Show(msg, "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == "error")
            {
                MessageBox.Show(msg, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*///////////////////////////////////////////!!!KEYS VALIDATIONS!!!/////////////////////////////////////////////////*/

        public static void resetEnable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.TabStop == false)
                    {

                    }
                    else
                    {
                        tb.Text = "";
                        tb.Enabled = true;
                        tb.BackColor = Color.White;
                    }

                }
                if (c is ListBox)
                {
                    ListBox lb = (ListBox)c;
                    if (lb.TabStop == false)
                    {

                    }
                    else
                    {
                        lb.Items.Clear();
                        lb.Enabled = true;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.SelectedIndex = -1;
                        cb.Enabled = true;
                        cb.BackColor = Color.White;
                    }    
                    
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.TabStop == false)
                    {

                    }
                    else
                    {
                        rb.Checked = false;
                        rb.Enabled = true;
                        rb.BackColor = Color.White;
                    }
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                        cb.Value = 0;
                    }
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }
                }
                if(c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    if (dt.TabStop == false)
                    {

                    }
                    else
                    {
                        dt.Value = DateTime.Now;
                        dt.Enabled = true;
                    }
                }
            }
        }

        public static void resetEnable(GroupBox p)
        {
            foreach (Control c in p.Controls)
            {
                if(c is GroupBox)
                {
                    GroupBox gb = (GroupBox)c;
                    resetEnable(gb);
                }
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.TabStop == false)
                    {

                    }
                    else
                    {
                        tb.Text = "";
                        tb.Enabled = true;
                        tb.BackColor = Color.White;
                    }

                }
                if (c is ListBox)
                {
                    ListBox lb = (ListBox)c;
                    if (lb.TabStop == false)
                    {

                    }
                    else
                    {
                        lb.DataSource = null;
                        lb.Enabled = true;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.SelectedIndex = -1;
                        cb.Enabled = true;
                        cb.BackColor = Color.White;
                    }

                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.TabStop == false)
                    {

                    }
                    else
                    {
                        rb.Checked = false;
                        rb.Enabled = true;
                        rb.BackColor = Color.White;
                    }
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                        cb.Value = 0;
                    }
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    if (dt.TabStop == false)
                    {

                    }
                    else
                    {
                        dt.Value = DateTime.Now;
                        dt.Enabled = true;
                    }
                }
            }
        }

        public static void resetEnable(TableLayoutPanel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is GroupBox)
                {
                    GroupBox gb = (GroupBox)c;
                    resetEnable(gb);
                }
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.TabStop == false)
                    {

                    }
                    else
                    {
                        tb.Text = "";
                        tb.Enabled = true;
                        tb.BackColor = Color.White;
                    }

                }
                if(c is ListBox)
                {
                    ListBox lb = (ListBox)c;
                    if (lb.TabStop == false)
                    {

                    }
                    else
                    {
                        lb.Items.Clear();
                        lb.Enabled = true;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.SelectedIndex = -1;
                        cb.Enabled = true;
                        cb.BackColor = Color.White;
                    }

                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.TabStop == false)
                    {

                    }
                    else
                    {
                        rb.Checked = false;
                        rb.Enabled = true;
                        rb.BackColor = Color.White;
                    }
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                        cb.Value = 0;
                    }
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    if (dt.TabStop == false)
                    {

                    }
                    else
                    {
                        dt.Value = DateTime.Now;
                        dt.Enabled = true;
                    }
                }
            }
        }

        public static void resetDisable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = false;
                    tb.BackColor = Color.White;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = false;
                    cb.BackColor = Color.White;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = false;
                    rb.BackColor = Color.White;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;
                    cb.BackColor = Color.White;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Now;
                    dt.Enabled = false;
                }
            }
        }

        public static void EnableControl(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.TabStop == false)
                    {

                    }
                    else
                    {
                        
                        tb.Enabled = true;
                        tb.BackColor = Color.White;
                    }

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        
                        cb.Enabled = true;
                        cb.BackColor = Color.White;
                    }

                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.TabStop == false)
                    {

                    }
                    else
                    {
                        
                        rb.Enabled = true;
                        rb.BackColor = Color.White;
                    }
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    if (cb.TabStop == false)
                    {

                    }
                    else
                    {
                        cb.Enabled = true;
                    }
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    if (dt.TabStop == false)
                    {

                    }
                    else
                    {
                        
                        dt.Enabled = true;
                    }
                }
            }
        }

        public static void DisableControl(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = false;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = false;
                }
            }
        }

        public static ArrayList checkControls(Panel p)
        {
            ArrayList arr = new ArrayList();
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.AllowDrop == true)
                    {

                    }
                    else
                    {
                        if (tb.Text == "")
                        {
                            arr.Add(tb);
                        }
                        else
                        {
                            if (arr.Contains(tb))
                            {
                                arr.Remove(tb);
                            }
                        }
                        tb.BackColor = tb.Text == "" ? tb.BackColor = Color.Red : tb.BackColor = Color.White;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if (cb.AllowDrop == true)
                    {

                    }
                    else
                    {
                        if (cb.SelectedIndex == -1)
                        {
                            arr.Add(cb);
                        }
                        else
                        {
                            if (arr.Contains(cb))
                            {
                                arr.Remove(cb);
                            }
                        }
                        cb.BackColor = cb.Text == "" ? cb.BackColor = Color.Red : cb.BackColor = Color.White;
                    }
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if(rb.AllowDrop==true)
                    {

                    }
                    else
                    {
                        if (!rb.Checked)
                        {
                            arr.Add(rb);
                        }
                        else
                        {
                            if (arr.Contains(rb))
                            {
                                arr.Remove(rb);
                            }
                        }
                        rb.BackColor = !rb.Checked ? rb.BackColor = Color.Red : rb.BackColor = Color.White;
                    }

                }
                if (c is CheckBox)
                {
                    //CheckBox cb = (CheckBox)c;
                    //if(cb.AllowDrop==true)
                    //{

                    //}
                    //else
                    //{
                    //    if (!cb.Checked)
                    //    {
                    //        arr.Add(cb);
                    //    }
                    //    else
                    //    {
                    //        if (cb.Contains(cb))
                    //        {
                    //            arr.Remove(cb);
                    //        }
                    //    }
                    //    cb.BackColor = !cb.Checked ? cb.BackColor = Color.Red : cb.BackColor = Color.White;
                    //}

                }
                if (c is NumericUpDown)
                {
                    NumericUpDown nb = (NumericUpDown)c;
                    if (nb.Value == 0)
                    {
                        arr.Add(nb);
                    }
                    else
                    {
                        if (arr.Contains(nb))
                        {
                            arr.Remove(nb);
                        }
                    }
                    nb.BackColor = nb.Value == 0 ? nb.BackColor = Color.Red : nb.BackColor = Color.White;

                }
                //if (c is DateTimePicker)
                //{
                //    DateTimePicker dt = (DateTimePicker)c;
                //    if(dt.AllowDrop==true)
                //    {
                //        arr.Add(dt);
                //    }
                //    else
                //    {
                //        if(dt.Value<DateTime.Today)
                //        {
                //            if (arr.Contains(dt))
                //            {
                //                arr.Remove(dt);
                //            }
                //        }
                //    }
                //    dt.BackColor = dt.Value < DateTime.Today ? dt.BackColor = Color.Red : dt.BackColor = Color.White;
                //}

            }
            return arr;
        }
    }
}