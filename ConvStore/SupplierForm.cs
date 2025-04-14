using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class SupplierForm : Form
    {
        private readonly DBHelper db = new DBHelper();

        public SupplierForm()
        {
            InitializeComponent();
            this.Load += SupplierForm_Load;

            FormHelper.AssignNavigationHandler(btnUser, FormHelper.OpenUserForm, this);
            FormHelper.AssignNavigationHandler(btnSupplier, FormHelper.OpenSupplierForm, this);
            FormHelper.AssignNavigationHandler(btnOrder, FormHelper.OpenOrderForm, this);
            FormHelper.AssignNavigationHandler(btnInventory, FormHelper.OpenInventoryForm, this);
            FormHelper.AssignNavigationHandler(btnChangelog, FormHelper.OpenChangeLogForm, this);
            FormHelper.AssignLogoutHandler(btnLogout, this);
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            FormHelper.FormatDataGridView(dgvSupplier);
            picIcon.Image = Image.FromFile("../../images/warehouse.jpg");
        }

        private void LoadSuppliers()
        {
            string query = "SELECT SupplierID, Name, Email, Code, PhoneNumber FROM Supplier";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    db.OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    db.CloseConnection();
                    dgvSupplier.DataSource = dt;
                    FormHelper.AdjustColumnWidths(dgvSupplier);
                    dgvSupplier.Columns["SupplierID"].HeaderText = "Supplier ID";
                    dgvSupplier.Columns["Name"].HeaderText = "Supplier Name";
                    dgvSupplier.Columns["Email"].HeaderText = "Email";
                    dgvSupplier.Columns["Code"].HeaderText = "Supplier Code";
                    dgvSupplier.Columns["PhoneNumber"].HeaderText = "Phone Number";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
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
