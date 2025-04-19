namespace ConvStore
{
    partial class OrderForm
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.lblOSupplier = new System.Windows.Forms.Label();
            this.lblSelectProduct = new System.Windows.Forms.Label();
            this.lblQuanity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtQuanity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.cmbOSupplier = new System.Windows.Forms.ComboBox();
            this.cmbSelectProduct = new System.Windows.Forms.ComboBox();
            this.dgvOrderProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(171, 180);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 72;
            this.dgvOrder.RowTemplate.Height = 31;
            this.dgvOrder.Size = new System.Drawing.Size(894, 262);
            this.dgvOrder.TabIndex = 9;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelOrder.Location = new System.Drawing.Point(919, 131);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(146, 36);
            this.btnCancelOrder.TabIndex = 10;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSaveOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveOrder.Location = new System.Drawing.Point(756, 66);
            this.btnSaveOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(92, 38);
            this.btnSaveOrder.TabIndex = 11;
            this.btnSaveOrder.Text = "Save";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateOrder.Location = new System.Drawing.Point(863, 66);
            this.btnUpdateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(92, 38);
            this.btnUpdateOrder.TabIndex = 12;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrder.Location = new System.Drawing.Point(966, 66);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(92, 38);
            this.btnDeleteOrder.TabIndex = 13;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            // 
            // lblOSupplier
            // 
            this.lblOSupplier.AutoSize = true;
            this.lblOSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOSupplier.Location = new System.Drawing.Point(187, 66);
            this.lblOSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOSupplier.Name = "lblOSupplier";
            this.lblOSupplier.Size = new System.Drawing.Size(84, 23);
            this.lblOSupplier.TabIndex = 14;
            this.lblOSupplier.Text = "Supplier:";
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectProduct.Location = new System.Drawing.Point(196, 105);
            this.lblSelectProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(131, 23);
            this.lblSelectProduct.TabIndex = 15;
            this.lblSelectProduct.Text = "Select Product:";
            // 
            // lblQuanity
            // 
            this.lblQuanity.AutoSize = true;
            this.lblQuanity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuanity.Location = new System.Drawing.Point(196, 142);
            this.lblQuanity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanity.Name = "lblQuanity";
            this.lblQuanity.Size = new System.Drawing.Size(85, 23);
            this.lblQuanity.TabIndex = 16;
            this.lblQuanity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(478, 105);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(123, 23);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price Per Unit:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.Location = new System.Drawing.Point(503, 145);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(91, 23);
            this.lblTotalCost.TabIndex = 18;
            this.lblTotalCost.Text = "Total cost:";
            // 
            // txtQuanity
            // 
            this.txtQuanity.Location = new System.Drawing.Point(289, 145);
            this.txtQuanity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(197, 22);
            this.txtQuanity.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(612, 110);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(197, 22);
            this.txtPrice.TabIndex = 22;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(612, 148);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(197, 22);
            this.txtTotalCost.TabIndex = 23;
            // 
            // cmbOSupplier
            // 
            this.cmbOSupplier.FormattingEnabled = true;
            this.cmbOSupplier.Location = new System.Drawing.Point(291, 66);
            this.cmbOSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOSupplier.Name = "cmbOSupplier";
            this.cmbOSupplier.Size = new System.Drawing.Size(89, 24);
            this.cmbOSupplier.TabIndex = 24;
            // 
            // cmbSelectProduct
            // 
            this.cmbSelectProduct.FormattingEnabled = true;
            this.cmbSelectProduct.Location = new System.Drawing.Point(351, 108);
            this.cmbSelectProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectProduct.Name = "cmbSelectProduct";
            this.cmbSelectProduct.Size = new System.Drawing.Size(89, 24);
            this.cmbSelectProduct.TabIndex = 25;
            // 
            // dgvOrderProducts
            // 
            this.dgvOrderProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProducts.Location = new System.Drawing.Point(171, 445);
            this.dgvOrderProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrderProducts.Name = "dgvOrderProducts";
            this.dgvOrderProducts.RowHeadersWidth = 72;
            this.dgvOrderProducts.RowTemplate.Height = 31;
            this.dgvOrderProducts.Size = new System.Drawing.Size(894, 130);
            this.dgvOrderProducts.TabIndex = 32;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 576);
            this.Controls.Add(this.dgvOrderProducts);
            this.Controls.Add(this.cmbSelectProduct);
            this.Controls.Add(this.cmbOSupplier);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuanity);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuanity);
            this.Controls.Add(this.lblSelectProduct);
            this.Controls.Add(this.lblOSupplier);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.dgvOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderForm";
            this.Text = "OrderFormApp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label lblOSupplier;
        private System.Windows.Forms.Label lblSelectProduct;
        private System.Windows.Forms.Label lblQuanity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtQuanity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.ComboBox cmbOSupplier;
        private System.Windows.Forms.ComboBox cmbSelectProduct;
        private System.Windows.Forms.DataGridView dgvOrderProducts;
    }
}