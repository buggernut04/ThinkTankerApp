using ThinkTankerApp;
using ThinkTankerClasses;

namespace ThinkTankerClassTests
{
    public class QuizTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsChecked_UserAnswerCorrect_ReturnTrue()
        {
            // Arrange
            Easy quiz = new Easy();
            TestItem test = new TestItem("What is the value in decimal formal of the given binary 101?", "5");
            quiz.Items.Add(test);

            // Act
            string user_ans = "5";
            bool result = quiz.IsCheck(test, user_ans);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsChecked_UserAnswerInCorrect_ReturnFalse()
        {
            // Arrange
            Easy quiz = new Easy();
            TestItem test = new TestItem("What is the value in decimal formal of the given binary 101?", "5");
            quiz.Items.Add(test);

            // Act
            string user_ans = "10";
            bool result = quiz.IsCheck(test, user_ans);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}
