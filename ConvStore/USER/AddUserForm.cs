using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class AddUserForm : Form
    {
        private DBHelper db = new DBHelper();

        public AddUserForm()
        {
            InitializeComponent();
            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new string[] { "Staff", "Manager" });
            cmbPermission.Items.Clear();
            cmbPermission.Items.AddRange(new string[] { "ReadOnly", "FullAccess" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"usp_AddUser";
                using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@storeBranch", txtStoreBranch.Text.Trim());
                    cmd.Parameters.AddWithValue("@permission", cmbPermission.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@executedByUserID", UserSession.UserID);

                    SqlParameter errorMessageParam = new SqlParameter("@errorMessage", SqlDbType.NVarChar, -1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(errorMessageParam);

                    db.OpenConnection();
                    cmd.ExecuteNonQuery();
                    string errorMessage = errorMessageParam.Value?.ToString();
                    db.CloseConnection();
                    MessageBox.Show(errorMessage ?? "Supplier added successfully.");
                }

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
