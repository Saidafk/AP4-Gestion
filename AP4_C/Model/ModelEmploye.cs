using AP4_C.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AP4_C.Model.ModelUser;

namespace AP4_C.Model
{
    public class ModelEmploye
    {
        public static Employe RetourneEmploye(ulong idEmp)
        {
            Employe unEmploye = new Employe();
            try
            {
                unEmploye = Modele.MonModel.Employes.First(x => x.Idper == idEmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unEmploye;

        }
        public static bool presenceEmploye(ulong id)
        {
            bool present = false;

            List<AP4_C.Entities.Employe> lesUsers = Modele.MonModel.Employes.Where(p => p.Idper == id).ToList();
            if (lesUsers.Count() == 1)
            {
                present = true;
            }
            return present;
        }

        public static List<User> listeEmployes()
        {
            
            List<User> lesUsers = Modele.MonModel.Users.ToList();
            
            List<User> lesEmployes = new List<User>();

            foreach (User user in lesUsers) {
                if (presenceEmploye(user.Id)) {
                    lesEmployes.Add(RecupererUserParID(user.Id));

                }
            }
            return lesEmployes;
        }

        public static List<Cuisinier> listeCuisiniers()
        {
            return Modele.MonModel.Cuisiniers.ToList();
        }

        public static List<Serveur> listeServeurs()
        {
            return Modele.MonModel.Serveurs.ToList();
        }

    }


}


