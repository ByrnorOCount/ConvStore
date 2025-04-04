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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnChangelog = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblStaff
            // 
            this.lblStaff.BackColor = System.Drawing.Color.Yellow;
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(135, 12);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(1330, 76);
            this.lblStaff.TabIndex = 2;
            this.lblStaff.Text = "STAFF";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupplier.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSupplier.Location = new System.Drawing.Point(12, 123);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(219, 68);
            this.btnSupplier.TabIndex = 4;
            this.btnSupplier.Text = "SUPPLIER";
            this.btnSupplier.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.Info;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOrder.Location = new System.Drawing.Point(12, 222);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(219, 68);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.Info;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInventory.Location = new System.Drawing.Point(12, 332);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(219, 68);
            this.btnInventory.TabIndex = 6;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnChangelog
            // 
            this.btnChangelog.BackColor = System.Drawing.SystemColors.Info;
            this.btnChangelog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangelog.Location = new System.Drawing.Point(12, 448);
            this.btnChangelog.Name = "btnChangelog";
            this.btnChangelog.Size = new System.Drawing.Size(219, 68);
            this.btnChangelog.TabIndex = 7;
            this.btnChangelog.Text = "CHANGELOG";
            this.btnChangelog.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(12, 564);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(219, 68);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(276, 452);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 72;
            this.dgvOrder.RowTemplate.Height = 31;
            this.dgvOrder.Size = new System.Drawing.Size(1178, 392);
            this.dgvOrder.TabIndex = 9;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelOrder.Location = new System.Drawing.Point(1242, 392);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(200, 54);
            this.btnCancelOrder.TabIndex = 10;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSaveOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveOrder.Location = new System.Drawing.Point(1042, 176);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(126, 56);
            this.btnSaveOrder.TabIndex = 11;
            this.btnSaveOrder.Text = "Save";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateOrder.Location = new System.Drawing.Point(1042, 254);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(126, 56);
            this.btnUpdateOrder.TabIndex = 12;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrder.Location = new System.Drawing.Point(1042, 338);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(126, 56);
            this.btnDeleteOrder.TabIndex = 13;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            // 
            // lblOSupplier
            // 
            this.lblOSupplier.AutoSize = true;
            this.lblOSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOSupplier.Location = new System.Drawing.Point(630, 106);
            this.lblOSupplier.Name = "lblOSupplier";
            this.lblOSupplier.Size = new System.Drawing.Size(117, 32);
            this.lblOSupplier.TabIndex = 14;
            this.lblOSupplier.Text = "Supplier:";
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectProduct.Location = new System.Drawing.Point(384, 184);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(186, 32);
            this.lblSelectProduct.TabIndex = 15;
            this.lblSelectProduct.Text = "Select Product:";
            // 
            // lblQuanity
            // 
            this.lblQuanity.AutoSize = true;
            this.lblQuanity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuanity.Location = new System.Drawing.Point(456, 244);
            this.lblQuanity.Name = "lblQuanity";
            this.lblQuanity.Size = new System.Drawing.Size(120, 32);
            this.lblQuanity.TabIndex = 16;
            this.lblQuanity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(393, 308);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(177, 32);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price Per Unit:";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.Location = new System.Drawing.Point(439, 370);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(131, 32);
            this.lblTotalCost.TabIndex = 18;
            this.lblTotalCost.Text = "Total cost:";
            // 
            // txtQuanity
            // 
            this.txtQuanity.Location = new System.Drawing.Point(600, 240);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(269, 29);
            this.txtQuanity.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(600, 308);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(269, 29);
            this.txtPrice.TabIndex = 22;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(600, 370);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(269, 29);
            this.txtTotalCost.TabIndex = 23;
            // 
            // cmbOSupplier
            // 
            this.cmbOSupplier.FormattingEnabled = true;
            this.cmbOSupplier.Location = new System.Drawing.Point(784, 104);
            this.cmbOSupplier.Name = "cmbOSupplier";
            this.cmbOSupplier.Size = new System.Drawing.Size(121, 32);
            this.cmbOSupplier.TabIndex = 24;
            // 
            // cmbSelectProduct
            // 
            this.cmbSelectProduct.FormattingEnabled = true;
            this.cmbSelectProduct.Location = new System.Drawing.Point(600, 184);
            this.cmbSelectProduct.Name = "cmbSelectProduct";
            this.cmbSelectProduct.Size = new System.Drawing.Size(121, 32);
            this.cmbSelectProduct.TabIndex = 25;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 854);
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
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChangelog);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderForm";
            this.Text = "OrderFormApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnChangelog;
        private System.Windows.Forms.Button btnLogout;
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
    }
}