using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Staff
{
    internal class AccountState
    {
        // State
        public static AccountState accountState = null;

        // Thêm các thuộc tính mới
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Salary { get; set; }

        // role 
        // 1: admin
        // 2: staff
        public int Role { get; set; }

        private AccountState()
        {
            // Khởi tạo các thuộc tính ở đây nếu cần
        }

        public static AccountState GetInstance()
        {
            if (accountState == null)
            {
                accountState = new AccountState();
            }
            return accountState;
        }
    }
}
