using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class UpdateUserForm : Form
    {
        private int orderId;
        private DBHelper db = new DBHelper();

        public UpdateUserForm(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            LoadInfo();
        }

        private void LoadInfo()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Pending", "Shipped", "Delivered", "Cancelled" });
            try
            {
                string query = "usp_SelectOrder";
                SqlCommand cmd = new SqlCommand(query, db.Connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                db.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtOrderID.Text = reader["OrderID"].ToString();
                    txtOrderer.Text = reader["UserID"].ToString();
                    txtSupplier.Text = reader["SupplierID"].ToString();
                    dtpDeliveryTime.Value = reader["DeliveryTime"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(reader["DeliveryTime"]);
                    cmbStatus.Text = reader["Status"].ToString();
                    txtQuantity.Text = reader["Quantity"].ToString();
                    txtPrice.Text = reader["Price"].ToString();
                    txtTypeOfGoods.Text = reader["TypeOfGoods"].ToString();
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading info: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = @"usp_UpdateOrder";
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderID", txtOrderID.Text.Trim());
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
                MessageBox.Show("Order updated successfully!");
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
