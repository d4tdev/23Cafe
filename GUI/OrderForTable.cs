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

namespace GUI
{
    public partial class OrderForTable : Form
    {
        GlobalState globalState;
        int categoryID = 0;
        int billId = 0;
        String foodId = "";
        List<FoodCategory> listCategory;
        public OrderForTable()
        {
            InitializeComponent();
            globalState = GlobalState.GetInstance();

            if (globalState.TableId == 0)
            {
                this.Text = "Đặt món";
            }
            else
            {
                this.Text = "Đặt món cho bàn số " + globalState.TableId;
            }
            loadCategoryList();
            loadTable();
            loadFoodListByCategory(categoryID);
            checkBillForTable(globalState.TableId);
            showBillInfo(billId);
            updateTotalPrice();
        }

        // hiển thị danh sách món ăn theo danh mục
        private void loadFoodListByCategory(int id)
        {
            List<Food> listFood;
            if (id == 0)
            {
                listFood = FoodBLL.Instance.GetListFood();
            }
            else
            {
                listFood = FoodBLL.Instance.GetFoodByCategoryID(id);
            }
            
            foreach (var Food in listFood)
            {
                Button btn = new Button() { Width = 100, Height = 50 };
                btn.Text = Food.Food_Name + Environment.NewLine + Food.Price;
                btn.Tag = Food.Id;
                // Add event handler
                btn.Click += new EventHandler(btnFood_Click);

                flowFood.Controls.Add(btn);
            }
        }

        // hiển thị danh sách danh mục cho combobox
        private void loadCategoryList()
        {
            listCategory = FoodCategoryBLL.Instance.GetAllCategory();
            foreach (var category in listCategory)
            {
                cbCategory.Items.Add(category.Name);
            }
        }

        // hiển thị danh sách bàn cho combobox
        private void loadTable()
        {
            List<Table> listTable = TableBLL.Instance.GetListTable();
            foreach (var table in listTable)
            {
                cbTable.Items.Add(table.TableName);
            }
        }

        private void checkBillForTable(int tableId)
        {
            bool existsBill = TableBLL.Instance.CheckTableExistsBill(tableId);
            if(!existsBill)
            {
                BillBLL.Instance.InsertBill(tableId);
            }

            billId = GetBillIdByTableId(tableId);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foodId = dataFoodBill.Rows[e.RowIndex].Cells["Mã sản phẩm"].Value.ToString();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex != -1)
            {
                // Lấy danh mục được chọn
                string selectedCategory = cbCategory.SelectedItem.ToString();

                // Tìm categoryID tương ứng với danh mục được chọn
                var selectedCategoryObj = listCategory.FirstOrDefault(category => category.Name == selectedCategory);

                // Nếu tìm thấy, cập nhật categoryID
                if (selectedCategoryObj != null)
                {
                    categoryID = selectedCategoryObj.Id;
                }

                // Xóa các control cũ trong flowFood
                flowFood.Controls.Clear();

                // Hiển thị danh sách món ăn theo danh mục
                loadFoodListByCategory(categoryID);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Xóa các control cũ trong flowFood
            flowFood.Controls.Clear();
            // Hiển thị danh sách món ăn
            loadFoodListByCategory(0);
        }

        private void OrderForTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            globalState.TableId = 0;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            foreach (Control control in flowFood.Controls)
            {
                if (control is Button button)
                {
                    if (button == sender)
                    {
                        string foodId = button.Tag.ToString();

                        // Get the food ID based on the food name
                        if (BillInfoBLL.Instance.InsetAndUpdateBillInfo(billId, foodId, 1))
                        {
                            showBillInfo(billId);
                            updateTotalPrice();
                        }
                    }
                }
            }
        }

        public int GetBillIdByTableId(int tableId)
        {
            List<Bill> listBill = BillBLL.Instance.GetAllListBill();

            foreach (var bill in listBill)
            {

                if (bill.Id_Table.ToString() == tableId.ToString() && bill.Status_Bill == 0)
                {
                    return bill.Id;
                }
            }

            return 0; // Return 0 if the bill is not found for the table ID
        }

        public void showBillInfo(int billId)
        {
            List<BillInfo> listBillInfo = BillInfoBLL.Instance.GetListByIdBill(billId);

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
            }
            dataFoodBill.DataSource = dt;
        }

        private void dataFoodBill_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataFoodBill.Columns["Số lượng"].Index)
            {
                int count = Convert.ToInt32(dataFoodBill.Rows[e.RowIndex].Cells["Số lượng"].Value);
                string foodId = dataFoodBill.Rows[e.RowIndex].Cells["Mã sản phẩm"].Value.ToString();
                BillInfoBLL.Instance.InsetAndUpdateBillInfo(billId, foodId, count);
                showBillInfo(billId);
                updateTotalPrice();
            }
        }

        private void updateTotalPrice()
        {
            Bill bill = BillBLL.Instance.GetOneBillById(billId);
            text_totalPrice.Text = bill.Total_Price.ToString();
        }

        private void dataFoodBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if(foodId != "")
            {
                BillInfoBLL.Instance.DeleteBillInfo(foodId);
                showBillInfo(billId);
                updateTotalPrice();
                foodId = "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
            }
        }

        private void dataFoodBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodId = dataFoodBill.Rows[e.RowIndex].Cells["Mã sản phẩm"].Value.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // nếu mà không có sản phẩm nào trong bill thì không cho thanh toán
            if (dataFoodBill.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }
            // xác nhận thanh toán
            if (MessageBox.Show("Bạn có chắc muốn thanh toán cho bàn này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // khi ấn nút chuyển trạng thái của bill từ 0 thành 1 thể hiện đã thanh toán
                BillBLL.Instance.UpdateBill(billId, 1, globalState.TableId);

                // chuyển về trang Order
                this.Close();
                // reset lại tableId
                globalState.TableId = 0;
            }

        }
    }
}
