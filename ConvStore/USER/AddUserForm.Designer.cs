
namespace ConvStore
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "AddUserForm";

            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtStoreBranch = new System.Windows.Forms.TextBox();
            this.cmbPermission = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            int labelX = 30, inputX = 150, startY = 30, gapY = 40;

            string[] labels = new string[] {
                "Username:",
                "Password:",
                "Role:",
                "Store Branch:",
                "Permission:",
            };

            System.Windows.Forms.Control[] controls = new System.Windows.Forms.Control[]
            {
                txtUsername,
                txtPassword,
                cmbRole,
                txtStoreBranch,
                cmbPermission
            };

            int len = labels.Length;
            for (int i = 0; i < len; i++)
            {
                var lbl = new System.Windows.Forms.Label();
                lbl.Text = labels[i];
                lbl.Location = new System.Drawing.Point(labelX, startY + i * gapY + 5);
                lbl.AutoSize = true;
                this.Controls.Add(lbl);
                var ctrl = controls[i];
                ctrl.Location = new System.Drawing.Point(inputX, startY + i * gapY);
                this.Controls.Add(ctrl);
            }

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(70, startY + (len + 1) * gapY);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.Controls.Add(btnSave);

            this.Text = "Add User";
            this.ClientSize = new System.Drawing.Size(450, startY + (len + 2) * gapY);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtStoreBranch;
        private System.Windows.Forms.ComboBox cmbPermission;
        private System.Windows.Forms.Button btnSave;
    }
}