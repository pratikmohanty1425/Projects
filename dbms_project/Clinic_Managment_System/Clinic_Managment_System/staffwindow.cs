using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Clinic_Managment_System
{
    public partial class staffwindow : sample1
    {
        /// <summary>
        /// variables used in the program
        /// </summary>

        int userID = 0;
        public staffwindow()
        {
            InitializeComponent();
        }

        private void staffwindow_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            crud.loadlist("st_getRoles",roleDD,"ID","Role",ht);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordtext_TextChanged(object sender, EventArgs e)
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

        private void nametext_TextChanged(object sender, EventArgs e)
        {
            if (nametext.Text == "")
            {
                nametext.BackColor = Color.Red;
            }
            else
            {
                nametext.BackColor = Color.White;
            }
        }

        private void usernametext_TextChanged(object sender, EventArgs e)
        {
            if (usernametext.Text == "")
            {
                usernametext.BackColor = Color.Red;
            }
            else
            {
                usernametext.BackColor = Color.White;
            }
        }

        private void phonetext_TextChanged(object sender, EventArgs e)
        {
            if (phonetext.Text == "")
            {
                phonetext.BackColor = Color.Red;
            }
            else
            {
                phonetext.BackColor = Color.White;
            }
        }

        private void addresstext_TextChanged(object sender, EventArgs e)
        {
            //if (addresstext.Text == "")
            //{
            //    addresstext.BackColor = Color.Red;
            //}
            //else
            //{
            //    addresstext.BackColor = Color.White;
            //}
        }

        public void loaduser()  
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(userIDgv);
            loadDa.Items.Add(nameGV);
            loadDa.Items.Add(UsernameGV);
            loadDa.Items.Add(passwordGV);
            loadDa.Items.Add(phoneGV);
            loadDa.Items.Add(addressGV);
            loadDa.Items.Add(roleIDGV);
            loadDa.Items.Add(RoleGV);
            crud.loadData("st_getStaff", dataGridView1, loadDa);
        }

        

        protected override void savebutton_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count > 0)
            {
                MainClass.ShowMessage("Field with RED are mandatory.", "error");
            }
            else
            {
                if (edit == 0)    ///insert new inputs for staff
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", nametext.Text);
                    ht.Add("@uname", usernametext.Text);
                    ht.Add("@password", passwordtext.Text);
                    ht.Add("@phone", phonetext.Text);
                    ht.Add("@address", addresstext.Text);
                    ht.Add("@roleID", Convert.ToInt32(roleDD.SelectedValue.ToString()));


                    if (crud.iud("st_insertStaff", ht) > 0)
                    {
                        MainClass.ShowMessage(nametext.Text + " added successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loaduser();
                    }
                    else
                    {
                        MainClass.ShowMessage("Unable to save record.", "error");
                    }
                }
                else if (edit == 1)      ///update code for staffs
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", nametext.Text);
                    ht.Add("@uname", usernametext.Text);
                    ht.Add("@password", passwordtext.Text);
                    ht.Add("@phone", phonetext.Text);
                    ht.Add("@address", addresstext.Text);
                    ht.Add("@roleID", Convert.ToInt32(roleDD.SelectedValue.ToString()));
                    ht.Add("@id", userID);

                    if (crud.iud("st_updateStaff", ht) > 0)
                    {
                        MainClass.ShowMessage(nametext.Text + " updated successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loaduser();
                    }

                }
            }
        }

        protected override void deletebutton_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("are you sure?", "question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", userID);


                    if (crud.iud("st_deleteStaff", ht) > 0)
                    {
                        MainClass.ShowMessage(nametext.Text + " deleted successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loaduser();
                    }
                }
            }
        }

        protected override void viewbutton_Click(object sender, EventArgs e)
        {
            loaduser();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControl(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nametext.Text = row.Cells["nameGV"].Value.ToString();
                usernametext.Text = row.Cells["UsernameGV"].Value.ToString();
                passwordtext.Text = row.Cells["passwordGV"].Value.ToString();
                phonetext.Text = row.Cells["phoneGV"].Value.ToString();
                addresstext.Text = row.Cells["addressGV"].Value.ToString();
                roleDD.SelectedValue = row.Cells["roleIDGV"].Value.ToString();
            }
        }

        private void roleDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (roleDD.SelectedIndex == -1)
            //{
            //    roleDD.BackColor = Color.Red;
            //}
            //else
            //{
            //    roleDD.BackColor = Color.White;
            //}
        }
    }
}
