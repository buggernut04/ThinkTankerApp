

namespace ThinkTankerApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Quiz q = new Quiz(QuizType.Easy);
            q.ImportQuestions();

            foreach(var qu in q.Items)
            {
                Console.WriteLine(qu.ToString());
            }

            Console.WriteLine("hello!");
        }
    }
}