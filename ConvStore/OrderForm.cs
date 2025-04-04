using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvStore
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("../../images/warehouse.jpg");

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
