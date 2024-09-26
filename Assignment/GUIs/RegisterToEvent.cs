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
    public partial class RegisterToEvent : Form
    {
        List<Event> events = EventManager.GetAllEventsList();
        List<string> eventNames = new List<string>();

        Person person;
        public RegisterToEvent(Person User)
        {
            person = User;
            InitializeComponent();

            foreach (Event e in events) 
            {
                string eventName = e.GetEventName();
                eventselectbox.Items.Add(eventName);    
                eventNames.Add(eventName);

            }
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            string eventName = eventselectbox.Text;

            if (eventNames.Contains(eventName))
            {
                BookingManager.RegisterToEvent(events[eventNames.IndexOf(eventName)],person);
            }
            else
            {
                MessageBox.Show("Event name invalid");
            }
        }

        private void RegisterToEvent_Load(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
