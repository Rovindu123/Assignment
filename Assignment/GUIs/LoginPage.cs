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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            usernametxt.Text = "";
            pwtxt.Text = "";

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
           string un =  usernametxt.Text;
           string pw = pwtxt.Text;

           Person loggedInUser = PersonManager.AuthenticateUser(un,pw);
            if (loggedInUser != null) 
            {
                Dashboard dashboard = new Dashboard(loggedInUser);
                dashboard.ShowDialog();
            
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        { 
            Registration registration = new Registration();
            registration.Show();
            

        }

        private void showpw_CheckedChanged(object sender, EventArgs e)
        {
            if (showpw.Checked)
            {
                
                MessageBox.Show("aa");
            }
            else
            {
                pwtxt.Text = pwtxt.Text;
            } 
        }
        
    }
}
