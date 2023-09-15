using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Staff
{
    public partial class StaffManager : Form
    {
        public StaffManager()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addStaff.ShowDialog();
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            String search = txtSearchStaff.Text;
            
        }
    }
}
