using BLL;
using DTO;
using GUI.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Order : Form
    {
        GlobalState globalState;
        AccountState accountState;
        public Order()
        {
            InitializeComponent();
            globalState = GlobalState.GetInstance();
            accountState = AccountState.GetInstance();
            // Khởi tạo Timer
            timer1.Interval = 1000; // Cập nhật mỗi giây (1000 milliseconds)
            timer1.Tick += timer1_Tick;
            timer1.Start(); // Bắt đầu Timer
            loadData();
        }

        void loadData()
        {
            List<Table> listTable = TableBLL.Instance.GetListTable();

            foreach (Table item in listTable)
            {
                Button btn = new Button() { Width = 129, Height = 100 };

                // Hiển thị trạng thái dưới dạng chuỗi
                string statusText = (item.StatusTable == 0) ? "Trống" : "Có khách";

                // Gán text cho button
                btn.Text = item.TableName + Environment.NewLine + statusText;
                btn.Tag = item;

                // Thay đổi màu nền dựa trên trạng thái
                btn.BackColor = (item.StatusTable == 0) ? Color.White : Color.Red;

                // Thêm sự kiện Click cho button
                btn.Click += btn_Click;

                flowTableOrder.Controls.Add(btn);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Hiển thị thời gian trên Label dưới định dạng HH:mm:ss
            labelCurrentTime.Text = currentTime.ToString("HH:mm:ss");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ca làm việc?", "Xác nhận thoát", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                // Xử lý đóng form khi ấn "OK"
                this.Close();
            }
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"Kết thúc ca làm việc vào lúc: {DateTime.Now}", "Kết thúc ca làm việc");
            globalState = null;
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ca làm việc?", "Xác nhận thoát", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // Ngăn không cho đóng form khi ấn "Cancel"
            }
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account account = AccountBLL.Instance.GetAccountByUsername(globalState.Username);
            if (account == null)
            {
                this.Close();
            } else
            {
                accountState.Username = account.Username;
                accountState.Password = account.Password;
                accountState.Name = account.Display_Name;
                accountState.Phone = account.Phone;
                accountState.Salary = account.Basic_Salary;
                accountState.Role = account.Role;

                StaffInformationDetail staffInformationDetail = new StaffInformationDetail();
                staffInformationDetail.ShowDialog();
            }
        }

        private void muaMangVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForTable orderForTable = new OrderForTable();
            orderForTable.ShowDialog();
        }

        // lấy giá trị của bàn thông qua click
        private void btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Table table = clickedButton.Tag as Table;
            globalState.TableId = table.Id;
            OrderForTable orderForTable = new OrderForTable();
            orderForTable.ShowDialog();
        }
    }
}
