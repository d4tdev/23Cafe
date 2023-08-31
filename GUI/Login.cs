using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true; // Enable KeyPreview
        }

        void loginSystem()
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=23Cafe;Integrated Security=True;Connect Timeout=30");
            connect.Open();
            SqlCommand command = new SqlCommand($"SELECT * FROM Account WHERE LOWER(username) = LOWER('{username}') AND LOWER(password) = LOWER('{password}')", connect);

            SqlDataReader reader = command.ExecuteReader();

            if (username == "" ||  password == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin để đăng nhập vào hệ thống!", "Cảnh báo");
                return;
            } else if(username == "admin" && password == "admin")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                this.Show();
            } else if (reader.HasRows)
            {
                MessageBox.Show(DateTime.Now.ToString());
                this.Hide();
                Order order = new Order();
                order.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản, vui lòng liên hệ admin để được cấp lại tài khoản!", "Thông báo");
                return;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi hệ thống?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginSystem();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginSystem();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtUsername.Text.ToLower();
            txtUsername.SelectionStart = txtUsername.Text.Length;
            txtPassword.Text = txtPassword.Text.ToLower();
            txtPassword.SelectionStart = txtPassword.Text.Length;
        }
    }
}
