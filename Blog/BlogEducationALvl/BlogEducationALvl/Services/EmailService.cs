using System.Net.Mail;

namespace BlogEducationALvl.Services
{
    public class EmailService : IEmailService
    {
        private readonly SmtpClient smtpClient;
        public EmailService()
        {
            smtpClient = new SmtpClient();
        }
        public void SendSmtp(string subject, string body, string from, string to)
        {
            smtpClient.Send(from, to, subject, body);
        }
    }

    public interface IEmailService
    {
        void SendSmtp(string subject, string body, string from, string to);
    }
}