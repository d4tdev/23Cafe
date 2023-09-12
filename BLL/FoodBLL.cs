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
            return FoodDAL.Instance.GetFoodByCategoryID(id);
        }
        public List<Food> GetListFood()
        {
            return FoodDAL.Instance.GetListFood();
        }
        public List<Food> SearchFoodByName(string name)
        {
            return FoodDAL.Instance.SearchFoodByName(name);
        }
        public bool InsertFood(string name, string id, int idCategory, float price)
        {
            return FoodDAL.Instance.InsertFood(name, id, idCategory, price);
        }
        public bool UpdateFood(string name, float price, int idCategory, string idFood)
        {
            return FoodDAL.Instance.UpdateFood(name, price, idCategory, idFood);
        }
        public bool DeleteFood(string idFood)
        {
            return FoodDAL.Instance.DeleteFood(idFood);
        }
    }
}
