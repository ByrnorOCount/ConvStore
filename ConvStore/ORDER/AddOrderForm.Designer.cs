
namespace ConvStore
{
    partial class AddOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "AddOrderForm";

            this.txtOrderer = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.dtpDeliveryTime = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTypeOfGoods = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            int labelX = 30, inputX = 150, startY = 30, gapY = 40;

            string[] labels = new string[] {
                "Orderer:",
                "Supplier:",
                "Delivery Time:",
                "Status:",
                "Quantity:",
                "Price:",
                "Type of Goods:"
            };

            System.Windows.Forms.Control[] controls = new System.Windows.Forms.Control[]
            {
                txtOrderer,
                txtSupplier,
                dtpDeliveryTime,
                cmbStatus,
                txtQuantity,
                txtPrice,
                txtTypeOfGoods
            };

            int len = labels.Length;
            for (int i = 0; i < len; i++)
            {
                var lbl = new System.Windows.Forms.Label();
                lbl.Text = labels[i];
                lbl.Location = new System.Drawing.Point(labelX, startY + i * gapY + 5);
                lbl.AutoSize = true;
                this.Controls.Add(lbl);
                var ctrl = controls[i];
                ctrl.Location = new System.Drawing.Point(inputX, startY + i * gapY);
                this.Controls.Add(ctrl);
            }

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(70, startY + (len + 1) * gapY);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.Controls.Add(btnSave);

            this.Text = "Add Order";
            this.ClientSize = new System.Drawing.Size(450, startY + (len + 2) * gapY);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderer;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTime;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTypeOfGoods;
        private System.Windows.Forms.Button btnSave;
    }
}