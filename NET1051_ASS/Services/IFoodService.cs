using NET1051_ASS.Models;

namespace NET1051_ASS.Services
{
    public interface IFoodService
    {
        List<FoodItem> GetAll();
        FoodItem GetById(int id);
    }
}
