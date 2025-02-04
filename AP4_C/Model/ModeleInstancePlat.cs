using AP4_C.Controller;
using AP4_C.Entities;
using Microsoft.EntityFrameworkCore;
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

        public static bool AjouterInstancePlat(int Idcommande, int Idplat, string Idinstance)
        {

            InstancePlat uneInstance;
            bool vretour = true;
            try
            {
                
                uneInstance = new InstancePlat();
                uneInstance.Idcommande = Idcommande;
                uneInstance.Idinstance = Idinstance;
                uneInstance.Idplat = Idplat;
                

                Modele.MonModel.InstancePlats.Add(uneInstance);
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
        