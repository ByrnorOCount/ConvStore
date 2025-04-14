namespace ConvStore
{
    partial class SupplierForm
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
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnCancelSupplier = new System.Windows.Forms.Button();
            this.btnSaveSupplier = new System.Windows.Forms.Button();
            this.btnResetSupplier = new System.Windows.Forms.Button();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierItems = new System.Windows.Forms.Label();
            this.lblSupplierPhone = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierItems = new System.Windows.Forms.TextBox();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.rdoSupplierIsActive = new System.Windows.Forms.RadioButton();
            this.lblSupplierManagement = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangelog = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(10, 10);
            this.picIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(96, 64);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(221, 92);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 72;
            this.dgvSupplier.RowTemplate.Height = 31;
            this.dgvSupplier.Size = new System.Drawing.Size(956, 300);
            this.dgvSupplier.TabIndex = 9;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddSupplier.Location = new System.Drawing.Point(278, 408);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(84, 48);
            this.btnAddSupplier.TabIndex = 10;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditSupplier.Location = new System.Drawing.Point(396, 408);
            this.btnEditSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(84, 48);
            this.btnEditSupplier.TabIndex = 11;
            this.btnEditSupplier.Text = "Edit";
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            // 
            // btnCancelSupplier
            // 
            this.btnCancelSupplier.BackColor = System.Drawing.Color.Red;
            this.btnCancelSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelSupplier.Location = new System.Drawing.Point(523, 408);
            this.btnCancelSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelSupplier.Name = "btnCancelSupplier";
            this.btnCancelSupplier.Size = new System.Drawing.Size(84, 48);
            this.btnCancelSupplier.TabIndex = 12;
            this.btnCancelSupplier.Text = "Cancel";
            this.btnCancelSupplier.UseVisualStyleBackColor = false;
            // 
            // btnSaveSupplier
            // 
            this.btnSaveSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveSupplier.Location = new System.Drawing.Point(936, 658);
            this.btnSaveSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveSupplier.Name = "btnSaveSupplier";
            this.btnSaveSupplier.Size = new System.Drawing.Size(115, 43);
            this.btnSaveSupplier.TabIndex = 13;
            this.btnSaveSupplier.Text = "Save";
            this.btnSaveSupplier.UseVisualStyleBackColor = false;
            // 
            // btnResetSupplier
            // 
            this.btnResetSupplier.BackColor = System.Drawing.Color.Red;
            this.btnResetSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnResetSupplier.Location = new System.Drawing.Point(1075, 658);
            this.btnResetSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetSupplier.Name = "btnResetSupplier";
            this.btnResetSupplier.Size = new System.Drawing.Size(115, 43);
            this.btnResetSupplier.TabIndex = 14;
            this.btnResetSupplier.Text = "Reset";
            this.btnResetSupplier.UseVisualStyleBackColor = false;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupplierID.Location = new System.Drawing.Point(284, 468);
            this.lblSupplierID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(122, 28);
            this.lblSupplierID.TabIndex = 15;
            this.lblSupplierID.Text = "Supplier ID:";
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupplierCode.Location = new System.Drawing.Point(258, 509);
            this.lblSupplierCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Size = new System.Drawing.Size(148, 28);
            this.lblSupplierCode.TabIndex = 16;
            this.lblSupplierCode.Text = "Supplier Code:";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupplierName.Location = new System.Drawing.Point(250, 552);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(157, 28);
            this.lblSupplierName.TabIndex = 17;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // lblSupplierItems
            // 
            this.lblSupplierItems.AutoSize = true;
            this.lblSupplierItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupplierItems.Location = new System.Drawing.Point(262, 592);
            this.lblSupplierItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierItems.Name = "lblSupplierItems";
            this.lblSupplierItems.Size = new System.Drawing.Size(146, 28);
            this.lblSupplierItems.TabIndex = 18;
            this.lblSupplierItems.Text = "Type of Items:";
            // 
            // lblSupplierPhone
            // 
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupplierPhone.Location = new System.Drawing.Point(296, 640);
            this.lblSupplierPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Size = new System.Drawing.Size(110, 28);
            this.lblSupplierPhone.TabIndex = 19;
            this.lblSupplierPhone.Text = "Phone No:";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(435, 468);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(281, 26);
            this.txtSupplierID.TabIndex = 20;
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Location = new System.Drawing.Point(435, 509);
            this.txtSupplierCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(281, 26);
            this.txtSupplierCode.TabIndex = 21;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(435, 552);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(281, 26);
            this.txtSupplierName.TabIndex = 22;
            // 
            // txtSupplierItems
            // 
            this.txtSupplierItems.Location = new System.Drawing.Point(435, 592);
            this.txtSupplierItems.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierItems.Name = "txtSupplierItems";
            this.txtSupplierItems.Size = new System.Drawing.Size(281, 26);
            this.txtSupplierItems.TabIndex = 23;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Location = new System.Drawing.Point(435, 640);
            this.txtSupplierPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(281, 26);
            this.txtSupplierPhone.TabIndex = 24;
            // 
            // rdoSupplierIsActive
            // 
            this.rdoSupplierIsActive.AutoSize = true;
            this.rdoSupplierIsActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdoSupplierIsActive.Location = new System.Drawing.Point(816, 468);
            this.rdoSupplierIsActive.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSupplierIsActive.Name = "rdoSupplierIsActive";
            this.rdoSupplierIsActive.Size = new System.Drawing.Size(112, 32);
            this.rdoSupplierIsActive.TabIndex = 25;
            this.rdoSupplierIsActive.TabStop = true;
            this.rdoSupplierIsActive.Text = "IsActive";
            this.rdoSupplierIsActive.UseVisualStyleBackColor = true;
            // 
            // lblSupplierManagement
            // 
            this.lblSupplierManagement.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblSupplierManagement.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierManagement.Location = new System.Drawing.Point(110, 10);
            this.lblSupplierManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierManagement.Name = "lblSupplierManagement";
            this.lblSupplierManagement.Size = new System.Drawing.Size(1088, 63);
            this.lblSupplierManagement.TabIndex = 2;
            this.lblSupplierManagement.Text = "Supplier Management";
            this.lblSupplierManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnUser.TabIndex = 37;
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
            this.btnLogout.TabIndex = 36;
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
            this.btnChangelog.TabIndex = 35;
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
            this.btnInventory.TabIndex = 34;
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
            this.btnOrder.TabIndex = 33;
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
            this.btnSupplier.TabIndex = 32;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = false;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChangelog);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.rdoSupplierIsActive);
            this.Controls.Add(this.txtSupplierPhone);
            this.Controls.Add(this.txtSupplierItems);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierCode);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.lblSupplierPhone);
            this.Controls.Add(this.lblSupplierItems);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblSupplierCode);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.btnResetSupplier);
            this.Controls.Add(this.btnSaveSupplier);
            this.Controls.Add(this.btnCancelSupplier);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.lblSupplierManagement);
            this.Controls.Add(this.picIcon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SupplierForm";
            this.Text = "Manage Suppliers List";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnCancelSupplier;
        private System.Windows.Forms.Button btnSaveSupplier;
        private System.Windows.Forms.Button btnResetSupplier;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierItems;
        private System.Windows.Forms.Label lblSupplierPhone;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierItems;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.RadioButton rdoSupplierIsActive;
        private System.Windows.Forms.Label lblSupplierManagement;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangelog;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSupplier;
    }
}