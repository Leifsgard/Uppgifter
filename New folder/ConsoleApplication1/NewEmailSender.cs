namespace ConsoleApplication1
{
    public class NewEmailSender : IEmailer, ILogger
    {
        public void SendEmail(string fromName, string toEmail, string subject, string message)
        {
            throw new System.NotImplementedException();
        }

        public void SendErrorEmailToAdmin(string errorMessage)
        {
            throw new System.NotImplementedException();
        }

        public void LogMessage(string message)
        {
            
        }
    }
}