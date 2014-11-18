using System;
using System.Collections.Generic;

namespace Exercise12
{
    public class DateTimeLogger : ILogger
    {
        private List<string> messages;

        public DateTimeLogger()
        {
            messages = new List<string>();
        }

        public List<string> LogPosts
        {
            get { return messages; }
        }

        public void Log(string message)
        {
            var myMessage = string.Format("{0}: {1}", DateTime.Now, message);
            messages.Add(myMessage);
        }
    }
}