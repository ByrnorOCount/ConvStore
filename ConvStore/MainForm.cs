using System;
using System.Drawing;

namespace ConvStore
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            picLarge.Image = Image.FromFile(Util.imgDir + "box_and_clipboard.png");
            picIcon.Image = Image.FromFile(Util.imgDir + "warehouse.jpg");
            lblTitle.Text = $"Welcome, {UserSession.Username}!";
        }
    }
}
