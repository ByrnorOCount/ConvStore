
namespace ConvStore
{
    partial class ModifyProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblProductionDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblImportLocation;
        private System.Windows.Forms.Label lblCertification;
        private System.Windows.Forms.Label lblPreservation;
        private System.Windows.Forms.Label lblIngredients;

        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtImportLocation;
        private System.Windows.Forms.TextBox txtCertification;
        private System.Windows.Forms.TextBox txtPreservation;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.Button btnUpdate;
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblProductionDate = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblImportLocation = new System.Windows.Forms.Label();
            this.lblCertification = new System.Windows.Forms.Label();
            this.lblPreservation = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();

            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtImportLocation = new System.Windows.Forms.TextBox();
            this.txtCertification = new System.Windows.Forms.TextBox();
            this.txtPreservation = new System.Windows.Forms.TextBox();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            int labelX = 30, inputX = 150, startY = 30, gapY = 40;

            // Setup Labels + Controls
            SetupLabel(this.lblProductID, "Product ID:", labelX, startY + 0 * gapY);
            SetupTextbox(this.txtProductID, inputX, startY + 0 * gapY, true);

            SetupLabel(this.lblName, "Product Name:", labelX, startY + 1 * gapY);
            SetupTextbox(this.txtName, inputX, startY + 1 * gapY);

            SetupLabel(this.lblOrigin, "Origin:", labelX, startY + 2 * gapY);
            SetupTextbox(this.txtOrigin, inputX, startY + 2 * gapY);

            SetupLabel(this.lblProductionDate, "Production Date:", labelX, startY + 3 * gapY);
            SetupDateTime(this.dtpProductionDate, inputX, startY + 3 * gapY);

            SetupLabel(this.lblExpiryDate, "Expiry Date:", labelX, startY + 4 * gapY);
            SetupDateTime(this.dtpExpiryDate, inputX, startY + 4 * gapY);

            SetupLabel(this.lblStatus, "Status:", labelX, startY + 5 * gapY);
            SetupComboBox(this.cmbStatus, inputX, startY + 5 * gapY);

            SetupLabel(this.lblPrice, "Price:", labelX, startY + 6 * gapY);
            SetupTextbox(this.txtPrice, inputX, startY + 6 * gapY);

            SetupLabel(this.lblImportLocation, "Import Location:", labelX, startY + 7 * gapY);
            SetupTextbox(this.txtImportLocation, inputX, startY + 7 * gapY);

            SetupLabel(this.lblCertification, "Certification:", labelX, startY + 8 * gapY);
            SetupTextbox(this.txtCertification, inputX, startY + 8 * gapY);

            SetupLabel(this.lblPreservation, "Preservation:", labelX, startY + 9 * gapY);
            SetupTextbox(this.txtPreservation, inputX, startY + 9 * gapY);

            SetupLabel(this.lblIngredients, "Ingredients:", labelX, startY + 10 * gapY);
            SetupTextbox(this.txtIngredients, inputX, startY + 10 * gapY, false, true);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(50, startY + 12 * gapY); // sửa 11 -> 12
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(170, startY + 12 * gapY); // sửa 11 -> 12
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add controls
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblProductID, txtProductID, lblName, txtName, lblOrigin, txtOrigin,
                lblProductionDate, dtpProductionDate, lblExpiryDate, dtpExpiryDate,
                lblStatus, cmbStatus, lblPrice, txtPrice, lblImportLocation, txtImportLocation,
                lblCertification, txtCertification, lblPreservation, txtPreservation,
                lblIngredients, txtIngredients, btnUpdate, btnCancel
            });

            this.Text = "Modify Product";
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetupLabel(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(120, 22);
        }

        private void SetupTextbox(System.Windows.Forms.TextBox txt, int x, int y, bool readOnly = false, bool multiline = false)
        {
            txt.Location = new System.Drawing.Point(x, y);
            txt.Size = multiline ? new System.Drawing.Size(200, 60) : new System.Drawing.Size(200, 22);
            txt.Multiline = multiline;
            txt.ReadOnly = readOnly;
        }

        private void SetupDateTime(System.Windows.Forms.DateTimePicker dtp, int x, int y)
        {
            dtp.Location = new System.Drawing.Point(x, y);
            dtp.Size = new System.Drawing.Size(200, 22);
        }

        private void SetupComboBox(System.Windows.Forms.ComboBox cmb, int x, int y)
        {
            cmb.Location = new System.Drawing.Point(x, y);
            cmb.Size = new System.Drawing.Size(200, 24);
            cmb.Items.AddRange(new object[] { "Available", "Out of Stock", "Discontinued" });
        }
    }
}
