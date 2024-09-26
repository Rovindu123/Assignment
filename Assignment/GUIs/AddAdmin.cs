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
    public partial class AddAdmin : Form
    {
        List<string> NamesofAllUsers = new List<string>();  
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savechangesbtn_Click(object sender, EventArgs e)
        {
            string person = selectuserbox.Text;
            string newRole = "";
            if (adminrole.Checked)
            {
                 newRole = "admin";
            }
            else if (organizerrole.Checked)
            {
                 newRole = "organizer";
            }
            


            if (NamesofAllUsers.Contains(person))
            {
                if (newRole != "")
                {
                    PersonManager.ChangeRole(person, newRole);
                }
                else
                {
                    MessageBox.Show("Please select a role");
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid usersname");
            }

        }
        
        private void AddAdmin_Load(object sender, EventArgs e)
        {
            List<Person> Users = PersonManager.GetAllUsersList();
            foreach (Person person in Users)
            {
                string username = person.GetUsername();
                selectuserbox.Items.Add(username);
                NamesofAllUsers.Add(username);  
            }
        }
    }
}
