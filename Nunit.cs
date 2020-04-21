using NUnit.Framework;
namespace moodAnalyaserTest
{
    public class Tests
    {
      [Test]
       public void retuenSad()
        {
            analyseMood mood = new analyseMood("This is sad message");
            Assert.AreEqual("SAD",mood.analyseMoodMethod());
        }
        [Test]
        public void returnHappy()
        {
            analyseMood mood = new analyseMood("i am happy mood");
            Assert.AreEqual("HAPPY",mood.analyseMoodMethod());

        }

        [Test]
        public void invalidInput()
        {
            analyseMood2 mood = new analyseMood2("aaaaaaaa");
            Assert.AreEqual("HAPPY", mood.analyseMoodMethod());
        }
        [Test]
        public void NullInput()
        {
            analyseMood2 mood = new analyseMood2(null);
            Assert.AreEqual("HAPPY", mood.analyseMoodMethod());
        }
    }
}
