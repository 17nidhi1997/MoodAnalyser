using System;
using System.Collections.Generic;
using System.Text;

namespace moodAnalyaserTest
{
    class analyseMood2
    {
        private string message;
        public analyseMood2(String message)
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
            try
            {
                if (message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(NullReferenceException)
            {
                return "HAPPY";
            }
        }

    }
}
