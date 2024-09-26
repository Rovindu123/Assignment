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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string cnumber = cnumbertxt.Text;
            string email = emailtxt.Text;
            string pw = pwtxt.Text;
            string confpw = confpwtxt.Text;
            string role = "participant";

            PersonManager.registerUser(name, pw, confpw, email, cnumber, role);
            
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
