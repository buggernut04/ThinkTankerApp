using Microsoft.VisualBasic.ApplicationServices;
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
