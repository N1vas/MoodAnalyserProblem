using System;
using System.Collections.Generic;
using System.Text;
namespace MoodeAnalyseAndExceptional
{
    class MoodAnalysisException:Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE = 10,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }
        private readonly ExceptionType type;
        public MoodAnalysisException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
