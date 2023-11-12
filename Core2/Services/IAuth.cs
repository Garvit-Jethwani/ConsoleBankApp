using Data.Entities;

namespace Core.Services
{
    public interface IAuth
    {
        void SignUp();
        User Login();
        void Logout();
    }
}
