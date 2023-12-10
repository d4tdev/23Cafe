using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FoodBLL
    {
        private static FoodBLL instance;
        public static FoodBLL Instance
        {
            get { if (instance == null) instance = new FoodBLL(); return FoodBLL.instance; }
            private set { FoodBLL.instance = value; }
        }
        public FoodBLL() { }
        public List<Food> GetFoodByCategoryID(int id)
        {
            ResponseFood res = (ResponseFood) FoodDAL.Instance.GetFoodByCategoryID(id);
            if (res.error == false) return res.data;
            else return null;
        }
        public List<Food> GetListFood()
        {
            ResponseFood res = (ResponseFood) FoodDAL.Instance.GetListFood();
            if (res.error == false) return res.data;
            else return null;
        }
        public List<Food> SearchFoodByName(string name)
        {
            ResponseFood res = (ResponseFood) FoodDAL.Instance.SearchFoodByName(name);
            if (res.error == false) return res.data;
            else return null;
        }
        public bool InsertFood(string name, string id, int idCategory, float price)
        {
            Response res = (Response)FoodDAL.Instance.InsertFood(name, id, idCategory, price);
            
            if (res.error == false)
                return true;
            else return false;
        }
        public bool UpdateFood(string name, float price, int idCategory, string idFood)
        {
            Response res = (Response) FoodDAL.Instance.UpdateFood(name, price, idCategory, idFood);
            if (res.error == false)
                return true;
            else return false;
        }
        public bool DeleteFood(string idFood)
        {
            Response res = (Response) FoodDAL.Instance.DeleteFood(idFood);
            if (res.error == false)
                return true;
            else return false;
        }
    }
}
