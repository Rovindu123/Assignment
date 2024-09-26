using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    public class Person
    {
        private string personID;
        private string username;
        private string password;
        private string email;
        private string contactNumber;
        private string role;

        //Constructor
        public Person(string personID, string username, string password, string email, string contactNumber, string role) 
        {
            this.personID = personID;
            this.username = username;
            this.password = password;
            this.email = email;
            this.contactNumber = contactNumber;
            this.role = role;
        }

        //Getters and Setters
        public string GetUsername() { return username; }
        public string GetRole() { return role; }

    }
}
