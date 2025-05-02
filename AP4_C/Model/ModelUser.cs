using AP4_C.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;
using Microsoft.VisualBasic.Logging;
using Microsoft.VisualBasic.ApplicationServices;
using static AP4_C.Model.ModelePersonnel;
using static AP4_C.Controller.GenererUnMDP;
using AP4_C.Controller;

namespace AP4_C.Model
{
    public class ModelUser
    {
        public static List<AP4_C.Entities.User> listeUsers()
        {
            return Modele.MonModel.Users.ToList();
        }
        public static bool presenceUser(string login)
        {
            bool present = false;

            List<AP4_C.Entities.User> lesUsers = Modele.MonModel.Users.Where(p => p.Email == login).ToList();
            if (lesUsers.Count() == 1)
            {
                present = true;
            }
            return present;
        }

        public static bool estAdmin(string login)
        {
            bool admin = false;
            AP4_C.Entities.User unUser = RecupererUser(login);
            if (Modele.MonModel.Managers.First(x => x.Idper == unUser.Id) != null)
            {
                Manager unAdmin = Modele.MonModel.Managers.First(x => x.Idper == unUser.Id);
                if (unAdmin.Estadmin == true)
                {
                    admin = true;
                }
                else
                {
                    admin = false;
                }
            }
            return admin;
        }


        public static AP4_C.Entities.User RecupererUser(string login)
        {
            AP4_C.Entities.User unUser = new AP4_C.Entities.User();
            try
            {
                unUser = Modele.MonModel.Users.First(x => x.Email == login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unUser;
        }
        public static AP4_C.Entities.User RecupererUserParID(ulong id)
        {
            AP4_C.Entities.User unUser = new AP4_C.Entities.User();
            try
            {
                unUser = Modele.MonModel.Users.First(x => x.Id == id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unUser;
        }

        public static bool estPersonnel(string login)
        {
            bool personnel = false;
            AP4_C.Entities.User unUser = RecupererUser(login);
            if (Modele.MonModel.Personnel.FirstOrDefault(x => x.Idper == unUser.Id) != null)
            {
                Personnel unPersonnel = Modele.MonModel.Personnel.First(x => x.Idper == unUser.Id);

                personnel = true;
            }
            else
            {
                personnel = false;
            }
            return personnel;
        }

        public static bool AjouterNouveauPersonnel(string NomPersonnel, string PrenomPersonnel, string EmailPersonnel,string mdpH,string mdp)
        {
            AP4_C.Entities.User unUser;
            
            bool vretour = true;
            try
            {
                // Générer un mot de passe aléatoire
                
                

                // Créer un nouvel utilisateur
                unUser = new AP4_C.Entities.User();
                unUser.Nom = NomPersonnel;
                unUser.Prenom = PrenomPersonnel;
                unUser.Email = EmailPersonnel;
                unUser.Mdp = mdpH;

                Modele.MonModel.SaveChanges();


                // Ajouter l'utilisateur à la base de données
                Modele.MonModel.Users.Add(unUser);
                Modele.MonModel.SaveChanges();

                // Sauvegarder les modifications
                Modele.MonModel.SaveChanges();



                // Envoyer un e-mail de bienvenue
                string sujet = "Bienvenue sur notre plateforme";
                string corps = $@"
                <h1>Bienvenue, {NomPersonnel} {PrenomPersonnel} !</h1>
                <p>Votre compte a été créé avec succès.</p>
                <p>Voici vos informations de connexion :</p>
                <ul>
                    <li><strong>E-mail :</strong> {EmailPersonnel}</li>
                    <li><strong>Mot de passe :</strong> {mdp}</li>
                </ul>
                ";

                // Envoyer l'email
                Email.EnvoyerEmailNouveauMembre(EmailPersonnel, sujet, corps);

            }
            catch (Exception ex)
            {
                // Afficher le message d'erreur complet
                MessageBox.Show($"Erreur lors de l'ajout du personnel : {ex.Message}");
                vretour = false;
            }
            return vretour;
        }

        public static bool ModifierUser(ulong Idper, string NomPersonnel, string PrenomPersonnel, string EmailPersonnel,string mdp)
        {
            AP4_C.Entities.User unUser;
            bool vretour = true;
            try
            {
                if (estPersonnel(EmailPersonnel))
                {
                    

                    unUser = Modele.MonModel.Users.First(x => x.Id == Idper);
                    unUser.Nom = NomPersonnel;
                    unUser.Prenom = PrenomPersonnel;
                    unUser.Email = EmailPersonnel;
                    unUser.Mdp = mdp;

                    Modele.MonModel.SaveChanges();

                }
                else
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception)
            {
                vretour = false;
            }
            return vretour;
        }

        public static AP4_C.Entities.User RetourneUser(ulong idUser)
        {
            AP4_C.Entities.User unUser = new AP4_C.Entities.User();
            try
            {
                unUser = Modele.MonModel.Users.First(x => x.Id == idUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unUser;
        }

    }
}