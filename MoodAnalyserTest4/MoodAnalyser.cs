using System;

namespace moodAnalyaserTest
{
    class analyseMood3
    {

        public string message;
        public analyseMood3()
        {
            this.message = "i am sad mood";
        }
        public analyseMood3(String message)
        {
            this.message = message;
        }

        
        public String analyseMoodMethod(String message)
        {
            this.message = message;
            return analyseMoodMethod();
        }

        public String analyseMoodMethod()
        {
            try
            {
                if ((message == null) || (message.Length == 0))
                {
                    throw new analyseMoodException(analyseMoodException.Exception_Type.Empty_Exception, "please enter proper mood");
                   
                }
                if (message.Contains("sad"))
                    return "SAD";
                else if (message.Contains("happy"))
                    return "HAPPY";
                else throw new analyseMoodException(analyseMoodException.Exception_Type.Invalid_Exception, "please enter proper mood");
              
            }
            catch (NullReferenceException)
            {

                throw new analyseMoodException(analyseMoodException.Exception_Type.Null_Exception, "please enter proper mood");
            }

        }

    }
}
