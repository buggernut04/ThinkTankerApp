using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerApp
{
    public abstract class Quiz
    {
        public List<TestItem> Items { get; private set; }

        public Quiz()
        {
            this.Items = new List<TestItem>();
        }

        public bool IsCheck(TestItem item, string ans)
        {
            return item.CorrectAnswer == ans;
        }
        public abstract void CreateQuestion();
    }
}
