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
            try
            {
                // Validation des paramètres plus explicite
                if (Idcommande <= 0)
                    throw new ArgumentException("L'ID de commande est invalide.", nameof(Idcommande));

                if (Idplat <= 0)
                    throw new ArgumentException("L'ID de plat est invalide.", nameof(Idplat));

                if (string.IsNullOrWhiteSpace(Idinstance))
                    throw new ArgumentException("L'ID d'instance est invalide.", nameof(Idinstance));

                // Création et ajout de l'instance du plat
                var unInstancePlat = new InstancePlat
                {
                    Idplat = Idplat,
                    Idcommande = Idcommande,
                    Idinstance = Idinstance
                };

                // Ajout et sauvegarde
                Modele.MonModel.InstancePlats.Add(unInstancePlat);
                Modele.MonModel.SaveChanges();

                return true;
            }
            catch (ArgumentException ex)
            {
                // Logging potentiel
                System.Diagnostics.Debug.WriteLine($"Erreur de validation : {ex.Message}");
                return false;
            }
            catch (DbUpdateException ex)
            {
                // Logging potentiel
                System.Diagnostics.Debug.WriteLine($"Erreur de base de données : {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Logging potentiel
                System.Diagnostics.Debug.WriteLine($"Erreur inattendue : {ex.Message}");
                return false;
            }
        }

    }
}