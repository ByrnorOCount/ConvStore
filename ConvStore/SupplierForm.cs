using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class SupplierForm : MyForm
    {
        private readonly DBHelper db = new DBHelper();

        public SupplierForm()
        {
            InitializeComponent();
            this.Load += SupplierForm_Load;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            FormatDataGridView(dgvSupplier);
            picIcon.Image = Image.FromFile(Const.IMAGE_DIRECTORY + "warehouse.jpg");
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }
    }
}
