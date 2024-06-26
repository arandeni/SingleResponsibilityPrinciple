using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class UserService
    {
        public void Register(string email, string password) 
        {
            if (!ValidateEmail(email))
                throw new ValidationException();

            var user = new User(email, password);
            SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "Test"});
        }


        //The SendEmail and ValidateEmail methods have nothing to do with the UserService class.
        public bool ValidateEmail(string email) 
        {
            return email.Contains("@");
        }

        public bool SendEmail(MailMessage message) 
        {
            //code for send message
            return true;
        }
    }
}
