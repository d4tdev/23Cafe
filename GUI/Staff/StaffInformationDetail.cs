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
    public partial class StaffInformationDetail : Form
    {
        public StaffInformationDetail()
        {
            InitializeComponent();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            EditStaff editStaff = new EditStaff();
            editStaff.ShowDialog();
        }
    }
}
