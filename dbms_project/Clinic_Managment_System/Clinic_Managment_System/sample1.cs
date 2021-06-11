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
    public partial class sample1 : sample
    {
        public sample1()
        {
            InitializeComponent();
        }

        protected void sample1_Load(object sender, EventArgs e)
        {
            
        }

        protected void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        protected virtual void systemtext_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void clinicmanegment_Click(object sender, EventArgs e)
        {

        }

        protected virtual void searchtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// ALL KINDS OF BUTTONS ARE HERE FOR EDIT 
        /// </summary>
        protected int edit = 0;
        protected virtual void addbutton_Click(object sender, EventArgs e)
        {

            edit = 0;
            MainClass.resetEnable(leftpanel);
            
        }

        protected virtual void editbutton_Click(object sender, EventArgs e)
        {
            if(edit == 1)
            {
                MainClass.EnableControl(leftpanel);
            }
        }
        protected virtual void viewbutton_Click(object sender, EventArgs e)
        {

        }
        
        protected virtual void savebutton_Click(object sender, EventArgs e)
        {

        }

        protected virtual void deletebutton_Click(object sender, EventArgs e)
        {

        }

        protected virtual void backbutton_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            MainClass.showWindow(hs, MDI.ActiveForm);
        }

    }
}
