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
    public partial class Dashboard : Form
    {
        Person User;
        public Dashboard(Person loggedUser)
        {
            User = loggedUser;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            unamelbl.Text = User.GetUsername();
            rolelbl.Text = User.GetRole();

            string role = User.GetRole();

            if (role == "participant")
            {
                addparttoeventbtn.Visible = false;
                viewallbookingsbtn.Visible = false;
                removepartbtn.Visible = false;
                addadminbtn.Visible = false;
                createeventbtn.Visible = false;
                editeventbtn.Visible = false;
                deleteeventbtn.Visible = false;
            }
            else if (role == "organizer" )
            {
                addparttoeventbtn.Visible = false;
                viewallbookingsbtn.Visible = false;
                removepartbtn.Visible = false;
                addadminbtn.Visible = false;
            }


            RefreshTable();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout from the account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void registertoeventbtn_Click(object sender, EventArgs e)
        {
            RegisterToEvent event1 = new RegisterToEvent(User);
            event1.ShowDialog();
        }

        private void createeventbtn_Click(object sender, EventArgs e)
        {
            CreateEvents event2 = new CreateEvents(User);
            event2.ShowDialog();
        }

        private void deleteeventbtn_Click(object sender, EventArgs e)
        {
            DeleteEvents event3 = new DeleteEvents();
            event3.ShowDialog();
        }

        private void editeventbtn_Click(object sender, EventArgs e)
        {
            EditEvents event4 = new EditEvents();
            event4.ShowDialog();
        }

        private void viewalleventsbtn_Click(object sender, EventArgs e)
        {
            ViewAllEvents event5 = new ViewAllEvents(User);
            event5.ShowDialog();
        }

        private void unregfromeventbtn_Click(object sender, EventArgs e)
        {
            UnregisterFromEvent event6 = new UnregisterFromEvent(User);
            event6.ShowDialog();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void addparttoeventbtn_Click(object sender, EventArgs e)
        {
            CreateBookings createbooking = new CreateBookings();
            createbooking.ShowDialog(); 
        }

        private void viewallbookingsbtn_Click(object sender, EventArgs e)
        {
            ViewAllBookings viewbooking = new ViewAllBookings(User);
            viewbooking.ShowDialog();
        }

        private void removepartbtn_Click(object sender, EventArgs e)
        {
            DeleteBooking deleteBooking = new DeleteBooking();
            deleteBooking.ShowDialog();
        }

        private void addadminbtn_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin();
            addAdmin.ShowDialog();  
        }

        private void RefreshTable()
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
                    table.Rows.Add(Event.GetEventID(), Event.GetEventName(), Event.GetDate(), Event.GetTime(), Event.GetVenue(), $"{Event.GetCurrentParticipants()}/{Event.GetMaxParticipants()}", Event.GetTicketPrice(), Event.GetOrganizer());
                }

                dashboardgrid.DataSource = table;
            
        }
    }
}
