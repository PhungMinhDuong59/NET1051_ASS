using NET1051_ASS.Context;
using NET1051_ASS.Models;

namespace NET1051_ASS.Services
{
    public class ComboService : IComboService
    {
        private readonly ApplicationDbContext _dbContext;
        public ComboService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ComboFoodItem> GetAllComboFoodItems()
        {
            return _dbContext.ComboFoodItems.ToList();
        }

        public List<Combo> GetAllCombos()
        {
            return _dbContext.Combos.ToList();
        }

        public Combo GetById(int id)
        {
            return _dbContext.Combos.FirstOrDefault(cb => cb.ComboID == id);
        }
    }
}
