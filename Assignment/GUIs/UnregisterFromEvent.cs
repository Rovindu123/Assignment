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
    public partial class UnregisterFromEvent : Form
    {
        List<Event> events = EventManager.GetAllEventsList();
        List<string> eventNames = new List<string>();

        Person person;
        public UnregisterFromEvent(Person User)
        {
            person = User;
            InitializeComponent();

            foreach (Event e in events)
            {
                string eventName = e.GetEventName();
                comboBox1.Items.Add(eventName);
                eventNames.Add(eventName);

            }
        }

        private void viewalleventsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unregfromeventbtn_Click(object sender, EventArgs e)
        {
            string eventName = comboBox1.Text;
            

            if (eventNames.Contains(eventName))
            {
                BookingManager.UnregisterEvent(events[eventNames.IndexOf(eventName)], person);
            }
            else
            {
                MessageBox.Show("Event name invalid");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UnregisterFromEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
