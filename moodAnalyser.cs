using System;
using System.Collections.Generic;
using System.Text;

namespace moodAnalyaserTest
{
    class analyseMood
    {
        private string message;

        public analyseMood()
        {
            this.message = "i am sad";
        }
        public analyseMood(String message)
        {
            this.message = message;
        }

        public String analyseMoodMethod(String message)
        {
            this.message = message;
            return analyseMoodMethod();
        }

        public string analyseMoodMethod()
        {

            if (message.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
                      
        }
    }
}
