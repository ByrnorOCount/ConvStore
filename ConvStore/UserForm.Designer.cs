namespace ConvStore
{
    partial class UserForm
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
            this.dgvNotification = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_staff = new System.Windows.Forms.Label();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangelog = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblStoreBranch = new System.Windows.Forms.Label();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.cmbStoreBranch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotification
            // 
            this.dgvNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotification.Location = new System.Drawing.Point(324, 312);
            this.dgvNotification.Name = "dgvNotification";
            this.dgvNotification.RowHeadersWidth = 72;
            this.dgvNotification.RowTemplate.Height = 31;
            this.dgvNotification.Size = new System.Drawing.Size(998, 466);
            this.dgvNotification.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_staff
            // 
            this.label_staff.BackColor = System.Drawing.Color.Yellow;
            this.label_staff.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staff.Location = new System.Drawing.Point(135, 12);
            this.label_staff.Name = "label_staff";
            this.label_staff.Size = new System.Drawing.Size(1330, 76);
            this.label_staff.TabIndex = 3;
            this.label_staff.Text = "STAFF";
            this.label_staff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupplier.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSupplier.Location = new System.Drawing.Point(12, 131);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(217, 68);
            this.btnSupplier.TabIndex = 5;
            this.btnSupplier.Text = "SUPPLIER";
            this.btnSupplier.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.Info;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOrder.Location = new System.Drawing.Point(12, 248);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(217, 68);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(12, 589);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(217, 68);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnChangelog
            // 
            this.btnChangelog.BackColor = System.Drawing.SystemColors.Info;
            this.btnChangelog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangelog.Location = new System.Drawing.Point(12, 479);
            this.btnChangelog.Name = "btnChangelog";
            this.btnChangelog.Size = new System.Drawing.Size(217, 68);
            this.btnChangelog.TabIndex = 11;
            this.btnChangelog.Text = "CHANGELOG";
            this.btnChangelog.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.Info;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInventory.Location = new System.Drawing.Point(12, 362);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(217, 68);
            this.btnInventory.TabIndex = 10;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(494, 99);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(98, 32);
            this.lblUserID.TabIndex = 13;
            this.lblUserID.Text = "UserID:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(521, 167);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(71, 32);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "Role:";
            // 
            // lblStoreBranch
            // 
            this.lblStoreBranch.AutoSize = true;
            this.lblStoreBranch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStoreBranch.Location = new System.Drawing.Point(433, 237);
            this.lblStoreBranch.Name = "lblStoreBranch";
            this.lblStoreBranch.Size = new System.Drawing.Size(159, 32);
            this.lblStoreBranch.TabIndex = 15;
            this.lblStoreBranch.Text = "StoreBranch:";
            // 
            // cmbUserID
            // 
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(653, 99);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(300, 32);
            this.cmbUserID.TabIndex = 16;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(653, 167);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(300, 32);
            this.cmbRole.TabIndex = 17;
            // 
            // cmbStoreBranch
            // 
            this.cmbStoreBranch.FormattingEnabled = true;
            this.cmbStoreBranch.Location = new System.Drawing.Point(653, 237);
            this.cmbStoreBranch.Name = "cmbStoreBranch";
            this.cmbStoreBranch.Size = new System.Drawing.Size(300, 32);
            this.cmbStoreBranch.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1171, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Notification";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 812);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStoreBranch);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbUserID);
            this.Controls.Add(this.lblStoreBranch);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChangelog);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.label_staff);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvNotification);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotification;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_staff;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangelog;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblStoreBranch;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.ComboBox cmbStoreBranch;
        private System.Windows.Forms.Label label1;
    }
}