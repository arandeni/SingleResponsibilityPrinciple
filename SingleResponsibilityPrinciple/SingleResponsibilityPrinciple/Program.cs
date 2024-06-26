// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SingleResponsibilityPrinciple;
using System.Net.Mail;

SmtpClient smtpClient = new SmtpClient();
EmailService emailService = new EmailService(smtpClient);
UserServiceNew userService = new UserServiceNew(emailService);
userService.Register("test@gmail.com", "12345");