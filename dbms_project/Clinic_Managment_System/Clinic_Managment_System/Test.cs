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
    public partial class Test : sample1
    {
        public Test()
        {
            InitializeComponent();
        }

        public void loadtest()
        {
            ListBox loadDa = new ListBox();
            loadDa.Items.Add(testIDgv);
            loadDa.Items.Add(tsxGV);
            loadDa.Items.Add(priceGV);
            loadDa.Items.Add(precautionGV);
            crud.loadData("st_getTests", dataGridView1, loadDa);
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }



        int testID=0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControl(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                testID = Convert.ToInt32(row.Cells["testIDgv"].Value.ToString());
                testnametext.Text = row.Cells["tsxGV"].Value.ToString();
                pricetext.Text = Math.Round(Convert.ToDouble(row.Cells["priceGV"].Value.ToString()),0).ToString();
                precautiontext.Text = row.Cells["precautionGV"].Value.ToString();

            }
        }

        /*////////////////////////////////////!!!ALL BUTTONS!!!//////////////////////////////////////////////*/

        protected override void viewbutton_Click(object sender, EventArgs e)
        {
            loadtest();
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
                    ht.Add("@name", testnametext.Text);
                    ht.Add("@price", pricetext.Text);
                    ht.Add("@prec", precautiontext.Text);


                    if (crud.iud("st_insertTests", ht) > 0)
                    {
                        MainClass.ShowMessage(testnametext.Text + " added successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadtest();
                    }
                    else
                    {
                        MainClass.ShowMessage("Unable to save record.", "error");
                    }
                }
                else if (edit == 1)      ///update code for staffs
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", testnametext.Text);
                    ht.Add("@price", pricetext.Text);
                    ht.Add("@prec", precautiontext.Text);
                    ht.Add("@id", testID);

                    if (crud.iud("st_updateTests", ht) > 0)
                    {
                        MainClass.ShowMessage(testnametext.Text + " updated successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadtest();
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
                    ht.Add("@id", testID);


                    if (crud.iud("st_deleteTest", ht) > 0)
                    {
                        MainClass.ShowMessage(testnametext.Text + " deleted successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadtest();
                    }
                }
            }
        }
    }
}
