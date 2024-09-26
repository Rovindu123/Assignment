using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    internal class Admin : Person
    {
        //Constructor
        public Admin(string personID, string username, string password, string email, string contactNumber):base(personID, username, password, email, contactNumber, "admin")
        {
        }

    }

}
