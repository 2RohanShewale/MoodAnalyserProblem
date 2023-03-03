using MoodAnalyser;
namespace MoodAnalyserTest
{
    public class UnitTest1
    {
        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnSad()
        {
            MoodAnalyzerProblem moodAnalyser = new MoodAnalyzerProblem("I Am In Sad Mood.");
            string result = moodAnalyser.AnaylseMood();
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenHappyMood_WhenAnalyzed_ShouldReturnHappy()
        {
            MoodAnalyzerProblem moodAnalyser = new MoodAnalyzerProblem("I Am In Happy Mood.");
            string result = moodAnalyser.AnaylseMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMood_WhenAnalyzed_ShouldReturnHappy()
        {
            MoodAnalyzerProblem moodAnalyser = new MoodAnalyzerProblem(null);
            string result = moodAnalyser.AnaylseMood();
            Assert.AreEqual(result, "Happy");
        }

    }
}