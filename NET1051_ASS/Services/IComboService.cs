using NET1051_ASS.Models;

namespace NET1051_ASS.Services
{
    public interface IComboService
    {
        List<Combo> GetAllCombos();
        Combo GetById(int id);
        List<ComboFoodItem> GetAllComboFoodItems();
    }
}
