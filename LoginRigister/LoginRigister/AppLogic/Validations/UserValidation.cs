using LoginRigister.DataBase.Models;
using LoginRigister.DataBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoginRigister.Validations
{
    class UserValidation
    {
        public static List<User> users = new List<User>();
        public static bool IsCheckName(string name)
        {
            if (Validation.IsCheckText(name))
            {
                return true;
            }
            Console.WriteLine("The name you entered is incorrect, make sure the name contains only letters, the first letter is capitalized, and the length is greater than 3 and less than 30.");
            return false;

        }
        public static bool IsCheckLastName(string lastName)
        {
            if (Validation.IsCheckText(lastName))
            {
                return true;
            }
            Console.WriteLine("The last name you entered is incorrect, make sure that the last name contains only letters, the first letter is capitalized, and the length is greater than 3 and less than 30.");
            return false;
        }

        public static bool IsCheckEmail(string email)
        {
            if (UserRepo.IsExistsEmail(email) && Validation.IsEmailCorret(email))
            {
                return true;
            }
            Console.WriteLine("Email is not correct");
            return false;
        }
       
        public static bool IsCheckPassword(string paswword)
        {
            if (Validation.IsPasswordCorrect(paswword))
            {
                return true;
            }
            Console.WriteLine("Password is not correct");
            return false;
        }
    }
}
