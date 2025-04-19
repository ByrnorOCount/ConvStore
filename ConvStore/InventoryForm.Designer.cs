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
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductStatus = new System.Windows.Forms.Label();
            this.txtInventoryID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblInventoryID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStatisticProduct = new System.Windows.Forms.Button();
            this.lblFindProduct = new System.Windows.Forms.Label();
            this.cmbImportDay = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbExportDay = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProductID.Location = new System.Drawing.Point(452, 70);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(101, 23);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID:";
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
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProductType.Location = new System.Drawing.Point(700, 70);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(121, 23);
            this.lblProductType.TabIndex = 2;
            this.lblProductType.Text = "Product Type:";
            // 
            // lblProductStatus
            // 
            this.lblProductStatus.AutoSize = true;
            this.lblProductStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProductStatus.Location = new System.Drawing.Point(681, 111);
            this.lblProductStatus.Name = "lblProductStatus";
            this.lblProductStatus.Size = new System.Drawing.Size(65, 23);
            this.lblProductStatus.TabIndex = 3;
            this.lblProductStatus.Text = "Status:";
            // 
            // txtInventoryID
            // 
            this.txtInventoryID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtInventoryID.Location = new System.Drawing.Point(319, 70);
            this.txtInventoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventoryID.Name = "txtInventoryID";
            this.txtInventoryID.Size = new System.Drawing.Size(88, 30);
            this.txtInventoryID.TabIndex = 4;
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtProductID.Location = new System.Drawing.Point(563, 70);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(88, 30);
            this.txtProductID.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtProductName.Location = new System.Drawing.Point(339, 114);
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
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 9;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtStatus.Location = new System.Drawing.Point(782, 109);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(196, 30);
            this.txtStatus.TabIndex = 10;
            // 
            // cmbProductType
            // 
            this.cmbProductType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(847, 68);
            this.cmbProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(196, 31);
            this.cmbProductType.TabIndex = 11;
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(197, 192);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(845, 206);
            this.dgvInventory.TabIndex = 16;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(197, 534);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(86, 33);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.AutoSize = true;
            this.btnModifyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModifyProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifyProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifyProduct.Location = new System.Drawing.Point(596, 534);
            this.btnModifyProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(91, 33);
            this.btnModifyProduct.TabIndex = 14;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = false;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.AutoSize = true;
            this.btnRemoveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveProduct.Location = new System.Drawing.Point(387, 534);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(103, 33);
            this.btnRemoveProduct.TabIndex = 13;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(953, 534);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 33);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnStatisticProduct
            // 
            this.btnStatisticProduct.AutoSize = true;
            this.btnStatisticProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStatisticProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStatisticProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatisticProduct.Location = new System.Drawing.Point(782, 534);
            this.btnStatisticProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatisticProduct.Name = "btnStatisticProduct";
            this.btnStatisticProduct.Size = new System.Drawing.Size(108, 33);
            this.btnStatisticProduct.TabIndex = 17;
            this.btnStatisticProduct.Text = "Statistic";
            this.btnStatisticProduct.UseVisualStyleBackColor = false;
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
            // cmbExportDay
            // 
            this.cmbExportDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbExportDay.FormattingEnabled = true;
            this.cmbExportDay.Location = new System.Drawing.Point(705, 158);
            this.cmbExportDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbExportDay.Name = "cmbExportDay";
            this.cmbExportDay.Size = new System.Drawing.Size(172, 31);
            this.cmbExportDay.TabIndex = 19;
            this.cmbExportDay.Text = "Export Day";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFind.Location = new System.Drawing.Point(898, 158);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(145, 34);
            this.btnFind.TabIndex = 21;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(197, 403);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(845, 126);
            this.dgvProduct.TabIndex = 32;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 576);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbExportDay);
            this.Controls.Add(this.cmbImportDay);
            this.Controls.Add(this.lblFindProduct);
            this.Controls.Add(this.btnStatisticProduct);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblInventoryID);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtInventoryID);
            this.Controls.Add(this.lblProductStatus);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InventoryForm";
            this.Text = "ProductManagementApp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductStatus;
        private System.Windows.Forms.TextBox txtInventoryID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblInventoryID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnStatisticProduct;
        private System.Windows.Forms.Label lblFindProduct;
        private System.Windows.Forms.ComboBox cmbImportDay;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.ComboBox cmbExportDay;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgvProduct;
    }
}

