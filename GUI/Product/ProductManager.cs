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
            String connectionString = "Data Source=HDCD-INSPIRON-3\\HDUC;Initial Catalog=QuanLy23Cafe;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Food", connection);
            DataTable dt = new DataTable();
            connection.Open();
            adapter.Fill(dt);
            dataGridViewFood.DataSource = dt;
            connection.Close();
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
            textCodeProduct.Text = dataGridViewFood.Rows[e.RowIndex].Cells[1].Value.ToString();
            textNameProduct.Text = dataGridViewFood.Rows[e.RowIndex].Cells[2].Value.ToString();
            textPriceProduct.Text = dataGridViewFood.Rows[e.RowIndex].Cells[4].Value.ToString();
            textCategoryProduct.Text = dataGridViewFood.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
