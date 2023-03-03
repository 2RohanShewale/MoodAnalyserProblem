using MoodAnalyser;
namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem();
        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnSad()
        {
            string result = moodAnalyzer.AnaylseMood("I Am In Sad Mood.");
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenHappyMood_WhenAnalyzed_ShouldReturnHappy()
        {
            string result = moodAnalyzer.AnaylseMood("I Am In Happy Mood.");
            Assert.AreEqual(result, "Happy");
        }

    }
}