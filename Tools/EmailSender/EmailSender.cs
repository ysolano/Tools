namespace EmailSender
{
    using System.Configuration;
    using System.Net;
    using System.Net.Configuration;
    using System.Net.Mail;
    using Models;
    using System;

    public class EmailSender
    {
        #region Public Methods

        public bool SendMail(MailModel sendMail)
        {
            try
            {
                var smtpSection = (SmtpSection)ConfigurationManager.GetSection("mailSettings/" + sendMail.SMTP);
                var smtpClient = new SmtpClient();
                smtpClient.Host = smtpSection.Network.Host;
                smtpClient.Port = smtpSection.Network.Port;
                smtpClient.EnableSsl = smtpSection.Network.EnableSsl;
                smtpClient.DeliveryMethod = smtpSection.DeliveryMethod;
                smtpClient.UseDefaultCredentials = smtpSection.Network.DefaultCredentials;
                if (!smtpClient.UseDefaultCredentials)
                    smtpClient.Credentials = new NetworkCredential(sendMail.User, sendMail.Password);

                var mail = new MailMessage
                {
                    From = new MailAddress(sendMail.From)
                };

                var to = sendMail.To.Split('|');
                foreach (var addrTo in to)
                {
                    mail.To.Add(new MailAddress(addrTo));
                }

                mail.Subject = sendMail.Subject;
                mail.IsBodyHtml = sendMail.IsHtml;
                mail.Body = sendMail.Body;

                if (sendMail.Attachments != null)
                {
                    foreach (var fileAttachment in sendMail.Attachments)
                    {
                        mail.Attachments.Add(fileAttachment);
                    }
                }
                smtpClient.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        } 

        #endregion
    }
}
