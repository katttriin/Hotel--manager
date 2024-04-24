using Hotel_m.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_m
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerRegistration.Left+18;
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left=btnAddRoom.Left+18;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();

            MovingPanel.Left=btnCheckOut.Left+18;
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            

            MovingPanel.Left=btnCustomerDetails.Left+18;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
                        
            MovingPanel.Left=btnEmployee.Left+18;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void uC_CustomerCheckOut1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Employee1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
