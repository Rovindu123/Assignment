using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    internal class Event
    {
        private string eventName;
        private string eventID;
        private string venue;
        private string time;
        private string date;
        private int maxParticipants;
        private int currentParticipants;
        private string organizer;
        private string ticketPrice;

        //Constructor
        public Event(string eventName, string eventID, string venue,string time,string date, int maxParticipants, int currentParticipants, string organizer, string ticketPrice)
        { 
            this.eventName = eventName;
            this.eventID = eventID;
            this.venue = venue;
            this.time = time;
            this.date = date;
            this.maxParticipants = maxParticipants;
            this.currentParticipants = currentParticipants;
            this.organizer = organizer;
            this.ticketPrice = ticketPrice;
        }

        //Getters and Setters
        public string GetEventName() { return eventName; }
        public string GetEventID() { return eventID; }
        public string GetVenue() { return venue; }  
        public string GetTime() { return time; }
        public string GetDate() 
        {
            string Date = date.Substring(0, 9);
            int indexOfDash = Date.IndexOf("/");
            int lastIndexOfDash = Date.LastIndexOf("/");
            string month = Date.Substring(0, indexOfDash);
            string day = Date.Substring(indexOfDash + 1, lastIndexOfDash - 2);
            if (day.Contains("/"))
            {
                day = day.Replace("/", "");
            }
            string year = Date.Substring(lastIndexOfDash + 1);

            string Date2 = $"{year}-{month}-{day}";


            return Date2;
        }
        public int GetMaxParticipants() { return maxParticipants; }
        public int GetCurrentParticipants() {return currentParticipants; }
        public string GetOrganizer() { return organizer; }
        public string GetTicketPrice() { return ticketPrice; }

    }
}
