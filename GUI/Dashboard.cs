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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=23Cafe;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * From Account", connect);
            DataTable dt = new DataTable();
            connect.Open();
            adapter.Fill(dt);
            dgvAccount.DataSource = dt;
            connect.Close();
        }

        private void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNaviOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order order = new Order();
            order.ShowDialog();
            this.Show();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            String username = txtUsernameAccount.Text;
            String password = txtPasswordAccount.Text;

            SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=23Cafe;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmdCheckAccount = new SqlCommand($"SELECT * From Account where username = '{username}'", connect);
            SqlCommand cmdAddAccount = new SqlCommand($"INSERT INTO Account VALUES ('{username}', '{password}')", connect);
            if (username == "" ||  password == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo");
                return;
            }

            connect.Open();
            int checkAccount = cmdCheckAccount.ExecuteNonQuery();
            int addAccount = cmdAddAccount.ExecuteNonQuery();
            if (checkAccount == 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Cảnh báo");
            } else
            {
                if(addAccount == 0)
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", "Thông báo");
                    return;
                } else
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thành công");
                    loadData();
                    txtUsernameAccount.Text = "";
                    txtPasswordAccount.Text = "";
                }
            }
            connect.Close();

        }
    }
}
