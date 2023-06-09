﻿using Microsoft.VisualBasic.ApplicationServices;
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
        public LogIn()
        {
            InitializeComponent();
            this.AcceptButton = signInB;
            this.FormClosing += LogIn_FormClosing;
            mainMenu.formClosed += MainMenu_formClosed;
        }

        private void MainMenu_formClosed(object? sender, EventArgs e)
        {
            this.Show();
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
            bool successfulLogin = false;
            
            foreach(var u in ProjectDatabase.UserList())
            {
                if(u.CanLogIn(usernameTB.Text, passwordTB.Text))
                {
                    this.Hide();
                    successfulLogin = true;
                    mainMenu.Show();
                    break;
                }
            }

            if(!successfulLogin)
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }



    }
}
