﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerApp
{
    public class TestItem
    {
        public string Question { get; private set; }
        public string CorrectAnswer { get; private set; }
        public bool IsCorrectAnswer { get; set; }
        public TestItem(string question, string correctAnswer)
        {
            this.Question = question;
            this.CorrectAnswer = correctAnswer;
            this.IsCorrectAnswer = false;
        }

        public static implicit operator int(TestItem v)
        {
            throw new NotImplementedException();
        }
    }
}
