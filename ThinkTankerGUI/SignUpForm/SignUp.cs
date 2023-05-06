using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkTankerClasses;
using ThinkTankerClasses.Databases;
using ThinkTankerGUI.LogInForm;

namespace ThinkTankerGUI.SignUpForm
{
    public partial class SignUp : Form
    {
        public static LogIn logIn = new();

        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }
        private void gradientCus1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signUp_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTB.Text))
            {
                MessageBox.Show("Name is a required field!");

            }
            else if (string.IsNullOrEmpty(userNameTB.Text))
            {
                MessageBox.Show("Username is a required field!");

            }
            else if (!User.IsValidPassword(passwordTB.Text))
            {
                MessageBox.Show("Invalid Password Credentials!\n-Password must be at least 8 characters long\n-Contain at least one uppercase letter\n-Contain at least one lowercase letter\n-Contain at least one digit\n-Contain at least one special character\r");
                passwordTB.Text = passwordTB.Text.Substring(0, passwordTB.Text.Length - passwordTB.Text.Length);
                conpasswordTB.Text = conpasswordTB.Text.Substring(0, conpasswordTB.Text.Length - conpasswordTB.Text.Length);
            }
            else if (!conpasswordTB.Text.Equals(passwordTB.Text))
            {
                MessageBox.Show("Inputted password must be the same in this field!");
                conpasswordTB.Text = conpasswordTB.Text.Substring(0, conpasswordTB.Text.Length - conpasswordTB.Text.Length);
            }
            else
            {
                ProjectDatabase.UserRecord.Add(new User(nameTB.Text, birthDatePicker.Value, 'M', userNameTB.Text, passwordTB.Text));
                ProjectDatabase.SaveUserRecord();
                MessageBox.Show("Successfully Created");
                this.Close();
            }


        }
    }
}
