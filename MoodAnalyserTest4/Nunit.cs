
using NUnit.Framework;
using System.Reflection;

namespace moodAnalyaserTest
{
    public class Tests
    {

       [Test]
        public void twoObjectAreEqual()
        {
            analyseMoodFactory<analyseMood3> mood = new analyseMoodFactory<analyseMood3>();
            ConstructorInfo constructor = mood.defaultConstructor();
            object obj_compare = mood.GetInstance("analyseMood3", constructor);
            Assert.IsInstanceOf(typeof(analyseMood3), obj_compare);
        }

        [Test]
        public void catchException_noClassException()
        {
            try
            {
                analyseMoodFactory<analyseMood3> mood = new analyseMoodFactory<analyseMood3>();
                ConstructorInfo constructor = mood.defaultConstructor();
                object obj_compare = mood.GetInstance("analyseMood3", constructor);
               
            }
            catch(analyseMoodException e)
            {
                Assert.AreEqual(analyseMoodException.Exception_Type.No_Such_Class_Exception, e.ex_ty);
            }
        }

        [Test]
        public void catchException_noMethodFound()
        {


            try
            {
                analyseMoodFactory<analyseMood3> mood = new analyseMoodFactory<analyseMood3>();
                ConstructorInfo constructor = mood.defaultConstructor();
                object obj_compare = mood.GetInstance("analyseMood3", constructor);
                
            }
            catch (analyseMoodException e)
            {
                Assert.AreEqual(analyseMoodException.Exception_Type.No_Such_Method_Exception, e.ex_ty);
            }
        }









    }
}
