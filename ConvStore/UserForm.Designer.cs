namespace ConvStore
{
    partial class UserForm
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
            this.dgvNotification = new System.Windows.Forms.DataGridView();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblUserPage = new System.Windows.Forms.Label();
            this.lblTitleUserID = new System.Windows.Forms.Label();
            this.lblTitleRole = new System.Windows.Forms.Label();
            this.lblTitleStoreBranch = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangelog = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblTitleUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblStoreBranch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotification
            // 
            this.dgvNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotification.Location = new System.Drawing.Point(208, 431);
            this.dgvNotification.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNotification.Name = "dgvNotification";
            this.dgvNotification.RowHeadersWidth = 72;
            this.dgvNotification.RowTemplate.Height = 31;
            this.dgvNotification.Size = new System.Drawing.Size(992, 289);
            this.dgvNotification.TabIndex = 0;
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(10, 10);
            this.picIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(96, 64);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 2;
            this.picIcon.TabStop = false;
            // 
            // lblUserPage
            // 
            this.lblUserPage.BackColor = System.Drawing.Color.Chartreuse;
            this.lblUserPage.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPage.Location = new System.Drawing.Point(110, 10);
            this.lblUserPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserPage.Name = "lblUserPage";
            this.lblUserPage.Size = new System.Drawing.Size(1088, 64);
            this.lblUserPage.TabIndex = 3;
            this.lblUserPage.Text = "User Page";
            this.lblUserPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleUserID
            // 
            this.lblTitleUserID.AutoSize = true;
            this.lblTitleUserID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleUserID.Location = new System.Drawing.Point(413, 95);
            this.lblTitleUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleUserID.Name = "lblTitleUserID";
            this.lblTitleUserID.Size = new System.Drawing.Size(121, 41);
            this.lblTitleUserID.TabIndex = 13;
            this.lblTitleUserID.Text = "User ID";
            // 
            // lblTitleRole
            // 
            this.lblTitleRole.AutoSize = true;
            this.lblTitleRole.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleRole.Location = new System.Drawing.Point(438, 230);
            this.lblTitleRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleRole.Name = "lblTitleRole";
            this.lblTitleRole.Size = new System.Drawing.Size(80, 41);
            this.lblTitleRole.TabIndex = 14;
            this.lblTitleRole.Text = "Role";
            // 
            // lblTitleStoreBranch
            // 
            this.lblTitleStoreBranch.AutoSize = true;
            this.lblTitleStoreBranch.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleStoreBranch.Location = new System.Drawing.Point(840, 230);
            this.lblTitleStoreBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleStoreBranch.Name = "lblTitleStoreBranch";
            this.lblTitleStoreBranch.Size = new System.Drawing.Size(197, 41);
            this.lblTitleStoreBranch.TabIndex = 15;
            this.lblTitleStoreBranch.Text = "Store Branch";
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNotification.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotification.Location = new System.Drawing.Point(1062, 401);
            this.lblNotification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(136, 28);
            this.lblNotification.TabIndex = 19;
            this.lblNotification.Text = "Notifications";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.SystemColors.Info;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnUser.Location = new System.Drawing.Point(10, 92);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(178, 56);
            this.btnUser.TabIndex = 25;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(10, 451);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 56);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnChangelog
            // 
            this.btnChangelog.BackColor = System.Drawing.SystemColors.Info;
            this.btnChangelog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangelog.Location = new System.Drawing.Point(10, 376);
            this.btnChangelog.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangelog.Name = "btnChangelog";
            this.btnChangelog.Size = new System.Drawing.Size(178, 56);
            this.btnChangelog.TabIndex = 23;
            this.btnChangelog.Text = "Changelog";
            this.btnChangelog.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.Info;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInventory.Location = new System.Drawing.Point(10, 303);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(178, 56);
            this.btnInventory.TabIndex = 22;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.Info;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrder.Location = new System.Drawing.Point(10, 231);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(178, 56);
            this.btnOrder.TabIndex = 21;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.SystemColors.Info;
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSupplier.Location = new System.Drawing.Point(10, 162);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(178, 56);
            this.btnSupplier.TabIndex = 20;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = false;
            // 
            // lblUserID
            // 
            this.lblUserID.BackColor = System.Drawing.Color.Goldenrod;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(294, 148);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(364, 56);
            this.lblUserID.TabIndex = 31;
            this.lblUserID.Text = "User Page";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleUsername
            // 
            this.lblTitleUsername.AutoSize = true;
            this.lblTitleUsername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleUsername.Location = new System.Drawing.Point(855, 95);
            this.lblTitleUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleUsername.Name = "lblTitleUsername";
            this.lblTitleUsername.Size = new System.Drawing.Size(158, 41);
            this.lblTitleUsername.TabIndex = 32;
            this.lblTitleUsername.Text = "Username";
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Goldenrod;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(294, 284);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(364, 56);
            this.lblRole.TabIndex = 33;
            this.lblRole.Text = "User Page";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Goldenrod;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(753, 148);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(364, 56);
            this.lblUsername.TabIndex = 34;
            this.lblUsername.Text = "User Page";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStoreBranch
            // 
            this.lblStoreBranch.BackColor = System.Drawing.Color.Goldenrod;
            this.lblStoreBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStoreBranch.Location = new System.Drawing.Point(753, 284);
            this.lblStoreBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreBranch.Name = "lblStoreBranch";
            this.lblStoreBranch.Size = new System.Drawing.Size(364, 56);
            this.lblStoreBranch.TabIndex = 35;
            this.lblStoreBranch.Text = "User Page";
            this.lblStoreBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.lblStoreBranch);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblTitleUsername);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChangelog);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.lblTitleStoreBranch);
            this.Controls.Add(this.lblTitleRole);
            this.Controls.Add(this.lblTitleUserID);
            this.Controls.Add(this.lblUserPage);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.dgvNotification);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotification;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblUserPage;
        private System.Windows.Forms.Label lblTitleUserID;
        private System.Windows.Forms.Label lblTitleRole;
        private System.Windows.Forms.Label lblTitleStoreBranch;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangelog;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblTitleUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblStoreBranch;
    }
}