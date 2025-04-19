namespace ConvStore
{
    partial class ChangeLogForm
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
            this.dgvChangeLog = new System.Windows.Forms.DataGridView();
            this.btnRefreshChangeLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChangeLog
            // 
            this.dgvChangeLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangeLog.Location = new System.Drawing.Point(172, 61);
            this.dgvChangeLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChangeLog.Name = "dgvChangeLog";
            this.dgvChangeLog.RowHeadersWidth = 51;
            this.dgvChangeLog.RowTemplate.Height = 24;
            this.dgvChangeLog.Size = new System.Drawing.Size(893, 458);
            this.dgvChangeLog.TabIndex = 1;
            // 
            // btnRefreshChangeLog
            // 
            this.btnRefreshChangeLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefreshChangeLog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefreshChangeLog.Location = new System.Drawing.Point(527, 524);
            this.btnRefreshChangeLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshChangeLog.Name = "btnRefreshChangeLog";
            this.btnRefreshChangeLog.Size = new System.Drawing.Size(208, 42);
            this.btnRefreshChangeLog.TabIndex = 2;
            this.btnRefreshChangeLog.Text = "Refresh";
            this.btnRefreshChangeLog.UseVisualStyleBackColor = false;
            // 
            // ChangeLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 576);
            this.Controls.Add(this.btnRefreshChangeLog);
            this.Controls.Add(this.dgvChangeLog);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangeLogForm";
            this.Text = "ChangeLog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvChangeLog;
        private System.Windows.Forms.Button btnRefreshChangeLog;
    }
}