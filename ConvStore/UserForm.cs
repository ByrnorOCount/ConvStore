﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class UserForm : MyForm
    {
        private readonly DBHelper db = new DBHelper();

        public UserForm()
        {
            InitializeComponent();
            this.Load += UserForm_Load;
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadNotifications();
            FormHelper.FormatDataGridView(dgvNotification);
            picIcon.Image = Image.FromFile(Const.IMAGE_DIRECTORY + "warehouse.jpg");
            lblUserID.Text = UserSession.UserID.ToString();
            lblUsername.Text = UserSession.Username;
            lblRole.Text = UserSession.Role;
            lblStoreBranch.Text = UserSession.StoreBranch;
            lblTitle.Text = $"User Page";
        }

        private void LoadNotifications()
        {
            string query = @"
                SELECT 
                    n.NotificationID,
                    o.OrderID,
                    s.Name AS SupplierName,
                    n.Time AS NotificationTime,
                    n.Message
                FROM Notification n
                LEFT JOIN [Order] o ON n.OrderID = o.OrderID
                LEFT JOIN Supplier s ON n.SupplierID = s.SupplierID
                WHERE n.UserID = @UserID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);

                    db.OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    db.CloseConnection();
                    dgvNotification.DataSource = dt;
                    FormHelper.AdjustColumnWidths(dgvNotification);
                    dgvNotification.Columns["NotificationID"].HeaderText = "Notification ID";
                    dgvNotification.Columns["OrderID"].HeaderText = "Order ID";
                    dgvNotification.Columns["SupplierName"].HeaderText = "Supplier Name";
                    dgvNotification.Columns["NotificationTime"].HeaderText = "Time";
                    dgvNotification.Columns["Message"].HeaderText = "Message";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notifications: " + ex.Message);
            }
        }
    }
}
