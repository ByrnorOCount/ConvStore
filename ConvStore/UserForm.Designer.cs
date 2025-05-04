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
            this.lblTitleUserID = new System.Windows.Forms.Label();
            this.lblTitleRole = new System.Windows.Forms.Label();
            this.lblTitleStoreBranch = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblTitleUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblStoreBranch = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotification
            // 
            this.dgvNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotification.Location = new System.Drawing.Point(185, 345);
            this.dgvNotification.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNotification.Name = "dgvNotification";
            this.dgvNotification.RowHeadersWidth = 72;
            this.dgvNotification.RowTemplate.Height = 31;
            this.dgvNotification.Size = new System.Drawing.Size(882, 231);
            this.dgvNotification.TabIndex = 0;
            // 
            // lblTitleUserID
            // 
            this.lblTitleUserID.AutoSize = true;
            this.lblTitleUserID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleUserID.Location = new System.Drawing.Point(367, 76);
            this.lblTitleUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleUserID.Name = "lblTitleUserID";
            this.lblTitleUserID.Size = new System.Drawing.Size(101, 35);
            this.lblTitleUserID.TabIndex = 13;
            this.lblTitleUserID.Text = "User ID";
            // 
            // lblTitleRole
            // 
            this.lblTitleRole.AutoSize = true;
            this.lblTitleRole.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleRole.Location = new System.Drawing.Point(389, 184);
            this.lblTitleRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleRole.Name = "lblTitleRole";
            this.lblTitleRole.Size = new System.Drawing.Size(66, 35);
            this.lblTitleRole.TabIndex = 14;
            this.lblTitleRole.Text = "Role";
            // 
            // lblTitleStoreBranch
            // 
            this.lblTitleStoreBranch.AutoSize = true;
            this.lblTitleStoreBranch.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleStoreBranch.Location = new System.Drawing.Point(747, 184);
            this.lblTitleStoreBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleStoreBranch.Name = "lblTitleStoreBranch";
            this.lblTitleStoreBranch.Size = new System.Drawing.Size(165, 35);
            this.lblTitleStoreBranch.TabIndex = 15;
            this.lblTitleStoreBranch.Text = "Store Branch";
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNotification.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotification.Location = new System.Drawing.Point(944, 321);
            this.lblNotification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(113, 23);
            this.lblNotification.TabIndex = 19;
            this.lblNotification.Text = "Notifications";
            // 
            // lblUserID
            // 
            this.lblUserID.BackColor = System.Drawing.Color.Goldenrod;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(261, 118);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(324, 45);
            this.lblUserID.TabIndex = 31;
            this.lblUserID.Text = "User Page";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleUsername
            // 
            this.lblTitleUsername.AutoSize = true;
            this.lblTitleUsername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleUsername.Location = new System.Drawing.Point(760, 76);
            this.lblTitleUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleUsername.Name = "lblTitleUsername";
            this.lblTitleUsername.Size = new System.Drawing.Size(133, 35);
            this.lblTitleUsername.TabIndex = 32;
            this.lblTitleUsername.Text = "Username";
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Goldenrod;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(261, 227);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(324, 45);
            this.lblRole.TabIndex = 33;
            this.lblRole.Text = "User Page";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Goldenrod;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(669, 118);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(324, 45);
            this.lblUsername.TabIndex = 34;
            this.lblUsername.Text = "User Page";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStoreBranch
            // 
            this.lblStoreBranch.BackColor = System.Drawing.Color.Goldenrod;
            this.lblStoreBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStoreBranch.Location = new System.Drawing.Point(669, 227);
            this.lblStoreBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreBranch.Name = "lblStoreBranch";
            this.lblStoreBranch.Size = new System.Drawing.Size(324, 45);
            this.lblStoreBranch.TabIndex = 35;
            this.lblStoreBranch.Text = "User Page";
            this.lblStoreBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.Location = new System.Drawing.Point(185, 290);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(94, 38);
            this.btnAddUser.TabIndex = 36;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUser.Location = new System.Drawing.Point(297, 290);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(94, 38);
            this.btnUpdateUser.TabIndex = 37;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.Location = new System.Drawing.Point(407, 290);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(94, 38);
            this.btnDeleteUser.TabIndex = 38;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 576);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblStoreBranch);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblTitleUsername);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.lblTitleStoreBranch);
            this.Controls.Add(this.lblTitleRole);
            this.Controls.Add(this.lblTitleUserID);
            this.Controls.Add(this.dgvNotification);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Controls.SetChildIndex(this.dgvNotification, 0);
            this.Controls.SetChildIndex(this.lblTitleUserID, 0);
            this.Controls.SetChildIndex(this.lblTitleRole, 0);
            this.Controls.SetChildIndex(this.lblTitleStoreBranch, 0);
            this.Controls.SetChildIndex(this.lblNotification, 0);
            this.Controls.SetChildIndex(this.lblUserID, 0);
            this.Controls.SetChildIndex(this.lblTitleUsername, 0);
            this.Controls.SetChildIndex(this.lblRole, 0);
            this.Controls.SetChildIndex(this.lblUsername, 0);
            this.Controls.SetChildIndex(this.lblStoreBranch, 0);
            this.Controls.SetChildIndex(this.picIcon, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnAddUser, 0);
            this.Controls.SetChildIndex(this.btnUpdateUser, 0);
            this.Controls.SetChildIndex(this.btnDeleteUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotification;
        private System.Windows.Forms.Label lblTitleUserID;
        private System.Windows.Forms.Label lblTitleRole;
        private System.Windows.Forms.Label lblTitleStoreBranch;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblTitleUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblStoreBranch;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}