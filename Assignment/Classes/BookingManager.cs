
using Assignment.Classes;
using Google.Protobuf.Compiler;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.ManagerClasses
{
    internal static class BookingManager {
        public static void RegisterToEvent(Event ev, Person participant)
        {
            string eventName = ev.GetEventName();
            string participantName = participant.GetUsername();

            if (InputValidator.CheckBookingRegister(participantName, eventName))
            {
                if (ev.GetCurrentParticipants() < ev.GetMaxParticipants())
                {
                    DBConnections dbConnection = new DBConnections();
                    try
                    {
                        dbConnection.OpenConnection();

                        string query2 = $"INSERT INTO `booking`( `participant`, `event`) VALUES ('{participantName}','{eventName}')";
                        MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                        cmd2.ExecuteNonQuery();

                        EventManager.UpdateCurrentParticipants(ev);

                        MessageBox.Show("Booking added succesfully..!");

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
                    MessageBox.Show("Cannot register : Maximum number of participants reached! ");
                }
            }



        }

        public static void UnregisterEvent(Event ev, Person participant)
        {
            string eventName = ev.GetEventName();
            string participantName = participant.GetUsername();
            if (InputValidator.CheckBookingUnregister(participantName, eventName))
            {


                DBConnections dbConnection = new DBConnections();
                try
                {
                    dbConnection.OpenConnection();

                    string query2 = $"DELETE FROM `booking` WHERE participant='{participantName}' and event='{eventName}';";
                    MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.GetConnection());
                    cmd2.ExecuteNonQuery();

                    EventManager.UpdateCurrentParticipants(ev);

                    MessageBox.Show("Booking removed succesfully..!");
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

        public static List<Event> GetAllMyEventsList(Person user)
        {
            List<Event> eventList = new List<Event>();

            string EventId;
            string Name;
            string Venue;
            string Time;
            string Date;
            int MaxParticipants;
            int CurrentParticipants;
            string Organizer;
            string ticketPrice;

            DBConnections dbConnections = new DBConnections();
            string query = $"SELECT event.* FROM event JOIN booking ON event.name = booking.event WHERE booking.participant = '{user.GetUsername()}' ORDER BY event.date ASC, event.time ASC;";
            MySqlCommand cmd = new MySqlCommand(query, dbConnections.GetConnection());

            try
            {
                dbConnections.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {

                    EventId = reader["eventId"].ToString();
                    Name = reader["name"].ToString();
                    Venue = reader["venue"].ToString();
                    Time = reader["time"].ToString();
                    Date = reader["date"].ToString();
                    MaxParticipants = Convert.ToInt32(reader["maxParticipants"].ToString());
                    CurrentParticipants = Convert.ToInt32(reader["currentParticipants"].ToString());
                    Organizer = reader["organizer"].ToString();
                    ticketPrice = reader["price"].ToString();


                    eventList.Add(new Event(Name, EventId, Venue, Time, Date, MaxParticipants, CurrentParticipants, Organizer, ticketPrice));

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

        public static List<Booking> GetAllBookingList()
        {
            List<Booking> bookingList = new List<Booking>();
            List<Event> allEventList = EventManager.GetAllEventsList();
            List<Person> allUsersList = PersonManager.GetAllUsersList();

            List<string> allEventNames = new List<string>();
            foreach (Event ev in allEventList)
            {
                allEventNames.Add(ev.GetEventName());
            }
            List<string> allUserNames = new List<string>();
            foreach (Person p in allUsersList)
            {
                allUserNames.Add(p.GetUsername());
            }

            string BookingID;
            string PARTICIPANT;
            string EVENT;

            DBConnections dbConnections = new DBConnections();
            string query = $"SELECT * FROM `booking`";
            MySqlCommand cmd = new MySqlCommand(query, dbConnections.GetConnection());

            try
            {
                dbConnections.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    BookingID = reader["bookingID"].ToString();
                    PARTICIPANT = reader["participant"].ToString();
                    EVENT = reader["event"].ToString();

                    Event bookedEvent = allEventList[allEventNames.IndexOf(EVENT)];
                    Person bookedUser = allUsersList[allUserNames.IndexOf(PARTICIPANT)];

                    bookingList.Add(new Booking(BookingID, bookedEvent, bookedUser));

                }

                return bookingList;
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
    } 
}

