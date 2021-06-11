using System;
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
    public partial class TokenReport : sample
    {
        public TokenReport()
        {
            InitializeComponent();
        }

        private void TokenReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void welcomelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
