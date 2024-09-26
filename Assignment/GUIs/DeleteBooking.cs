using Assignment.Classes;
using Assignment.ManagerClasses;
using Google.Protobuf.Compiler;
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
    public partial class DeleteBooking : Form
    {
        List<string> NamesofallUsers = new List<string>();
        List<string> NamesofallEvents = new List<string>();
        List<Classes.Event> allevents = Classes.EventManager.getAllEventsList();
        List<Classes.Person> allusers = Classes.PersonManager.getAllUsersList();


        public DeleteBooking()
        {
            InitializeComponent();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectpartlbl_Click(object sender, EventArgs e)
        {

        }

        private void createbookingbtn_Click(object sender, EventArgs e)
        {
            string participant = partselectorbox.Text;
            string evenT = eventselectbox.Text;
            if (participant == "")
            {
                MessageBox.Show("Select a user");
            }
            else if (NamesofallUsers.Contains(participant))
            {
                if (evenT == "")
                {
                    MessageBox.Show("Select an event");
                }
                else if (NamesofallEvents.Contains(evenT))
                {
                    Person selectedPerson = allusers[NamesofallUsers.IndexOf(participant)];
                    Event selectedEvent = allevents[NamesofallEvents.IndexOf(evenT)];
                    BookingManager.unregisterEvent(selectedEvent, selectedPerson);

                }
                else
                {
                    MessageBox.Show($"Event does not exist");
                }

            }
            else
            {
                MessageBox.Show($"User  does not exist");
            }


        }

        private void selecteventlbl_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBooking_Load(object sender, EventArgs e)
        {
            foreach (Classes.Person user in allusers)
            {
                partselectorbox.Items.Add(user.GetUsername());
                NamesofallUsers.Add(user.GetUsername());
            }

            foreach (Classes.Event name in allevents)
            {
                eventselectbox.Items.Add(name.GetEventName());
                NamesofallEvents.Add(name.GetEventName());

            }

        }
    }
}
