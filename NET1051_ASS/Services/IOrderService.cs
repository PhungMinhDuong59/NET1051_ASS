using NET1051_ASS.Models;

namespace NET1051_ASS.Services
{
    public interface IOrderService
    {
        int CreateOrder(int userId);
        Order GetOrderDetails(int orderId);
        List<Order> GetOrderHistory(int userId);
        void CancelOrder(int orderId);
    }
}
