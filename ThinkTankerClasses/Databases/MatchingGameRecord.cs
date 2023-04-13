using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerClasses.Databases
{
    public class MatchingGameRecord
    {
        public User LoggedInUser { get; set; }
        public DateTime LogDateTime { get; set; }
        public int TimeTaken { get; set; }

        public MatchingGameRecord(User user, DateTime logDateTime, int timeTaken) 
        {
            this.LoggedInUser = user;
            this.LogDateTime = logDateTime;
            this.TimeTaken = timeTaken;
        }
    }
}
