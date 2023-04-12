using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkTankerApp;

namespace ThinkTankerClasses.Databases
{
    public class ProjectDatabase
    {
        private static string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;

        private static string userListFileName = "userrecord.thinktanker";
        public static List<User> UserRecord = new List<User>();

        private static string quizRecordFileName = "quizrecord.thinktanker";
        public static List<QuizUserRecord> QuizRecord = new List<QuizUserRecord>();

        public static void SaveUserRecord()
        {
            string json = JsonConvert.SerializeObject(UserRecord);
            File.WriteAllText(Path.Combine(rootDirectory, userListFileName), json);
        }

        public static void LoadUserRecord()
        {
            string json = File.ReadAllText(Path.Combine(rootDirectory, userListFileName));
            UserRecord = JsonConvert.DeserializeObject<List<User>>(json);
        }

        public static void SaveQuizRecord()
        {
            string json = JsonConvert.SerializeObject(QuizRecord);
            File.WriteAllText(Path.Combine(rootDirectory, quizRecordFileName), json);
        }

        public static void LoadQuizRecord()
        {
            string json = File.ReadAllText(Path.Combine(rootDirectory, quizRecordFileName));
            QuizRecord = Newtonsoft.Json.JsonConvert.DeserializeObject<List<QuizUserRecord>>(json);
        }


    }
}
