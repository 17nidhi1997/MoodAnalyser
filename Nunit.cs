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
            analyseMood mood = new analyseMood("aaaaaaaa");
            Assert.AreEqual("HAPPY", mood.analyseMoodMethod());
        }

        [Test]
        public void NullInput()
        {
            analyseMood mood = new analyseMood(null);
            Assert.AreEqual("HAPPY", mood.analyseMoodMethod());
        }
        
        [Test]
       public void EmptyException()
        {
            try
            {
                analyseMood mood = new analyseMood("");
                Assert.AreEqual("please enter proper mood", mood.analyseMoodMethod());
            }
            catch (analyseMoodException e)
            {
                Assert.AreEqual(analyseMoodException.Exception_Type.Empty_Exception, e.ex_ty);
            }
        }

        [Test]
        public void NullException()
        {
            try
            {
                analyseMood mood = new analyseMood(null);

                Assert.AreEqual("please enter proper mood", mood.analyseMoodMethod());
            }
            catch (analyseMoodException e)
            {
                Assert.AreEqual(analyseMoodException.Exception_Type.Null_Exception, e.ex_ty);
            }
        }

   }
}
