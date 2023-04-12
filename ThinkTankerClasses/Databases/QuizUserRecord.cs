using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerClasses.Databases
{
    public class QuizUserRecord
    {
        public DateTime LogDateTime { get; set; }
        public User User { get; set; }
        public int Score { get; set; }
        public QuizType Type { get; set; }
        public int TimeTaken { get; set; }

        public QuizUserRecord(DateTime logDateTime, User user, int score, QuizType quizType, int timeTaken)
        {
            this.LogDateTime = logDateTime;
            this.User = user;
            this.Score = score;
            this.Type = quizType;
            this.TimeTaken = timeTaken;
        }
    }
}
