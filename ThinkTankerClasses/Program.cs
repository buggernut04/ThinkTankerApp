using ThinkTankerClasses.Databases;

namespace ThinkTankerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<User> u = new List<User>();
            //u.Add(new User("Salem", DateTime.Now, 'M', "fdskfdjf", "12312jdhsj"));

            /*u.Add(new User("kjfsdkjfd", DateTime.Now, 'M', "fdskfdjf", "12312jdhsj"));
            u.Add(new User("Kaloy", DateTime.Now, 'M', "fdskfdjf", "12312jdhsj"));
            u.Add(new User("hey", DateTime.Now, 'M', "fdskfdjf", "12312jdhsj"));
            u.Add(new User("sup", DateTime.Now, 'M', "fdskfdjf", "12312jdhsj"));

            foreach (var user in u)
            {
                ProjectDatabase.UserRecord.Add(user);
            }

            ProjectDatabase.SaveUserRecord();*/

            

            ProjectDatabase.UserRecord.Add(new User("Michael Cye R. Salem", DateTime.Now, 'M', "buggernut04", "gwapoko123"));

            //ProjectDatabase.LoadUserRecord();


            ProjectDatabase.SaveUserRecord();



        }
    }
}