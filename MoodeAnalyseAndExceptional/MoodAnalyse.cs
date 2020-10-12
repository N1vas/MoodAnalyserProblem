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
                if (message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception occurred: "+e);
                return "HAPPY";
            }
        }
    }
}