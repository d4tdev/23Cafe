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
        public SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=23Cafe;Integrated Security=True;Connect Timeout=30");
        public Dashboard()
        {
            InitializeComponent();
            loadDataAccount();
            loadDataTable();
        }

        void loadDataAccount()
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * From Account", connect);
            DataTable dt = new DataTable();
            connect.Open();
            adapter.Fill(dt);
            dgvAccount.DataSource = dt;
            connect.Close();
        }
        void loadDataTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM TableManager", connect);
            DataTable dt = new DataTable();
            connect.Open();
            adapter.Fill(dt);
            dgvTable.DataSource = dt;
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
            String displayName = txtDisplayNameAccount.Text;
            int salary = Convert.ToInt16(txtSalaryAccount);

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
                    loadDataAccount();
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
                loadDataAccount();
            }
            connect.Close();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            String username = txtUsernameAccount.Text;
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
                loadDataAccount();
            }
            connect.Close();
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            loadDataAccount();
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            String search = txtSearchAccount.Text;
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Account WHERE username LIKE '%{search}%'", connect);
            DataTable dt = new DataTable();
            connect.Open();
            adapter.Fill(dt);
            dgvAccount.DataSource = dt;
            connect.Close();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(txtTable.Text);
            String Status = cbStatusTable.Text;

            SqlCommand checkDuplicateCommand = new SqlCommand($"SELECT * FROM TableManager WHERE ID = '{Id}'", connect);
            SqlCommand command = new SqlCommand($"INSERT INTO TableManager VALUES ('{Id}', '{Status}')", connect);
            connect.Open();
            int checkDuplicate = checkDuplicateCommand.ExecuteNonQuery();
            int addTable = command.ExecuteNonQuery();
            if ( checkDuplicate == 0 )
            {
                MessageBox.Show("Bàn đã tồn tại, vui lòng kiểm tra lại!", "Thông báo");
                return;
            }
            else if ( checkDuplicate != 0 && addTable != 0 ) {
                MessageBox.Show("Thêm bàn thành công!", "Thành công");
                loadDataTable();
            } else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Thông báo");
                return;
            }
            connect.Close();
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTable.Text = dgvTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbStatusTable.Text = dgvTable.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(txtTable.Text);
            SqlCommand command = new SqlCommand($"DELETE FROM TableManager WHERE Id = '{Id}'", connect);
            connect.Open();
            int deleteTable = command.ExecuteNonQuery();
            if ( deleteTable == 0 )
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Thông báo");
                return;
            } else
            {
                MessageBox.Show("Xóa bàn thành công", "Thành công");
                loadDataTable();
            }
            connect.Close();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            String codeFood = txtCodeFood.Text;
            String nameFood = txtNameFood.Text;
            int priceFood = Convert.ToInt16(txtPriceFood.Text);
            String categoryFood = comboBoxCategoryFood.Text;
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeFood.Text = dgvFood.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameFood.Text = dgvFood.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPriceFood.Text = dgvFood.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxCategoryFood.Text = dgvFood.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            String search = txtSearchFood.Text;
        }
    }
}
