using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;
using System.Text.RegularExpressions;

namespace AP4_C.Controller
{
    internal class Email
    {
        public static void EnvoyerEmailNouveauMembre(string destinataire, string sujet, string corps)
        {

            string to = destinataire;
            string from = "Camoel@gmail.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = sujet;
            message.Body = corps;
            SmtpClient client = new SmtpClient();

            client.Host = "mail.dombtsig.local";
            client.Port = 1025;

            client.UseDefaultCredentials = true;
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());

            }
        }

        public static bool ValidMail(string mail)
        {

            string pattern = @"^([a-zA-Z0-9_\.]+)@([a-zA-Z0-9_\-]+)\.([\w]{2,4})$";
            Regex r1 = new Regex(pattern);
            return r1.IsMatch(mail);
        }
    }
}