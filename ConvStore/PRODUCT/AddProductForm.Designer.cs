
namespace ConvStore
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtImportLocation;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPreservation;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtImportLocation = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtPreservation = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            int labelX = 30, inputX = 150, startY = 30, gapY = 40;

            // Add labels
            string[] labels = new string[] {
                "Product Name:", "Origin:", "Status:", "Price:", "Import Location:", "Category:", "Product ID:", "Production Date:", "Expiry Date:", "Preservation:"
            };

            for (int i = 0; i < labels.Length; i++)
            {
                var lbl = new System.Windows.Forms.Label();
                lbl.Text = labels[i];
                lbl.Location = new System.Drawing.Point(labelX, startY + i * gapY + 5);
                lbl.AutoSize = true;
                this.Controls.Add(lbl);
            }

            this.txtProductName.Location = new System.Drawing.Point(inputX, startY + 0 * gapY);
            this.txtOrigin.Location = new System.Drawing.Point(inputX, startY + 1 * gapY);
            this.cmbStatus.Location = new System.Drawing.Point(inputX, startY + 2 * gapY);
            this.txtPrice.Location = new System.Drawing.Point(inputX, startY + 3 * gapY);
            this.txtImportLocation.Location = new System.Drawing.Point(inputX, startY + 4 * gapY);
            this.txtCategory.Location = new System.Drawing.Point(inputX, startY + 5 * gapY);
            this.txtCode.Location = new System.Drawing.Point(inputX, startY + 6 * gapY);
            this.dtpProductionDate.Location = new System.Drawing.Point(inputX, startY + 7 * gapY);
            this.dtpExpiryDate.Location = new System.Drawing.Point(inputX, startY + 8 * gapY);
            this.txtPreservation.Location = new System.Drawing.Point(inputX, startY + 9 * gapY);

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(70, startY + 10 * gapY);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(200, startY + 10 * gapY);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                txtProductName, txtOrigin, cmbStatus, txtPrice,
                txtImportLocation, txtCategory, txtCode, dtpProductionDate, dtpExpiryDate,
                txtPreservation, btnSave, btnCancel
            });

            this.Text = "Add Product";
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
