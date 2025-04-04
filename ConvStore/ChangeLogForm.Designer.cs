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
            this.lblChangeLog = new System.Windows.Forms.Label();
            this.dgvChangeLog = new System.Windows.Forms.DataGridView();
            this.btn_RefreshChangeLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChangeLog
            // 
            this.lblChangeLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblChangeLog.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeLog.Location = new System.Drawing.Point(3, -3);
            this.lblChangeLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeLog.Name = "lblChangeLog";
            this.lblChangeLog.Size = new System.Drawing.Size(1380, 102);
            this.lblChangeLog.TabIndex = 0;
            this.lblChangeLog.Text = "CHANGELOG";
            this.lblChangeLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvChangeLog
            // 
            this.dgvChangeLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangeLog.Location = new System.Drawing.Point(0, 104);
            this.dgvChangeLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChangeLog.Name = "dgvChangeLog";
            this.dgvChangeLog.RowHeadersWidth = 51;
            this.dgvChangeLog.RowTemplate.Height = 24;
            this.dgvChangeLog.Size = new System.Drawing.Size(1383, 644);
            this.dgvChangeLog.TabIndex = 1;
            // 
            // btn_RefreshChangeLog
            // 
            this.btn_RefreshChangeLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_RefreshChangeLog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_RefreshChangeLog.Location = new System.Drawing.Point(590, 756);
            this.btn_RefreshChangeLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RefreshChangeLog.Name = "btn_RefreshChangeLog";
            this.btn_RefreshChangeLog.Size = new System.Drawing.Size(155, 64);
            this.btn_RefreshChangeLog.TabIndex = 2;
            this.btn_RefreshChangeLog.Text = "Refresh";
            this.btn_RefreshChangeLog.UseVisualStyleBackColor = false;
            // 
            // ChangeLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 866);
            this.Controls.Add(this.btn_RefreshChangeLog);
            this.Controls.Add(this.dgvChangeLog);
            this.Controls.Add(this.lblChangeLog);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeLogForm";
            this.Text = "ChangeLog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChangeLog;
        private System.Windows.Forms.DataGridView dgvChangeLog;
        private System.Windows.Forms.Button btn_RefreshChangeLog;
    }
}