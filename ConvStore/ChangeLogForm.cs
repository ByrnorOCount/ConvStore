﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class ChangeLogForm : MyForm
    {
        private readonly DBHelper db = new DBHelper();

        public ChangeLogForm()
        {
            InitializeComponent();
            this.Load += ChangeLogForm_Load;
            btnRefreshChangeLog.Click += (s, e) => LoadChangelogs();
        }

        private void ChangeLogForm_Load(object sender, EventArgs e)
        {
            LoadChangelogs();
            FormHelper.FormatDataGridView(dgvChangeLog);
            picIcon.Image = Image.FromFile(Const.IMAGE_DIRECTORY + "warehouse.jpg");
            lblTitle.Text = $"Changelog";
        }

        private void LoadChangelogs()
        {
            string query = @"
                SELECT 
                    c.LogID,
                    u.Username AS UserName,
                    p.Name AS ProductName,
                    c.ChangedData,
                    c.Timestamp,
                    c.PaymentAmount,
                    c.Invoice
                FROM Changelog c
                LEFT JOIN [User] u ON c.UserID = u.UserID
                LEFT JOIN Product p ON c.ProductID = p.ProductID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    db.OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    db.CloseConnection();
                    dgvChangeLog.DataSource = dt;
                    FormHelper.AdjustColumnWidths(dgvChangeLog);
                    dgvChangeLog.Columns["LogID"].HeaderText = "Log ID";
                    dgvChangeLog.Columns["UserName"].HeaderText = "User Name";
                    dgvChangeLog.Columns["ProductName"].HeaderText = "Product Name";
                    dgvChangeLog.Columns["ChangedData"].HeaderText = "Changed Data";
                    dgvChangeLog.Columns["Timestamp"].HeaderText = "Timestamp";
                    dgvChangeLog.Columns["PaymentAmount"].HeaderText = "Payment Amount";
                    dgvChangeLog.Columns["Invoice"].HeaderText = "Invoice";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading changelog: " + ex.Message);
            }
        }
    }
}
