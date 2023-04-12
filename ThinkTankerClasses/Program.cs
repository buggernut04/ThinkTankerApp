using ThinkTankerClasses.Databases;

namespace ThinkTankerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<User> user = new List<User>();

            user.Add(new User("Cye", DateTime.Now, 'M', "fhjsdhfd", "uriewiur123"));
            user.Add(new User("Youmu", DateTime.Now, 'M', "fhjsdhfd", "uriewiur123"));
            user.Add(new User("Kaloy", DateTime.Now, 'M', "fhjsdhfd", "uriewiur123"));
            user.Add(new User("Alvin", DateTime.Now, 'M', "fhjsdhfd", "uriewiur123"));
            user.Add(new User("Rea", DateTime.Now, 'M', "fhjsdhfd", "uriewiur123"));

           
            foreach(var u in user)
            {
                ProjectDatabase.UserRecord.Add(u);
            }

            ProjectDatabase.LoadUserRecord();

            ProjectDatabase.SaveUserRecord();

            

        }
    }
}