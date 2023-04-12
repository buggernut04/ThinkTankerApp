using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerClasses
{
    public class TestItem
    {
        public string Question { get; private set; }
        public string CorrectAnswer { get; private set; }
        public TestItem(string question, string correctAnswer)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
        }

        public static implicit operator int(TestItem v)
        {
            throw new NotImplementedException();
        }
    }
}
