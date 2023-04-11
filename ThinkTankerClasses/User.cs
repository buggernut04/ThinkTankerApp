using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerClasses
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public char Sex { get; set; }

        public string Username { get; private set; }
        public string Password { get; private set; }
        //constructor
        public User(string name, DateTime birthdate, char sex, string username, string password)
        {
            this.Name = name;
            this.BirthDate = birthdate;
            this.Sex = sex;
            this.Username = username;
            this.Password = password;
        }
        public bool CanLogIn(string username, string password)
        {
            return Username.Equals(username) && Password.Equals(password);
        }

        public bool IsValidPassword(string password)
        {
            // Password must be at least 8 characters long
            // Password must contain at least one uppercase letter
            // Password must contain at least one lowercase letter
            // Password must contain at least one digit
            // Password must contain at least one special character

            if (password.Length < 8 || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit) || !password.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            return true;
        }
    }
}
