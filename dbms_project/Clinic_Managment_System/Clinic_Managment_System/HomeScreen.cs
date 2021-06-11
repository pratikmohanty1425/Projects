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
    public partial class HomeScreen : sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void rolesbutton_Click(object sender, EventArgs e)
        {
            rolewindow rw = new rolewindow();
            MainClass.showWindow(rw, MDI.ActiveForm);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void staffbutton_Click(object sender, EventArgs e)
        {
            staffwindow st = new staffwindow();
            MainClass.showWindow(st, MDI.ActiveForm);
        }

        private void medicinebutton_Click(object sender, EventArgs e)
        {
            Medicine_Window mw = new Medicine_Window();
            MainClass.showWindow(mw, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatientRegistrationWindow prw = new PatientRegistrationWindow();
            MainClass.showWindow(prw, MDI.ActiveForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DiseaseWindow dw = new DiseaseWindow();
            MainClass.showWindow(dw, MDI.ActiveForm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SymptomsWindow dw = new SymptomsWindow();
            MainClass.showWindow(dw, MDI.ActiveForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Check_up dw = new Check_up();
            MainClass.showWindow(dw, MDI.ActiveForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            turn_no_window dw = new turn_no_window();
            MainClass.showWindow(dw, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test dw = new Test();
            MainClass.showWindow(dw, MDI.ActiveForm);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PAYMENTS dw = new PAYMENTS();
            MainClass.showWindow(dw, MDI.ActiveForm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Test dw = new Test();
            MainClass.showWindow(dw, MDI.ActiveForm);
        }
    }
}
