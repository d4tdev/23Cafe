using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class GlobalState
    {
        public static GlobalState globalState = null;

        // Thêm các thuộc tính mới
        public string Username { get; set; }
        public int Role { get; set; }

        private GlobalState()
        {
            // Khởi tạo các thuộc tính ở đây nếu cần
        }

        public static GlobalState GetInstance()
        {
            if (globalState == null)
            {
                globalState = new GlobalState();
            }
            return globalState;
        }
    }
}
