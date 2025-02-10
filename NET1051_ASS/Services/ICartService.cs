using NET1051_ASS.Models;

namespace NET1051_ASS.Services
{
    public interface ICartService
    {
        Cart GetByUserID(int id);
        void AddToCart(int userId, int foodItemId, int quantity);
        void AddComboToCart(int userId, int comboId, int quantity);
        void RemoveCartItem(int cartItemId);
        void UpdateCartItemQuantity(int cartItemId, int quantity);
    }
}
