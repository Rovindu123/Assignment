using Google.Protobuf.Compiler;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Classes
{
    internal static class EventManager
    {
        public static List<Event> GetAllEventsList()
        {
            List<Event> eventList = new List<Event>();


            string EventID;
            string Name;
            string Venue;
            string Time;
            string Date;
            int MaxParticipants;
            int CurrentParticipants;
            string Organizer;
            string Ticket;


            DBConnections dbConnections = new DBConnections();
            string query = $"SELECT * FROM `event` ORDER BY date ASC, time ASC;";
            MySqlCommand cmd = new MySqlCommand(query, dbConnections.GetConnection());

            try
            {
                dbConnections.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {

                    EventID = reader["eventId"].ToString();
                    Name = reader["name"].ToString();
                    Venue = reader["venue"].ToString();
                    Time = reader["time"].ToString();
                    Date = reader["date"].ToString();
                    MaxParticipants = Convert.ToInt32(reader["maxParticipants"].ToString());
                    CurrentParticipants = Convert.ToInt32(reader["currentParticipants"].ToString());
                    Organizer = reader["organizer"].ToString();
                    Ticket = reader["price"].ToString();


                    eventList.Add(new Event(Name, EventID, Venue, Time, Date, MaxParticipants, CurrentParticipants, Organizer, Ticket));

                }
                return eventList;
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
            return null;
        }

        public static void CreateEvent(string name, string venue, string time, string date, string maxparticipant, Person organizer,string price)
        {
            if (InputValidator.validateEventName(name))
            {

                DBConnections dbConnection = new DBConnections();
                try
                {
                    dbConnection.OpenConnection();



                    string query2 = $"INSERT INTO `event`(`name`, `venue`, `time`, `date`, `maxParticipants`, `organizer`,`price`) VALUES ('{name}','{venue}','{time}','{date}','{maxparticipant}','{organizer.GetUsername()}','{price}')";
                    MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Event successfully created..");



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
     
        public static void DeleteEvent(Event ev)
        {


           
            DBConnections dbConnection = new DBConnections();
            try
            {
                
                dbConnection.OpenConnection();



                string query2 = $"DELETE FROM event WHERE eventid = '{ev.GetEventID()}'";
                MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Event successfully deleted..");



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

        public static void EditEvent(Event ev, string name, string venue, string time, string date, string maxParticipants,string price)
        {
            string evId = ev.GetEventID();
            string evName = name;
            string evVenue = venue;
            string evTime = time;
            string evdate = date;
            string evMaxP = maxParticipants;
            string evPrice = price;

            if (name == "")
            {
                evName = ev.GetEventName();
            }
            if (venue == "")
            {
                evVenue = ev.GetVenue();
            }
            if (time == "0:0")
            {
                evTime = ev.GetTime();
            }
            if (date == "0-0-0")
            {
                evdate = ev.GetDate();

            }
            if (maxParticipants == "0")
            {
                evMaxP = $"{ev.GetMaxParticipants()}";
            }
            if (price == "")
            {
                evPrice = ev.GetTicketPrice();
            }





            DBConnections dbConnection = new DBConnections();
            try
            {
                dbConnection.OpenConnection();


                string query2 = $"UPDATE event SET name='{evName}', venue='{evVenue}', time='{evTime}', date='{evdate}', maxParticipants='{evMaxP}',price='{evPrice}' WHERE eventID = '{evId}';";
                MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Event successfully Updated..");





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

      
        public static void UpdateCurrentParticipants(Event ev)
        {
            int participantCount = 0;

            DBConnections dbConnections = new DBConnections();
            string query = $"SELECT * FROM `booking` WHERE event='{ev.GetEventName()}';";
            MySqlCommand cmd = new MySqlCommand(query, dbConnections.GetConnection());

            try
            {
                dbConnections.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    participantCount += 1;


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





            DBConnections dbConnection = new DBConnections();
            try
            {
                dbConnection.OpenConnection();


                string query2 = $"UPDATE event SET currentParticipants={participantCount} WHERE eventId = '{ev.GetEventID()}';";
                MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                cmd2.ExecuteNonQuery();







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
     