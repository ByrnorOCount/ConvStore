using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class OrderForm : MyForm
    {
        private readonly DBHelper db = new DBHelper();

        public OrderForm()
        {
            InitializeComponent();
            this.Load += OrderForm_Load;
            dgvOrder.SelectionChanged += dgvOrder_SelectionChanged;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
            FormatDataGridView(dgvOrder);
            FormatDataGridView(dgvOrderProducts);
            picIcon.Image = Image.FromFile(Const.IMAGE_DIRECTORY + "warehouse.jpg");
            lblTitle.Text = $"Order Management";
        }

        private void dgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvOrder.SelectedRows[0].Cells["OrderID"].Value);
                LoadOrderProducts(orderId);
            }
        }

        private void LoadOrders()
        {
            string query = @"
                SELECT 
                    o.OrderID,
                    u.Username AS OrdererName,
                    s.Name AS SupplierName,
                    o.DeliveryTime,
                    o.Status,
                    o.Quantity,
                    o.Price,
                    o.TypeOfGoods
                FROM [Order] o
                LEFT JOIN [User] u ON o.UserID = u.UserID
                LEFT JOIN Supplier s ON o.SupplierID = s.SupplierID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    db.OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    db.CloseConnection();
                    dgvOrder.DataSource = dt;
                    AdjustColumnWidths(dgvOrder);
                    dgvOrder.Columns["OrderID"].HeaderText = "ID";
                    dgvOrder.Columns["OrdererName"].HeaderText = "Orderer";
                    dgvOrder.Columns["SupplierName"].HeaderText = "Supplier";
                    dgvOrder.Columns["DeliveryTime"].HeaderText = "Delivery Time";
                    dgvOrder.Columns["Status"].HeaderText = "Status";
                    dgvOrder.Columns["Quantity"].HeaderText = "Quantity";
                    dgvOrder.Columns["Price"].HeaderText = "Price";
                    dgvOrder.Columns["TypeOfGoods"].HeaderText = "Type of Goods";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void LoadOrderProducts(int orderId)
        {
            string query = @"
                SELECT 
                    op.ProductID,
                    p.Name AS ProductName,
                    p.Price,
                    p.Origin,
                    p.Status
                FROM OrderProducts op
                LEFT JOIN Product p ON op.ProductID = p.ProductID
                WHERE op.OrderID = @OrderID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);

                    db.OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    db.CloseConnection();
                    dgvOrderProducts.DataSource = dt;
                    FormatDataGridView(dgvOrderProducts);
                    dgvOrderProducts.Columns["ProductID"].HeaderText = "Product ID";
                    dgvOrderProducts.Columns["ProductName"].HeaderText = "Product Name";
                    dgvOrderProducts.Columns["Price"].HeaderText = "Price";
                    dgvOrderProducts.Columns["Origin"].HeaderText = "Origin";
                    dgvOrderProducts.Columns["Status"].HeaderText = "Status";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order products: " + ex.Message);
            }
        }
    }
}
