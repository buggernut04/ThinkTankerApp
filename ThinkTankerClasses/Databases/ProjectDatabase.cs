using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerClasses.Databases
{
    public class ProjectDatabase
    {
        private static string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;

        private static string userListFileName = "userrecord.thinktanker";
        public static List<User> UserRecord = new List<User>();

        private static string quizRecordFileName = "quizrecord.thinktanker";
        public static List<QuizUserRecord> QuizRecord = new List<QuizUserRecord>();

        private static string matchingGameRecordFileName = "matchGameRec.thinktanker";
        public static List<MatchingGameRecord> MatchingGameRecord = new List<MatchingGameRecord>();

        public static void SaveUserRecord()
        {
            string json = JsonConvert.SerializeObject(UserRecord);
            File.WriteAllText(Path.Combine(rootDirectory, userListFileName), json);
        }

        public static void LoadUserRecord()
        {
            if (!File.Exists(Path.Combine(rootDirectory, userListFileName)))
                using (StreamWriter writer = new StreamWriter(Path.Combine(rootDirectory, userListFileName)));

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
            if (!File.Exists(Path.Combine(rootDirectory, quizRecordFileName)))
                using (StreamWriter writer = new StreamWriter(Path.Combine(rootDirectory, quizRecordFileName)));

            string json = File.ReadAllText(Path.Combine(rootDirectory, quizRecordFileName));
            QuizRecord = Newtonsoft.Json.JsonConvert.DeserializeObject<List<QuizUserRecord>>(json);
        }

        public static void SaveMatchingGameRecord()
        {
            string json = JsonConvert.SerializeObject(MatchingGameRecord);
            File.WriteAllText(Path.Combine(rootDirectory, matchingGameRecordFileName), json);
        }

        public static void LoadMatchingGameRecord()
        {
            if (!File.Exists(Path.Combine(rootDirectory, matchingGameRecordFileName)))
                using (StreamWriter writer = new StreamWriter(Path.Combine(rootDirectory, matchingGameRecordFileName))) ; 

            string json = File.ReadAllText(Path.Combine(rootDirectory, matchingGameRecordFileName));
            MatchingGameRecord = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MatchingGameRecord>>(json);
        }

    }
}
