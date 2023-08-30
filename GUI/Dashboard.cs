using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNaviOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order order = new Order();
            order.ShowDialog();
            this.Show();
        }
    }
}
