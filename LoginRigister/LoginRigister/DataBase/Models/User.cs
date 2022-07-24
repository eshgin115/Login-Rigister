using LoginRigister.DataBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRigister.DataBase.Models
{
    class User
    {

        public int Id { get; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime _rigisterTime { get; }
        public int NumberOnTheList { get; }

        public User(string name, string lastName, string email, string password, int id, DateTime time, int number)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
            _rigisterTime = time;
            NumberOnTheList = number;
        }
        public User(string name, string lastName, string email, string password)
        {


            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
            _rigisterTime = DateTime.Now;
            
            Id = UserRepo.IDCounter;
            NumberOnTheList = UserRepo.NumberOnTheList;


        }


        public virtual string GetInfo()
        {
            return Name + " " + LastName + " " + _rigisterTime;
        }

    }
}
