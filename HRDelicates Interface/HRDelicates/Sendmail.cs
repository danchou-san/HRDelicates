using System;
using System.Net;
using System.Net.Mail;

namespace HRDelicates
{
    public class SendMail
    {
        private string MailPassWord = "Henk12345";
        private string senderAdress = "HRDelicates@gmail.com";
        private string senderName = "HRDelicates";
        private readonly string mailSubject = "Uw reservatie bij HRDelicates";
        private readonly int mailPort = 587;
        private readonly string mailHost = "smtp.gmail.com";


        public void Mail(string mailTo, string nameMailTo, string time)
        {
            var fromAddress = new MailAddress(senderAdress, senderName);
            var toAddress = new MailAddress(mailTo, nameMailTo);
            string fromPassword = MailPassWord;
            string subject = mailSubject;
            string body = time;

            var smtp = new SmtpClient
            {
                Host = mailHost,
                Port = mailPort,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

        }
    }
}