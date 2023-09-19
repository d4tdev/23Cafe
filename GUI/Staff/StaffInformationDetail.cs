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
    public partial class StaffInformationDetail : Form
    {
        AccountState accountState;
        GlobalState globalState;
        public StaffInformationDetail()
        {
            InitializeComponent();
            accountState = AccountState.GetInstance();
            globalState = GlobalState.GetInstance();
            labelName.Text = accountState.Name;
            labelPhone.Text = accountState.Phone;

            if(globalState.Role == 1)
            {
                btnDelStaff.Visible = true;
            }
            else if (globalState.Role == 0)
            {
                btnDelStaff.Visible = false;
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            EditStaff editStaff = new EditStaff();
            editStaff.ShowDialog();
        }

        private void btnDelStaff_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (AccountBLL.Instance.DeleteAccount(accountState.Username))
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    accountState = null;
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void StaffInformationDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            accountState = null;
        }
    }
}
