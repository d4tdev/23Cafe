using BLL;
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
        AccountState accountState;
        GlobalState globalState;
        public EditStaff()
        {
            InitializeComponent();
            // load data from account state
            accountState = AccountState.GetInstance();
            globalState = GlobalState.GetInstance();
            txtUsername.Text = accountState.Username;
            txtPassword.Text = accountState.Password;
            txtName.Text = accountState.Name;
            txtPhone.Text = accountState.Phone;
            txtSalary.Text = accountState.Salary.ToString();

            if (globalState.Role == 0)
            {
                txtName.Enabled = false;
                txtPassword.Enabled = false;
                txtSalary.Enabled = false;
            }
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
                if (password != accountState.Password)
                {
                    if(MessageBox.Show("Bạn có chắc muốn đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (AccountBLL.Instance.ResetPassword(password, username))
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            accountState.Password = password;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }   
                }

                if (AccountBLL.Instance.UpdateAccount(username, name, 0, phone, salary))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    accountState.Name = name;
                    accountState.Phone = phone;
                    accountState.Salary = salary;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            accountState = null;
        }
    }
}
