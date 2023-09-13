using GUI.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using BLL;
using DTO;

namespace GUI
{
    public partial class ProductManager : Form
    {
        public ProductManager()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            List<Food> listFood = FoodBLL.Instance.GetListFood();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm", typeof(string));
            dt.Columns.Add("Tên sản phẩm", typeof(string));
            dt.Columns.Add("Danh mục", typeof(string));
            dt.Columns.Add("Giá", typeof(int));

            foreach (var food in listFood)
            {
                DataRow row = dt.NewRow();
                row["Mã sản phẩm"] = food.Id;
                row["Tên sản phẩm"] = food.Food_Name;
                row["Danh mục"] = food.Id_Category;
                row["Giá"] = food.Price;
                dt.Rows.Add(row);
            }
            dataGridViewFood.DataSource = dt;
            viewDetail(0);
        }

        public void viewDetail(int index)
        {
            textCodeProduct.Text = dataGridViewFood.Rows[index].Cells[0].Value.ToString();
            textNameProduct.Text = dataGridViewFood.Rows[index].Cells[1].Value.ToString();
            textPriceProduct.Text = dataGridViewFood.Rows[index].Cells[3].Value.ToString();
            textCategoryProduct.Text = dataGridViewFood.Rows[index].Cells[2].Value.ToString();

            // lưu giá trị khi click vào foodState
            ClassState foodState = ClassState.GetInstance();
            foodState.Id = textCodeProduct.Text;
            foodState.Food_Name = textNameProduct.Text;
            foodState.Price = textPriceProduct.Text;
            foodState.Id_Category = textCategoryProduct.Text;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
            loadData();
            MessageBox.Show("Thêm sản phẩm thành công");
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditProduct editProduct = new EditProduct();
            editProduct.ShowDialog();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            String search = txtSearchProduct.Text;

            List<Food> listFood = FoodBLL.Instance.SearchFoodByName(search);

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm", typeof(string));
            dt.Columns.Add("Tên sản phẩm", typeof(string));
            dt.Columns.Add("Danh mục", typeof(string));
            dt.Columns.Add("Giá", typeof(int));

            foreach (var food in listFood)
            {
                DataRow row = dt.NewRow();
                row["Mã sản phẩm"] = food.Id;
                row["Tên sản phẩm"] = food.Food_Name;
                row["Danh mục"] = food.Id_Category;
                row["Giá"] = food.Price;
                dt.Rows.Add(row);
            }
            dataGridViewFood.DataSource = dt;
        }

        private void dataGridViewFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viewDetail(e.RowIndex);
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            ClassState foodState = ClassState.GetInstance();
            String id = foodState.Id;
            if(id == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    FoodBLL.Instance.DeleteFood(id);
                    MessageBox.Show("Xóa thành công");
                    loadData();
                    // reset lại giá trị foodState
                    foodState = null;
                }
            }   
        }
    }
}
