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
        Object GetFoodByCategoryID(int id);
        Object GetListFood();
        Object SearchFoodByName(string querySearch);
        Object InsertFood(string name, string id, int idCategory, float price);
        Object UpdateFood(string name, float price, int idCategory, string idFood);
        Object DeleteFood(string idFood);

    }
}
