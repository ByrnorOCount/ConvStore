using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ConvStore;

namespace ConvStore
{
    public partial class InventoryForm : BaseForm
    {
        private readonly DBHelper db = new DBHelper();

        public InventoryForm()
        {
            InitializeComponent();
            this.Load += InventoryForm_Load;
            dgvInventory.SelectionChanged += dgvInventory_SelectionChanged;
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadInventory();
            LoadComboBoxData();
            LoadStatusComboBox();
            FormatDataGridView(dgvInventory);
            FormatDataGridView(dgvProduct);
            picIcon.Image = Image.FromFile(Util.imgDir + "warehouse.jpg");
            lblTitle.Text = $"Inventory";
            txtInventoryID.TextChanged += (s, ev) => FilterInventory();
            
            txtProductName.TextChanged += (s, ev) => FilterInventory();
            
            cmbStatus.SelectedIndexChanged += (s, ev) => FilterInventory();

        }
        private void LoadStatusComboBox()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("In Stock");
            cmbStatus.Items.Add("Low Stock");
            cmbStatus.Items.Add("Out of Stock");
            cmbStatus.SelectedIndex = 0; // Mặc định là All
        }
        private void FilterInventory()
        {
            if (dgvInventory.DataSource == null) return;

            dgvInventory.SelectionChanged -= dgvInventory_SelectionChanged; // Tạm ngắt

            string filter = "";

            if (!string.IsNullOrEmpty(txtInventoryID.Text.Trim()))
                filter += $"Convert(InventoryID, 'System.String') LIKE '%{txtInventoryID.Text.Trim()}%' AND ";

            if (!string.IsNullOrEmpty(txtProductName.Text.Trim()))
                filter += $"ProductName LIKE '%{txtProductName.Text.Trim()}%' AND ";

            if (cmbStatus.SelectedIndex > 0)
                filter += $"Status = '{cmbStatus.Text}' AND ";

            if (filter.EndsWith(" AND "))
                filter = filter.Substring(0, filter.Length - 5);

            (dgvInventory.DataSource as DataTable).DefaultView.RowFilter = filter;

            dgvInventory.ClearSelection();
            dgvInventory.SelectionChanged += dgvInventory_SelectionChanged; // Gắn lại
        }

        private void LoadComboBoxData()
        {
            try
            {
                string query = "SELECT DISTINCT Origin, FORMAT(ImportTime, 'yyyy-MM-dd') AS ImportDay, FORMAT(ExpiryDate, 'yyyy-MM-dd') AS ExportDay FROM Product";
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    db.OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    db.CloseConnection();

                    cmbSupplier.Items.Clear();
                    cmbImportDay.Items.Clear();

                    foreach (DataRow row in table.Rows)
                    {
                        string supplier = row["Origin"].ToString();
                        string importDay = row["ImportDay"].ToString();

                        if (!cmbSupplier.Items.Contains(supplier))
                            cmbSupplier.Items.Add(supplier);

                        if (!cmbImportDay.Items.Contains(importDay))
                            cmbImportDay.Items.Add(importDay);
                    }

                    // Không chọn item nào lúc load
                    cmbSupplier.SelectedIndex = -1;
                    cmbImportDay.SelectedIndex = -1;

                    // Gán text mặc định
                    cmbSupplier.Text = "Supplier";
                    cmbImportDay.Text = "Import Day";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading combobox data: " + ex.Message);
            }
        }

        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0 && dgvInventory.SelectedRows[0].Cells["InventoryID"].Value != DBNull.Value)
            {
                int inventoryId;
                if (int.TryParse(dgvInventory.SelectedRows[0].Cells["InventoryID"].Value.ToString(), out inventoryId))
                {
                    LoadProducts(inventoryId);
                }
            }
        }

        private void LoadInventory()
        {
            string query = "usp_LoadInventory";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    db.OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    db.CloseConnection();
                    dgvInventory.DataSource = dt;
                    AdjustColumnWidths(dgvInventory);
                    dgvInventory.Columns["InventoryID"].HeaderText = "Inventory ID";
                    dgvInventory.Columns["ProductName"].HeaderText = "Product Name";
                    dgvInventory.Columns["StorageLocation"].HeaderText = "Storage Location";
                    dgvInventory.Columns["Quantity"].HeaderText = "Quantity";
                    dgvInventory.Columns["Category"].HeaderText = "Category";
                    dgvInventory.Columns["Status"].HeaderText = "Status";
                    dgvInventory.Columns["AveragePrice"].HeaderText = "Average Price";
                    dgvInventory.Columns["TotalOrders"].HeaderText = "Total Orders";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message);
            }
        }

        private void LoadProducts(int inventoryId)
        {
            string query = "usp_LoadProducts";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InventoryID", inventoryId);
                    db.OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    db.CloseConnection();
                    dgvProduct.DataSource = dt;
                    AdjustColumnWidths(dgvProduct);
                    dgvProduct.Columns["ProductID"].HeaderText = "Product ID";
                    dgvProduct.Columns["ProductName"].HeaderText = "Product Name";
                    dgvProduct.Columns["ExpiryDate"].HeaderText = "Expiry Date";
                    dgvProduct.Columns["ProductionDate"].HeaderText = "Production Date";
                    dgvProduct.Columns["Origin"].HeaderText = "Origin";
                    dgvProduct.Columns["Status"].HeaderText = "Status";
                    dgvProduct.Columns["Ingredients"].HeaderText = "Ingredients";
                    dgvProduct.Columns["ImportTime"].HeaderText = "Import Time";
                    dgvProduct.Columns["ImportLocation"].HeaderText = "Import Location";
                    dgvProduct.Columns["Code"].HeaderText = "Product Code";
                    dgvProduct.Columns["Price"].HeaderText = "Price";
                    dgvProduct.Columns["Certification"].HeaderText = "Certification";
                    dgvProduct.Columns["Preservation"].HeaderText = "Preservation";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product details: " + ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm();
            addForm.ShowDialog();
            LoadInventory();
        }



        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["ProductID"].Value);

                var confirm = MessageBox.Show("Are you sure you want to remove this product?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        // 1. Xóa Inventory trước
                        string deleteInventoryQuery = "DELETE FROM Inventory WHERE ProductID = @ProductID";
                        using (SqlCommand cmdInventory = new SqlCommand(deleteInventoryQuery, db.Connection))
                        {
                            cmdInventory.Parameters.AddWithValue("@ProductID", productId);
                            db.OpenConnection();
                            cmdInventory.ExecuteNonQuery();
                            db.CloseConnection();
                        }

                        // 2. Sau đó mới xóa Product
                        string deleteProductQuery = "usp_DeleteProduct";
                        using (SqlCommand cmdProduct = new SqlCommand(deleteProductQuery, db.Connection))
                        {
                            cmdProduct.CommandType = CommandType.StoredProcedure;
                            cmdProduct.Parameters.AddWithValue("@ProductID", productId);
                            db.OpenConnection();
                            cmdProduct.ExecuteNonQuery();
                            db.CloseConnection();
                        }

                        MessageBox.Show("Product removed successfully.");
                        LoadInventory();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error removing product: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to remove.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "usp_FindProduct";
                SqlDataAdapter adapter = new SqlDataAdapter(query, db.Connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                string supplier = cmbSupplier.Text == "Supplier" ? null : cmbSupplier.Text;
                string importDay = cmbImportDay.Text == "Import Day" ? null : cmbImportDay.Text;
                

                adapter.SelectCommand.Parameters.AddWithValue("@Supplier", (object)supplier ?? DBNull.Value);
                adapter.SelectCommand.Parameters.AddWithValue("@ImportDay", (object)importDay ?? DBNull.Value);
                
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProduct.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finding product: " + ex.Message);
            }
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["ProductID"].Value);
                ModifyProductForm modifyForm = new ModifyProductForm(productId);
                modifyForm.ShowDialog();
                LoadInventory(); // Load lại Inventory sau khi sửa
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }
    }
}



//CREATE TABLE[Order] (
//    OrderID INT IDENTITY(1,1) PRIMARY KEY,
//    UserID INT NOT NULL,
//    SupplierID INT NOT NULL,
//    DeliveryTime DATETIME2 NOT NULL,
//    Status VARCHAR(50) NOT NULL CHECK (Status IN ('Pending', 'Shipped', 'Delivered', 'Cancelled')),
//    Quantity INT NOT NULL CHECK (Quantity > 0),
//    Price DECIMAL(10,2) NOT NULL CHECK (Price >= 0),
//    TypeOfGoods VARCHAR(100) NOT NULL,
//    FOREIGN KEY (UserID) REFERENCES [User] (UserID),
//    FOREIGN KEY(SupplierID) REFERENCES Supplier(SupplierID)
//);

//CREATE TABLE Product (
//    ProductID INT IDENTITY(1,1) PRIMARY KEY,
//    Name VARCHAR(100) NOT NULL,
//    ExpiryDate DATE,
//    ProductionDate DATE NOT NULL,
//    Origin VARCHAR(100) NOT NULL,
//    Status VARCHAR(50) NOT NULL CHECK (Status IN ('Available', 'Out of Stock', 'Discontinued')),
//    Ingredients VARCHAR(MAX),
//    ImportTime DATETIME2 NOT NULL,
//    ImportLocation VARCHAR(100) NOT NULL,
//    Code VARCHAR(50) UNIQUE NOT NULL,
//    Price DECIMAL(10,2) NOT NULL CHECK (Price >= 0),
//    Certification VARCHAR(100),
//    Preservation VARCHAR(50) NOT NULL
//);

//CREATE TABLE OrderProducts (
//    OrderID INT NOT NULL,
//    ProductID INT NOT NULL,
//    PRIMARY KEY (OrderID, ProductID),
//    FOREIGN KEY (OrderID) REFERENCES [Order] (OrderID)ON DELETE CASCADE,
//    FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE CASCADE
//);

//CREATE TABLE Inventory (
//    InventoryID INT IDENTITY(1,1) PRIMARY KEY,
//    ProductID INT NOT NULL,
//    StorageLocation VARCHAR(100) NOT NULL,
//    Quantity INT NOT NULL CHECK (Quantity >= 0),
//    Category VARCHAR(100) NOT NULL,
//    Status VARCHAR(50) NOT NULL CHECK (Status IN ('In Stock', 'Low Stock', 'Out of Stock')),
//    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
//);