using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerApp
{
    public class Quiz
    {
        public List<TestItem> Items { get; private set; }
        public QuizType QuizType { get; private set; }

        public Quiz(QuizType quizType)
        {
            this.Items = new List<TestItem>();
            this.QuizType = quizType;

        }
        public bool IsChecked(TestItem item, string ans)
        {
            return item.CorrectAnswer == ans;
        }

        public void ImportQuestions()
        {
            /*if (this.QuizType == QuizType.Easy)
                importQuestionHelper("easy.csv");
            else if (this.QuizType == QuizType.Moderate)
                importQuestionHelper("moderate.csv");
            else if (this.QuizType == QuizType.Difficult)
                importQuestionHelper("difficult.csv");

            randomizeContents();*/
        }

        private void randomizeContents()
        {
            // Creating a object
            // for Random class
            Random r = new Random();

            // Start from the last element and
            // swap one by one. We don't need to
            // run for the first element
            // that's why i > 0
            for (int i = Items.Count() - 1; i > 0; i--)
            {

                // Pick a random index
                // from 0 to i
                int j = r.Next(0, i + 1);

                // Swap arr[i] with the
                // element at random index
                TestItem temp = Items[i];
                Items[i] = Items[j];
                Items[j] = temp;
            }
        }

        /*private void importQuestionHelper(string fileName)
        {
            using (TextFieldParser parser = new TextFieldParser(fileName))
            {
                // Set the delimiter to a comma
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(".");

                // Read the data line by line
                while (!parser.EndOfData)
                {
                    // Read the fields in the current line
                    string[] fields = parser.ReadFields();

                    TestItem item = new TestItem(fields[0], fields[1]);

                    // Add the fields to the data list
                    Items.Add(item);
                }
            }
        }*/

    }
}
