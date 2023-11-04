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
        }

        public void showBill()
        {
            List<Bill> listBill = BillBLL.Instance.GetAllListBill();

            DataTable dt = new DataTable();

            // tạo ra các cột cho datatable
            dt.Columns.Add("Mã hóa đơn", typeof(int));
            dt.Columns.Add("Mã bàn", typeof(int));
            dt.Columns.Add("Ngày vào", typeof(DateTime));
            dt.Columns.Add("Ngày ra", typeof(DateTime));
            dt.Columns.Add("Trạng thái", typeof(int));
            dt.Columns.Add("Tổng tiền", typeof(int));

            // đổ dữ liệu từ listBill vào datatable
            foreach (Bill item in listBill)
            {
                dt.Rows.Add(item.Id, item.Id_Table, item.Date_Checkout, item.Date_Checkout, item.Status_Bill, item.Status_Bill);
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }


    }
}
