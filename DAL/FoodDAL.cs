using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FoodDAL
    {
        private static FoodDAL instance;
        public static FoodDAL Instance
        {
            get { if (instance == null) instance = new FoodDAL(); return FoodDAL.instance; }
            private set { FoodDAL.instance = value; }
        }
        private FoodDAL() { }
        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select id, food_name, id_category=(select name from FoodCategory where FoodCategory.id=Food.id_category), price from Food where id_category = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "select id, food_name, id_category=(select name from FoodCategory where FoodCategory.id=Food.id_category), price from Food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        /**
        * Hàm tìm kiếm món 
        *@param name @name [Food Name] 
        *@return result
        */

        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();

            string query = string.Format("SELECT id, food_name, id_category=(select name from FoodCategory where FoodCategory.id=Food.id_category), price FROM dbo.Food WHERE food_name LIKE N'%{0}%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        /**
        * Hàm thêm món 
        *@param name @name [Food Name] 
        *@param id @id [ID] 
        *@param price @price [Price] 
        *@return result
        */

        public bool InsertFood(string name, string id, int idCategory, float price)
        {
            string query = string.Format("INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  ({0}, N'{1}', {2}, {3})", id, name, idCategory, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        /**
       * Hàm sửa món 
       *@param idFood @idFood [ID Food] 
       *@param name @name [Food Name] 
       *@param id @id [ID] 
       *@param price @price [Price] 
       *@return result
       */

        public bool UpdateFood(string name, float price, int idCategory, string idFood)
        {
            string query = string.Format("UPDATE dbo.Food SET food_name = N'{0}', id_category = {1}, price = {2} WHERE id = {3}", name, idCategory, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        /**
        * Hàm xóa món 
        *@param idFood @idFood [ID Food]    
        *@return result
        */


        public bool DeleteFood(string idFood)
        {
            //BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("DELETE FROM Food WHERE id = N'{0}'", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

