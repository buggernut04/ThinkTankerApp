    using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkTankerApp;
using CsvHelper;

namespace ThinkTankerClasses
{
    public class Easy : Quiz
    {
        public Easy() : base() { }

        public override void CreateQuestion()
        {
            string csvData = Properties.Resources.easy;

            using (TextFieldParser parser = new TextFieldParser(new StringReader(csvData)))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // Loop through each record in the CSV data
                while (!parser.EndOfData)
                {
                    // Parse the fields in the record
                    string[] fields = parser.ReadFields();
                    TestItem[] item = new TestItem[fields.Length / 2];
                    // Print the fields
                    int count = 0;
                    for (int i = 0; i < fields.Length; i += 2)
                    {
                        item[count] = new TestItem(fields[i], fields[i + 1]);
                        Items.Add(item[count]);
                        count++;
                        /*Console.WriteLine("Question: " + fields[i]);
                        Console.WriteLine("Answer: " + fields[i + 1]);*/
                    }
                }
            }
        }
    }
}

