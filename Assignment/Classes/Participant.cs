using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    internal class Participant : Person
    {
        //Constructor
        public Participant(string personID, string username, string password, string email, string contactNumber) : base(personID, username, password, email, contactNumber, "participant")
        {
        }

    }

}

