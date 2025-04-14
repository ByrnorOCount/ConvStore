using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConvStore
{
    public static class FormHelper
    {
        public static void AssignNavigationHandler(Button button, Action<Form> navigationAction, Form currentForm)
        {
            button.Click += (sender, e) => navigationAction(currentForm);
        }

        public static void AssignLogoutHandler(Button button, Form currentForm)
        {
            button.Click += (sender, e) => Logout(currentForm);
        }

        public static void OpenUserForm(Form currentForm)
        {
            UserForm userForm = new UserForm();
            userForm.Show();

            if (!(currentForm is MainForm))
            {
                currentForm.Close();
            }
        }

        public static void OpenSupplierForm(Form currentForm)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();

            if (!(currentForm is MainForm))
            {
                currentForm.Close();
            }
        }

        public static void OpenOrderForm(Form currentForm)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();

            if (!(currentForm is MainForm))
            {
                currentForm.Close();
            }
        }

        public static void OpenInventoryForm(Form currentForm)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();

            if (!(currentForm is MainForm))
            {
                currentForm.Close();
            }
        }

        public static void OpenChangeLogForm(Form currentForm)
        {
            ChangeLogForm changeLogForm = new ChangeLogForm();
            changeLogForm.Show();

            if (!(currentForm is MainForm))
            {
                currentForm.Close();
            }
        }

        public static void Logout(Form currentForm)
        {
            UserSession.Clear();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            currentForm.Close();
        }

        public static void FormatDataGridView(DataGridView dgv)
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

        public static void AdjustColumnWidths(DataGridView dgv)
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
