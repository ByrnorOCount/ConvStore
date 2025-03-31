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
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_KindOfProduct = new System.Windows.Forms.Label();
            this.lbl_ProductStatus = new System.Windows.Forms.Label();
            this.txt_InventoryID = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.lbl_Inventory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Statistic = new System.Windows.Forms.Button();
            this.lbl_Find = new System.Windows.Forms.Label();
            this.comboBox_Import = new System.Windows.Forms.ComboBox();
            this.comboBox_Supplier = new System.Windows.Forms.ComboBox();
            this.comboBox_Export = new System.Windows.Forms.ComboBox();
            this.lbl_Management = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductID.Location = new System.Drawing.Point(34, 148);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(105, 20);
            this.lbl_ProductID.TabIndex = 0;
            this.lbl_ProductID.Text = "Product ID:";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(34, 190);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(134, 20);
            this.lbl_ProductName.TabIndex = 1;
            this.lbl_ProductName.Text = "Product Name:";
            // 
            // lbl_KindOfProduct
            // 
            this.lbl_KindOfProduct.AutoSize = true;
            this.lbl_KindOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KindOfProduct.Location = new System.Drawing.Point(431, 148);
            this.lbl_KindOfProduct.Name = "lbl_KindOfProduct";
            this.lbl_KindOfProduct.Size = new System.Drawing.Size(126, 20);
            this.lbl_KindOfProduct.TabIndex = 2;
            this.lbl_KindOfProduct.Text = "Product Type:";
            // 
            // lbl_ProductStatus
            // 
            this.lbl_ProductStatus.AutoSize = true;
            this.lbl_ProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductStatus.Location = new System.Drawing.Point(431, 99);
            this.lbl_ProductStatus.Name = "lbl_ProductStatus";
            this.lbl_ProductStatus.Size = new System.Drawing.Size(69, 20);
            this.lbl_ProductStatus.TabIndex = 3;
            this.lbl_ProductStatus.Text = "Status:";
            // 
            // txt_InventoryID
            // 
            this.txt_InventoryID.Location = new System.Drawing.Point(167, 97);
            this.txt_InventoryID.Name = "txt_InventoryID";
            this.txt_InventoryID.Size = new System.Drawing.Size(183, 22);
            this.txt_InventoryID.TabIndex = 4;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(167, 146);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(183, 22);
            this.txt_ProductID.TabIndex = 5;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(167, 188);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(183, 22);
            this.txt_ProductName.TabIndex = 6;
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inventory.Location = new System.Drawing.Point(34, 97);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(116, 20);
            this.lbl_Inventory.TabIndex = 8;
            this.lbl_Inventory.Text = "Inventory ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 9;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(563, 95);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(196, 22);
            this.txt_Status.TabIndex = 10;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(563, 144);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(196, 24);
            this.comboBox_Type.TabIndex = 11;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(38, 277);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(835, 360);
            this.dataGridView.TabIndex = 16;
            // 
            // btn_Add
            // 
            this.btn_Add.AutoSize = true;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(68, 657);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 32);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Modify
            // 
            this.btn_Modify.AutoSize = true;
            this.btn_Modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Modify.Location = new System.Drawing.Point(335, 657);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 32);
            this.btn_Modify.TabIndex = 14;
            this.btn_Modify.Text = "Modify";
            this.btn_Modify.UseVisualStyleBackColor = false;
            // 
            // btn_Remove
            // 
            this.btn_Remove.AutoSize = true;
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Remove.Location = new System.Drawing.Point(200, 657);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(86, 32);
            this.btn_Remove.TabIndex = 13;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AutoSize = true;
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(631, 657);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(76, 32);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Statistic
            // 
            this.btn_Statistic.AutoSize = true;
            this.btn_Statistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Statistic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Statistic.Location = new System.Drawing.Point(469, 657);
            this.btn_Statistic.Name = "btn_Statistic";
            this.btn_Statistic.Size = new System.Drawing.Size(99, 32);
            this.btn_Statistic.TabIndex = 17;
            this.btn_Statistic.Text = "Statistic";
            this.btn_Statistic.UseVisualStyleBackColor = false;
            // 
            // lbl_Find
            // 
            this.lbl_Find.AutoSize = true;
            this.lbl_Find.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Find.Location = new System.Drawing.Point(34, 233);
            this.lbl_Find.Name = "lbl_Find";
            this.lbl_Find.Size = new System.Drawing.Size(130, 22);
            this.lbl_Find.TabIndex = 18;
            this.lbl_Find.Text = "Find Product:";
            // 
            // comboBox_Import
            // 
            this.comboBox_Import.FormattingEnabled = true;
            this.comboBox_Import.Location = new System.Drawing.Point(348, 233);
            this.comboBox_Import.Name = "comboBox_Import";
            this.comboBox_Import.Size = new System.Drawing.Size(131, 24);
            this.comboBox_Import.TabIndex = 19;
            this.comboBox_Import.Text = "Import Day";
            // 
            // comboBox_Supplier
            // 
            this.comboBox_Supplier.FormattingEnabled = true;
            this.comboBox_Supplier.Location = new System.Drawing.Point(170, 233);
            this.comboBox_Supplier.Name = "comboBox_Supplier";
            this.comboBox_Supplier.Size = new System.Drawing.Size(131, 24);
            this.comboBox_Supplier.TabIndex = 19;
            this.comboBox_Supplier.Text = "Supplier";
            // 
            // comboBox_Export
            // 
            this.comboBox_Export.FormattingEnabled = true;
            this.comboBox_Export.Location = new System.Drawing.Point(536, 233);
            this.comboBox_Export.Name = "comboBox_Export";
            this.comboBox_Export.Size = new System.Drawing.Size(131, 24);
            this.comboBox_Export.TabIndex = 19;
            this.comboBox_Export.Text = "Export Day";
            // 
            // lbl_Management
            // 
            this.lbl_Management.BackColor = System.Drawing.Color.Cyan;
            this.lbl_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Management.Location = new System.Drawing.Point(-2, -3);
            this.lbl_Management.Name = "lbl_Management";
            this.lbl_Management.Size = new System.Drawing.Size(939, 75);
            this.lbl_Management.TabIndex = 20;
            this.lbl_Management.Text = "INVENTORY MANAGEMENT";
            this.lbl_Management.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // ProductManagementApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 711);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.lbl_Management);
            this.Controls.Add(this.comboBox_Supplier);
            this.Controls.Add(this.comboBox_Export);
            this.Controls.Add(this.comboBox_Import);
            this.Controls.Add(this.lbl_Find);
            this.Controls.Add(this.btn_Statistic);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Inventory);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.txt_InventoryID);
            this.Controls.Add(this.lbl_ProductStatus);
            this.Controls.Add(this.lbl_KindOfProduct);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_ProductID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductManagementApp";
            this.Text = "ProductManagementApp";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_KindOfProduct;
        private System.Windows.Forms.Label lbl_ProductStatus;
        private System.Windows.Forms.TextBox txt_InventoryID;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label lbl_Inventory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Statistic;
        private System.Windows.Forms.Label lbl_Find;
        private System.Windows.Forms.ComboBox comboBox_Import;
        private System.Windows.Forms.ComboBox comboBox_Supplier;
        private System.Windows.Forms.Label lbl_Management;
        private System.Windows.Forms.ComboBox comboBox_Export;
        private System.Windows.Forms.Button btn_Find;
    }
}

