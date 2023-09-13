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

        private void loadData()
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
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditProduct editProduct = new EditProduct();
            editProduct.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String search = txtSearchProduct.Text;
        }

        private void dataGridViewFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viewDetail(e.RowIndex);
        }
    }
}
