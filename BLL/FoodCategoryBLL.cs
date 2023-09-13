using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FoodCategoryBLL
    {
        private static FoodCategoryBLL instance;
        public static FoodCategoryBLL Instance
        {
            get { if (instance == null) instance = new FoodCategoryBLL(); return FoodCategoryBLL.instance; }
            private set { FoodCategoryBLL.instance = value; }
        }
        public FoodCategoryBLL() { }
        public List<FoodCategory> GetAllCategory()
        {
            return FoodCategoryDAL.Instance.GetAllCategory();
        }
    }
}
