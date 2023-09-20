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

namespace GUI.Product
{
    public partial class EditProduct : Form
    {
        List<FoodCategory> listCategory;
        public EditProduct()
        {
            listCategory = FoodCategoryBLL.Instance.GetAllCategory();
            InitializeComponent();
            this.KeyPreview = true;
            FoodState foodState = FoodState.GetInstance();
            txtCodeProduct.Text = foodState.Id;
            txtNameProduct.Text = foodState.Food_Name;
            txtPriceProduct.Text = foodState.Price;
            cbCategoryProduct.Text = foodState.Id_Category;
            foreach (var category in listCategory)
            {
                cbCategoryProduct.Items.Add(category.Name);
            }
            txtCodeProduct.Enabled = false;
        }

        private void btnSaveEditProduct_Click(object sender, EventArgs e)
        {
            String name = txtNameProduct.Text;
            if (name == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            String code = txtCodeProduct.Text;
            if (code == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            String price = txtPriceProduct.Text;
            if (price == "")
            {
                MessageBox.Show("Bạn chưa nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            String category = cbCategoryProduct.Text;
            if (category == "")
            {
                MessageBox.Show("Bạn chưa lựa chọn danh mục sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int idCategory = -1;
            foreach (var item in listCategory)
            {
                if (item.Name == category)
                {
                    idCategory = item.Id;
                    break;
                }
            }

            if (idCategory == -1)
            {
                MessageBox.Show("Không tìm thấy danh mục sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (FoodBLL.Instance.UpdateFood(name, float.Parse(price), idCategory, code))
                {
                    MessageBox.Show("Sửa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có dừng chỉnh sửa thông tin sản phẩm?", "Thoát", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
