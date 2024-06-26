using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class EmailService
    {
        private SmtpClient _smtpClient;

        public EmailService(SmtpClient smtpClient) 
        {
            _smtpClient = smtpClient;
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }
    }
}
