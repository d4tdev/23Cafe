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
    public partial class AddProduct : Form
    {
        List<FoodCategory> listCategory = FoodCategoryBLL.Instance.GetAllCategory();
        ClassState foodState = ClassState.GetInstance();
        public AddProduct()
        {
            InitializeComponent();
            this.KeyPreview = true;
            // thêm danh mục sản phẩm vào combobox
            foreach (var category in listCategory)
            {
                cbCategoryProduct.Items.Add(category.Name);
            }
        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có dừng tạo mới sản phẩm?", "Thoát", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnSaveAddProduct_Click(object sender, EventArgs e)
        {
            String name = txtNameProduct.Text;
            if (name == null)
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            String code = txtCodeProduct.Text;
            if (code == null)
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            String price = txtPriceProduct.Text;
            if (price == null)
            {
                MessageBox.Show("Bạn chưa nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            String category = cbCategoryProduct.Text;
            if (category == null)
            {
                MessageBox.Show("Bạn chưa lựa chọn danh mục sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // thêm sản phẩm

            // chuyển category thành id
            int idCategory = -1;
            foreach (var item in listCategory)
            {
                if(item.Name == category)
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
                if (FoodBLL.Instance.InsertFood(name, code, idCategory, float.Parse(price)))
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
