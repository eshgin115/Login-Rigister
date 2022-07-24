using LoginRigister.DataBase.Models;
using LoginRigister.DataBase.Repository;
using LoginRigister.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRigister.AppLogic
{
    public static partial class DashBoard
    {
        public static void AdminPanel()
        {
            while (true)
            {


                Console.WriteLine("/Add-User");
                Console.WriteLine("/Uppdate-User");
                Console.WriteLine("/Remove-User");
                Console.WriteLine("/Reports");
                Console.WriteLine("/Add-Admin");
                Console.WriteLine("/Show-Admin");
                Console.WriteLine("/Show-User");
                Console.WriteLine("/Uppdate-Admin");
                Console.WriteLine("/Remove-Admin");
                Console.WriteLine("/Logout");
                string command = Console.ReadLine();
                if (command == "/Add-User")
                {
                    Authenfication.Register();

                }
                else if (command == "/Uppdate-User")
                {
                    Console.WriteLine("Pls enter email : ");
                    string searchEmail = Console.ReadLine();
                    User user = UserRepo.GetUserByEmail(searchEmail);
                    if (user == null)
                    {
                        Console.WriteLine("This mail not found int system");
                    }
                    else if (user is Admin)
                    {

                        Console.WriteLine("This mail consist of Admin");

                    }
                    else
                    {
                        UserRepo.Delete(user);
                        string newName = Authenfication.GetName();
                        string newLastName = Authenfication.GetLastName();
                        User user1 = new User(newName, newLastName, user.Email, user.Password, user.Id, user._rigisterTime, user.NumberOnTheList);
                        UserRepo.Add(user1);
                    }

                }
                else if (command == "/Remove-User")
                {
                    Console.WriteLine("Pls enter mail user");
                    string searchEmail = Console.ReadLine();
                    User user = UserRepo.GetUserByEmail(searchEmail);
                    if (user == null)
                    {
                        Console.WriteLine("This mail is not correct");
                    }
                    else if (user is Admin)
                    {
                        Console.WriteLine("This mail consist of Admin");
                    }
                    else
                    {
                        UserRepo.Delete(user);
                        Console.WriteLine("This user deleted");
                    }
                }
                else if (command == "/Reports")
                {

                }
                else if (command == "/Add-Admin")
                {

                    Console.WriteLine("Pls enter email : ");
                    string searchEmail = Console.ReadLine();
                    User user = UserRepo.GetUserByEmail(searchEmail);
                    if (user == null)
                    {
                        string firstName = Authenfication.GetName();
                        string lastName = Authenfication.GetLastName();
                        string email = Authenfication.GetEmail();
                        string password = Authenfication.GetPassword();
                        Console.WriteLine();
                        Admin admin = UserRepo.AddAdmin(firstName, lastName, email, password);
                        Console.WriteLine("Admin aded the system" + admin.GetInfo());
                    }
                    else
                    {
                        Console.WriteLine("This mail olready in system");
                    }

                }
                else if (command == "/Show-User")
                {
                    UserRepo.ShowUser();
                }
                else if (command == "/Show-Admin")
                {
                    UserRepo.ShowAdmin();
                }
                else if (command == "/Uppdate-Admin")
                {
                    Console.WriteLine("Pls enter email : ");
                    string searchEmail = Console.ReadLine();
                    User admin = UserRepo.GetUserByEmail(searchEmail);
                    if (admin == null)
                    {
                        Console.WriteLine("This mail not found int system");
                    }
                    else if (admin is Admin)
                    {

                        UserRepo.Delete(admin);
                        string newName = Authenfication.GetName();
                        string newLastName = Authenfication.GetName();
                        Admin admin1 = new Admin(newName, newLastName, admin.Email, admin.Password, admin.Id, admin._rigisterTime, admin.NumberOnTheList);
                        UserRepo.AddAdmin(admin1);

                    }
                    else
                    {
                        Console.WriteLine("This mail consist User");
                    }
                }
                else if (command == "/Remove-Admin")
                {
                    Console.WriteLine("Pls enter mail admin");
                    string searchEmail = Console.ReadLine();
                    User admin = UserRepo.GetUserByEmail(searchEmail);
                    if (admin == null)
                    {
                        Console.WriteLine("This mail is not correct");
                    }
                    else if (admin is Admin)
                    {
                        UserRepo.Delete(admin);
                        Console.WriteLine("This user deleted");
                    }
                    else
                    {
                        Console.WriteLine("This mail consist of User");
                    }
                }
                else if (command == "/Logout")
                {
                    Program.Main(new string[] { });
                }
                else
                {
                    Console.WriteLine("This Command not found");
                }


            }
        }
    }

    public static partial class DashBoard
    {
        public static void UserPanel(string email)
        {
            Console.WriteLine("/Logout");
            Console.WriteLine("/Update-info");
            string command = Console.ReadLine();
            if (command == "/Logout")
            {
                Program.Main(new string[] { });
            }
            else if (command == "/Update-info")
            {
                User user = UserRepo.GetUserByEmail(email);
                UserRepo.Delete(user);
                string newName = Authenfication.GetName();
                string newLastName = Authenfication.GetName();
                User user1 = new User(newName, newLastName, user.Email, user.Password, user.Id, user._rigisterTime, user.NumberOnTheList);
                UserRepo.Add(user1);
            }
            else
            {
                Console.WriteLine("This Command not found");
            }


        }
    }
}

