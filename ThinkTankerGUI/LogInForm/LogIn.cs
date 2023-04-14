using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkTankerClasses.Databases;
using ThinkTankerGUI.MainMenuForm;
using ThinkTankerGUI.SignUpForm;

namespace ThinkTankerGUI.LogInForm
{
    public partial class LogIn : Form
    {
        public static MainMenu mainMenu = new();
        public static SignUp signUp = new();
        //public static User user = new();
        public LogIn()
        {
            InitializeComponent();
            this.AcceptButton = signInB;
            this.FormClosing += LogIn_FormClosing;
        }

        private void LogIn_FormClosing(object? sender, FormClosingEventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
        private void SignUp_Click(object sender, EventArgs e)
        {
            LogIn.signUp.ShowDialog(this);
            this.Show();
        }
        private void signInB_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogIn.mainMenu.ShowDialog(this);
            this.Show();

            /* bool canLogin = false;

             foreach (var u in )
             {
                 if (u.CanLogIn(usernameTB.Text, passwordTB.Text))
                 {
                     // creation partial database

                     this.Hide();
                     LogIn.mainMenu.ShowDialog(this);
                     this.Show();
                     canLogin = true;
                     break;
                 }
             }

             if (!canLogin)
                 MessageBox.Show("Invalid Username and Password!");*/


            /* this.Hide();
             LogIn.mainMenu.ShowDialog(this);
             this.Show();*/
        }



    }
}
