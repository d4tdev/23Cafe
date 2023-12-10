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
    public partial class BillInformationDetail : Form
    {
        // Nhận giá trị từ BillManager
        public BillInformationDetail(int billId)
        {
            InitializeComponent();
            
            // hiển thị thông tin hóa đơn
            showBill(billId);
            getInfoBill(billId);
        }

        public void showBill(int billId)
        {
            List<BillInfo> listBillInfo = BillInfoBLL.Instance.GetListByIdBill(billId);
            double totalPrice = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Tên sản phẩm", typeof(string)).ReadOnly = true;
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Thành tiền", typeof(float)).ReadOnly = true;

            foreach (var billInfo in listBillInfo)
            {
                DataRow row = dt.NewRow();
                row["Mã sản phẩm"] = billInfo.Id_Food;
                row["Tên sản phẩm"] = GetNameFoodFromId(billInfo.Id_Food);
                row["Số lượng"] = billInfo.Count;
                row["Thành tiền"] = billInfo.Price;
                dt.Rows.Add(row);
                totalPrice += billInfo.Price;
            }
            dataGridView1.DataSource = dt;

            txtTotal.Text = totalPrice.ToString();
        }

        public void getInfoBill(int billId)
        {
            Bill bill = BillBLL.Instance.GetOneBillById(billId);
            txtBillId.Text = bill.Id.ToString();
            txtTaleId.Text = bill.Id_Table.ToString();
            txtTime.Text = bill.Date_Checkout.ToString();
        }

        public String GetNameFoodFromId(String id)
        {
            List<Food> listFood = FoodBLL.Instance.GetListFood();
            foreach (var food in listFood)
            {
                if (food.Id == id)
                {
                    return food.Food_Name;
                }
            }
            return "";
        }
    }
}
