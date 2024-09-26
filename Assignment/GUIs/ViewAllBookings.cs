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
    public partial class ViewAllBookings : Form
    {
        

        Person User;
        public ViewAllBookings(Person User)
        {
            this.User = User;
            InitializeComponent();
        }

        private void removepartbtn_Click(object sender, EventArgs e)
        {
             DeleteBooking event1 = new DeleteBooking();
            event1.Show();
        }

        private void ViewAllBookings_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        public void refreshTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("bookingID", typeof(string));
            table.Columns.Add("Participant", typeof(string));
            table.Columns.Add("Event", typeof(string));

            List<Booking> allBookings = BookingManager.GetAllBookingList();

            foreach (Booking booking in allBookings)
            {
                table.Rows.Add(booking.GetBookingID(), booking.GetParticipant().GetUsername(), booking.GetBookingEvent().GetEventName());

            }

            allbookingsgrid.DataSource = table;
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
