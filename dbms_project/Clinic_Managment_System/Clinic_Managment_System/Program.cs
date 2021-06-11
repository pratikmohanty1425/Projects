using System;
using MongoDB.Driver;
using MongoDB.Bson;
/*using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;*/
using MongoDB.Driver.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Data;
//using System.Data.MongoClient;
//using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Collections;

namespace Clinic_Managment_System
{
    class mainlcass
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new sample1());
        }
        public static void sno(DataGridView gv, string snogv)
        {
            int count = 0;
            /*foreach (var item in collection)
            {
                
            }*/
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[snogv].Value = count;
            }
        }
        public static string path;

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

        public static MongoClient client = new MongoClient(connectionString());

        public static void showWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }

        public static void ShowMessage(string msg, string type)
        {
            if (type == "success")
            {
                MessageBox.Show(msg, "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == "Error")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void resetEnable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = true;
                    tb.BackColor = Color.White;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = true;
                    cb.BackColor = Color.White;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = true;
                    rb.BackColor = Color.White;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = true;
                    cb.BackColor = Color.White;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = true;
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
            }
        }

        public static void EnableControl(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = true;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = true;
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
                            if (tb.Text == "")
                            {
                                arr.Remove(tb);
                            }
                        }
                        tb.BackColor = tb.Text == ""? tb.BackColor = Color.Firebrick : tb.BackColor = Color.White;
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
                            if (cb.Text == "")
                            {
                                arr.Remove(cb);
                            }
                        }
                        cb.BackColor = cb.Text == "" ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                    }
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (!rb.Checked)
                    {
                        arr.Add(rb);
                    }
                    else
                    {
                        if (rb.Contains(rb))
                        {
                            arr.Remove(rb);
                        }
                    }
                    rb.BackColor = !rb.Checked ? rb.BackColor = Color.Firebrick : rb.BackColor = Color.White;

                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (!cb.Checked)
                    {
                        arr.Add(cb);
                    }
                    else
                    {
                        if (cb.Contains(cb))
                        {
                            arr.Remove(cb);
                        }
                    }
                    cb.BackColor = !cb.Checked ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;

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
                        if (nb.Contains(nb))
                        {
                            arr.Remove(nb);
                        }
                    }
                    nb.BackColor = nb.Value == 0 ? nb.BackColor = Color.Firebrick : nb.BackColor = Color.White;

                }
            }
            return arr;
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        public static void resetEnable(FlowLayoutPanel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = true;
                    tb.BackColor = Color.White;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = true;
                    cb.BackColor = Color.White;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = true;
                    rb.BackColor = Color.White;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = true;
                    cb.BackColor = Color.White;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = true;
                }
            }
        }

        public static void resetDisable(FlowLayoutPanel p)
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
            }
        }

        public static void EnableControl(FlowLayoutPanel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Enabled = true;
                }
                if (c is Button)
                {
                    Button cb = (Button)c;
                    cb.Enabled = true;
                }
            }
        }

        public static void DisableControl(FlowLayoutPanel p)
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
            }
        }

        public static ArrayList checkControls(FlowLayoutPanel p)
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
                            if (tb.Text == "")
                            {
                                arr.Remove(tb);
                            }
                        }
                        tb.BackColor = tb.Text == "" ? tb.BackColor = Color.Firebrick : tb.BackColor = Color.White;
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
                            if (cb.Text == "")
                            {
                                arr.Remove(cb);
                            }
                        }
                        cb.BackColor = cb.Text == "" ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;
                    }
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (!rb.Checked)
                    {
                        arr.Add(rb);
                    }
                    else
                    {
                        if (rb.Contains(rb))
                        {
                            arr.Remove(rb);
                        }
                    }
                    rb.BackColor = !rb.Checked ? rb.BackColor = Color.Firebrick : rb.BackColor = Color.White;

                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (!cb.Checked)
                    {
                        arr.Add(cb);
                    }
                    else
                    {
                        if (cb.Contains(cb))
                        {
                            arr.Remove(cb);
                        }
                    }
                    cb.BackColor = !cb.Checked ? cb.BackColor = Color.Firebrick : cb.BackColor = Color.White;

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
                        if (nb.Contains(nb))
                        {
                            arr.Remove(nb);
                        }
                    }
                    nb.BackColor = nb.Value == 0 ? nb.BackColor = Color.Firebrick : nb.BackColor = Color.White;

                }
            }
            return arr;
        }
    }
}