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
    public partial class EditStaff : Form
    {
        public EditStaff()
        {
            InitializeComponent();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String name = txtName.Text;
            String phone = txtPhone.Text;
            int salary = int.Parse(txtSalary.Text);

            if (username == null || password == null || name == null || phone == null || salary == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Staff edited successfully!");
            }
        }
    }
}
