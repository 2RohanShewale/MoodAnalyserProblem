using MoodAnalyserProblem;
namespace MoodAnalyserTest
{
    public class UnitTest1
    {
        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnSad()
        {
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("I Am In Sad Mood.");
            string result = moodAnalyser.AnaylseMood();
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenHappyMood_WhenAnalyzed_ShouldReturnHappy()
        {
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("I Am In Happy Mood.");
            string result = moodAnalyser.AnaylseMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMood_WhenAnalyzed_ShouldReturnHappy()
        {
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(null);
            string result = moodAnalyser.AnaylseMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMessage_ThrowMoodAnalysisException()
        {
            
            try
            {
                MoodAnalyzer moodAnalyser = new MoodAnalyzer(null);
                string result = moodAnalyser.AnaylseMood();
            }
            catch (MoodAnalysisException obj)
            {
                Assert.AreEqual("Message is null", obj.Message);
            }
           
        }
    }
}