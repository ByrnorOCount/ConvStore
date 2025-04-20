using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            AssignNavigationHandler(btnUser, OpenForm<UserForm>);
            AssignNavigationHandler(btnSupplier, OpenForm<SupplierForm>);
            AssignNavigationHandler(btnOrder, OpenForm<OrderForm>);
            AssignNavigationHandler(btnInventory, OpenForm<InventoryForm>);
            AssignNavigationHandler(btnChangelog, OpenForm<ChangeLogForm>);
            AssignLogoutHandler(btnLogout);
        }

        private void AssignNavigationHandler(Button button, Action navigationAction)
        {
            button.Click += (sender, e) => navigationAction();
        }

        private void AssignLogoutHandler(Button button)
        {
            button.Click += (sender, e) => Logout();
        }

        private void OpenForm<T>() where T : Form, new()
        {
            T userForm = new T();
            userForm.Show();

            if (!(this is MainForm))
                Close();
        }

        private void Logout()
        {
            UserSession.Clear();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Close();
        }

        protected void FormatDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 20;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Comic Sans MS", 9, FontStyle.Regular);
        }

        protected void AdjustColumnWidths(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                column.FillWeight = 1;
            }
        }
    }
}
