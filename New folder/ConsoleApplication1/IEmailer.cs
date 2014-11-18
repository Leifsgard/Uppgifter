namespace ConsoleApplication1
{
    public interface IEmailer
    {
        void SendEmail(string fromName, string toEmail,
            string subject, string message);

        void SendErrorEmailToAdmin(string errorMessage);
    }
}