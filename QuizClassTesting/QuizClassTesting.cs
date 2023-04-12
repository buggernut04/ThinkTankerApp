using ThinkTankerApp;

namespace QuizClassTesting;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void IsChecked_UserAnswerCorrect_ReturnTrue()
    {
        // Arrange
        Quiz quiz = new Quiz(QuizType.Easy);
        TestItem test = new TestItem("What is the value in decimal formal of the given binary 101?", "5");
        quiz.Items.Add(test);

        // Act
        string user_ans = "5";
        bool result = quiz.IsChecked(test, user_ans);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsChecked_UserAnswerInCorrect_ReturnFalse()
    {
        // Arrange
        Quiz quiz = new Quiz(QuizType.Easy);
        TestItem test = new TestItem("What is the value in decimal formal of the given binary 101?", "5");
        quiz.Items.Add(test);

        // Act
        string user_ans = "10";
        bool result = quiz.IsChecked(test, user_ans);

        // Assert
        Assert.That(result, Is.False);
    }
}