using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyserProblem.MoodAnalysisException;

namespace MoodAnalyserProblem
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message) 
        {
            this.message = message;
        }
        public string AnaylseMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                    throw new MoodAnalysisException(MoodAnalysisExceptionType.EmptyString,"Message is empty.");
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {

                throw new MoodAnalysisException(MoodAnalysisExceptionType.NullMood, "Message is null.");
            }
            
        }
    }
}
