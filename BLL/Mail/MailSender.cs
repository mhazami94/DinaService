using DTO;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace BLL.Mail
{
    public class MailSender
    {
        public static string OrginUrl { get; set; }
        private string _sender = "info@dinaservice.com";
        private string _password = "Dinaservice1451045";
        private string _webmail = "webmail.dinaservice.com";

        public bool SendEMail(Request obj, string email)
        {

            SmtpClient client = new SmtpClient(_webmail);

            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;

            System.Net.NetworkCredential credentials =
                new System.Net.NetworkCredential(_sender, _password);
            client.EnableSsl = true;
            client.Credentials = credentials;

            MailMessage message = new MailMessage(_sender, email);
            message.IsBodyHtml = true;
            message.Subject = "Dinaservice Contact Message";
            var body = new StringBuilder();
            //body.AppendLine("<table><tr>");
            //body.AppendLine("<td style = 'padding-left:15px;padding-right:15px'> Sender Name :</td>");
            //body.AppendLine($"<td style = 'padding-left:15px;padding-right:15px'>{contact.FirstName} {contact.LastName}</td></tr>");
            //body.AppendLine("<tr><td style = 'padding-left:15px;padding-right:15px'> Email :</td>");
            //body.AppendLine($"<td style = 'padding-left:15px;padding-right:15px'>{contact.Email}</td></tr>");
            //body.AppendLine("<tr><td style = 'padding-left:15px;padding-right:15px'> Tel :</td>");
            //body.AppendLine($"<td style = 'padding-left:15px;padding-right:15px'>{contact.Tel}</td></tr>");
            //body.AppendLine("<tr><td style = 'padding-left:15px;padding-right:15px'> Message :</td>");
            //body.AppendLine($"<td style = 'padding-left:15px;padding-right:15px'>{contact.Message}</td></tr></table><");

            message.Body = body.ToString();
            client.Send(message);
            return true;

        }
    }
}
