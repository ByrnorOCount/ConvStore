namespace ConvStore
{
    partial class InventoryForm
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductStatus = new System.Windows.Forms.Label();
            this.txtInventoryID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblInventoryID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFindProduct = new System.Windows.Forms.Label();
            this.cmbImportDay = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(193, 116);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(130, 23);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductStatus
            // 
            this.lblProductStatus.AutoSize = true;
            this.lblProductStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProductStatus.Location = new System.Drawing.Point(652, 70);
            this.lblProductStatus.Name = "lblProductStatus";
            this.lblProductStatus.Size = new System.Drawing.Size(65, 23);
            this.lblProductStatus.TabIndex = 3;
            this.lblProductStatus.Text = "Status:";
            // 
            // txtInventoryID
            // 
            this.txtInventoryID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtInventoryID.Location = new System.Drawing.Point(343, 70);
            this.txtInventoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventoryID.Name = "txtInventoryID";
            this.txtInventoryID.Size = new System.Drawing.Size(88, 30);
            this.txtInventoryID.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtProductName.Location = new System.Drawing.Point(343, 113);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(232, 30);
            this.txtProductName.TabIndex = 6;
            // 
            // lblInventoryID
            // 
            this.lblInventoryID.AutoSize = true;
            this.lblInventoryID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInventoryID.Location = new System.Drawing.Point(193, 70);
            this.lblInventoryID.Name = "lblInventoryID";
            this.lblInventoryID.Size = new System.Drawing.Size(115, 23);
            this.lblInventoryID.TabIndex = 8;
            this.lblInventoryID.Text = "Inventory ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 9;
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(197, 192);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(845, 174);
            this.dgvInventory.TabIndex = 16;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(197, 520);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(86, 33);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.AutoSize = true;
            this.btnModifyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModifyProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifyProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifyProduct.Location = new System.Drawing.Point(596, 520);
            this.btnModifyProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(91, 33);
            this.btnModifyProduct.TabIndex = 14;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = false;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.AutoSize = true;
            this.btnRemoveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveProduct.Location = new System.Drawing.Point(387, 520);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(103, 33);
            this.btnRemoveProduct.TabIndex = 13;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(822, 520);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 33);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFindProduct
            // 
            this.lblFindProduct.AutoSize = true;
            this.lblFindProduct.BackColor = System.Drawing.SystemColors.Control;
            this.lblFindProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFindProduct.Location = new System.Drawing.Point(193, 160);
            this.lblFindProduct.Name = "lblFindProduct";
            this.lblFindProduct.Size = new System.Drawing.Size(118, 23);
            this.lblFindProduct.TabIndex = 18;
            this.lblFindProduct.Text = "Find Product:";
            // 
            // cmbImportDay
            // 
            this.cmbImportDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbImportDay.FormattingEnabled = true;
            this.cmbImportDay.Location = new System.Drawing.Point(508, 158);
            this.cmbImportDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbImportDay.Name = "cmbImportDay";
            this.cmbImportDay.Size = new System.Drawing.Size(179, 31);
            this.cmbImportDay.TabIndex = 19;
            this.cmbImportDay.Text = "Import Day";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(320, 158);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(170, 31);
            this.cmbSupplier.TabIndex = 19;
            this.cmbSupplier.Text = "Supplier";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFind.Location = new System.Drawing.Point(745, 154);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(145, 34);
            this.btnFind.TabIndex = 21;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(197, 370);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(845, 146);
            this.dgvProduct.TabIndex = 32;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(723, 72);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(177, 28);
            this.cmbStatus.TabIndex = 33;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 576);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbImportDay);
            this.Controls.Add(this.lblFindProduct);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblInventoryID);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtInventoryID);
            this.Controls.Add(this.lblProductStatus);
            this.Controls.Add(this.lblProductName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InventoryForm";
            this.Text = "ProductManagementApp";
            this.Controls.SetChildIndex(this.lblProductName, 0);
            this.Controls.SetChildIndex(this.lblProductStatus, 0);
            this.Controls.SetChildIndex(this.txtInventoryID, 0);
            this.Controls.SetChildIndex(this.txtProductName, 0);
            this.Controls.SetChildIndex(this.lblInventoryID, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnAddProduct, 0);
            this.Controls.SetChildIndex(this.btnRemoveProduct, 0);
            this.Controls.SetChildIndex(this.btnModifyProduct, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.dgvInventory, 0);
            this.Controls.SetChildIndex(this.lblFindProduct, 0);
            this.Controls.SetChildIndex(this.cmbImportDay, 0);
            this.Controls.SetChildIndex(this.cmbSupplier, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.dgvProduct, 0);
            this.Controls.SetChildIndex(this.picIcon, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.cmbStatus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductStatus;
        private System.Windows.Forms.TextBox txtInventoryID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblInventoryID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblFindProduct;
        private System.Windows.Forms.ComboBox cmbImportDay;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}

