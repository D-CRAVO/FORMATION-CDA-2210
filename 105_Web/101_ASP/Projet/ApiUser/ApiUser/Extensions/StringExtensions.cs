using BCrypt.Net;
using Microsoft.Identity.Client;

namespace ApiUser.Extensions
{
    public static class StringExtensions
    {
        public static string ToPassword(this string str)
        {
            return BCrypt.Net.BCrypt.HashPassword(str);
            
        }

        public static bool CheckPassword(this string passwordHash, string passwordToTest )
        {
            return BCrypt.Net.BCrypt.Verify(passwordToTest, passwordHash);
        }
    }
}
