namespace Hotel_m
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_CustomerCheckOut1 = new Hotel_m.All_User_Control.UC_CustomerCheckOut();
            this.uC_CustomerRegistration1 = new Hotel_m.All_User_Control.UC_CustomerRegistration();
            this.uC_AddRoom1 = new Hotel_m.All_User_Control.UC_AddRoom();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomerDetails);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCustomerRegistration);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(53, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 85);
            this.panel1.TabIndex = 0;
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.MediumOrchid;
            this.MovingPanel.Location = new System.Drawing.Point(64, 64);
            this.MovingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(128, 5);
            this.MovingPanel.TabIndex = 1;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderColor = System.Drawing.Color.White;
            this.btnEmployee.BorderRadius = 20;
            this.btnEmployee.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.Plum;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmployee.Location = new System.Drawing.Point(934, 14);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.PressedColor = System.Drawing.Color.White;
            this.btnEmployee.Size = new System.Drawing.Size(200, 60);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BorderColor = System.Drawing.Color.White;
            this.btnCustomerDetails.BorderRadius = 20;
            this.btnCustomerDetails.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnCustomerDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerDetails.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCustomerDetails.CustomBorderColor = System.Drawing.Color.White;
            this.btnCustomerDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetails.FillColor = System.Drawing.Color.Plum;
            this.btnCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetails.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCustomerDetails.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCustomerDetails.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.btnCustomerDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDetails.Image")));
            this.btnCustomerDetails.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomerDetails.Location = new System.Drawing.Point(702, 14);
            this.btnCustomerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.PressedColor = System.Drawing.Color.White;
            this.btnCustomerDetails.Size = new System.Drawing.Size(200, 60);
            this.btnCustomerDetails.TabIndex = 0;
            this.btnCustomerDetails.Text = "Customer Details";
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderColor = System.Drawing.Color.White;
            this.btnCheckOut.BorderRadius = 20;
            this.btnCheckOut.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.Plum;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCheckOut.Location = new System.Drawing.Point(471, 14);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.PressedColor = System.Drawing.Color.White;
            this.btnCheckOut.Size = new System.Drawing.Size(200, 60);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.BorderColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.BorderRadius = 20;
            this.btnCustomerRegistration.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnCustomerRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRegistration.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCustomerRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRegistration.FillColor = System.Drawing.Color.Plum;
            this.btnCustomerRegistration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCustomerRegistration.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.btnCustomerRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRegistration.Image")));
            this.btnCustomerRegistration.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomerRegistration.Location = new System.Drawing.Point(250, 14);
            this.btnCustomerRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.PressedColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.Size = new System.Drawing.Size(200, 60);
            this.btnCustomerRegistration.TabIndex = 0;
            this.btnCustomerRegistration.Text = "Customer Registration";
            this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderColor = System.Drawing.Color.White;
            this.btnAddRoom.BorderRadius = 20;
            this.btnAddRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.Plum;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddRoom.Location = new System.Drawing.Point(23, 14);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.PressedColor = System.Drawing.Color.White;
            this.btnAddRoom.Size = new System.Drawing.Size(200, 60);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Plum;
            this.panel2.Controls.Add(this.uC_CustomerCheckOut1);
            this.panel2.Controls.Add(this.uC_CustomerRegistration1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.ForeColor = System.Drawing.Color.DarkBlue;
            this.panel2.Location = new System.Drawing.Point(8, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 593);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uC_CustomerCheckOut1
            // 
            this.uC_CustomerCheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerCheckOut1.Location = new System.Drawing.Point(45, 8);
            this.uC_CustomerCheckOut1.Margin = new System.Windows.Forms.Padding(1);
            this.uC_CustomerCheckOut1.Name = "uC_CustomerCheckOut1";
            this.uC_CustomerCheckOut1.Size = new System.Drawing.Size(1195, 573);
            this.uC_CustomerCheckOut1.TabIndex = 2;
            this.uC_CustomerCheckOut1.Load += new System.EventHandler(this.uC_CustomerCheckOut1_Load);
            // 
            // uC_CustomerRegistration1
            // 
            this.uC_CustomerRegistration1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegistration1.Location = new System.Drawing.Point(45, 8);
            this.uC_CustomerRegistration1.Margin = new System.Windows.Forms.Padding(1);
            this.uC_CustomerRegistration1.Name = "uC_CustomerRegistration1";
            this.uC_CustomerRegistration1.Size = new System.Drawing.Size(1195, 573);
            this.uC_CustomerRegistration1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(45, 8);
            this.uC_AddRoom1.Margin = new System.Windows.Forms.Padding(1);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1195, 573);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(16, 8);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(33, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinimize.Location = new System.Drawing.Point(16, 48);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.Size = new System.Drawing.Size(33, 29);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1297, 719);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetails;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegistration;
        private System.Windows.Forms.Panel MovingPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UC_CustomerCheckOut uC_CustomerCheckOut1;
        private All_User_Control.UC_CustomerRegistration uC_CustomerRegistration1;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
    }
}