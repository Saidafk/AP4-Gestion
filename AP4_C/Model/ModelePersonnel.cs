using AP4_C.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Model;

namespace AP4_C.Model

//user -> personnel qui hérite de user -> employe et cuisinier qui héritent de personnel avec contraite XT -> cuisinier et serveur dans employe
{
    public class ModelePersonnel : ModelUser
    {
        public static Personnel RetournePersonnel(ulong idPersonnel)
        {
            Personnel unPersonnel = new Personnel();
            try
            {
                unPersonnel = Modele.MonModel.Personnel.First(x => x.Idper == idPersonnel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unPersonnel;
        }

        public static List<Personnel> listePersonnels()
        {
            return Modele.MonModel.Personnel.ToList();
        }

        /*public static bool AjouterNouveauPersonnel(string NomPersonnel, string PrenomPersonnel, string EmailPersonnel)
        {
            User unUser;
            bool vretour = true;
            try
            {
                if (estPersonnel(login) != null)
                {
                    unUser = new User();
                    unUser.Nom = NomPersonnel;
                    unUser.Prenom = PrenomPersonnel;
                    unUser.Email = EmailPersonnel;

                    Modele.MonModel.Personnel.Add(unUser);
                    Modele.MonModel.SaveChanges();
                }
                else
                {
                    throw new Exception("Le personnel sélectionné n'existe pas.");
                }
            }
            catch (Exception)
            {
                vretour = false;
            }
            return vretour;
        }*/
    }

}
