using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using OrderProcess.BusinessLayer.Interfaces;
using OrderProcess.Models;

namespace OrderProcess.BusinessLayer
{
    public class EmailService : IEmailService
    {
        public bool SendEmail(string email, string subject, string content)
        {
            // This method will handle the email sending logic like connecting to the email server. 
            // The server settings will be fetched from the configuration file like App.Config or Web.Config. 
            // For testing purpose a simple SMTP client has been implemented. 
            try
            {
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                MailAddress from = new MailAddress("order@thecompany.com");
                MailAddress to = new MailAddress(email);
                MailMessage mail = new MailMessage(from, to);

                client.Host = "smtp.gmail.com";  // this would normally come from config file.                    
                mail.Subject = subject;
                mail.Body = content;
                client.Send(mail);

                return true;
            }
            catch (SmtpException ex)
            {
                // log
                return false;
            }
            catch (Exception ex)
            {
                // log
                return false;
            }
        }
    }
}
