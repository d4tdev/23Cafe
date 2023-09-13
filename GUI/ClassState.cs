using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class ClassState
    {
        // State
        public static ClassState foodState = null;

        // Thêm các thuộc tính mới
        public string Id { get; set; }
        public string Food_Name { get; set; }
        public string Price { get; set; }
        public string Id_Category { get; set; }

        private ClassState()
        {
            // Khởi tạo các thuộc tính ở đây nếu cần
        }

        public static ClassState GetInstance()
        {
            if (foodState == null)
            {
                foodState = new ClassState();
            }
            return foodState;
        }
    }
}
