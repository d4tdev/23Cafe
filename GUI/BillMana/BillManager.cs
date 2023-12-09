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
            // get month from now
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            double sum = 0;

            List<Bill> listBill = BillBLL.Instance.GetAllListBill();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn", typeof(int)).ReadOnly = true;
            dt.Columns.Add("Mã bàn", typeof(int)).ReadOnly = true;
            dt.Columns.Add("Ngày vào", typeof(DateTime)).ReadOnly = true;
            dt.Columns.Add("Ngày ra", typeof(DateTime)).ReadOnly = true;
            dt.Columns.Add("Trạng thái", typeof(String)).ReadOnly = true;
            dt.Columns.Add("Tổng tiền", typeof(int)).ReadOnly = true;

            foreach (Bill item in listBill)
            {
                if (item.Date_Checkout.Month == month && item.Date_Checkout.Year == year)
                {
                    if (item.Status_Bill == 1)
                    {
                        sum += item.Total_Price;
                        dt.Rows.Add(item.Id, item.Id_Table, item.Date_Checkout, item.Date_Checkout, "Đã thanh toán", item.Total_Price);
                    }
                }
            }

            dataGridView1.DataSource = dt;
            MessageBox.Show("Tổng doanh thu tháng " + month + " năm " + year + " là: " + sum);
        }
    }
}
