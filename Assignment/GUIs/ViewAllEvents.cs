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
    public partial class ViewAllEvents : Form
    {
        Person person;
        public ViewAllEvents(Person User)
        {
            this.person = User;   
            InitializeComponent();
        }

        private void regtoeventbtn_Click(object sender, EventArgs e)
        {
            RegisterToEvent event1 = new RegisterToEvent(person);
            event1.ShowDialog();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllEvents_Load(object sender, EventArgs e)
        {
            RefreshTable();


        }
        public void RefreshTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Event ID", typeof(string));
            table.Columns.Add("Event Name", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Venue", typeof(string));
            table.Columns.Add("Queue", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Organizer", typeof(string));

            List<Classes.Event> Events = Classes.EventManager.GetAllEventsList();
            foreach (Classes.Event Event in Events)
            {
                table.Rows.Add(Event.GetEventID(), Event.GetEventName(), Event.GetDate(), Event.GetTime(), Event.GetVenue(), $"{Event.GetCurrentParticipants()}/{Event.GetMaxParticipants()}",Event.GetTicketPrice(), Event.GetOrganizer());
            }

            datagrid.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
