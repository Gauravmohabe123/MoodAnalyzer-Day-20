using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class Moodanalyser
    {
        public string message;


        public Moodanalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
