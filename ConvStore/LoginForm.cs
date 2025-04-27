using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            picLoginForm.Image = Image.FromFile(Util.imgDir + "user_icon.png");
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!ValidateLoginFields(username, password, out List<string> errors))
            {
                MessageBox.Show(string.Join("\n", errors), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (DBHelper db = new DBHelper())
            {
                try
                {
                    db.OpenConnection();

                    string query = "usp_GetUser";
                    using (SqlCommand cmd = new SqlCommand(query, db.Connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserSession.UserID = reader.GetInt32(0);
                                UserSession.Username = reader.GetString(1);
                                UserSession.Role = reader.GetString(2);
                                UserSession.StoreBranch = reader.GetString(3);
                                UserSession.Permission = reader.GetString(4);

                                Hide();
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private bool ValidateLoginFields(string username, string password, out List<string> errors)
        {
            errors = new List<string>();

            if (string.IsNullOrWhiteSpace(username))
                errors.Add("Username cannot be empty.");

            if (string.IsNullOrWhiteSpace(password))
                errors.Add("Password cannot be empty.");
            else if (password.Length < 8)
                errors.Add("Password must be at least 8 characters long.");
            else if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit))
                errors.Add("Password must contain at least one letter and one number.");

            return errors.Count == 0;
        }
    }
}
