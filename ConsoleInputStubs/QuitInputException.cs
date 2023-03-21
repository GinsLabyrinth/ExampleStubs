using System;

namespace ConsoleInputStubs
{
    public class QuitInputException : Exception
    {
        public QuitInputException()
        {
        }

        public QuitInputException(string? message) : base(message)
        {
        }

        public QuitInputException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
