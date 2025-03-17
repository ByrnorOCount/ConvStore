using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class ProductManagementApp: Form
    {
        private DBHelper db;

        public ProductManagementApp()
        {
            InitializeComponent();
            db = new DBHelper();
        }

        private void ProductManagementApp_Load(object sender, EventArgs e)
        {
            LoadData("[User]", dataGridViewUsers);
            LoadData("Supplier", dataGridViewSuppliers);
            LoadData("[Order]", dataGridViewOrders);
            LoadData("Product", dataGridViewProducts);
        }

        private void LoadData(string tableName, DataGridView gridView)
        {
            try
            {
                db.OpenConnection();
                string query = $"SELECT * FROM {tableName}";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.Connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    gridView.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
