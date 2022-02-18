using Restaurant_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.Presentation_Layer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            if (userDataAccess.LoginValidation(usernameTextBox.Text, passwordTextBox.Text))
            {
                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password ");
            }
        }

        private void userRegistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
