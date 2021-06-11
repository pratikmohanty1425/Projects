using System;
//using MongoDB.Driver;
//using MongoDB.Bson;
//using MongoDB.Driver.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections;

namespace Clinic_Managment_System
{
    public partial class rolewindow : sample1
    {
        public rolewindow()
        {
            InitializeComponent();
        }
        static int roleID;

        protected void rolewindow_Load(object sender, EventArgs e)
        {

        }//not used

        protected void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(roletextBox.Text=="")
            {
                Color firebrick = Color.Firebrick;
                roletextBox.BackColor = firebrick;
            }
            else
            {
                roletextBox.BackColor = Color.White;
            }
        }

        protected void rolelabel_Click(object sender, EventArgs e)
        {

        }//not used

        public void loadRoles()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(roleIDGV);
            loadDa.Items.Add(RoleGV);
            crud.loadData("st_getRoles", dataGridView1, loadDa);
        }
        //////////////////////////////////////////////////////////////////////
        ///////////////ALL BUTTONS ARE HERE////////////
        /// // / // // // /// / / / / / / / / / / / / / / / / 
        protected override void savebutton_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count > 0)
            {
                MainClass.ShowMessage("Field with RED are mandatory.", "error");
            }
            else
            {
                if (edit == 0)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", roletextBox.Text);
                    

                    if (crud.iud("st_insertRoles", ht) > 0)
                    {
                        MainClass.ShowMessage(roletextBox.Text + " Record Added Successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadRoles();
                    }
                    else
                    {
                        MainClass.ShowMessage("Unable to save record.", "error");
                    }
                }
                else if (edit == 1)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", roletextBox.Text);
                    ht.Add("@id", roletextBox.Text);


                    if (crud.iud("st_updateRoles", ht) > 0)
                    {
                        MainClass.ShowMessage(roletextBox.Text + " Record Updated Successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadRoles();
                    }

                }
            }
        }

        protected override void deletebutton_Click(object sender, EventArgs e)
        {
            if(edit==1)
            {
                DialogResult dr = MessageBox.Show("Do you want to proceed?", "question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr==DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@id",roleID);


                    if (crud.iud("st_deleteRoles", ht) > 0)
                    {
                        MainClass.ShowMessage(roletextBox.Text + " Record Deleted Successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadRoles();
                    }
                }
            }
        }
        
        protected void toprightpanel_Paint(object sender, PaintEventArgs e)
        {

        }//not used

        protected void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!= -1 && e.ColumnIndex!= -1)
            {
                edit = 1;
                MainClass.DisableControl(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["roleIDGV"].Value.ToString());
                roletextBox.Text=row.Cells["roleIDGV"].Value.ToString();
            }
        }
        protected override void viewbutton_Click(object sender, EventArgs e)
        {
            loadRoles();
        }

        protected override void searchtextbox_TextChanged(object sender, EventArgs e)
        {

        }//not used
        protected void groupBox1_Enter(object sender, EventArgs e)
        {

        }//not used

        protected void userlabel_Click(object sender, EventArgs e)
        {

        }//not used

        protected void backbutton1_Click(object sender, EventArgs e)
        {

        }//not used

        protected void panel2_Paint(object sender, PaintEventArgs e)
        {

        }//not used


    }
}
