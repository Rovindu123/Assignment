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
    public partial class EditEvents : Form
    {
        List<Classes.Event> allEvents = Classes.EventManager.getAllEventsList();
        List<string> allNamesOfEvents = new List<string>();

        public EditEvents()
        {
            InitializeComponent();

            int index  = 0;
            while (true)
            {
                
                if (index >= allEvents.Count)
                {
                    
                    break;

                }
                string NameOfEvent = allEvents[index].GetEventName();
                allNamesOfEvents.Add(NameOfEvent);
                selecteventbox.Items.Add(NameOfEvent);
               
                

                index++;
                
            
            }

        }

        private void EditEvents_Load(object sender, EventArgs e)
        {

        }

        private void savechangesbtn_Click(object sender, EventArgs e)
        {
            string newEventName = eventnametxt.Text;
            string newEventVenue = eventvenuetxt.Text;
            string newEventTime = $"{numericUpDown2.Value}:{numericUpDown1.Value}";
            string newEventDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            int eventYear = Convert.ToInt32(newEventDate.Substring(0, 4));
            int eventMonth = Convert.ToInt32(newEventDate.Substring(5, 2));
            int eventDay = Convert.ToInt32((newEventDate.Substring(8, 2)));

            string newMaxP = Convert.ToString(numericUpDown3.Value);
            string newPrice = ticketpricetxt.Text;

            DateTime today = DateTime.Today;

            DateTime evDate = new DateTime(eventYear, eventMonth, eventDay);

            if (allNamesOfEvents.Contains(selecteventbox.Text))
            {



                if (evDate > today)
                {
                    Classes.Event eventToEdit = allEvents[allNamesOfEvents.IndexOf(selecteventbox.Text)];
                    Classes.EventManager.editEvent(eventToEdit,newEventName,newEventVenue,newEventTime,newEventDate,newMaxP,newPrice);

                }

                else
                {
                    MessageBox.Show("Please select an upcoming Date");
                }
            }
            else
            {
                MessageBox.Show("selected event invalid .");
            }


        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
