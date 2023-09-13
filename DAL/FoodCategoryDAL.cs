using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FoodCategoryDAL
    {
        private static FoodCategoryDAL instance;
        public static FoodCategoryDAL Instance
        {
            get { if (instance == null) instance = new FoodCategoryDAL(); return FoodCategoryDAL.instance; }
            private set { FoodCategoryDAL.instance = value; }
        }
        private FoodCategoryDAL() { }
        public List<FoodCategory> GetAllCategory()
        {
            List<FoodCategory> list = new List<FoodCategory>();

            string query = "SELECT * FROM FoodCategory";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodCategory category = new FoodCategory(item);
                list.Add(category);
            }

            return list;
        }
    }
}
