using NET1051_ASS.Models;

namespace NET1051_ASS.Services
{
    public interface IAccountService
    {
        bool Login(string username, string password);
        bool Register(User registerUser);
        void CreateCartForUser(int userId);
        User GetByUsername(string username);
        void Update(User user);
    }
}
