using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;

namespace AP4_C.Model
{
    internal class ModeleServeur
    {
        public static bool NouveauServeur(ulong IdServeur)
        {
            Serveur unServeur;
            bool vretour = true;
            try
            {
                unServeur = new Serveur();
                unServeur.Idper = IdServeur;



                Modele.MonModel.Serveurs.Add(unServeur);
                Modele.MonModel.SaveChanges();
            }
            catch (Exception)
            {
                vretour = false;
            }
            return vretour;
        }
    }
}
