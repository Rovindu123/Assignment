using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Classes
{
    internal static class InputValidator
    {
        public static bool Validate(params string[] fields)
        {
            bool emptyFields = false;
            foreach (string field in fields)
            {
                if (field == "")
                {
                    emptyFields = true;
                }
            }
            if (emptyFields)
            {
                MessageBox.Show("Please fill all fields");
            }
            return emptyFields;

        }

        public static bool CheckBookingUnregister(string participant, string ev)
        {
            bool nameValid = false;

            DBConnections dbConnections5 = new DBConnections();
            string query5 = $"SELECT * FROM `booking` where participant='{participant}' and event='{ev}'";
            MySqlCommand cmd5 = new MySqlCommand(query5, dbConnections5.GetConnection());

            try
            {
                dbConnections5.OpenConnection();
                MySqlDataReader reader5 = cmd5.ExecuteReader();


                if (reader5.HasRows)
                {

                    nameValid = true;




                }
                else
                {
                    MessageBox.Show("Booking does not exist ..Cannot remove booking");
                }

                reader5.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections5.CloseConnection();
            }
            return nameValid;

        }

        public static bool CheckBookingRegister(string participant, string ev)
        {
            bool nameValid = false;

            DBConnections dbConnections5 = new DBConnections();
            string query5 = $"SELECT * FROM `booking` where participant='{participant}' and event='{ev}'";
            MySqlCommand cmd5 = new MySqlCommand(query5, dbConnections5.GetConnection());

            try
            {
                dbConnections5.OpenConnection();
                MySqlDataReader reader5 = cmd5.ExecuteReader();


                if (!reader5.HasRows)
                {

                    nameValid = true;




                }
                else
                {
                    MessageBox.Show("Booking  already Exists.. cannot add booking");
                }

                reader5.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections5.CloseConnection();
            }
            return nameValid;

        }
        public static bool validateEventName(string name)
        {
            bool nameValid = false;

            DBConnections dbConnections5 = new DBConnections();
            string query5 = $"SELECT * FROM `event` where name='{name}'";
            MySqlCommand cmd5 = new MySqlCommand(query5, dbConnections5.GetConnection());

            try
            {
                dbConnections5.OpenConnection();
                MySqlDataReader reader5 = cmd5.ExecuteReader();


                if (!reader5.HasRows)
                {

                    nameValid = true;




                }
                else
                {
                    MessageBox.Show("Event name already Exists..");
                }

                reader5.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections5.CloseConnection();
            }
            return nameValid;

        }

        public static bool ValidateRegistrationInputs(string password, string confpassword, string role, string username)
        {
            bool usernameValid = false;

            DBConnections dbConnections5 = new DBConnections();
            string query5 = $"SELECT * FROM `person` where username='{username}'";
            MySqlCommand cmd5 = new MySqlCommand(query5, dbConnections5.GetConnection());

            try
            {
                dbConnections5.OpenConnection();
                MySqlDataReader reader5 = cmd5.ExecuteReader();


                if (!reader5.HasRows)
                {

                    usernameValid = true;




                }

                reader5.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                dbConnections5.CloseConnection();
            }




            if (usernameValid)
            {
                if (password == confpassword)
                {

                    return true;



                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Username already exists..\nPlease Login..");
                return false;
            }



        }

        public static bool CheckNumber(string inputText)
        {
            bool onlyhasNumber = true;
            foreach (char ch in inputText)
            {
                if (char.IsNumber(ch))
                {

                }else
                {
                    onlyhasNumber = false;
                }
            }
            return onlyhasNumber;
        }
    }

}