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
    public partial class PAYMENTS : sample1
    {
        public PAYMENTS()
        {
            InitializeComponent();
        }

        private void PAYMENTS_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        public void loadcheckpatient()
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
            Hashtable ht = new Hashtable();
            ht.Add("@day", dateTimePicker1.Value.Day);
            ht.Add("@month", dateTimePicker1.Value.Month);
            ht.Add("@year", dateTimePicker1.Value.Year);
            ht.Add("@status", 1);
            crud.loadData("st_getpatientappointmentreg2", dataGridView1, loadDa,ht);
        }

        
        private void loadbutton_Click(object sender, EventArgs e)
        {
            loadcheckpatient();
        }
        public static Int64 pid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            pid = Convert.ToInt64(row.Cells["patientIDgv"].Value.ToString());
            MessageBox.Show("Your app id is -" + row.Cells["appIDGV"].Value.ToString());

            printout o = new printout();
            o.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
