using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class FoodState
    {
        // State
        public static FoodState foodState = null;

        // Thêm các thuộc tính mới
        public string Id { get; set; }
        public string Food_Name { get; set; }
        public string Price { get; set; }
        public string Id_Category { get; set; }

        private FoodState()
        {
            // Khởi tạo các thuộc tính ở đây nếu cần
        }

        public static FoodState GetInstance()
        {
            if (foodState == null)
            {
                foodState = new FoodState();
            }
            return foodState;
        }
    }
}
