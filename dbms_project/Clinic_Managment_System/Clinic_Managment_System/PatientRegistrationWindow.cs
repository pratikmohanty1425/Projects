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
using System.Transactions;

namespace Clinic_Managment_System
{
    public partial class PatientRegistrationWindow : sample1
    {
        
        public PatientRegistrationWindow()
        {
            InitializeComponent();
        }
        private void phonetext_Leave(object sender, EventArgs e)
        {
            if (phonetext.Text != "")
            {
                if (get_checkpatientrecord(phonetext.Text))
                {

                }
                else
                {

                }
            }
        }

        /*//////////////////////////////////////!!!MEMBER VARIABLES!!!///////////////////////////////////////////////*/

        Int64 patID, appID;

        /*/////////////////////////////////////!!!MEMBER FUNCTION!!!////////////////////////////////////////////////*/

        private bool get_checkpatientrecord(string phone)
        {
            bool check = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkPatientRegistrationExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", phone);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    check = true;
                    while(dr.Read())
                    {
                        patID = Convert.ToInt64(dr["PatientID"].ToString());
                        patienttext.Text = dr["Patient"].ToString();
                        fmgtext.Text = dr["Guardian"].ToString();
                        gendertext.Text = dr["Gender"].ToString();                        
                        lastappintmentdatePicker.Value = Convert.ToDateTime(dr["Last Appointment"].ToString());
                        agetext.Text = dr["Age"].ToString();
                        consultedtext.Text = dr["Doctor"].ToString();
                        statustext.Text = dr["Status"].ToString();
                    }
                }
                else
                {
                    check = false;
                }
                MainClass.con.Close();
            }
            catch(Exception)
            {
                MainClass.con.Close();
                throw;
            }
            return check;
        }
        private void PatientRegistrationWindow_Load(object sender, EventArgs e)//check
        {
            Hashtable ht = new Hashtable();
            crud.loadlist("st_getDoctors",appointmentforDD,"ID","Doctor",ht);            
        }


        public void loadpatient()
        {
            ListBox loadDa = new ListBox();

            loadDa.Items.Add(turnGV);
            loadDa.Items.Add(patientIDgv);
            loadDa.Items.Add(PatientGV);
            loadDa.Items.Add(fmgGV);
            loadDa.Items.Add(genderGV);
            loadDa.Items.Add(appointdateGV);
            loadDa.Items.Add(ageGV);
            loadDa.Items.Add(doctorGV);
            loadDa.Items.Add(doctorIDGV);
            loadDa.Items.Add(statusGV);
            loadDa.Items.Add(appIDGV);
            loadDa.Items.Add(phoneGV);
            crud.loadData("st_getPatientAppointmentRegistration", dataGridView1, loadDa);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.DisableControl(leftpanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];                
                patID = Convert.ToInt64(row.Cells["patientIDgv"].Value.ToString());
                appID= Convert.ToInt64(row.Cells["appIDGV"].Value.ToString());
                phonetext.Text = row.Cells["phoneGV"].Value.ToString();
                patienttext.Text = row.Cells["PatientGV"].Value.ToString();
                fmgtext.Text = row.Cells["fmgGV"].Value.ToString();
                agetext.Text = row.Cells["ageGV"].Value.ToString();
                gendertext.Text = row.Cells["genderGV"].Value.ToString();
                appointmentdatePicker.Value = Convert.ToDateTime(row.Cells["appointdateGV"].Value.ToString());
                appointmentforDD.SelectedValue = row.Cells["doctorIDGV"].Value;
                get_checkpatientrecord(phonetext.Text);
            }

        }
        
        /*/////////////////////////////////////  !!!ALL BUTTONS!!!  ///////////////////////////////////////////////////*/

        protected override void viewbutton_Click(object sender, EventArgs e)
        {
            loadpatient();
        }


        protected override void savebutton_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftpanel).Count > 0)
            {
                MainClass.ShowMessage("Field with RED are mandatory.", "error");
            }
            else
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    if (edit == 0)    ///insert new inputs for patient
                    {
                        if (get_checkpatientrecord(phonetext.Text))
                        {
                            Hashtable ht = new Hashtable();
                            ht.Add("@name", patienttext.Text);
                            ht.Add("@age", agetext.Text);
                            ht.Add("@guard", fmgtext.Text);
                            ht.Add("@gender", gendertext.Text);
                            ht.Add("@phone", phonetext.Text);
                            ht.Add("@id", patID);
                            if (crud.iud("st_updatePatientReg", ht) > 0)
                            {
                                Int64 patientID = patID;
                                Hashtable hw = new Hashtable();
                                hw.Add("@date", appointmentdatePicker.Value);
                                hw.Add("@doctorID", Convert.ToInt32(appointmentforDD.SelectedValue.ToString()));
                                hw.Add("@patientID", patientID);
                                hw.Add("@status", 0);
                                hw.Add("@day", appointmentdatePicker.Value.Day);
                                hw.Add("@month", appointmentdatePicker.Value.Month);
                                hw.Add("@year", appointmentdatePicker.Value.Year);

                                if (crud.iud("st_insertAppointment", hw) > 0)
                                {
                                    MainClass.ShowMessage(patienttext.Text + " added successfully..", "success");
                                    MainClass.resetDisable(leftpanel);
                                    loadpatient();
                                }

                            }
                            else
                            {
                                MainClass.ShowMessage("Unable to save record.", "error");
                            }
                        }
                        else
                        {
                            Hashtable ht = new Hashtable();
                            ht.Add("@name", patienttext.Text);
                            ht.Add("@guard", fmgtext.Text);
                            ht.Add("@age", agetext.Text);
                            ht.Add("@gender", gendertext.Text);
                            ht.Add("@phone", phonetext.Text);

                            if (crud.iud("st_insertPatientReg", ht) > 0)
                            {
                                Int64 patientID = Convert.ToInt64(crud.getlastID("st_getLastPatientID"));
                                Hashtable hw = new Hashtable();
                                hw.Add("@date", appointmentdatePicker.Value);
                                hw.Add("@doctorID", Convert.ToInt32(appointmentforDD.SelectedValue.ToString()));
                                hw.Add("@patientID", patientID);
                                hw.Add("@status", 0);
                                hw.Add("@day", appointmentdatePicker.Value.Day);
                                hw.Add("@month", appointmentdatePicker.Value.Month);
                                hw.Add("@year", appointmentdatePicker.Value.Year);

                                if (crud.iud("st_insertAppointment", hw) > 0)
                                {
                                    MainClass.ShowMessage(patienttext.Text + " added successfully..", "success");
                                    MainClass.resetDisable(leftpanel);
                                    loadpatient();
                                }

                            }
                            else
                            {
                                MainClass.ShowMessage("Unable to save record.", "error");
                            }
                        }

                    }
                    else if (edit == 1)      ///update code 
                    {
                        Hashtable ht = new Hashtable();
                        ht.Add("@name", patienttext.Text);
                        ht.Add("@guard", fmgtext.Text);
                        ht.Add("@gender", gendertext.Text);
                        ht.Add("@phone", phonetext.Text);
                        ht.Add("@age", agetext.Text);
                        ht.Add("@id", patID);

                        if (crud.iud("st_updatePatientReg", ht) > 0)
                        {
                            //Int64 pID = Convert.ToInt64(crud.getlastID("st_getLastPatientID"));
                            Hashtable hw = new Hashtable();
                            hw.Add("@date", appointmentdatePicker.Value);
                            hw.Add("@doctorID", Convert.ToInt32(appointmentforDD.SelectedValue.ToString()));
                            hw.Add("@patientID", patID);
                            hw.Add("@status", 1);
                            hw.Add("@id", appID);
                            if (crud.iud("st_updateAppointment", hw) > 0)
                            {
                                MainClass.ShowMessage(patienttext.Text + " updated successfully..", "success");
                                MainClass.resetDisable(leftpanel);
                                loadpatient();
                            }

                        }
                        else
                        {
                            MainClass.ShowMessage("Unable to update the record.", "error");
                        }
                    }
                    sc.Complete();
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
                    ht.Add("@id", patID);


                    if (crud.iud("st_deletePatientReg", ht) > 0)
                    {
                        MainClass.ShowMessage(patienttext.Text + " deleted successfully..", "success");
                        MainClass.resetDisable(leftpanel);
                        loadpatient();
                    }
                }
            }
        }

    }
}
