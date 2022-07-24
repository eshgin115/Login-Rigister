using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRigister.DataBase.Models
{
    class Admin : User
    {
        public Admin(string name, string lastName, string email, string password, int id, DateTime time, int number)
            : base(name, lastName, email, password, id, time, number)
        {

        }
        public Admin(string name, string lastName, string email, string password)
            : base(name, lastName, email, password)
        {

        }
        public override string GetInfo()
        {
            return Name + " " + LastName + " " + Email + " " + Id + " " + _rigisterTime;
        }
    }
}
