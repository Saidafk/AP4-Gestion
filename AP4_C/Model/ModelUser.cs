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


namespace AP4_C.Model
{
    public class ModelUser
    {
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

        public static bool AjouterNouveauPersonnel(string NomPersonnel, string PrenomPersonnel, string EmailPersonnel)
        {
            AP4_C.Entities.User unUser;
            bool vretour = true;
            try
            {
                
                    unUser = new AP4_C.Entities.User();
                    unUser.Nom = NomPersonnel;
                    unUser.Prenom = PrenomPersonnel;
                    unUser.Email = EmailPersonnel;

                    Modele.MonModel.Users.Add(unUser);
                    Modele.MonModel.SaveChanges();
                
            }
            catch (Exception)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool ModifierUser(ulong Idper, string NomPersonnel, string PrenomPersonnel, string EmailPersonnel)
        {
            AP4_C.Entities.User unUser;
            bool vretour = true;
            try
            {
                if (estPersonnel(EmailPersonnel))
                {
                    unUser = new AP4_C.Entities.User();
                    unUser.Nom = NomPersonnel;
                    unUser.Prenom = PrenomPersonnel;
                    unUser.Email = EmailPersonnel;

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