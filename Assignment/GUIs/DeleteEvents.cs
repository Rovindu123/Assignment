using Assignment.Classes;
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
    public partial class DeleteEvents : Form
    {
        List<Classes.Event> allEvents = Classes.EventManager.getAllEventsList();
        List<string> allNamesOfEvents = new List<string>();
        public DeleteEvents()
        {
            InitializeComponent();
            int index = 0;
            while (true)
            {

                if (index >= allEvents.Count)
                {

                    break;

                }
                string NameOfEvent = allEvents[index].GetEventName();
                allNamesOfEvents.Add(NameOfEvent);
                eventselectbox.Items.Add(NameOfEvent);



                index++;


            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventselectbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DeleteEvents_Load(object sender, EventArgs e)
        {

        }

        private void deleteeventbtn_Click(object sender, EventArgs e)
        {
            string eventName = eventselectbox.Text;

            if (!InputValidator.Validate(eventName))
            {
                if (allNamesOfEvents.Contains(eventName))
                {
                    Classes.Event EventToDelete = allEvents[allNamesOfEvents.IndexOf(eventName)];
                    Classes.EventManager.deleteEvent(EventToDelete);

                    

                }
                else
                {
                    MessageBox.Show("Invalid event name");
                }

            }
            
        }
    }
}
