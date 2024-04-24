using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_m.All_User_Control
{
    public partial class UC_CustomerCheckOut : UserControl
    {
        function fn = new function(); // Create an instance of the Function class
        String query;
       

        public UC_CustomerCheckOut()
        {
            InitializeComponent();
        }

        // Load data into the DataGridView when the UserControl loads
        private void UC_CustomerCheckOut_Load(object sender, EventArgs e)
        {
            // Query to select customer and room information for customers who have not checked out
            query = "SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid WHERE chekout = 'NO'";
            DataSet ds = fn.GetData(query);
            DataTable dataTable = ds.Tables[0];
            guna2DataGridView1.DataSource = dataTable;
        }

        // Search for customers by name as the user types in the text box
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Query to search for customers by name and who have not checked out
            query = "SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid WHERE cname LIKE '" + txtName.Text + "%' AND chekout ='NO'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;

        // Capture the selected customer's information when a cell is clicked in the DataGridView
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Capture the customer ID and related room information
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        // Process the check-out button click event
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                // Confirm check-out with a dialog box
                if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;
                    // Query to update customer check-out status and date
                    query = "UPDATE customer SET chekout = 'YES', checkout = '" + cdate + "' WHERE cid =" + id;
                    fn.SetData(query, "Check Out Successfully.");

                    // Update room status to 'NO' for the checked-out room
                    query = "UPDATE rooms SET booked = 'NO' WHERE roomNo = '" + txtRoom.Text + "'";
                    fn.SetData(query, "Room status updated.");

                    // Reload data into the DataGridView and clear input fields
                    UC_CustomerCheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Clear all input fields
        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();
        }

        // Clear all input fields when leaving the UserControl
        private void UC_CustomerCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
