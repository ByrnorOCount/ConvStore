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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_staff = new System.Windows.Forms.Label();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnChangelog = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_staff
            // 
            this.label_staff.BackColor = System.Drawing.Color.Yellow;
            this.label_staff.Location = new System.Drawing.Point(98, 8);
            this.label_staff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_staff.Name = "label_staff";
            this.label_staff.Size = new System.Drawing.Size(967, 51);
            this.label_staff.TabIndex = 2;
            this.label_staff.Text = "STAFF";
            this.label_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSupplier.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSupplier.Location = new System.Drawing.Point(9, 86);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(158, 45);
            this.btnSupplier.TabIndex = 4;
            this.btnSupplier.Text = "SUPPLIER";
            this.btnSupplier.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.Info;
            this.btnOrder.Location = new System.Drawing.Point(9, 157);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(158, 45);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.Info;
            this.btnInventory.Location = new System.Drawing.Point(9, 226);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(158, 45);
            this.btnInventory.TabIndex = 6;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnChangelog
            // 
            this.btnChangelog.BackColor = System.Drawing.SystemColors.Info;
            this.btnChangelog.Location = new System.Drawing.Point(9, 303);
            this.btnChangelog.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangelog.Name = "btnChangelog";
            this.btnChangelog.Size = new System.Drawing.Size(158, 45);
            this.btnChangelog.TabIndex = 7;
            this.btnChangelog.Text = "CHANGELOG";
            this.btnChangelog.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogout.Location = new System.Drawing.Point(9, 374);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 45);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(196, 74);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 72;
            this.dgvSupplier.RowTemplate.Height = 31;
            this.dgvSupplier.Size = new System.Drawing.Size(850, 240);
            this.dgvSupplier.TabIndex = 9;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddSupplier.Location = new System.Drawing.Point(247, 326);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(75, 38);
            this.btnAddSupplier.TabIndex = 10;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditSupplier.Location = new System.Drawing.Point(352, 326);
            this.btnEditSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(75, 38);
            this.btnEditSupplier.TabIndex = 11;
            this.btnEditSupplier.Text = "Edit";
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            // 
            // btnCancelSupplier
            // 
            this.btnCancelSupplier.BackColor = System.Drawing.Color.Red;
            this.btnCancelSupplier.Location = new System.Drawing.Point(465, 326);
            this.btnCancelSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelSupplier.Name = "btnCancelSupplier";
            this.btnCancelSupplier.Size = new System.Drawing.Size(75, 38);
            this.btnCancelSupplier.TabIndex = 12;
            this.btnCancelSupplier.Text = "Cancel";
            this.btnCancelSupplier.UseVisualStyleBackColor = false;
            // 
            // btnSaveSupplier
            // 
            this.btnSaveSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveSupplier.Location = new System.Drawing.Point(832, 526);
            this.btnSaveSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveSupplier.Name = "btnSaveSupplier";
            this.btnSaveSupplier.Size = new System.Drawing.Size(102, 35);
            this.btnSaveSupplier.TabIndex = 13;
            this.btnSaveSupplier.Text = "Save";
            this.btnSaveSupplier.UseVisualStyleBackColor = false;
            // 
            // btnResetSupplier
            // 
            this.btnResetSupplier.BackColor = System.Drawing.Color.Red;
            this.btnResetSupplier.Location = new System.Drawing.Point(956, 526);
            this.btnResetSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetSupplier.Name = "btnResetSupplier";
            this.btnResetSupplier.Size = new System.Drawing.Size(102, 35);
            this.btnResetSupplier.TabIndex = 14;
            this.btnResetSupplier.Text = "Reset";
            this.btnResetSupplier.UseVisualStyleBackColor = false;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(192, 374);
            this.lblSupplierID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(76, 16);
            this.lblSupplierID.TabIndex = 15;
            this.lblSupplierID.Text = "Supplier ID:";
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Location = new System.Drawing.Point(192, 409);
            this.lblSupplierCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Size = new System.Drawing.Size(96, 16);
            this.lblSupplierCode.TabIndex = 16;
            this.lblSupplierCode.Text = "Supplier Code:";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(192, 442);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(100, 16);
            this.lblSupplierName.TabIndex = 17;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // lblSupplierItems
            // 
            this.lblSupplierItems.AutoSize = true;
            this.lblSupplierItems.Location = new System.Drawing.Point(192, 474);
            this.lblSupplierItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierItems.Name = "lblSupplierItems";
            this.lblSupplierItems.Size = new System.Drawing.Size(91, 16);
            this.lblSupplierItems.TabIndex = 18;
            this.lblSupplierItems.Text = "Type of Items:";
            // 
            // lblSupplierPhone
            // 
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.Location = new System.Drawing.Point(192, 510);
            this.lblSupplierPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Size = new System.Drawing.Size(70, 16);
            this.lblSupplierPhone.TabIndex = 19;
            this.lblSupplierPhone.Text = "Phone No:";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(316, 374);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(250, 22);
            this.txtSupplierID.TabIndex = 20;
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Location = new System.Drawing.Point(316, 409);
            this.txtSupplierCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(250, 22);
            this.txtSupplierCode.TabIndex = 21;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(316, 442);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(250, 22);
            this.txtSupplierName.TabIndex = 22;
            // 
            // txtSupplierItems
            // 
            this.txtSupplierItems.Location = new System.Drawing.Point(316, 474);
            this.txtSupplierItems.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierItems.Name = "txtSupplierItems";
            this.txtSupplierItems.Size = new System.Drawing.Size(250, 22);
            this.txtSupplierItems.TabIndex = 23;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Location = new System.Drawing.Point(316, 510);
            this.txtSupplierPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(250, 22);
            this.txtSupplierPhone.TabIndex = 24;
            // 
            // rdoSupplierIsActive
            // 
            this.rdoSupplierIsActive.AutoSize = true;
            this.rdoSupplierIsActive.Location = new System.Drawing.Point(614, 375);
            this.rdoSupplierIsActive.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSupplierIsActive.Name = "rdoSupplierIsActive";
            this.rdoSupplierIsActive.Size = new System.Drawing.Size(75, 20);
            this.rdoSupplierIsActive.TabIndex = 25;
            this.rdoSupplierIsActive.TabStop = true;
            this.rdoSupplierIsActive.Text = "IsActive";
            this.rdoSupplierIsActive.UseVisualStyleBackColor = true;
            this.rdoSupplierIsActive.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 570);
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
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChangelog);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.label_staff);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SupplierForm";
            this.Text = "Manage Suppliers List";
            this.Load += new System.EventHandler(this.SupplierFormApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_staff;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnChangelog;
        private System.Windows.Forms.Button btnLogout;
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
    }
}