﻿using LoginRigister.DataBase.Models;
using LoginRigister.DataBase.Repository;
using LoginRigister.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRigister.AppLogic
{
    class Authenfication
    {
        public static void Register()
        {
            Console.WriteLine();
            string firstName = GetName();
            string lastName = GetLastName();
            string email = GetEmail();
            string password = GetPassword();
            Console.WriteLine();
            User user = UserRepo.Add(firstName, lastName, email, password);
            Console.WriteLine("User aded the system" + user.GetInfo());
            Console.WriteLine("You successfully registered, now you can login with your new account!");
        }
        public static void Login()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Please enter Password");
            string password = Console.ReadLine();
            if (UserRepo.IsCheckEmailAndPassword(email, password))
            {
                User user = UserRepo.GetUserByEmail(email);
                if (user == null)
                {
                    Console.WriteLine("User is not have in system");
                }
                else if (user is Admin)
                {
                    DashBoard.AdminPanel();
                }
                else
                {
                    DashBoard.UserPanel(email);
                }

            }

        }
        public static string GetName()
        {
            Console.Write("Please add User's name : ");
            string firstName = Console.ReadLine();
            while (!UserValidation.IsCheckName(firstName))
            {
                Console.Write("Please Enter correct UsersName : ");
                firstName = Console.ReadLine();
            }
            return firstName;
        }
        public static string GetLastName()
        {
            Console.Write("Please add User's LastName : ");
            string lastName = Console.ReadLine();
            while (!UserValidation.IsCheckLastName(lastName))
            {
                Console.Write("Please Enter correct LastName : ");
                lastName = Console.ReadLine();
            }
            return lastName;
        }
        public static string GetEmail()
        {
            Console.Write("Please add User's email : ");
            string email = Console.ReadLine();
            while (!UserValidation.IsCheckEmail(email))
            {
                Console.Write("Please Enter correct email : ");
                email = Console.ReadLine();
            }
            return email;
        }
        public static string GetPassword()
        {
            Console.Write("Please add User's password : ");
            string password = Console.ReadLine();
            Console.WriteLine("Please enter confirmPassword");
            string confirmPass = Console.ReadLine();
            if (password == confirmPass)
            {
                while (!UserValidation.IsCheckPassword(password))
                {
                    Console.Write("Please Enter correct password : ");
                    password = Console.ReadLine();
                }
                return password;
            }
            return null;
        }
    }

}
