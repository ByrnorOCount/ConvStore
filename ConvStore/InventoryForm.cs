using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class InventoryForm : MyForm
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
            FormatDataGridView(dgvInventory);
            FormatDataGridView(dgvProduct);
            picIcon.Image = Image.FromFile(Util.imgDir + "warehouse.jpg");
            lblTitle.Text = $"Inventory";
        }

        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int inventoryId = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["InventoryID"].Value);
                LoadProducts(inventoryId);
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