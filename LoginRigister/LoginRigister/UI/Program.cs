using LoginRigister.AppLogic;
using System;

namespace LoginRigister.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/Register");
            Console.WriteLine("/Login");
            Console.WriteLine("/exit");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter command: ");
                string command = Console.ReadLine();
                if (command== "/Register")
                {
                    Authenfication.Register();
                }
                else if(command== "/Login")
                {
                    Authenfication.Login();
                }
                else if( command== "/exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Command is not correct");
                }
            }
        }

        internal static void Main(string[] strings)
        {
            throw new NotImplementedException();
        }
    }
}
