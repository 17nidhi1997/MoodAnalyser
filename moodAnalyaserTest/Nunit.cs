using NUnit.Framework;
namespace moodAnalyaserTest
{
    public class Tests
    {
        [Test]
        public void return_Sad()
        {
            MoodAnalyse mood = new MoodAnalyse("This is sad message");
            Assert.AreEqual("SAD",mood.analyseMoodMethod());
        }
        [Test]
        public void return_Happy()
        {
            MoodAnalyse mood = new MoodAnalyse("i am happy mood");
            Assert.AreEqual("HAPPY",mood.analyseMoodMethod());
        }
    }
}
