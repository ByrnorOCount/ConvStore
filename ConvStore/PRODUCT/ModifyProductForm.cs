
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class ModifyProductForm : Form
    {
        private int productId;
        private DBHelper db = new DBHelper();

        public ModifyProductForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            LoadProductInfo();
        }

        private void LoadProductInfo()
        {
            try
            {
                string query = "SELECT * FROM Product WHERE ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductID", productId);

                db.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtProductID.Text = reader["ProductID"].ToString();
                    txtName.Text = reader["Name"].ToString();
                    txtOrigin.Text = reader["Origin"].ToString();
                    dtpProductionDate.Value = Convert.ToDateTime(reader["ProductionDate"]);
                    dtpExpiryDate.Value = reader["ExpiryDate"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(reader["ExpiryDate"]);
                    cmbStatus.Text = reader["Status"].ToString();
                    txtPrice.Text = reader["Price"].ToString();
                    txtImportLocation.Text = reader["ImportLocation"].ToString();
                    txtCertification.Text = reader["Certification"].ToString();
                    txtPreservation.Text = reader["Preservation"].ToString();
                    txtIngredients.Text = reader["Ingredients"].ToString();
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product info: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"UPDATE Product SET 
                                    Name = @Name, 
                                    Origin = @Origin, 
                                    ProductionDate = @ProductionDate, 
                                    ExpiryDate = @ExpiryDate, 
                                    Status = @Status, 
                                    Price = @Price, 
                                    ImportLocation = @ImportLocation, 
                                    Certification = @Certification, 
                                    Preservation = @Preservation, 
                                    Ingredients = @Ingredients 
                                WHERE ProductID = @ProductID";

                SqlCommand cmd = new SqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Origin", txtOrigin.Text.Trim());
                cmd.Parameters.AddWithValue("@ProductionDate", dtpProductionDate.Value);
                cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value);
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text.Trim()));
                cmd.Parameters.AddWithValue("@ImportLocation", txtImportLocation.Text.Trim());
                cmd.Parameters.AddWithValue("@Certification", txtCertification.Text.Trim());
                cmd.Parameters.AddWithValue("@Preservation", txtPreservation.Text.Trim());
                cmd.Parameters.AddWithValue("@Ingredients", txtIngredients.Text.Trim());

                db.OpenConnection();
                cmd.ExecuteNonQuery();
                db.CloseConnection();

                MessageBox.Show("Product updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
