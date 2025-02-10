using NET1051_ASS.Context;
using NET1051_ASS.Models;

namespace NET1051_ASS.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Category> GetAll()
        {
            return _dbContext.Categories.ToList();
        }
    }
}
