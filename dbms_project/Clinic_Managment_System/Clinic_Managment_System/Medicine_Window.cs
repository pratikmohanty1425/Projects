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
    public partial class Medicine_Window : sample1
    {
        public Medicine_Window()
        {
            InitializeComponent();
        }

        public void loadmedicine()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(medicineIDGV);
            loadDa.Items.Add(medicineGV);
            loadDa.Items.Add(typeGV);
            loadDa.Items.Add(companyGV);
            loadDa.Items.Add(costGV);
            crud.loadData("st_getMedicine", dataGridView1, loadDa);
        }
        private void Medicine_Window_Load(object sender, EventArgs e)
        {

        }

        
        protected override void viewbutton_Click(object sender, EventArgs e)
        {
            loadmedicine();
        }

        int medid = 0;
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
                    ht.Add("@name", medicinetext.Text);
                    if(companytext.Text=="")
                    {
                        ht.Add("@comp", DBNull.Value);
                    }
                    else
                    {
                        ht.Add("@comp", companytext.Text);
                    }
                    ht.Add("@type", typeDD.SelectedIndex);
                    ht.Add("@cost", costtext.Text);
                    

                    if (crud.iud("st_insertMedicine", ht) > 0)
                    {
                        MainClass.ShowMessage(medicinetext.Text + " added successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadmedicine();
                    }
                    else
                    {
                        MainClass.ShowMessage("Unable to save record.", "error");
                    }
                }
                else if (edit == 1)      ///update code for staffs
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", medicinetext.Text);
                    if (companytext.Text == "")
                    {
                        ht.Add("@comp", DBNull.Value);
                    }
                    else
                    {
                        ht.Add("@comp", companytext.Text);
                    }
                    ht.Add("@type", typeDD.SelectedIndex);
                    ht.Add("@cost", costtext.Text);
                    ht.Add("@id", medid);

                    if (crud.iud("st_updateMedicine", ht) > 0)
                    {
                        MainClass.ShowMessage(medicinetext.Text + " updated successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadmedicine();
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
                    ht.Add("@id", medid);


                    if (crud.iud("st_deleteMedicine", ht) > 0)
                    {
                        MainClass.ShowMessage(medicinetext.Text + " deleted successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadmedicine();
                    }
                }
            }
        }

        private void medicinetext_TextChanged(object sender, EventArgs e)
        {
            if (medicinetext.Text == "")
            {
                medicinetext.BackColor = Color.Red;
            }
            else
            {
                medicinetext.BackColor = Color.White;
            }
        }

        private void companytext_TextChanged(object sender, EventArgs e)
        {
            if (companytext.Text == "")
            {
                companytext.BackColor = Color.Red;
            }
            else
            {
                companytext.BackColor = Color.White;
            }
        }

        private void typeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeDD.SelectedIndex == -1)
            {
                typeDD.BackColor = Color.Red;
            }
            else
            {
                typeDD.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControl(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                medid = Convert.ToInt32(row.Cells["medicineIDGV"].Value.ToString());
                medicinetext.Text = row.Cells["medicineGV"].Value.ToString();
                companytext.Text = row.Cells["companyGV"].Value.ToString();
                typeDD.SelectedItem = row.Cells["typeGV"].Value.ToString();
                costtext.Text = row.Cells["costGV"].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
