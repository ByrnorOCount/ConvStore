using System;
using System.Drawing;

namespace ConvStore
{
    public partial class MainForm : MyForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            picLarge.Image = Image.FromFile(Const.IMAGE_DIRECTORY + "box_and_clipboard.png");
            picIcon.Image = Image.FromFile(Const.IMAGE_DIRECTORY + "warehouse.jpg");
            lblTitle.Text = $"Welcome, {UserSession.Username}!";
        }
    }
}
