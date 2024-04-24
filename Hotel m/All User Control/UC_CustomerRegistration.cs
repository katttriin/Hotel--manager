using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel_m.All_User_Control
{
    public partial class UC_CustomerRegistration : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        public void SetComboBox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.GetForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType= '" + txtRoom.Text + "' and booked= 'NO' ";
            SetComboBox(query, txtRoomNo);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }

        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from rooms where roomNo = '" + txtRoomNo.Text + "' ";
            DataSet ds = fn.GetData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());

        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDob.Text != "" && txtIdProof.Text != "" && txtAddress.Text != "" && txtChecIn.Text != "" && txtPrice.Text != "")
            {
                string name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                string national = txtNationality.Text;
                string gender = txtGender.Text;
                string dob = txtDob.Text;
                string id = txtIdProof.Text;
                string address = txtAddress.Text;
                string checin = txtChecIn.Text;

                // Corrected the column name and added checkout column
                query = "INSERT INTO customer (cname, mobile, nationality, gender, dob, idproof, address, checkin, checkout, chekout, roomid) VALUES ('" + name + "', " + mobile + ", '" + national + "', '" + gender + "', '" + dob + "', '" + id + "', '" + address + "', '" + checin + "', NULL, 'NO', " + rid + ")";

                // Added SQL query to update room status to 'YES' after allocation
                string updateRoomQuery = "UPDATE rooms SET booked ='YES' WHERE roomNo ='" + txtRoomNo.Text + "'";

                // Execute both queries in a transaction to ensure atomicity
                using (SqlConnection connection = fn.GetConnection())
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, connection, transaction);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand(updateRoomQuery, connection, transaction);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("Room No " + txtRoomNo.Text + " Allocation Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearAll();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIdProof.Clear();
            txtAddress.Clear();
            txtChecIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            txtRoomNo.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}

