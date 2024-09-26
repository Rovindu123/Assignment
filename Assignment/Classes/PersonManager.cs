using Google.Protobuf.Compiler;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment.Classes
{
    internal static class PersonManager
    {
        public static Person AuthenticateUser(string username, string password)
        {
            string Username = "";
            string Password = "";
            string PersonId = "";
            string MobileNumber = "";
            string Email = "";
            string Role = "";

            // get username and password from the database and save the respond
            DBConnections dbConnections = new DBConnections();
            string query = $"SELECT * FROM `person` where username='{username}'";
            MySqlCommand cmd = new MySqlCommand(query, dbConnections.GetConnection());

            try
            {
                dbConnections.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {

                    Username = reader["username"].ToString();
                    Password = reader["password"].ToString();
                    PersonId = reader["personid"].ToString();
                    MobileNumber = reader["mobilenumber"].ToString();
                    Role = reader["role"].ToString();
                    Email = reader["email"].ToString();
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections.CloseConnection();
            }

            if (Username == "" || Password != password)
            {
                MessageBox.Show("Invalid Username or Password!");
            }
            else
            {
                MessageBox.Show("Login Successful!");

                if (Role == "admin")
                {
                    Person user = new Admin(PersonId, Username, Password, Email, MobileNumber);
                    return user;
                }
                else if (Role == "organizer")
                {
                    Person user = new Organizer(PersonId, Username, Password, Email, MobileNumber);
                    return user;
                }
                else
                {
                    Person user = new Participant(PersonId, Username, Password, Email, MobileNumber);
                    return user;
                }
            }

            return null;
        }

        public static void registerUser(string username, string password, string confpassword, string email, string number, string role)
        {
            if (!InputValidator.Validate(username, password, confpassword, email, number, role))
            {

                if (InputValidator.ValidateRegistrationInputs(password, confpassword, role, username))
                {
                    if (InputValidator.CheckNumber(number))
                    {
                        if (!InputValidator.CheckNumber(username))
                        {
                            DBConnections dbConnection = new DBConnections();

                            try
                            {
                                dbConnection.OpenConnection();
                                string query2 = $"INSERT INTO `person`(`username`, `password`, `role`, `mobilenumber`, `email`) VALUES ('{username}','{password}','{role}','{number}','{email}')";
                                MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                                cmd2.ExecuteNonQuery();

                                MessageBox.Show("Regististration success!! \nLogin to use the application.");

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("An error occurred: " + ex.Message);
                            }
                            finally
                            {
                                dbConnection.CloseConnection();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Name cant be only numbers");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Mobile number cant have letters");
                    }



                }
            }
        }

        public static List<Person> GetAllUsersList()
        {//Return a list of all the users (in the type of person)

            //List declaration (empty at this point)
            List<Person> personList = new List<Person>();

            DBConnections dbConnections = new DBConnections();
            // get all the records from the 'person' table
            string query = $"SELECT * FROM `person`";
            MySqlCommand cmd = new MySqlCommand(query, dbConnections.GetConnection());

            try
            {
                dbConnections.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();

                //read all records one at a time
                while (reader.Read())
                {
                    //get all the data in columns and save it in variables
                    string personName = reader["username"].ToString();
                    string personID = reader["personId"].ToString();
                    string personPass = reader["password"].ToString();
                    string personRole = reader["role"].ToString();
                    string personMN = reader["mobilenumber"].ToString();
                    string personEmail = reader["email"].ToString();

                    //create person object according to the role. and add it to the the personList.

                    if (personRole == "admin")
                    {
                        personList.Add(new Admin(personID, personName, personPass, personMN, personEmail));
                    }
                    else if (personRole == "organizer")
                    {
                        personList.Add(new Organizer(personID, personName, personPass, personMN, personEmail));
                    }
                    else
                    {
                        personList.Add(new Participant(personID, personName, personPass, personMN, personEmail));
                    }

                }
                // return person list(contains all the users )
                return personList;
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections.CloseConnection();
            }
            // if theres no users in the database return null 
            return null;
        }

        public static void ChangeRole(string user, string role)
        {


            DBConnections dbConnection = new DBConnections();

            try
            {
                dbConnection.OpenConnection();



                string query2 = $"UPDATE person SET role = '{role}' WHERE username = '{user}';";
                MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                cmd2.ExecuteNonQuery();

                MessageBox.Show($"Role change successful ..");

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
    }
}


        