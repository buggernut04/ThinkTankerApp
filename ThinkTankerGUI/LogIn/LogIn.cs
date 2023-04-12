using Microsoft.VisualBasic.ApplicationServices;
using Study_Application.Classes;
using Study_Application.Forms.MainMenuForm;
using Study_Application.Forms.SignUpForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = Study_Application.Classes.User;

namespace Study_Application.Forms.LogIn
{
    public partial class LogIn : Form
    {
        public static MainMenu mainMenu = new();
        public static SignUp signUp = new();
        public static User player = null;

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

            if (usernameTB.Text == "hello" && passwordTB.Text == "hello")
            {
                LogIn.mainMenu.ShowDialog(this);
                this.Show();
            }
            else
                MessageBox.Show("Invalid Username and Password!");
        }
    }
}
