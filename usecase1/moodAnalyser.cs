namespace moodAnalyaserTest
{
    class MoodAnalyser
    {
        public bool SAD { get; private set; }
        public bool HAPPY { get; private set; }

        public String Mood(string message)
        {
            if (message == "This is sad message")
                return "SAD";
            else
                return "HAPPY";
            
        }
    }
}
