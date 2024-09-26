using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    internal class Organizer : Person
    {
        //Constructor
        public Organizer(string personID, string username, string password, string email, string contactNumber) : base(personID, username, password, email, contactNumber, "organizer")
        {
        }

    }
}

