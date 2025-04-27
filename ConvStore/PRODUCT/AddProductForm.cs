
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class AddProductForm : Form
    {
        private DBHelper db = new DBHelper();

        public AddProductForm()
        {
            InitializeComponent();
            LoadStatusComboBox();
        }

        private void LoadStatusComboBox()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Available", "Out of Stock", "Discontinued" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();

                // Kiểm tra Duplicate Code
                string checkCodeQuery = "SELECT COUNT(*) FROM Product WHERE Code = @Code";
                using (SqlCommand checkCmd = new SqlCommand(checkCodeQuery, db.Connection))
                {
                    checkCmd.Parameters.AddWithValue("@Code", txtCode.Text.Trim());
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("The Code already exists. Please enter a different Code.", "Duplicate Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        db.CloseConnection();
                        return;
                    }
                }

                // Thêm Product và Inventory
                using (SqlCommand cmd = new SqlCommand("usp_AddProductAndInventory", db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Origin", txtOrigin.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text.Trim()));
                    cmd.Parameters.AddWithValue("@ImportLocation", txtImportLocation.Text.Trim());
                    cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
                    cmd.Parameters.AddWithValue("@Code", txtCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@ProductionDate", dtpProductionDate.Value);
                    cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value);
                    cmd.Parameters.AddWithValue("@ImportTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Preservation", txtPreservation.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                db.CloseConnection();
                MessageBox.Show("Product added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                db.CloseConnection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
