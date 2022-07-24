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
        private static int _idcounter;

        public static int IDCounter
        {
            get
            {
                _idcounter++;
                return _idcounter;
            }
        }
        private static int _numberOnTheList;

        public static int NumberOnTheList
        {
            get
            {
                _numberOnTheList++;
                return _numberOnTheList;
            }

        }


        public static List<User> users { get; set; } = new List<User>()
        {
            new Admin("Eshqin","Faracov","eshqin115@gmail.com","Danser115")
        };
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
        public static User Add(string name,
            string lastName,
            string email,
            string password)
        {
            User user = new User(name, lastName, email, password);
            users.Add(user);
            return user;
        }
        public static Admin AddAdmin(string name,
            string lastName,
            string email,
            string password)
        {
            Admin admin = new Admin(name, lastName, email, password);
            users.Add(admin);
            return admin;

        }
        public static User Add(User user)
        {
            users.Add(user);
            return user;
        }
        public static Admin AddAdmin(Admin admin)
        {
            users.Add(admin);
            return admin;

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
        public static void RemoveUserByEmail(string email)
        {
            foreach (User user in users)
            {
                if (user.Email == email)
                {
                    users.Remove(user);
                }
            }
        }
        //public static void Update(string email)
        //{
        //    User findUser = UserRepo.GetUserByEmail(email);
        //    findUser.Name =

        //}

        public static void Delete(User user)
        {
            users.Remove(user);
        }
        public static void ShowAdmin()
        {
            foreach (User user in users)
            {
                if (user is Admin)
                {
                    Console.WriteLine(user.GetInfo());
                }
            }
        }
        public static void ShowUser()
        {
            foreach (User user in users)
            {
                Console.WriteLine(user.GetInfo());
            }
        }


    }
}

