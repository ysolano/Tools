namespace ConsoleEmailSender
{
    using System;
    using EmailSender;
    using EmailSender.Models;

    class Program
    {
        static void Main(string[] args)
        {
            var sendMail = new MailModel
            {
                SMTP = "smtpGmail",
                User = "test@gmail.com",
                Password = "Test1234",
                From = "test@gmail.com",
                To = "testto@gmail.com",
                Subject = "TEST",
                Body = "<h1>Test</h1><span>Text body</span>",
                IsHtml = true,
            };

            var emailSender = new EmailSender();
            if (emailSender.SendMail(sendMail))
            {
                Console.WriteLine("Mail was sended");
            }
            else
            {
                Console.WriteLine("Error :'(");
            }
            Console.Read();
        }
    }
}
