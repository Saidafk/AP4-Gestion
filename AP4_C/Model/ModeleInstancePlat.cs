using AP4_C.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4_C.Model
{
    internal class ModeleInstancePlat
    {

        public static List<InstancePlat> listeInstancePlat()
        {
            return Modele.MonModel.InstancePlats.ToList();
        }

        public static List<InstancePlat> RetourneCommandesParInstanceDePlat(int idInstanceDePlat)
        {
            try
            {
                return Modele.MonModel.InstancePlats.Where(c => c.Idcommande == idInstanceDePlat).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return new List<InstancePlat>();
            }
        }

        /*public static InstancePlat PrixCommande(int idInstanceDePlat)
        {
            int prix = 0;


        }*/

        public static bool AjouterInstancePlat( int Idcommande, int Idplat, string Idinstance)
        {
            InstancePlat unInstancePlat;
            bool vretour = true;
            try
            {

                unInstancePlat = new InstancePlat();
                unInstancePlat.Idplat = Idplat;
                unInstancePlat.Idcommande = Idcommande;
                unInstancePlat.Idinstance = Idinstance;

                Modele.MonModel.InstancePlats.Add(unInstancePlat);
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