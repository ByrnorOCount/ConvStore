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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
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
            this.lblInventoryManagement = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(34, 148);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(105, 20);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(34, 190);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(134, 20);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(431, 148);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(126, 20);
            this.lblProductType.TabIndex = 2;
            this.lblProductType.Text = "Product Type:";
            // 
            // lblProductStatus
            // 
            this.lblProductStatus.AutoSize = true;
            this.lblProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductStatus.Location = new System.Drawing.Point(431, 99);
            this.lblProductStatus.Name = "lblProductStatus";
            this.lblProductStatus.Size = new System.Drawing.Size(69, 20);
            this.lblProductStatus.TabIndex = 3;
            this.lblProductStatus.Text = "Status:";
            // 
            // txtInventoryID
            // 
            this.txtInventoryID.Location = new System.Drawing.Point(167, 97);
            this.txtInventoryID.Name = "txtInventoryID";
            this.txtInventoryID.Size = new System.Drawing.Size(183, 22);
            this.txtInventoryID.TabIndex = 4;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(167, 146);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(183, 22);
            this.txtProductID.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(167, 188);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(183, 22);
            this.txtProductName.TabIndex = 6;
            // 
            // lblInventoryID
            // 
            this.lblInventoryID.AutoSize = true;
            this.lblInventoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryID.Location = new System.Drawing.Point(34, 97);
            this.lblInventoryID.Name = "lblInventoryID";
            this.lblInventoryID.Size = new System.Drawing.Size(116, 20);
            this.lblInventoryID.TabIndex = 8;
            this.lblInventoryID.Text = "Inventory ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 9;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(563, 95);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(196, 22);
            this.txtStatus.TabIndex = 10;
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(563, 144);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(196, 24);
            this.cmbProductType.TabIndex = 11;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(38, 277);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(835, 360);
            this.dgvInventory.TabIndex = 16;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(68, 657);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 32);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.AutoSize = true;
            this.btnModifyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifyProduct.Location = new System.Drawing.Point(335, 657);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(75, 32);
            this.btnModifyProduct.TabIndex = 14;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = false;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.AutoSize = true;
            this.btnRemoveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveProduct.Location = new System.Drawing.Point(200, 657);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(86, 32);
            this.btnRemoveProduct.TabIndex = 13;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(631, 657);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 32);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnStatisticProduct
            // 
            this.btnStatisticProduct.AutoSize = true;
            this.btnStatisticProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStatisticProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatisticProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatisticProduct.Location = new System.Drawing.Point(469, 657);
            this.btnStatisticProduct.Name = "btnStatisticProduct";
            this.btnStatisticProduct.Size = new System.Drawing.Size(99, 32);
            this.btnStatisticProduct.TabIndex = 17;
            this.btnStatisticProduct.Text = "Statistic";
            this.btnStatisticProduct.UseVisualStyleBackColor = false;
            // 
            // lblFindProduct
            // 
            this.lblFindProduct.AutoSize = true;
            this.lblFindProduct.BackColor = System.Drawing.SystemColors.Control;
            this.lblFindProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindProduct.Location = new System.Drawing.Point(34, 233);
            this.lblFindProduct.Name = "lblFindProduct";
            this.lblFindProduct.Size = new System.Drawing.Size(130, 22);
            this.lblFindProduct.TabIndex = 18;
            this.lblFindProduct.Text = "Find Product:";
            // 
            // cmbImportDay
            // 
            this.cmbImportDay.FormattingEnabled = true;
            this.cmbImportDay.Location = new System.Drawing.Point(348, 233);
            this.cmbImportDay.Name = "cmbImportDay";
            this.cmbImportDay.Size = new System.Drawing.Size(131, 24);
            this.cmbImportDay.TabIndex = 19;
            this.cmbImportDay.Text = "Import Day";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(170, 233);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(131, 24);
            this.cmbSupplier.TabIndex = 19;
            this.cmbSupplier.Text = "Supplier";
            // 
            // cmbExportDay
            // 
            this.cmbExportDay.FormattingEnabled = true;
            this.cmbExportDay.Location = new System.Drawing.Point(536, 233);
            this.cmbExportDay.Name = "cmbExportDay";
            this.cmbExportDay.Size = new System.Drawing.Size(131, 24);
            this.cmbExportDay.TabIndex = 19;
            this.cmbExportDay.Text = "Export Day";
            // 
            // lblInventoryManagement
            // 
            this.lblInventoryManagement.BackColor = System.Drawing.Color.Cyan;
            this.lblInventoryManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryManagement.Location = new System.Drawing.Point(-2, -3);
            this.lblInventoryManagement.Name = "lblInventoryManagement";
            this.lblInventoryManagement.Size = new System.Drawing.Size(939, 75);
            this.lblInventoryManagement.TabIndex = 20;
            this.lblInventoryManagement.Text = "INVENTORY MANAGEMENT";
            this.lblInventoryManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Location = new System.Drawing.Point(704, 233);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(90, 26);
            this.btn_Find.TabIndex = 21;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = false;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 711);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.lblInventoryManagement);
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
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
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnStatisticProduct;
        private System.Windows.Forms.Label lblFindProduct;
        private System.Windows.Forms.ComboBox cmbImportDay;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblInventoryManagement;
        private System.Windows.Forms.ComboBox cmbExportDay;
        private System.Windows.Forms.Button btn_Find;
    }
}

