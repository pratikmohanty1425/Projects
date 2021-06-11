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
    public partial class Check_up : sample1

    {
        public Check_up()
        {
            InitializeComponent();
        }       

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        /*///////////////////////////////////!!!ALL MEMBERS VARIABLES!!!//////////////////////////////////////////////////////////////////////*/

        public static int turnno;
        public static string patientName;
        Int64 patientappID = 0;
        Hashtable htinternal = new Hashtable();
        Hashtable htexternal = new Hashtable();
        Hashtable diseaseHT = new Hashtable();

        /*//////////////////////////////////!!!ALL FUNCTIONS!!!///////////////////////////////////////////////////*/

        public void loadtodayspatiens()
        {
            patientDD1.DataSource = null;
            Hashtable ht = new Hashtable();
            ht.Add("@day", dateTimePicker1.Value.Day);
            ht.Add("@month", dateTimePicker1.Value.Month);
            ht.Add("@year", dateTimePicker1.Value.Year);
            crud.loadlist("st_getTodaysPatients", patientDD1, "Patient ID", "Patient", ht);
        }

        public void getpatientinfo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPatientGuardianAndAge", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt64(patientDD1.SelectedValue.ToString()));
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        fmgtext.Text = dr[0].ToString();
                        patientagetext.Text = dr[1].ToString();
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception )
            {
                MainClass.con.Close();
            }
        }

        private int getdiseaseID(string name)
        {
            int did = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getDiseaseIDWRTName", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",name);

                MainClass.con.Open();
                did = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return did;
        }

        private Int64 getsymptomID(string name)
        {
            Int64 sid = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSymptomIDWRTName", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);

                MainClass.con.Open();
                sid = Convert.ToInt64(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return sid;
        }

        private int getTestID(string name)
        {
            int tid = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getTestIDWRTName", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);

                MainClass.con.Open();
                tid = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return tid;
        }

        private int getmedicineID(string name)
        {
            int mid = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getMedicineIDWRTName", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);

                MainClass.con.Open();
                mid = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
            }
            return mid;
        }

        public Int64 getpatientappintmentID()
        {
            Int64 appointmentID = 0; 
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPatientAppointmentID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@patID", Convert.ToInt64(patientDD1.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@day", dateTimePicker1.Value.Day );
                cmd.Parameters.AddWithValue("@month", dateTimePicker1.Value.Month );
                cmd.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year );
                //MainClass.con.Open();
                appointmentID = Convert.ToInt64(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
            }
            return appointmentID;
        }

        private void Check_up_Load(object sender, EventArgs e)
        {
            loadtodayspatiens();

            Hashtable ht = new Hashtable();
            crud.loadlist("st_getDiseases", diseaseDD, "ID", "Disease", ht);//to get diseases
            crud.loadlist("st_getSymptoms", symptomsDD, "SymptomID", "Symptom", ht);//to get symptoms

            Hashtable ht1 = new Hashtable();

            ht1.Add("@type", 0);
            crud.loadlist("st_getMedicineWRTType", prescriptioninternelDD, "ID", "Medicine", ht1);//to get internal medicines


            Hashtable ht2 = new Hashtable();

            ht2.Add("@type", 1);
            crud.loadlist("st_getMedicineWRTType", prescriptionexternalDD, "ID", "Medicine", ht2);//to get internal medicines


            crud.loadlist("st_getTests", testsDD, "ID", "Test", ht);//to get tests
        }        

        private void patientDD_Enter(object sender, EventArgs e)
        {
            loadtodayspatiens();
        }

        public void getlastmedicine(ListBox lb,Int64 appID,Int16 type)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("st_getLastPrescribedMedicine",MainClass.con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@type",type);
                cmd2.Parameters.AddWithValue("@appID",appID);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable gt = new DataTable();
                da.Fill(gt);
                lb.DisplayMember = "Medicine";
                lb.ValueMember = "ID";
                lb.DataSource = gt;
            }
            catch(Exception)
            {
            }
        }

        public void getlastdetails(string proc,ListBox lb,string param,object val,string dmember,string vmember)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand(proc, MainClass.con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue(param, val);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable gt = new DataTable();
                da.Fill(gt);
                lb.DisplayMember = dmember;
                lb.ValueMember = vmember;
                lb.DataSource = gt;
            }
            catch (Exception)
            {
            }
        }

        public void getlastremarks()
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("st_getLastRemarks", MainClass.con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@appID",patientappID);
                MainClass.con.Open();
                remarks2text.Text = cmd2.ExecuteScalar().ToString();
                MainClass.con.Close();
            }
            catch (Exception)
            {
            }
        }

        public void getlastCheckUpDetails(Int16 status, Int64 patientID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLastCheckupDetails1", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@status",status);
                cmd.Parameters.AddWithValue("@patientID",patientID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lastappintmentdatePicker.Value = Convert.ToDateTime(dr["AppointmentDate"].ToString());
                        consultedtext.Text = dr["Doctor"].ToString();
                        pulsetext.Text = dr["Pulse"].ToString();
                        temptext.Text = dr["Temperature"].ToString();
                        bloodtext.Text = dr["Glucose"].ToString();
                        patientappID = Convert.ToInt64(dr["AppointID"].ToString());
                    }
                }              

                MainClass.con.Close();

            }
            catch(Exception)
            {
                MainClass.con.Close();
            }
        }

        

        /*///////////////////////////////////!!!ALL BUTTONS!!!///////////////////////////////////////*/

        /*//////////////////////////!!!ADD!!!///////////////////////////*/

        private void callpatientbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@day", dateTimePicker1.Value.Day);
                ht.Add("@month", dateTimePicker1.Value.Month);
                ht.Add("@year", dateTimePicker1.Value.Year);
                ht.Add("@patID", Convert.ToInt64(patientDD1.SelectedValue.ToString()));
                turnno = crud.getturnno("st_getTurnNumberWRTpatientWRTToday", ht);
                getpatientinfo();
                getlastCheckUpDetails(1, Convert.ToInt64(patientDD1.SelectedValue.ToString()));/////////i have change 1 to 0 as the patient ids get deleted autometically when the status is becoming 1 
                getlastmedicine(listBox6, patientappID, 0);
                getlastmedicine(listBox7, patientappID, 1);
                getlastdetails("st_getLastSymptoms", listBox8, "@appID", patientappID, "Symptom", "ID");
                getlastdetails("st_getLastDisease", listBox9, "@appID", patientappID, "Disease", "ID");
                getlastdetails("st_getLastTests", listBox10, "@appID", patientappID, "Test", "ID");
                getlastremarks();
            }
            catch(Exception)
            {
                MainClass.ShowMessage("Before calling enter the name","error");
            }
        }

        private void diseaseaddbutton_Click(object sender, EventArgs e)
        {
            if (diseaseDD.Text != "")
            {
                if (!diseaseLB.Items.Contains(diseaseDD.Text))
                {
                    diseaseLB.Items.Add(diseaseDD.Text);
                    //diseaseHT.Add(diseaseDD.SelectedValue.ToString());
                }
            }
        }

        private void internalprescriptionaddbutton_Click(object sender, EventArgs e)
        {
            if (prescriptioninternelDD.Text != "")
            {
                
                if(!MorningRB.Checked && !MorningEveningRB.Checked && !MorningAfternoonNightRB.Checked && !BeforeMeal.Checked && !AtNightBeforeSleepRB.Checked && !OnceADayRB.Checked && !OtherRB.Checked )
                {
                    MainClass.ShowMessage("Do select dosage before adding ", "error");
                }
                else
                {
                    if (!internalprescriptionLB.Items.Contains(prescriptioninternelDD.Text))
                    {
                        try
                        {
                            if (MorningRB.Checked)
                            {
                                htinternal.Add(prescriptioninternelDD.Text, 0);
                                internalprescriptionLB.Items.Add(prescriptioninternelDD.Text + "|" + MorningRB.Text);
                            }
                            else if (MorningEveningRB.Checked)
                            {
                                htinternal.Add(prescriptioninternelDD.Text, 1);
                                internalprescriptionLB.Items.Add(prescriptioninternelDD.Text + "|" + MorningEveningRB.Text);
                            }
                            else if (MorningAfternoonNightRB.Checked)
                            {
                                htinternal.Add(prescriptioninternelDD.Text, 2);
                                internalprescriptionLB.Items.Add(prescriptioninternelDD.Text + "|" + MorningAfternoonNightRB.Text);
                            }
                            else if (AtNightBeforeSleepRB.Checked)
                            {
                                htinternal.Add(prescriptioninternelDD.Text, 3);
                                internalprescriptionLB.Items.Add(prescriptioninternelDD.Text + "|" + AtNightBeforeSleepRB.Text);
                            }
                            else if (BeforeMeal.Checked)
                            {
                                htinternal.Add(prescriptioninternelDD.Text, 4);
                                internalprescriptionLB.Items.Add(prescriptioninternelDD.Text + "|" + BeforeMeal.Text);
                            }
                            else if (OnceADayRB.Checked)
                            {
                                htinternal.Add(prescriptioninternelDD.Text, 5);
                                internalprescriptionLB.Items.Add(prescriptioninternelDD.Text + "|" + OnceADayRB.Text);
                            }
                            else if (OtherRB.Checked)
                            {
                                htinternal.Add(prescriptioninternelDD.Text, 6);
                                internalprescriptionLB.Items.Add(prescriptioninternelDD.Text + "|" + othertext.Text);
                            }
                        }
                        catch(Exception)
                        {
                            MainClass.ShowMessage("you cant give same medicine ", "error");
                        }

                        

                        /////////////////!!!RESETING ALL RADIO BUTTONS!!!///////////// 
                        MorningRB.Checked = false;
                        MorningEveningRB.Checked = false; 
                        MorningAfternoonNightRB.Checked = false; 
                        BeforeMeal.Checked = false; 
                        AtNightBeforeSleepRB.Checked = false; 
                        OnceADayRB.Checked = false; 
                        OtherRB.Checked = false;

                    }
                }
                
            }
        }

        private void externalprescriptionaddbutton_Click(object sender, EventArgs e)
        {
            if (prescriptionexternalDD.Text != "")
            {
                if (!Morning2RB.Checked && !MorningEvening2RB.Checked && !MorningAfternoonNight2RB.Checked && !BeforeMeal2RB.Checked && !AtNightBeforeSleep2RB.Checked && !OnceADay2RB.Checked && !Other2RB.Checked)
                {
                    MainClass.ShowMessage("Do select dosage before adding ", "error");
                }
                else
                {
                    if (!externalprescriptionLB.Items.Contains(prescriptionexternalDD.Text))
                    {
                        try
                        {
                            if (Morning2RB.Checked)
                            {
                                htinternal.Add(prescriptionexternalDD.Text, 0);
                                externalprescriptionLB.Items.Add(prescriptionexternalDD.Text + "|" + Morning2RB.Text);
                            }
                            else if (MorningEvening2RB.Checked)
                            {
                                htinternal.Add(prescriptionexternalDD.Text, 1);
                                externalprescriptionLB.Items.Add(prescriptionexternalDD.Text + "|" + MorningEvening2RB.Text);
                            }
                            else if (MorningAfternoonNight2RB.Checked)
                            {
                                htinternal.Add(prescriptionexternalDD.Text, 2);
                                externalprescriptionLB.Items.Add(prescriptionexternalDD.Text + "|" + MorningAfternoonNight2RB.Text);
                            }
                            else if (AtNightBeforeSleep2RB.Checked)
                            {
                                htinternal.Add(prescriptionexternalDD.Text, 3);
                                externalprescriptionLB.Items.Add(prescriptionexternalDD.Text + "|" + AtNightBeforeSleep2RB.Text);
                            }
                            else if (BeforeMeal2RB.Checked)
                            {
                                htinternal.Add(prescriptionexternalDD.Text, 4);
                                externalprescriptionLB.Items.Add(prescriptionexternalDD.Text + "|" + BeforeMeal2RB.Text);
                            }
                            else if (OnceADay2RB.Checked)
                            {
                                htinternal.Add(prescriptionexternalDD.Text, 5);
                                externalprescriptionLB.Items.Add(prescriptionexternalDD.Text + "|" + OnceADay2RB.Text);
                            }
                            else if (Other2RB.Checked)
                            {
                                htinternal.Add(prescriptionexternalDD.Text, 6);
                                externalprescriptionLB.Items.Add(prescriptionexternalDD.Text + "|" + othertext2.Text);
                            }
                        }
                        catch (Exception)
                        {
                            MainClass.ShowMessage("you cant give same medicine ", "error");
                        }

                        

                        /////////////////!!!RESETING ALL RADIO BUTTONS!!!///////////// 
                        
                        Morning2RB.Checked = false;
                        MorningEvening2RB.Checked = false;
                        MorningAfternoonNight2RB.Checked = false;
                        BeforeMeal2RB.Checked = false;
                        AtNightBeforeSleep2RB.Checked = false;
                        OnceADay2RB.Checked = false;
                        Other2RB.Checked = false;

                    }
                }
            }
        }

        private void testsaddbutton_Click(object sender, EventArgs e)
        {
            if (testsDD.Text != "")
            {
                if (!testsLB.Items.Contains(testsDD.Text))
                {
                    testsLB.Items.Add(testsDD.Text);
                    //Hashtable ht = new Hashtable();
                    //ht.Add("@disease", diseaseDD.Text);
                    //crud.iud("st_insertDisease", ht);
                }
            }
        }

        private void symptomsaddbutton_Click(object sender, EventArgs e)
        {
            if (symptomsDD.Text != "")
            {
                if (!symptomsLB.Items.Contains(symptomsDD.Text))
                {
                    symptomsLB.Items.Add(symptomsDD.Text);
                    //Hashtable ht = new Hashtable();
                    //ht.Add("@disease", diseaseDD.Text);
                    //crud.iud("st_insertDisease", ht);
                }
            }
        }

        private void OtherRB_CheckedChanged(object sender, EventArgs e)
        {
            if(OtherRB.Checked)
            {
                othertext.Enabled = true;

            }
            else
            {
                othertext.Enabled = false;
            }
        }

        private void Other2RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Other2RB.Checked)
            {
                othertext2.Enabled = true;

            }
            else
            {
                othertext2.Enabled = false;
            }
        }

        /*/////////////////////!!!REMOVE!!!//////////////////////////////*/

        private void internalprescriptionRemovebutton_Click(object sender, EventArgs e)
        {
            if(internalprescriptionLB.SelectedItems.Count > 0)
            {
                char[] delim = { '|' };
                string[] arr = internalprescriptionLB.SelectedItem.ToString().Split(delim);
                htinternal.Remove(arr[0]);
                internalprescriptionLB.Items.Remove(internalprescriptionLB.SelectedItem);
            }
        }

        private void externalprescriptionRemovebutton_Click(object sender, EventArgs e)
        {
            if (externalprescriptionLB.SelectedItems.Count > 0)
            {
                char[] delim = { '|' };
                string[] arr = externalprescriptionLB.SelectedItem.ToString().Split(delim);
                htexternal.Remove(arr[0]);
                externalprescriptionLB.Items.Remove(externalprescriptionLB.SelectedItem);
            }
        }

        private void diseaseremovebutton_Click(object sender, EventArgs e)
        {
            if (diseaseLB.SelectedItems.Count > 0)
            {
                diseaseLB.Items.Remove(diseaseLB.SelectedItem);
            }
        }

        private void testremovebutton_Click(object sender, EventArgs e)
        {
            if (testsLB.SelectedItems.Count > 0)
            {
                testsLB.Items.Remove(testsLB.SelectedItem);
            }
        }

        private void symptomremovebutton_Click(object sender, EventArgs e)
        {
            if (symptomsLB.SelectedItems.Count > 0)
            {
                symptomsLB.Items.Remove(symptomsLB.SelectedItem);
            }
        }

        /*//////////////////!!!MAIN BUTTON!!!////////////////////////////*/

        protected override void viewbutton_Click(object sender, EventArgs e)
        {

        }

        protected override void savebutton_Click(object sender, EventArgs e)
        {
            using (TransactionScope sc = new TransactionScope())
            {
                 Int64 patientappointmentID = getpatientappintmentID();//15;

                /*////////// !!!DISEASE!!! ///////////////*/

                if (diseaseLB.Items.Count > 0)
                {
                    foreach (string item in diseaseLB.Items)
                    {
                        Hashtable h = new Hashtable();
                        h.Add("@disease", item);
                        int diseaseID;
                        if (!crud.checkExitance("st_checkDisease", h))
                        {
                            crud.iud("st_insertDisease", h);
                            diseaseID = Convert.ToInt32(crud.getlastID("st_getLastDiseaseID"));
                        }
                        else
                        {
                            diseaseID = getdiseaseID(item);
                        }
                        Hashtable patientDiseaseHT = new Hashtable();
                        patientDiseaseHT.Add("@appID", patientappointmentID);
                        patientDiseaseHT.Add("@diseaseID", diseaseID);
                        crud.iud("st_insertPatientDisease", patientDiseaseHT);
                    }
                }

                ////////////////////////////////////////////////////////////////////////////////////////

                ///*////////// !!!SYMPTOMS!!! ///////////////*/

                if (symptomsLB.Items.Count > 0)
                {
                    foreach (string item in symptomsLB.Items)
                    {
                        Hashtable h = new Hashtable();
                        h.Add("@symptom", item);
                        Int64 symptomID;
                        if (crud.checkExitance("st_checkSymptomExists2", h))
                        {
                            crud.iud("st_insertSymptoms", h);
                            symptomID = Convert.ToInt32(crud.getlastID("st_getLastSymptomID"));
                        }
                        else
                        {
                            symptomID = getsymptomID(item);
                        }
                        Hashtable patientSymptomHT = new Hashtable();
                        patientSymptomHT.Add("@appID", patientappointmentID);
                        patientSymptomHT.Add("@symID", symptomID);
                        crud.iud("st_insertPatientSymptoms", patientSymptomHT);
                    }
                }

                ////////////////////////////////////////////////////////////////////////////////////////

                ///*////////// !!!TESTS!!! ///////////////*/

                if (testsLB.Items.Count > 0)
                {
                    foreach (string item in testsLB.Items)
                    {
                        Hashtable h = new Hashtable();
                        h.Add("@name", item);
                        int TestID;
                        if (crud.checkExitance("st_checkTestsExists", h))
                        {
                            crud.iud("st_insertTests2", h);
                            TestID = Convert.ToInt32(crud.getlastID("st_getLastTestID"));
                        }
                        else
                        {
                            TestID = getTestID(item);
                        }
                        Hashtable TestHT = new Hashtable();
                        TestHT.Add("@appID", patientappointmentID);
                        TestHT.Add("@testID", TestID);
                        crud.iud("st_insertPatientTests", TestHT);
                    }
                }

                //////////////////////////////////////////////////////////////////////////////////////

                ///*////////// !!!INTERNAL MEDICINE!!! ///////////////*/

                if (internalprescriptionLB.Items.Count > 0)
                {
                    char[] delim = { '|' };
                    foreach (string item in internalprescriptionLB.Items)
                    {
                        string[] med = item.Split(delim);
                        Hashtable h = new Hashtable();
                        h.Add("@name", med[0]);
                        h.Add("@type", 0);
                        int medicineID;
                        if (!crud.checkExitance("st_checkMedicineExists", h))
                        {
                            crud.iud("st_insertMedicine2", h);
                            medicineID = Convert.ToInt32(crud.getlastID("st_getMedicineTestID"));
                        }
                        else
                        {
                            medicineID = getmedicineID(med[0]);
                        }
                        Hashtable internalmedicineHT = new Hashtable();
                        internalmedicineHT.Add("@appID", patientappointmentID);
                        internalmedicineHT.Add("@medicineID", medicineID);
                        Int16 dosageID = 0;
                        if (med[1] == "Morning")
                        {
                            dosageID = 0;
                        }
                        else if (med[1] == "Morning + Evening")
                        {
                            dosageID = 1;
                        }
                        else if (med[1] == "Morning + AfternoonNight")
                        {
                            dosageID = 2;
                        }
                        else if (med[1] == "At Night Before Sleep")
                        {
                            dosageID = 3;
                        }
                        else if (med[1] == "Before Meal")
                        {
                            dosageID = 4;
                        }
                        else if (med[1] == "Once A Day")
                        {
                            dosageID = 5;
                        }
                        else if (med[1] == "Other")
                        {
                            dosageID = 6;
                        }
                        internalmedicineHT.Add("@dosage", dosageID);
                        if (OtherRB.Checked)
                        {

                            internalmedicineHT.Add("@other", othertext.Text);
                            crud.iud("st_insertPatientMedicineALL", internalmedicineHT);

                        }
                        else
                        {
                            crud.iud("st_insertPatientMedicine", internalmedicineHT);
                        }

                    }
                }

                //////////////////////////////////////////////////////////////////////////////////////
                /////
                ///*////////// !!!EXTERNAL MEDICINE!!! ///////////////*/

                if (externalprescriptionLB.Items.Count > 0)
                {
                    char[] delim = { '|' };
                    foreach (string item in externalprescriptionLB.Items)
                    {
                        string[] med = item.Split(delim);

                        Hashtable h = new Hashtable();
                        h.Add("@name", med[0]);
                        h.Add("@type", 1);
                        int medicineID;
                        if (!crud.checkExitance("st_checkMedicineExists", h))
                        {
                            crud.iud("st_insertMedicine2", h);
                            medicineID = Convert.ToInt32(crud.getlastID("st_getMedicineTestID"));
                        }
                        else
                        {
                            medicineID = getmedicineID(med[0]);
                        }
                        Hashtable externalmedicineHT = new Hashtable();
                        externalmedicineHT.Add("@appID", patientappointmentID);
                        externalmedicineHT.Add("@medicineID", medicineID);
                        Int16 dosageID = 0;
                        if (med[1] == "Morning")
                        {
                            dosageID = 0;
                        }
                        else if (med[1] == "Morning + Evening")
                        {
                            dosageID = 1;
                        }
                        else if (med[1] == "Morning + AfternoonNight")
                        {
                            dosageID = 2;
                        }
                        else if (med[1] == "At Night Before Sleep")
                        {
                            dosageID = 3;
                        }
                        else if (med[1] == "Before Meal")
                        {
                            dosageID = 4;
                        }
                        else if (med[1] == "Once A Day")
                        {
                            dosageID = 5;
                        }
                        else if (med[1] == "Other")
                        {
                            dosageID = 6;
                        }
                        externalmedicineHT.Add("@dosage", dosageID);
                        if (Other2RB.Checked)
                        {

                            externalmedicineHT.Add("@other", othertext2.Text);
                            crud.iud("st_insertPatientMedicineALL", externalmedicineHT);

                        }
                        else
                        {
                            crud.iud("st_insertPatientMedicine", externalmedicineHT);
                        }
                    }
                }

                //////////////////////////////////////////////////////////////////////////////////////
                /////

                Hashtable htstatus = new Hashtable();
                htstatus.Add("@appID", patientappointmentID);
                htstatus.Add("@status", 1);
                crud.iud("st_updatePatientStatus", htstatus);

                /*////////// !!!PULSE TEMPERATURE AND BLOOD PRESSURE!!! ///////////////*/

                Hashtable htpbt = new Hashtable();
                htpbt.Add("@appID", patientappointmentID);
                htpbt.Add("@pulse", pulse1text.Text);
                htpbt.Add("@temp", temp1text.Text);
                htpbt.Add("@glucose", bloodgroup1text.Text);
                crud.iud("st_insertPulseGlucoseTemp", htpbt);

                ////////////////////////////////////////////////////////////////////////////////////

                /*////////// !!!REMARKS AND FEES!!! ///////////////*/

                Hashtable htrf = new Hashtable();
                htrf.Add("@appID", patientappointmentID);
                htrf.Add("@rem", remarktext.Text);
                htrf.Add("@fees", feestext.Text);
                crud.iud("st_insertpatientCheckUp", htrf);

                //////////////////////////////////////////////////////////////////////////////////
                MainClass.ShowMessage("Patient CheckedUP Successfully", "success");
                //////////////////////////////////////////////////////////////////////////////////
                //MainClass.resetEnable(tableLayoutPanel2);
                //MainClass.resetEnable(leftpanel);
                sc.Complete();
            }
        }

        protected override void deletebutton_Click(object sender, EventArgs e)
        {

        }

        /*//////////////////////////////////////////////!!!DIFFERENT ENTRY!!!/////////////////////////////////////////////*/

        private void pulse1text_Enter(object sender, EventArgs e)
        {
            pulse1text.SelectAll();
        }

        private void pulse1text_Leave(object sender, EventArgs e)
        {
            if(pulse1text.Text == "")
            {
                pulse1text.Text = "-";
            }
        }

        private void temp1text_Enter(object sender, EventArgs e)
        {
            temp1text.SelectAll();
        }

        private void temp1text_Leave(object sender, EventArgs e)
        {
            if (temp1text.Text == "")
            {
                temp1text.Text = "-";
            }
        }

        private void bloodgroup1text_Enter(object sender, EventArgs e)
        {
            bloodgroup1text.SelectAll();
        }

        private void bloodgroup1text_Leave(object sender, EventArgs e)
        {
            if (bloodgroup1text.Text == "")
            {
                bloodgroup1text.Text = "-";
            }
        }
    }
}