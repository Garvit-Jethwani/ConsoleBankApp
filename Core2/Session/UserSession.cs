using Data.Entities;

namespace Core.Session
{
    public class UserSession
    {
        public static User LoggedInUser { get; set; }
    }
}
