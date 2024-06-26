using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class UserServiceNew
    {
        EmailService _emailService;
        //DbContext _dbContext;

       /* public UserServiceNew(EmailService emailService, DbContext dbContext) 
        {
            _emailService = emailService;
            _dbContext = dbContext;
        }*/

        public UserServiceNew(EmailService emailService)
        {
            _emailService = emailService;
        }

        public void Register(string email, string password) 
        {
            if (!_emailService.ValidateEmail(email))
                throw new ValidationException();

            User user = new User(email, password);
            //_dbContext.Save(user);

            _emailService.SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "Test" });
        }
    }
}
