using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;

namespace AP4_C.Controller
{
    internal class Email
    {
        public static void EnvoyerEmail(string destinataire, string sujet, string corps)
        {
            try
            {
                // Créer un objet MailMessage
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("votre-email@dombtsig.local"); // Adresse de l'expéditeur
                mailMessage.To.Add(destinataire); // Ajouter le destinataire
                mailMessage.Subject = sujet; // Sujet du message
                mailMessage.Body = corps; // Corps du message (HTML)

                // Configurer le client SMTP pour utiliser le serveur mail.dombtsig.local
                SmtpClient smtpClient = new SmtpClient("mail.dombtsig.local")
                {
                    Port = 25, // Port SMTP, utilisez le port approprié selon votre configuration
                    Credentials = new NetworkCredential("votre-email@dombtsig.local", "votre-mot-de-passe"), // Identifiants SMTP
                    EnableSsl = true // Activer SSL si nécessaire
                };

                // Envoyer l'email
                smtpClient.Send(mailMessage);
                Console.WriteLine("E-mail envoyé avec succès !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'envoi de l'email : " + ex.Message);
            }
        }
    }
}