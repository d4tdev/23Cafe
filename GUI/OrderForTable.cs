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
    }
}
