using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    internal class Booking
    {
        private string bookingID;
        private Event bookingEvent;
        private Person participant;

        //Constructor
        public Booking(string bookingID, Event bookingEvent, Person participant)
        {
            this.bookingID = bookingID;
            this.bookingEvent = bookingEvent;
            this.participant = participant;
        }

        //Getters and Setters
        public string GetBookingID() { return bookingID; }
        public Event GetBookingEvent() { return bookingEvent; }
        public Person GetParticipant(){ return participant;}

        



    }
}
