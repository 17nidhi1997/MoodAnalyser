using NUnit.Framework;
using System.Reflection;

namespace moodAnalyaserTest
{
    public class Tests
    { 
        [Test]
        public void EmptyMood()

        {
            analyseMood3 mood = new analyseMood3();
            Assert.AreNotEqual("HAPPY",mood.analyseMoodMethod());
        }
       [Test]
        public void EmptyMood1()
        {
            try
            {
                analyseMood3 mood = new analyseMood3("");
                Assert.AreEqual("please enter proper mood", mood.analyseMoodMethod());
            }
            catch (analyseMoodException e)
            {
                Assert.AreEqual(analyseMoodException.Exception_Type.Empty_Exception, e.ex_ty);
            }
        }
        [Test]
        public void NullMood()
        {
            try
            {
                analyseMood3 mood = new analyseMood3(null);

                Assert.AreEqual("please enter proper mood", mood.analyseMoodMethod());
            }
            catch (analyseMoodException e)
            {
                Assert.AreEqual(analyseMoodException.Exception_Type.Empty_Exception, e.ex_ty);
            }
        }
}}
