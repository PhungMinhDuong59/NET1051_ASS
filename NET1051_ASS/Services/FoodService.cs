using NET1051_ASS.Context;
using NET1051_ASS.Models;

namespace NET1051_ASS.Services
{
    public class FoodService : IFoodService
    {
        private readonly ApplicationDbContext _dbContext;
        public FoodService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<FoodItem> GetAll()
        {
            return _dbContext.FoodItems.ToList();
        }

        public FoodItem GetById(int id)
        {
            return _dbContext.FoodItems.FirstOrDefault(fi => fi.FoodItemID == id);
        }
    }
}
