using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalysisException : Exception
    {
        public enum MoodAnalysisExceptionType
        {
            NullMood,
            EmptyString
        }
        public MoodAnalysisExceptionType Type;
        public MoodAnalysisException(MoodAnalysisExceptionType Type, string message): base(message)
        {
            this.Type = Type;
        }
    }
}
