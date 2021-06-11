using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Managment_System
{
    public partial class printout : sample
    {
        public printout()
        {
            InitializeComponent();
        }
        ReportDocument rd = null;
        private void printout_Load(object sender, EventArgs e)
        {
            rd = new ReportDocument();
            Hashtable ht = new Hashtable();
            ht.Add("@patientID", PAYMENTS.pid);
            crud.showreport("st_getappid",rd, "prescription",ht,crystalReportViewer1);
        }
        private void printout_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
