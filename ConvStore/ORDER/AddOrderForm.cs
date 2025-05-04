using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class AddOrderForm : Form
    {
        private DBHelper db = new DBHelper();

        public AddOrderForm()
        {
            InitializeComponent();
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Pending", "Shipped", "Delivered", "Cancelled" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = @"usp_AddOrder";
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", txtOrderer.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierID", txtSupplier.Text.Trim());
                    cmd.Parameters.AddWithValue("@DeliveryTime", dtpDeliveryTime.Value);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
                    cmd.Parameters.AddWithValue("@TypeOfGoods", txtTypeOfGoods.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                db.CloseConnection();
                MessageBox.Show("Order added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                db.CloseConnection();
            }
        }
    }
}
