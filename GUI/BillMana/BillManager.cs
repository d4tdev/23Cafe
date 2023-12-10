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

namespace GUI.BillMana
{
    public partial class BillManager : Form
    {
        public BillManager()
        {
            InitializeComponent();
            showBill();
        }

        public void showBill()
        {
            List<Bill> listBill = BillBLL.Instance.GetAllListBill();

            DataTable dt = new DataTable();

            // tạo ra các cột cho datatable
            dt.Columns.Add("Mã hóa đơn", typeof(int)).ReadOnly = true;
            dt.Columns.Add("Mã bàn", typeof(int)).ReadOnly = true;
            dt.Columns.Add("Ngày vào", typeof(DateTime)).ReadOnly = true;
            dt.Columns.Add("Ngày ra", typeof(DateTime)).ReadOnly = true;
            dt.Columns.Add("Trạng thái", typeof(String)).ReadOnly = true;
            dt.Columns.Add("Tổng tiền", typeof(int)).ReadOnly = true;

            // đổ dữ liệu từ listBill vào datatable
            foreach (Bill item in listBill)
            {
                if(item.Status_Bill == 1)
                {
                       dt.Rows.Add(item.Id, item.Id_Table, item.Date_Checkout, item.Date_Checkout, "Đã thanh toán", item.Total_Price);
                }
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lấy giá trị từ dataTimePicker1 và dataTimePicker2
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;

            DataTable dt = new DataTable();

            // tạo ra các cột cho datatable
            dt.Columns.Add("Mã hóa đơn", typeof(int)).ReadOnly = true;
            dt.Columns.Add("Mã bàn", typeof(int)).ReadOnly = true;
            dt.Columns.Add("Ngày vào", typeof(DateTime)).ReadOnly = true;
            dt.Columns.Add("Ngày ra", typeof(DateTime)).ReadOnly = true;
            dt.Columns.Add("Trạng thái", typeof(String)).ReadOnly = true;
            dt.Columns.Add("Tổng tiền", typeof(int)).ReadOnly = true;

            List<Bill> listBill = BillBLL.Instance.GetAllListBill();
            foreach (Bill item in listBill)
            {
                // so sánh ngày tháng năm của item.Date_Checkin với date1 và date2 
                // không so sanh gio phut giay
                if (item.Date_Checkout.Date >= date1.Date && item.Date_Checkout.Date <= date2.Date)
                {
                    if (item.Status_Bill == 1)
                    {
                        dt.Rows.Add(item.Id, item.Id_Table, item.Date_Checkout, item.Date_Checkout, "Đã thanh toán", item.Total_Price);
                    }
                }
            }

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int billID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.GetHashCode();
            BillInformationDetail billInformationDetail = new BillInformationDetail(billID);
            billInformationDetail.ShowDialog();
        }
    }
}
