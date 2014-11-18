using System.Collections.Generic;

namespace Exercise12
{
    public interface ILogger
    {
        /// <summary>
        /// Returns the list of messages in the logger class
        /// </summary>
        List<string> LogPosts { get; }

        /// <summary>
        /// Add a message to the log
        /// </summary>
        /// <param name="message">The log message</param>
        void Log(string message);
    }
}