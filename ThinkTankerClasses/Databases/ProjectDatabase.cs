using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace ThinkTankerClasses.Databases
{
    public class ProjectDatabase
    {
        //private static string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;

        private static string userListFileName = "userrecord.json";
        private static string userCombinePath =  Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), userListFileName);
        //private static string userCombinePath = Path.Combine(rootDirectory, userListFileName);
        public static List<User> UserRecord = new List<User>();


        private static string quizRecordFileName = "quizrecord.json";
        private static string quizCombinePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), quizRecordFileName);
        public static List<QuizUserRecord> QuizRecord = new List<QuizUserRecord>();

        private static string matchingGameRecordFileName = "matchGameRec.json";
        private static string matchCombinePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), matchingGameRecordFileName);
        public static List<MatchingGameRecord> MatchingGameRecord = new List<MatchingGameRecord>();

        public static void SaveUserRecord()
        {
            string json = JsonConvert.SerializeObject(UserRecord);
            File.WriteAllText(userCombinePath, json);
        }

        public static void LoadUserRecord()
        {
            if (!File.Exists(Path.Combine(userCombinePath)))
                using (StreamWriter writer = new StreamWriter(userCombinePath));

            dynamic json = File.ReadAllText(userCombinePath);
            UserRecord = JsonConvert.DeserializeObject<List<User>>(json);
        }

        public static void SaveQuizRecord()
        {
            string json = JsonConvert.SerializeObject(QuizRecord);
            File.WriteAllText(quizCombinePath, json);
        }

        public static void LoadQuizRecord()
        {
            if (!File.Exists(quizCombinePath))
                using (StreamWriter writer = new StreamWriter(quizCombinePath)) ;

            string json = File.ReadAllText(quizCombinePath);
            QuizRecord = Newtonsoft.Json.JsonConvert.DeserializeObject<List<QuizUserRecord>>(json);
        }

        public static void SaveMatchingGameRecord()
        {
            string json = JsonConvert.SerializeObject(MatchingGameRecord);
            File.WriteAllText(matchCombinePath, json);
        }

        public static void LoadMatchingGameRecord()
        {
            if (!File.Exists(matchCombinePath))
                using (StreamWriter writer = new StreamWriter(matchCombinePath)) ;

            string json = File.ReadAllText(matchCombinePath);
            MatchingGameRecord = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MatchingGameRecord>>(json);
        }

    }
}
