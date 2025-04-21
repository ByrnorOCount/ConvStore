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
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnResetFields = new System.Windows.Forms.Button();
            this.lblSupplierEmail = new System.Windows.Forms.Label();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierPhone = new System.Windows.Forms.Label();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.chkSupplierIsActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(220, 92);
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
            this.btnAddSupplier.Location = new System.Drawing.Point(260, 408);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(106, 48);
            this.btnAddSupplier.TabIndex = 10;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateSupplier.Location = new System.Drawing.Point(435, 408);
            this.btnUpdateSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(106, 48);
            this.btnUpdateSupplier.TabIndex = 11;
            this.btnUpdateSupplier.Text = "Update";
            this.btnUpdateSupplier.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSupplier.Location = new System.Drawing.Point(610, 408);
            this.btnDeleteSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(106, 48);
            this.btnDeleteSupplier.TabIndex = 12;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            // 
            // btnResetFields
            // 
            this.btnResetFields.BackColor = System.Drawing.Color.Peru;
            this.btnResetFields.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnResetFields.Location = new System.Drawing.Point(260, 662);
            this.btnResetFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetFields.Name = "btnResetFields";
            this.btnResetFields.Size = new System.Drawing.Size(149, 32);
            this.btnResetFields.TabIndex = 14;
            this.btnResetFields.Text = "Reset Fields";
            this.btnResetFields.UseVisualStyleBackColor = false;
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupplierEmail.Location = new System.Drawing.Point(259, 520);
            this.lblSupplierEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(153, 28);
            this.lblSupplierEmail.TabIndex = 15;
            this.lblSupplierEmail.Text = "Supplier Email:";
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupplierCode.Location = new System.Drawing.Point(264, 571);
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
            this.lblSupplierName.Location = new System.Drawing.Point(255, 470);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(157, 28);
            this.lblSupplierName.TabIndex = 17;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // lblSupplierPhone
            // 
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupplierPhone.Location = new System.Drawing.Point(218, 617);
            this.lblSupplierPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Size = new System.Drawing.Size(194, 28);
            this.lblSupplierPhone.TabIndex = 19;
            this.lblSupplierPhone.Text = "Supplier Phone No:";
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Location = new System.Drawing.Point(435, 522);
            this.txtSupplierEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(281, 26);
            this.txtSupplierEmail.TabIndex = 20;
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Location = new System.Drawing.Point(435, 571);
            this.txtSupplierCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(281, 26);
            this.txtSupplierCode.TabIndex = 21;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(435, 474);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(281, 26);
            this.txtSupplierName.TabIndex = 22;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Location = new System.Drawing.Point(435, 621);
            this.txtSupplierPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(281, 26);
            this.txtSupplierPhone.TabIndex = 24;
            // 
            // chkSupplierIsActive
            // 
            this.chkSupplierIsActive.AutoSize = true;
            this.chkSupplierIsActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkSupplierIsActive.Location = new System.Drawing.Point(435, 662);
            this.chkSupplierIsActive.Name = "chkSupplierIsActive";
            this.chkSupplierIsActive.Size = new System.Drawing.Size(232, 32);
            this.chkSupplierIsActive.TabIndex = 26;
            this.chkSupplierIsActive.Text = "Is an Active Supplier";
            this.chkSupplierIsActive.UseVisualStyleBackColor = true;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.chkSupplierIsActive);
            this.Controls.Add(this.txtSupplierPhone);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierCode);
            this.Controls.Add(this.txtSupplierEmail);
            this.Controls.Add(this.lblSupplierPhone);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblSupplierCode);
            this.Controls.Add(this.lblSupplierEmail);
            this.Controls.Add(this.btnResetFields);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnUpdateSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.dgvSupplier);
            this.Name = "SupplierForm";
            this.Text = "Manage Suppliers List";
            this.Controls.SetChildIndex(this.dgvSupplier, 0);
            this.Controls.SetChildIndex(this.btnAddSupplier, 0);
            this.Controls.SetChildIndex(this.btnUpdateSupplier, 0);
            this.Controls.SetChildIndex(this.btnDeleteSupplier, 0);
            this.Controls.SetChildIndex(this.btnResetFields, 0);
            this.Controls.SetChildIndex(this.lblSupplierEmail, 0);
            this.Controls.SetChildIndex(this.lblSupplierCode, 0);
            this.Controls.SetChildIndex(this.lblSupplierName, 0);
            this.Controls.SetChildIndex(this.lblSupplierPhone, 0);
            this.Controls.SetChildIndex(this.txtSupplierEmail, 0);
            this.Controls.SetChildIndex(this.txtSupplierCode, 0);
            this.Controls.SetChildIndex(this.txtSupplierName, 0);
            this.Controls.SetChildIndex(this.txtSupplierPhone, 0);
            this.Controls.SetChildIndex(this.picIcon, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.chkSupplierIsActive, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnResetFields;
        private System.Windows.Forms.Label lblSupplierEmail;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierPhone;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.CheckBox chkSupplierIsActive;
    }
}