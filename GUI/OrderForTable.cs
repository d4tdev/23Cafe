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
            createBillFromTableId(globalState.TableId);
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

        // tạo mới bill theo tableId
        private void createBillFromTableId(int tableId)
        {
            // Create a new bill for the table
            MessageBox.Show("Creating a new bill for table ID: " + tableId);
            bool success = BillBLL.Instance.InsertBill(tableId);

            if (success)
            {
                // Retrieve the bill ID associated with the table ID
                billId = GetBillIdByTableId(tableId);

                if (billId != 0)
                {
                    MessageBox.Show("Bill created successfully. Bill ID: " + billId);
                }
                else
                {
                    MessageBox.Show("Failed to retrieve Bill ID.");
                }
            }
            else
            {
                MessageBox.Show("Failed to create a new bill.");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void OrderForTable_Load(object sender, EventArgs e)
        {

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
                        string buttonText = button.Text;
                        string[] foodInfo = buttonText.Split('\n');

                        string foodName = foodInfo[0];
                        string price = foodInfo[1];

                        // Get the food ID based on the food name
                        string foodId = GetFoodIdByName(foodName);
                        MessageBox.Show(foodId);
                        if (!string.IsNullOrEmpty(foodId))
                        {
                            // Add the food item to BillInfo
                            if (BillInfoBLL.Instance.InsetAndUpdateBillInfo(billId, foodId, 1))
                            {
                                MessageBox.Show("Added food to bill info successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add food to bill info");
                            }
                        }
                    }
                }
            }
        }

        private string GetFoodIdByName(string foodName)
        {
            // Iterate through the list of foods to find the ID of the selected food
            foreach (var food in FoodBLL.Instance.GetListFood())
            {
                if (food.Food_Name == foodName)
                {
                    return food.Id;
                }
            }

            return null; // Return null if the food name is not found (handle accordingly)
        }

        public int GetBillIdByTableId(int tableId)
        {
            foreach (var bill in BillBLL.Instance.GetAllListBill())
            {
                if (bill.Id_Table == tableId.ToString())
                {
                    return bill.Id;
                }
            }

            return 0; // Return 0 if the bill is not found for the table ID
        }
    }
}
