using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace google_smtp_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // from and recipient can be replaced with your own email addresses.
            // for the network credentials you will need to replace it with your own
            // gmail email address and password.

            const string from = "username@gmail.com";
            const string recipient = "receipient@gmail.com";
            const string subject = "Smtp Test";
            const string body = "This email was sent using Google's Smtp server!";

            var smptClient = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("username@gmail.com", "password"),
                EnableSsl = true
            };
            
            smptClient.Send(from, recipient, subject, body);

        }
    }
}
