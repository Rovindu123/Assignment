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
    public partial class CreateEvents : Form
    {
        Person organizer;
        public CreateEvents(Person User)
        {
            organizer = User;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateEvents_Load(object sender, EventArgs e)
        {

        }

        private void maxparts_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timemins_ValueChanged(object sender, EventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            string eventName = eventnametxt.Text;
            string venue = venuetxt.Text;
            string eventDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int eventYear = Convert.ToInt32(eventDate.Substring(0, 4));
            int eventMonth = Convert.ToInt32(eventDate.Substring(5,2));
            int eventDay = Convert.ToInt32((eventDate.Substring(8,2)));
            string timehrs = timegours.Value.ToString();
            string timemin = timemins.Value.ToString();
            string maxParts = maxparts.Value.ToString();
            string ticketPrice = ticketprctxt.Text;

            DateTime today = DateTime.Today;

            DateTime evDate = new DateTime(eventYear, eventMonth, eventDay);





            if (!InputValidator.Validate(eventName, venue))
            {
                
                if (evDate > today)
                {
                    EventManager.createEvent(eventName, venue, $"{timehrs}:{timemin}", $"{eventDate}", maxParts, organizer, ticketPrice);
                }
                else
                {
                    MessageBox.Show("Please select an upcoming Date");
                }
            }
            
            
        }

        private void eventnametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
