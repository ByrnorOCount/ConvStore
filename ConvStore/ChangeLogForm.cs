using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class ChangeLogForm : Form
    {
        private readonly DBHelper db = new DBHelper();

        public ChangeLogForm()
        {
            InitializeComponent();
            this.Load += ChangeLogForm_Load;

            FormHelper.AssignNavigationHandler(btnUser, FormHelper.OpenUserForm, this);
            FormHelper.AssignNavigationHandler(btnSupplier, FormHelper.OpenSupplierForm, this);
            FormHelper.AssignNavigationHandler(btnOrder, FormHelper.OpenOrderForm, this);
            FormHelper.AssignNavigationHandler(btnInventory, FormHelper.OpenInventoryForm, this);
            FormHelper.AssignNavigationHandler(btnChangelog, FormHelper.OpenChangeLogForm, this);
            FormHelper.AssignLogoutHandler(btnLogout, this);
            btnRefreshChangeLog.Click += (s, e) => LoadChangelogs();
        }

        private void ChangeLogForm_Load(object sender, EventArgs e)
        {
            LoadChangelogs();
            FormHelper.FormatDataGridView(dgvChangeLog);
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

        private void btnUser_Click(object sender, EventArgs e) => FormHelper.OpenUserForm(this);
        private void btnSupplier_Click(object sender, EventArgs e) => FormHelper.OpenSupplierForm(this);
        private void btnOrder_Click(object sender, EventArgs e) => FormHelper.OpenOrderForm(this);
        private void btnInventory_Click(object sender, EventArgs e) => FormHelper.OpenInventoryForm(this);
        private void btnChangelog_Click(object sender, EventArgs e) => FormHelper.OpenChangeLogForm(this);
        private void btnLogout_Click(object sender, EventArgs e) => FormHelper.Logout(this);
    }
}
