using DAL;
using DAL.UseCase;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FoodDAL : FoodUseCase
    {
        private static FoodDAL instance;
        public static FoodDAL Instance
        {
            get { if (instance == null) instance = new FoodDAL(); return FoodDAL.instance; }
            private set { FoodDAL.instance = value; }
        }
        private FoodDAL() { }
        public Object GetFoodByCategoryID(int id)
        {
            ResponseFood res = new ResponseFood();
            List<Food> list = new List<Food>();

            string query = "select id, food_name, id_category=(select name from FoodCategory where FoodCategory.id=Food.id_category), price from Food where id_category = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            res.error = list.Count > 0 ? false : true;
            res.message = "";
            res.data = list;
            return res;
        }
        public Object GetListFood()
        {
            ResponseFood res = new ResponseFood();
            List<Food> list = new List<Food>();

            string query = "select id, food_name, id_category=(select name from FoodCategory where FoodCategory.id=Food.id_category), price from Food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            res.error = list.Count > 0 ? false : true;
            res.message = "";
            res.data = list;
            return res;
        }

        /**
        * Hàm tìm kiếm món 
        *@param name @name [Food Name] 
        *@return result
        */

        public Object SearchFoodByName(string querySearch)
        {
            ResponseFood res = new ResponseFood();
    
            List<Food> list = new List<Food>();

            string query = string.Format($"SELECT id, food_name, id_category=(select name from FoodCategory where FoodCategory.id=Food.id_category), price FROM dbo.Food WHERE ((food_name LIKE N'%{querySearch}%') OR (id LIKE N'%{querySearch}%'))");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            res.error = list.Count > 0 ? false : true;
            res.message = "";
            res.data = list;
            return res;
        }

        /**
        * Hàm thêm món 
        *@param name @name [Food Name] 
        *@param id @id [ID] 
        *@param price @price [Price] 
        *@return result
        */

        public Object InsertFood(string name, string id, int idCategory, float price)
        {
            Response res = new Response();
            try
            {
                
                string query = string.Format("INSERT dbo.Food ( id, food_name, id_category, price ) VALUES  (N'{0}', N'{1}', {2}, {3})", id, name, idCategory, price);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                res.error = result > 0 ? false : true;
                if (res.error = true || result <= 0)
                {

                    Logger.WriteLog("Không thêm sản phẩm được");
                }
                res.message = "";
                return res;
            } catch (Exception ex)
            {
                res.error = true;
                res.message = ex.Message;
                Logger.WriteLog(ex.Message);
                return res;
            }
        }

        /**
       * Hàm sửa món 
       *@param idFood @idFood [ID Food] 
       *@param name @name [Food Name] 
       *@param id @id [ID] 
       *@param price @price [Price] 
       *@return result
       */

        public Object UpdateFood(string name, float price, int idCategory, string idFood)
        {
            Response res = new Response();
            try
            {
                string query = string.Format("UPDATE dbo.Food SET food_name = N'{0}', id_category = {1}, price = {2} WHERE id = N'{3}'", name, idCategory, price, idFood);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                res.error = result > 0 ? false : true;
                res.message = "";
                if (res.error = true || result <= 0)
                {

                    Logger.WriteLog("Không cập nhật sản phẩm được");
                }
                return res;
            } catch(Exception ex)
            {
                res.error = true;
                res.message = ex.Message;
                Logger.WriteLog(ex.Message);
                return res;
            }
        }

        /**
        * Hàm xóa món 
        *@param idFood @idFood [ID Food]    
        *@return result
        */


        public Object DeleteFood(string idFood)
        {
            //BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);
            Response res = new Response();
            try
            {
                string query = string.Format("DELETE FROM Food WHERE id = N'{0}'", idFood);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                res.error = result > 0 ? false : true;
                res.message = "";

                return res;
            } catch (Exception e)
            {
                res.error = true;
                res.message = e.Message;
                Logger.WriteLog(e.Message);
                return res;
            }
        }
    }
}

