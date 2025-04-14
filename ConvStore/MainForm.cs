using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;

            FormHelper.AssignNavigationHandler(btnUser, FormHelper.OpenUserForm, this);
            FormHelper.AssignNavigationHandler(btnSupplier, FormHelper.OpenSupplierForm, this);
            FormHelper.AssignNavigationHandler(btnOrder, FormHelper.OpenOrderForm, this);
            FormHelper.AssignNavigationHandler(btnInventory, FormHelper.OpenInventoryForm, this);
            FormHelper.AssignNavigationHandler(btnChangelog, FormHelper.OpenChangeLogForm, this);
            FormHelper.AssignLogoutHandler(btnLogout, this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            picLarge.Image = Image.FromFile("../../images/box_and_clipboard.png");
            picIcon.Image = Image.FromFile("../../images/warehouse.jpg");
            lblStaff.Text = $"Welcome, {UserSession.Username}!";
        }

        private void btnUser_Click(object sender, EventArgs e) => FormHelper.OpenUserForm(this);
        private void btnSupplier_Click(object sender, EventArgs e) => FormHelper.OpenSupplierForm(this);
        private void btnOrder_Click(object sender, EventArgs e) => FormHelper.OpenOrderForm(this);
        private void btnInventory_Click(object sender, EventArgs e) => FormHelper.OpenInventoryForm(this);
        private void btnChangelog_Click(object sender, EventArgs e) => FormHelper.OpenChangeLogForm(this);
        private void btnLogout_Click(object sender, EventArgs e) => FormHelper.Logout(this);
    }
}
