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
    public partial class SymptomsWindow : sample1
    {
        public SymptomsWindow()
        {
            InitializeComponent();
        }

        private void SymptomsWindow_Load(object sender, EventArgs e)
        {
            

        }

        public void loadsymptoms()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(symptomIDgv);
            loadDa.Items.Add(symptomGV);
            crud.loadData("st_getSymptoms", dataGridView1, loadDa);
        }

        /*/////////////////////////////!!!ALL BUTTON!!!///////////////////////////////////*/

        int symptomID;
        protected override void viewbutton_Click(object sender, EventArgs e)
        {
            loadsymptoms();
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
                    ht.Add("@symptom", symptomtext.Text);


                    if (crud.iud("st_insertSymptoms", ht) > 0)
                    {
                        MainClass.ShowMessage(symptomtext.Text + " Record Added Successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadsymptoms();
                    }
                    else
                    {
                        MainClass.ShowMessage("Unable to save record.", "error");
                    }
                }
                else if (edit == 1)//update
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@symptom", symptomtext.Text);
                    ht.Add("@syid", symptomID);


                    if (crud.iud("st_updateSymptom", ht) > 0)
                    {
                        MainClass.ShowMessage(symptomtext.Text + " Record Added Successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadsymptoms();
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
                    ht.Add("@syid", symptomID);


                    if (crud.iud("st_deleteSymptom", ht) > 0)
                    {
                        MainClass.ShowMessage(symptomtext.Text + " Record Deleted Successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadsymptoms();
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
                symptomID = Convert.ToInt32(row.Cells["symptomIDgv"].Value.ToString());
                symptomtext.Text = row.Cells["symptomGV"].Value.ToString();
            }
        }
    }
}
