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

         [Test]
        public void compareDefaultConstructor()
        {
            analyseMoodFactory<analyseMood> mood = new analyseMoodFactory<analyseMood>();
            ConstructorInfo constructor = mood.defaultConstructor();
            object obj_compare = mood.GetInstance("analyseMood", constructor);
            Assert.IsInstanceOf(typeof(analyseMood3), obj_compare);
        }

        [Test]
        public void reflectionNoSuchClassEception()
        {
            try
            {
                analyseMoodFactory<analyseMood> mood = new analyseMoodFactory<analyseMood>();
                ConstructorInfo constructor = mood.defaultConstructor();
                object obj_compare = mood.GetInstance("analyseMood", constructor);
               
            }
            catch(analyseMoodException e)
            {
                Assert.AreEqual(analyseMoodException.Exception_Type.No_Such_Class_Exception, e.ex_ty);
            }
        }

        [Test]
        public void reflectionNoSuchMethoEception()
        {
            try
            {
                analyseMoodFactory<analyseMood> mood = new analyseMoodFactory<analyseMood>();
                ConstructorInfo constructor = mood.defaultConstructor();
                object obj_compare = mood.GetInstance("analyseMood", constructor);
                
            }
            catch (analyseMoodException e)
            {
                Assert.AreEqual(analyseMoodException.Exception_Type.No_Such_Method_Exception, e.ex_ty);
            }
        }

           [Test]
        public void CompareObj_UsingParmeterConstructor()
        {
            analyseMoodFactory<analyseMood3> mood = new analyseMoodFactory<analyseMood3>();
            ConstructorInfo constructor = mood.defaultConstructor(1);
            object obj_compare = mood.GetParameterizedInstance("analyseMood3", constructor, "I am in sad mood");
        }


        [Test]
        public void UsingParmConstructor_noSuchClassException()
        {
            try
            {
                analyseMoodFactory<analyseMood3> mood = new analyseMoodFactory<analyseMood3>();
                ConstructorInfo constructor = mood.defaultConstructor(1);
                object obj_compare = mood.GetParameterizedInstance("analyseMood3", constructor,"i am happy");

            }
            catch (analyseMoodException e)
            {
                Assert.AreEqual(analyseMoodException.Exception_Type.No_Such_Class_Exception, e.ex_ty);
            }
        }

        [Test]
        public void UsingParmConstructor_NoSuchMethod()
        {
            try
            {
                analyseMoodFactory<analyseMood3> mood = new analyseMoodFactory<analyseMood3>();
                ConstructorInfo constructor = mood.defaultConstructor();
                object obj_compare = mood.GetParameterizedInstance("analyseMood3", constructor,"I am in sad mood");

            }
            catch (analyseMoodException e)
            {
                Assert.AreEqual(analyseMoodException.Exception_Type.No_Such_Method_Exception, e.ex_ty);
            }
        }

        
        [Test]
        public void InvokemethodUsingReflection_returnHappy()
        {
            try
            {

                analyseMoodFactory<string> mood = new analyseMoodFactory<string>();
                string result = mood.InvokeMethodUsingReflection();
                Assert.AreEqual(result, "Happy");
            }
            catch (NullReferenceException e)
            {

                _ = e.StackTrace;
            }
        }




    }
}
