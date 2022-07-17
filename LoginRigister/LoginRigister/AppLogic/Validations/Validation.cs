using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoginRigister.Validations
{
    class Validation
    {
        public static bool IsCheckText(string text)
        {

            return Regex.IsMatch(text, @"^[A-Z]{1,1}[a-zA-Z]{3,30}");
        }
        public static bool IsPasswordCorrect(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
        }
        public static bool IsEmailCorret(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]{0,18}@code\.edu\.az");
        }
    }
}
