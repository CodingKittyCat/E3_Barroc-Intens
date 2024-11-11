using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens
{
    class Helper
    {
        internal static string HashPassword(string password)
        {
            // gebruik deze methode om wachtwoorden te hashen
            return BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
        }

        internal static bool VerifyPassword(string password, string hashedPassword)
        {
            // gebruik deze methode om wachtwoorden te vergelijken met de gehashte versie in database
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword);
        }
    }
}
