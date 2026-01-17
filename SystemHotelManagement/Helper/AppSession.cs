using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHotelManagement.Helper
{
    public static class AppSession
    {
        public static int? UserId { get; private set; }
        public static string? Username { get; private set; }
        public static string? FullName { get; private set; }
        public static string? Role { get; private set; }

        public static bool IsLoggedIn => UserId != null;

        public static void SignIn(int userId, string username, string fullName, string role)
        {
            UserId = userId;
            Username = username;
            FullName = fullName;
            Role = role;
        }

        public static void SignOut()
        {
            UserId = null;
            Username = null;
            FullName = null;
            Role = null;
        }
    }
}
