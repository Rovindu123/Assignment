using Assignment.Classes;
using Assignment.ManagerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.GUIs
{
    public partial class CreateBookings : Form
    {
        List<string> NamesofAllUsers = new List<string>(); 
        List<string> NamesofAllEvents = new List<string>();

        List<Event> allEvents = EventManager.getAllEventsList();
        List<Person> allUsers = PersonManager.getAllUsersList();

        
        public CreateBookings()
        {
            InitializeComponent();
            foreach (Classes.Person user in allUsers)
            {
                NamesofAllUsers.Add(user.GetUsername());
                partselectbox.Items.Add(user.GetUsername());
            }

            foreach(Classes.Event ev in allEvents){

                NamesofAllEvents.Add(ev.GetEventName());
                eventselectbox.Items.Add(ev.GetEventName());

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void createbookingbtn_Click(object sender, EventArgs e)
        {
            string Participant = partselectbox.Text;
            string evenT = eventselectbox.Text;

            if (NamesofAllUsers.Contains(Participant))
            {
                if (NamesofAllEvents.Contains(evenT))
                {
                    Person partcipant = allUsers[NamesofAllUsers.IndexOf(Participant)];
                    Event Event = allEvents[NamesofAllEvents.IndexOf(evenT)];
                    BookingManager.RegisterToEvent(Event,partcipant);

                }
                else
                {
                    MessageBox.Show("Invalid Event");
                }

            }
            else
            {
                MessageBox.Show("Invalid participant");
            }
           

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBookings_Load(object sender, EventArgs e)
        {

        }
    }
}
