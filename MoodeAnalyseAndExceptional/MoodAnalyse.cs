using System;
using System.Collections.Generic;
using System.Text;
namespace MoodeAnalyseAndExceptional
{
    public class MoodAnalyse
    {
        private string message;
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string analyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(Exception e)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}