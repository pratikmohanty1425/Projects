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
    public partial class turn_no_window : sample
    {
        public turn_no_window()
        {
            InitializeComponent();
        }

        int tick = 0;
        private void turn_no_window_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            if(tick == 5)
            {
                tick = 0;
                tokenlabel.Text = Check_up.turnno.ToString() + "";

            }
        }

        private void turn_no_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            HomeScreen hs = new HomeScreen();
            MainClass.showWindow(hs, MDI.ActiveForm);
        }
    }
}
