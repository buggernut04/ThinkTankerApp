using ThinkTankerApp;

namespace ThinkTankerClassTests
{
    public class UserTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanLogIn_UserHaveAnExistingAccount_ReturnTrue()
        {
            //Arrange
            User[] u = new User[5];
            u[0] = new User("Sophie Williams", DateTime.Now, 'F', "SophieWill95", "Spr!ngBreeze23");
            u[1] = new User("David Johnson", DateTime.Now, 'M', "DavidJ88", "Bl@ckC@t1988");
            u[2] = new User("Maria Rodriguez", DateTime.Now, 'F', "MariaR2000", "Purpl3Butterfly!");
            u[3] = new User("James Lee", DateTime.Now, 'M', "JLee92", "F1reF0x@17");
            u[4] = new User("Emily Chen", DateTime.Now, 'F', "EmChen98", "R@inb0wSpr!nkles");

            //Act
            string samp_username = "MariaR2000", samp_password = "Purpl3Butterfly!";
            var result = false;

            foreach (var item in u)
                if (result = item.CanLogIn(samp_username, samp_password)) break;

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanLogIn_UserHaveNoExistingAccount_ReturnFalse()
        {
            //Arrange
            User[] u = new User[5];
            u[0] = new User("Sophie Williams", DateTime.Now, 'F', "SophieWill95", "Spr!ngBreeze23");
            u[1] = new User("David Johnson", DateTime.Now, 'M', "DavidJ88", "Bl@ckC@t1988");
            u[2] = new User("Maria Rodriguez", DateTime.Now, 'F', "MariaR2000", "Purpl3Butterfly!");
            u[3] = new User("James Lee", DateTime.Now, 'M', "JLee92", "F1reF0x@17");
            u[4] = new User("Emily Chen", DateTime.Now, 'F', "EmChen98", "R@inb0wSpr!nkles");

            //Act
            string samp_username = "McyeSalem", samp_password = "hfjdhsakw";
            var result = false;

            foreach (var item in u)
                if (result = item.CanLogIn(samp_username, samp_password)) break;

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidPassword_UserInputValidPasswordWhenSignUp_ReturnTrue()
        {
            //Arrange
            User u = new User("Sophie Williams", DateTime.Now, 'F', "SophieWill95", "Spr!ngBreeze23");

            //Act
            var result = u.IsValidPassword(u.Password);

            //Assert
            Assert.That(result, Is.True);
        }


        [Test]
        public void IsValidPassword_UserInputInValidPasswordWhenSignUp_ReturnFalse()
        {
            //Arrange
            User u = new User("Sophie Williams", DateTime.Now, 'F', "SophieWill95", "hfjsdhdfsq123");

            //Act
            var result = u.IsValidPassword(u.Password);

            //Assert
            Assert.IsFalse(result);
        }
    }
}