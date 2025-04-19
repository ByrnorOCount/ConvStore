using System.Drawing;

namespace ConvStore
{
    partial class MainForm
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
            this.picLarge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // picLarge
            // 
            this.picLarge.Location = new System.Drawing.Point(181, 62);
            this.picLarge.Margin = new System.Windows.Forms.Padding(2);
            this.picLarge.Name = "picLarge";
            this.picLarge.Size = new System.Drawing.Size(884, 515);
            this.picLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLarge.TabIndex = 2;
            this.picLarge.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 576);
            this.Controls.Add(this.picLarge);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.picLarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picLarge;
    }
}