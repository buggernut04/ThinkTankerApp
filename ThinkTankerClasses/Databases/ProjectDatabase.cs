using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Resources;
using System.ComponentModel;

namespace ThinkTankerClasses.Databases
{
    public class ProjectDatabase
    {
        private static string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;

        private static string userListFileName = "userrecord.json";
        public static List<User> UserRecord = new List<User>();


        private static string quizRecordFileName = "quizrecord.json";
        public static List<QuizUserRecord> QuizRecord = new List<QuizUserRecord>();

        private static string matchingGameRecordFileName = "matchGameRec.json";
        public static List<MatchingGameRecord> MatchingGameRecord = new List<MatchingGameRecord>();

        public static void Init()
        {
            if (!File.Exists(Path.Combine(rootDirectory, userListFileName)))
                using (StreamWriter writer = new StreamWriter(Path.Combine(rootDirectory, userListFileName))) ;
    
            LoadUserRecord();
        }
        public static List<User> UserList()
        {
            List<User> UserList = new List<User>();
            UserList.AddRange(UserRecord);

            return UserList;
        }

        public static void SaveUserRecord()
        {
            string json = JsonConvert.SerializeObject(UserRecord);
            File.WriteAllText(userListFileName, json);
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

        public static void SaveMatchingGameRecord()
        {
            string json = JsonConvert.SerializeObject(MatchingGameRecord);
            File.WriteAllText(Path.Combine(rootDirectory, matchingGameRecordFileName), json);
        }

        public static void LoadMatchingGameRecord()
        {

            string json = File.ReadAllText(Path.Combine(rootDirectory, matchingGameRecordFileName));
            MatchingGameRecord = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MatchingGameRecord>>(json);
        }

    }
}
