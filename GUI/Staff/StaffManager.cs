using BLL;
using DTO;
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
            loadData();
        }

        public void loadData()
        {
            List<Account> listAccount = AccountBLL.Instance.GetAccounts();
            DataTable dt = new DataTable();

            dt.Columns.Add("Tên đăng nhập", typeof(string));
            dt.Columns.Add("Mật khẩu", typeof(string));
            dt.Columns.Add("Họ và tên", typeof(string));
            dt.Columns.Add("Số điện thoại", typeof(string));
            dt.Columns.Add("Lương cơ bản", typeof(int));

            foreach (var account in listAccount)
            {
                DataRow row = dt.NewRow();
                row["Tên đăng nhập"] = account.Username;
                row["Mật khẩu"] = account.Password;
                row["Họ và tên"] = account.Display_Name;
                row["Số điện thoại"] = account.Phone;
                row["Lương cơ bản"] = account.Basic_Salary;
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
        }

        // thêm giá trị vào account state
        public void saveAccountState()
        {
            AccountState accountState = AccountState.GetInstance();
            accountState.Username = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            accountState.Password = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            accountState.Name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            accountState.Phone = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            accountState.Salary = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
        }


        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addStaff.ShowDialog();
            loadData();
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            String search = txtSearchStaff.Text;
            List<Account> listAccount = AccountBLL.Instance.SearchListAccounts(search);
            DataTable dt = new DataTable();

            dt.Columns.Add("Tên đăng nhập", typeof(string));
            dt.Columns.Add("Mật khẩu", typeof(string));
            dt.Columns.Add("Họ và tên", typeof(string));
            dt.Columns.Add("Số điện thoại", typeof(string));
            dt.Columns.Add("Lương cơ bản", typeof(int));

            foreach (var account in listAccount)
            {
                DataRow row = dt.NewRow();
                row["Tên đăng nhập"] = account.Username;
                row["Mật khẩu"] = account.Password;
                row["Họ và tên"] = account.Display_Name;
                row["Số điện thoại"] = account.Phone;
                row["Lương cơ bản"] = account.Basic_Salary;
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            saveAccountState();
            StaffInformationDetail staffInformationDetail = new StaffInformationDetail();
            staffInformationDetail.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            saveAccountState();
            StaffInformationDetail staffInformationDetail = new StaffInformationDetail();
            staffInformationDetail.ShowDialog();
            loadData();
        }
    }
}
