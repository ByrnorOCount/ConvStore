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
            this.label_staff = new System.Windows.Forms.Label();
            this.button_supplier = new System.Windows.Forms.Button();
            this.button_order = new System.Windows.Forms.Button();
            this.button_Inventory = new System.Windows.Forms.Button();
            this.button_changelog = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_osupplier = new System.Windows.Forms.Label();
            this.label_selectproduct = new System.Windows.Forms.Label();
            this.label_quanity = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.textBox_quanity = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox_osupplier = new System.Windows.Forms.ComboBox();
            this.comboBox_selectproduct = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_staff
            // 
            this.label_staff.BackColor = System.Drawing.Color.Yellow;
            this.label_staff.Location = new System.Drawing.Point(135, 12);
            this.label_staff.Name = "label_staff";
            this.label_staff.Size = new System.Drawing.Size(1330, 77);
            this.label_staff.TabIndex = 2;
            this.label_staff.Text = "STAFF";
            this.label_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_supplier
            // 
            this.button_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_supplier.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_supplier.Location = new System.Drawing.Point(12, 123);
            this.button_supplier.Name = "button_supplier";
            this.button_supplier.Size = new System.Drawing.Size(218, 67);
            this.button_supplier.TabIndex = 4;
            this.button_supplier.Text = "SUPPLIER";
            this.button_supplier.UseVisualStyleBackColor = false;
            // 
            // button_order
            // 
            this.button_order.BackColor = System.Drawing.SystemColors.Info;
            this.button_order.Location = new System.Drawing.Point(12, 222);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(218, 67);
            this.button_order.TabIndex = 5;
            this.button_order.Text = "ORDER";
            this.button_order.UseVisualStyleBackColor = false;
            // 
            // button_Inventory
            // 
            this.button_Inventory.BackColor = System.Drawing.SystemColors.Info;
            this.button_Inventory.Location = new System.Drawing.Point(12, 332);
            this.button_Inventory.Name = "button_Inventory";
            this.button_Inventory.Size = new System.Drawing.Size(218, 67);
            this.button_Inventory.TabIndex = 6;
            this.button_Inventory.Text = "INVENTORY";
            this.button_Inventory.UseVisualStyleBackColor = false;
            // 
            // button_changelog
            // 
            this.button_changelog.BackColor = System.Drawing.SystemColors.Info;
            this.button_changelog.Location = new System.Drawing.Point(12, 448);
            this.button_changelog.Name = "button_changelog";
            this.button_changelog.Size = new System.Drawing.Size(218, 67);
            this.button_changelog.TabIndex = 7;
            this.button_changelog.Text = "CHANGELOG";
            this.button_changelog.UseVisualStyleBackColor = false;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.Info;
            this.button_logout.Location = new System.Drawing.Point(12, 564);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(218, 67);
            this.button_logout.TabIndex = 8;
            this.button_logout.Text = "LOG OUT";
            this.button_logout.UseVisualStyleBackColor = false;
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Location = new System.Drawing.Point(276, 451);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowHeadersWidth = 72;
            this.dataGridView_order.RowTemplate.Height = 31;
            this.dataGridView_order.Size = new System.Drawing.Size(1178, 391);
            this.dataGridView_order.TabIndex = 9;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_cancel.Location = new System.Drawing.Point(1280, 391);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(162, 54);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Cancel Order";
            this.button_cancel.UseVisualStyleBackColor = false;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_save.Location = new System.Drawing.Point(1042, 176);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(126, 55);
            this.button_save.TabIndex = 11;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_update.Location = new System.Drawing.Point(1042, 254);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(126, 56);
            this.button_update.TabIndex = 12;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_delete.Location = new System.Drawing.Point(1042, 338);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(126, 55);
            this.button_delete.TabIndex = 13;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // label_osupplier
            // 
            this.label_osupplier.AutoSize = true;
            this.label_osupplier.Location = new System.Drawing.Point(630, 107);
            this.label_osupplier.Name = "label_osupplier";
            this.label_osupplier.Size = new System.Drawing.Size(90, 25);
            this.label_osupplier.TabIndex = 14;
            this.label_osupplier.Text = "Supplier:";
            // 
            // label_selectproduct
            // 
            this.label_selectproduct.AutoSize = true;
            this.label_selectproduct.Location = new System.Drawing.Point(402, 191);
            this.label_selectproduct.Name = "label_selectproduct";
            this.label_selectproduct.Size = new System.Drawing.Size(145, 25);
            this.label_selectproduct.TabIndex = 15;
            this.label_selectproduct.Text = "Select Product:";
            // 
            // label_quanity
            // 
            this.label_quanity.AutoSize = true;
            this.label_quanity.Location = new System.Drawing.Point(456, 244);
            this.label_quanity.Name = "label_quanity";
            this.label_quanity.Size = new System.Drawing.Size(91, 25);
            this.label_quanity.TabIndex = 16;
            this.label_quanity.Text = "Quantity:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(411, 311);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(136, 25);
            this.label_price.TabIndex = 17;
            this.label_price.Text = "Price Per Unit:";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(444, 375);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(103, 25);
            this.label_total.TabIndex = 18;
            this.label_total.Text = "Total cost:";
            // 
            // textBox_quanity
            // 
            this.textBox_quanity.Location = new System.Drawing.Point(599, 240);
            this.textBox_quanity.Name = "textBox_quanity";
            this.textBox_quanity.Size = new System.Drawing.Size(270, 29);
            this.textBox_quanity.TabIndex = 21;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(599, 307);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(270, 29);
            this.textBox_price.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(599, 371);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(270, 29);
            this.textBox5.TabIndex = 23;
            // 
            // comboBox_osupplier
            // 
            this.comboBox_osupplier.FormattingEnabled = true;
            this.comboBox_osupplier.Location = new System.Drawing.Point(784, 104);
            this.comboBox_osupplier.Name = "comboBox_osupplier";
            this.comboBox_osupplier.Size = new System.Drawing.Size(121, 32);
            this.comboBox_osupplier.TabIndex = 24;
            // 
            // comboBox_selectproduct
            // 
            this.comboBox_selectproduct.FormattingEnabled = true;
            this.comboBox_selectproduct.Location = new System.Drawing.Point(599, 184);
            this.comboBox_selectproduct.Name = "comboBox_selectproduct";
            this.comboBox_selectproduct.Size = new System.Drawing.Size(121, 32);
            this.comboBox_selectproduct.TabIndex = 25;
            // 
            // OrderFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 854);
            this.Controls.Add(this.comboBox_selectproduct);
            this.Controls.Add(this.comboBox_osupplier);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_quanity);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_quanity);
            this.Controls.Add(this.label_selectproduct);
            this.Controls.Add(this.label_osupplier);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.dataGridView_order);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_changelog);
            this.Controls.Add(this.button_Inventory);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.button_supplier);
            this.Controls.Add(this.label_staff);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderFormApp";
            this.Text = "OrderFormApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_staff;
        private System.Windows.Forms.Button button_supplier;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Button button_Inventory;
        private System.Windows.Forms.Button button_changelog;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_osupplier;
        private System.Windows.Forms.Label label_selectproduct;
        private System.Windows.Forms.Label label_quanity;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox textBox_quanity;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox_osupplier;
        private System.Windows.Forms.ComboBox comboBox_selectproduct;
    }
}