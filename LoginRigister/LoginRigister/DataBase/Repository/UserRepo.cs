using LoginRigister.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRigister.DataBase.Repository
{
    class UserRepo
    {
        public static List<User> users { get; set; } = new List<User>() { new User("Super", "Admin", "Admin@gmail.com", "123312") };
        public static bool IsExistsEmail(string email)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Email == email)
                {
                    return false;
                }
            }
            return true;
        }
        public static User AddUser(string name,
            string lastName,
            string email,
            string password)
        {
            User user = new User(name, lastName, email, password);
            users.Add(user);
            return user;
        }
        public static User GetUserByEmailAndPassword(string email, string password)
        {
            foreach (User user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }
            }
            Console.WriteLine("User Password is not correct");
            return null;
        }
        public static bool IsCheckEmailAndPassword(string email, string password)
        {
            foreach (User user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }
            Console.WriteLine("User Password is not correct");
            return false;
        }
        public static User GetUserByEmail(string email)
        {
            foreach (User user in users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
