using System.Windows.Forms;

namespace ConvStore
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            FormHelper.AssignNavigationHandler(btnUser, FormHelper.OpenForm<UserForm>, this);
            FormHelper.AssignNavigationHandler(btnSupplier, FormHelper.OpenForm<SupplierForm>, this);
            FormHelper.AssignNavigationHandler(btnOrder, FormHelper.OpenForm<OrderForm>, this);
            FormHelper.AssignNavigationHandler(btnInventory, FormHelper.OpenForm<InventoryForm>, this);
            FormHelper.AssignNavigationHandler(btnChangelog, FormHelper.OpenForm<ChangeLogForm>, this);
            FormHelper.AssignLogoutHandler(btnLogout, this);
        }
    }
}
