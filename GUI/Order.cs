using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            // Khởi tạo Timer
            timer1.Interval = 1000; // Cập nhật mỗi giây (1000 milliseconds)
            timer1.Tick += timer1_Tick;
            timer1.Start(); // Bắt đầu Timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Hiển thị thời gian trên Label dưới định dạng HH:mm:ss
            labelCurrentTime.Text = currentTime.ToString("HH:mm:ss");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ca làm việc?", "Xác nhận thoát", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"Kết thúc ca làm việc vào lúc: {DateTime.Now}", "Kết thúc ca làm việc");
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ca làm việc?", "Xác nhận thoát", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
