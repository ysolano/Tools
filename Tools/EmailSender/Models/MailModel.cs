namespace EmailSender.Models
{
    using System.Collections.Generic;
    using System.Net.Mail;

    public class MailModel
    {
        #region Properties

        public string SMTP { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public bool IsHtml { get; set; }

        public List<Attachment> Attachments { get; set; } 

        #endregion
    }
}
