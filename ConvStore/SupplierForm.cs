using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class SupplierForm : BaseForm
    {
        private readonly DBHelper db = new DBHelper();

        public SupplierForm()
        {
            InitializeComponent();
            this.Load += SupplierForm_Load;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
            btnAddSupplier.Click += btnAddSupplier_Click;
            btnUpdateSupplier.Click += btnUpdateSupplier_Click;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;
            btnResetFields.Click += btnResetFields_Click;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            FormatDataGridView(dgvSupplier);
            picIcon.Image = Image.FromFile(Util.imgDir + "warehouse.jpg");
            lblTitle.Text = $"Supplier Management";
        }

        private void LoadSuppliers()
        {
            string query = "usp_LoadSupplier";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    db.CloseConnection();
                    dgvSupplier.DataSource = dt;
                    AdjustColumnWidths(dgvSupplier);
                    dgvSupplier.Columns["SupplierID"].HeaderText = "Supplier ID";
                    dgvSupplier.Columns["Name"].HeaderText = "Supplier Name";
                    dgvSupplier.Columns["Email"].HeaderText = "Email";
                    dgvSupplier.Columns["Code"].HeaderText = "Supplier Code";
                    dgvSupplier.Columns["PhoneNumber"].HeaderText = "Phone Number";
                    dgvSupplier.Columns["IsActive"].HeaderText = "Is Active";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];
                txtSupplierName.Text = row.Cells["Name"].Value.ToString();
                txtSupplierEmail.Text = row.Cells["Email"].Value.ToString();
                txtSupplierCode.Text = row.Cells["Code"].Value.ToString();
                txtSupplierPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                chkSupplierIsActive.Checked = (bool)row.Cells["IsActive"].Value;
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string query = "usp_AddSupplier";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtSupplierEmail.Text);
                    cmd.Parameters.AddWithValue("@Code", txtSupplierCode.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtSupplierPhone.Text);
                    cmd.Parameters.AddWithValue("@IsActive", chkSupplierIsActive.Checked);

                    // Add output parameter for errorMessage
                    SqlParameter errorMessageParam = new SqlParameter("@errorMessage", SqlDbType.NVarChar, -1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(errorMessageParam);

                    db.OpenConnection();
                    cmd.ExecuteNonQuery();
                    string errorMessage = errorMessageParam.Value?.ToString();
                    db.CloseConnection();

                    MessageBox.Show(errorMessage ?? "Supplier added successfully.");
                    LoadSuppliers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error adding supplier: " + ex.Message);
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            string query = "usp_UpdateSupplier";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtSupplierEmail.Text);
                    cmd.Parameters.AddWithValue("@Code", txtSupplierCode.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtSupplierPhone.Text);
                    cmd.Parameters.AddWithValue("@IsActive", chkSupplierIsActive.Checked);
                    cmd.Parameters.AddWithValue("@SupplierID", dgvSupplier.SelectedRows[0].Cells["SupplierID"].Value);

                    // Add output parameter for errorMessage
                    SqlParameter errorMessageParam = new SqlParameter("@errorMessage", SqlDbType.NVarChar, -1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(errorMessageParam);

                    db.OpenConnection();
                    cmd.ExecuteNonQuery();
                    string errorMessage = errorMessageParam.Value?.ToString();
                    db.CloseConnection();

                    MessageBox.Show(errorMessage ?? "Supplier updated successfully.");
                    LoadSuppliers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error updating supplier: " + ex.Message);
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            string query = "usp_DeleteSupplier";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierID", dgvSupplier.SelectedRows[0].Cells["SupplierID"].Value);

                    // Add output parameter for errorMessage
                    SqlParameter errorMessageParam = new SqlParameter("@errorMessage", SqlDbType.NVarChar, -1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(errorMessageParam);

                    db.OpenConnection();
                    cmd.ExecuteNonQuery();
                    string errorMessage = errorMessageParam.Value?.ToString();
                    db.CloseConnection();

                    MessageBox.Show(errorMessage ?? "Supplier deleted successfully.");
                    LoadSuppliers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error deleting supplier: " + ex.Message);
            }
        }

        private void btnResetFields_Click(object sender, EventArgs e)
        {
            txtSupplierName.Clear();
            txtSupplierEmail.Clear();
            txtSupplierCode.Clear();
            txtSupplierPhone.Clear();
            chkSupplierIsActive.Checked = false;
        }
    }
}
