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

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsernameAccount.Text = dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPasswordAccount.Text = dgvAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            String username = txtUsernameAccount.Text;
            String password = txtPasswordAccount.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo");
                return;
            }

            SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=23Cafe;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand($"UPDATE Account SET username = '{username}', password = '{password}' WHERE username = '{username}'", connect);
            connect.Open();
            int udpate = command.ExecuteNonQuery();
            if (udpate == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", "Thông báo");
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thành công");
                loadData();
            }

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            String username = txtUsernameAccount.Text;
            SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=23Cafe;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand($"DELETE FROM Account WHERE username = '{username}'", connect);
            connect.Open();
            int delete = command.ExecuteNonQuery();
            if (delete == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", "Thông báo");
                return;
            } else
            {
                MessageBox.Show("Xóa tài khoản thành công!", "Thành công");
                loadData();
            }
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            String search = txtSearchAccount.Text;
            SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=23Cafe;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Account WHERE username LIKE '%{search}%'", connect);
            DataTable dt = new DataTable();
            connect.Open();
            adapter.Fill(dt);
            dgvAccount.DataSource = dt;
            connect.Close();
        }
    }
}
