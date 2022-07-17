using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRigister.DataBase.Models
{
    class User
    {
        private static int _idcounter = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime _rigisterTime { get; set; }
        public User(string name, string lastName, string email, string password)
        {
            Id = _idcounter;
            _idcounter++;
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
            _rigisterTime = DateTime.Now;
        }
        public string GetInfo()
        {
            return Name + " " + LastName + " " + Email+" "+Id;
        }

    }
}
