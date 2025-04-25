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
            this.btnAddOrder = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(192, 225);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 72;
            this.dgvOrder.RowTemplate.Height = 31;
            this.dgvOrder.Size = new System.Drawing.Size(1006, 328);
            this.dgvOrder.TabIndex = 9;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelOrder.Location = new System.Drawing.Point(1034, 164);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(164, 45);
            this.btnCancelOrder.TabIndex = 10;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddOrder.Location = new System.Drawing.Point(850, 82);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(104, 48);
            this.btnAddOrder.TabIndex = 11;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateOrder.Location = new System.Drawing.Point(969, 82);
            this.btnUpdateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(104, 48);
            this.btnUpdateOrder.TabIndex = 12;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrder.Location = new System.Drawing.Point(1087, 82);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(104, 48);
            this.btnDeleteOrder.TabIndex = 13;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            // 
            // lblOSupplier
            // 
            this.lblOSupplier.AutoSize = true;
            this.lblOSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOSupplier.Location = new System.Drawing.Point(210, 82);
            this.lblOSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOSupplier.Name = "lblOSupplier";
            this.lblOSupplier.Size = new System.Drawing.Size(96, 28);
            this.lblOSupplier.TabIndex = 14;
            this.lblOSupplier.Text = "Supplier:";
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectProduct.Location = new System.Drawing.Point(220, 131);
            this.lblSelectProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(154, 28);
            this.lblSelectProduct.TabIndex = 15;
            this.lblSelectProduct.Text = "Select Product:";
            // 
            // lblQuanity
            // 
            this.lblQuanity.AutoSize = true;
            this.lblQuanity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuanity.Location = new System.Drawing.Point(220, 178);
            this.lblQuanity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanity.Name = "lblQuanity";
            this.lblQuanity.Size = new System.Drawing.Size(100, 28);
            this.lblQuanity.TabIndex = 16;
            this.lblQuanity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(538, 131);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(146, 28);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price Per Unit:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.Location = new System.Drawing.Point(566, 181);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(109, 28);
            this.lblTotalCost.TabIndex = 18;
            this.lblTotalCost.Text = "Total cost:";
            // 
            // txtQuanity
            // 
            this.txtQuanity.Location = new System.Drawing.Point(325, 181);
            this.txtQuanity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(221, 26);
            this.txtQuanity.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(688, 138);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(221, 26);
            this.txtPrice.TabIndex = 22;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(688, 185);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(221, 26);
            this.txtTotalCost.TabIndex = 23;
            // 
            // cmbOSupplier
            // 
            this.cmbOSupplier.FormattingEnabled = true;
            this.cmbOSupplier.Location = new System.Drawing.Point(327, 82);
            this.cmbOSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOSupplier.Name = "cmbOSupplier";
            this.cmbOSupplier.Size = new System.Drawing.Size(100, 28);
            this.cmbOSupplier.TabIndex = 24;
            // 
            // cmbSelectProduct
            // 
            this.cmbSelectProduct.FormattingEnabled = true;
            this.cmbSelectProduct.Location = new System.Drawing.Point(395, 135);
            this.cmbSelectProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectProduct.Name = "cmbSelectProduct";
            this.cmbSelectProduct.Size = new System.Drawing.Size(100, 28);
            this.cmbSelectProduct.TabIndex = 25;
            // 
            // dgvOrderProducts
            // 
            this.dgvOrderProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProducts.Location = new System.Drawing.Point(192, 556);
            this.dgvOrderProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrderProducts.Name = "dgvOrderProducts";
            this.dgvOrderProducts.RowHeadersWidth = 72;
            this.dgvOrderProducts.RowTemplate.Height = 31;
            this.dgvOrderProducts.Size = new System.Drawing.Size(1006, 162);
            this.dgvOrderProducts.TabIndex = 32;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
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
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.dgvOrder);
            this.Name = "OrderForm";
            this.Text = "OrderFormApp";
            this.Controls.SetChildIndex(this.dgvOrder, 0);
            this.Controls.SetChildIndex(this.btnCancelOrder, 0);
            this.Controls.SetChildIndex(this.btnAddOrder, 0);
            this.Controls.SetChildIndex(this.btnUpdateOrder, 0);
            this.Controls.SetChildIndex(this.btnDeleteOrder, 0);
            this.Controls.SetChildIndex(this.lblOSupplier, 0);
            this.Controls.SetChildIndex(this.lblSelectProduct, 0);
            this.Controls.SetChildIndex(this.lblQuanity, 0);
            this.Controls.SetChildIndex(this.lblPrice, 0);
            this.Controls.SetChildIndex(this.lblTotalCost, 0);
            this.Controls.SetChildIndex(this.txtQuanity, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.txtTotalCost, 0);
            this.Controls.SetChildIndex(this.cmbOSupplier, 0);
            this.Controls.SetChildIndex(this.cmbSelectProduct, 0);
            this.Controls.SetChildIndex(this.dgvOrderProducts, 0);
            this.Controls.SetChildIndex(this.picIcon, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnAddOrder;
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