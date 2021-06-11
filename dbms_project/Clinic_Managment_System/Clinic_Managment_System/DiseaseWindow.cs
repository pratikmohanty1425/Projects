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
    public partial class DiseaseWindow : sample1
    {
        public DiseaseWindow()
        {
            InitializeComponent();
        }

        private void DiseaseWindow_Load(object sender, EventArgs e)
        {

        }

        public void loaddisease()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(diseaseIDgv);
            loadDa.Items.Add(diseaseGV);
            crud.loadData("st_getDiseases", dataGridView1, loadDa);
        }
        /*///////////////////////////////////////!!!ALL BUTTONS!!!/////////////////////////////////////////////////////////////////*/

        int diseaseID;
        protected override void viewbutton_Click(object sender, EventArgs e)
        {
            loaddisease();
        }
        protected override void savebutton_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count > 0)
            {
                MainClass.ShowMessage("Field with RED are mandatory.", "error");
            }
            else
            {
                if (edit == 0)//save
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@disease", diseasetext.Text);


                    if (crud.iud("st_insertDisease", ht) > 0)
                    {
                        MainClass.ShowMessage(diseasetext.Text + " Record Added Successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loaddisease();
                    }
                    else
                    {
                        MainClass.ShowMessage("Unable to save record.", "error");
                    }
                }
                else if(edit ==1 )//update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@disease", diseasetext.Text);
                    ht.Add("@did",diseaseID);


                    if (crud.iud("st_updateDisease", ht) > 0)
                    {
                        MainClass.ShowMessage(diseasetext.Text + " Record Added Successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loaddisease();
                    }
                    else
                    {
                        MainClass.ShowMessage("Unable to save record.", "error");
                    }
                }
            }
        }

        protected override void deletebutton_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Do you want to proceed?", "question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@did", diseaseID);
                    if (crud.iud("st_deleteDisease", ht) > 0)
                    {
                        MainClass.ShowMessage(diseasetext.Text + " Record Deleted Successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loaddisease();
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControl(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                diseaseID = Convert.ToInt32(row.Cells["diseaseIDgv"].Value.ToString());
                diseasetext.Text = row.Cells["diseaseGV"].Value.ToString();
            }
        }
    }
}
