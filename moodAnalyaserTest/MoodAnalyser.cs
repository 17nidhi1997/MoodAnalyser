using System;
using System.Collections.Generic;
using System.Text;

namespace moodAnalyaserTest
{
    class MoodAnalyser
    {
        private string message;

        public MoodAnalyser()
        {
            this.message = "i am sad";
        }
        public MoodAnalyser(String message)
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
