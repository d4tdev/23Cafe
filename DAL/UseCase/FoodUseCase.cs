using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UseCase
{
    public interface FoodUseCase
    {
        List<Food> GetFoodByCategoryID(int id);
        List<Food> GetListFood();
        List<Food> SearchFoodByName(string querySearch);
        bool InsertFood(string name, string id, int idCategory, float price);
        bool UpdateFood(string name, float price, int idCategory, string idFood);
        bool DeleteFood(string idFood);

    }
}
