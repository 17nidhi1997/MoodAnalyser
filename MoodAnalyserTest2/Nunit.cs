using NUnit.Framework;


namespace moodAnalyaserTest
{
    public class Tests
    {
        [Test]
        public void Test21()
        {
            analyseMood2 mood = new analyseMood2("This is sad message");
            Assert.AreEqual("SAD",mood.analyseMoodMethod());
        }
        [Test]
        public void Test22()
        {
            analyseMood2 mood = new analyseMood2("aaaaaaaa");
            Assert.AreEqual("HAPPY", mood.analyseMoodMethod());
        }
        [Test]
        public void Test23()
        {
            analyseMood2 mood = new analyseMood2(null);
            Assert.AreEqual("HAPPY", mood.analyseMoodMethod());
        }
    }
}
