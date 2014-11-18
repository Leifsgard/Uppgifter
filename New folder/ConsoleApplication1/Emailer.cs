namespace ConsoleApplication1
{
    public class Emailer : IEmailer
    {
        public void SendEmail(string fromName, string toEmail,
            string subject, string message)
        {
            //...    
        }

        public void SendErrorEmailToAdmin(string errorMessage)
        {
            //...    
        }
    }
}