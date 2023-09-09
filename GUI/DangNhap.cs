﻿using System;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public void loginEvent()
        {
            String username = txtUsernameLogin.Text;
            String password = txtPasswordLogin.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (username == "admin" && password == "admin")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                this.Show();
            }
            else if (username == "user" && password == "user")
            {
                this.Hide();
                Order order = new Order();
                order.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản, vui lòng liên hệ quản lý để cung cấp tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginEvent();
        }

        private void DangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //khi ấn enter thực hiện đăng nhập
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginEvent();
            }
        }
    }
}