using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;

namespace AP4_C.Model
{
    public class ModelePlat
    {
        public static Plat RetournePlat(int idPlat)
        {
            Plat unPlat = new Plat();
            try
            {
                unPlat = Modele.MonModel.Plats.First(x => x.Idplat == idPlat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unPlat;
        }

        public static bool AjouterPlat(int idPlat, int Qte)
        {
            bool vretour = true;
            try
            {
                Plat unPlat = Modele.MonModel.Plats.FirstOrDefault(x => x.Idplat == idPlat);

                if (unPlat != null)
                {
                    
                    unPlat.Qte += Qte;
                    Modele.MonModel.SaveChanges();
                }
                else
                {
                    
                    throw new Exception("Le plat sélectionné n'existe pas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                vretour = false;
            }
            return vretour;
        }

        public static bool AjouterNouveauPlat(string Libelleplat, int Idtypeplat, int Qte, double Prixplatht, bool Veggie, string? Lienimg, int Idrestau, string Description)
        {
            Plat unPlat;
            bool vretour = true;
            try
            {
                unPlat = new Plat();
                unPlat.Libelleplat = Libelleplat;
                unPlat.Qte = 0;
                unPlat.Description = Description;
                unPlat.Prixplatht = Prixplatht;
                unPlat.Veggie = Veggie;
                unPlat.Lienimg = Lienimg;
                unPlat.Idtypeplat = Idtypeplat;
                unPlat.Idrestau = 1;

                Modele.MonModel.Plats.Add(unPlat);
                Modele.MonModel.SaveChanges();
            }
            catch (Exception)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool ModifierPlat(int idPlat, string Libelleplat, int Idtypeplat, int Qte, double Prixplatht, bool Veggie, string? Lienimg, int Idrestau)
        {
            Plat unPlat;
            bool vretour = true;
            try
            {
                unPlat = RetournePlat(idPlat);
                unPlat.Libelleplat = Libelleplat;
                unPlat.Qte = 0;
                unPlat.Prixplatht = Prixplatht;
                unPlat.Veggie = Veggie;
                unPlat.Lienimg = Lienimg;
                unPlat.Idtypeplat = Idtypeplat;
                unPlat.Idrestau = 1;

                Modele.MonModel.SaveChanges();
            }
            catch (Exception)
            {
                vretour = false;
            }
            return vretour;
        }

        public static List<Plat> listePlats()
        {
            return Modele.MonModel.Plats.ToList();
        }

        public static Plat RentourneNomPlat(int Idplat)
        {
            var commandePlat = Modele.MonModel.Plats.FirstOrDefault(x => x.Idplat == Idplat);
            return commandePlat;
        }

        public static List<Plat> RentournePlatsParFacture(int idFacture)
        {
            List<Plat> plats = new List<Plat>();
            try
            {
                // Récupérer les commandes associées à la facture
                var commandes = ModeleCommande.RetourneCommandesParFacture(idFacture);

                // Récupérer les plats associés à ces commandes
                foreach (var commande in commandes)
                {
                    var plat = Modele.MonModel.Plats.FirstOrDefault(x => x.Idplat == commande.Idplat);
                    if (plat != null)
                    {
                        plats.Add(plat);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            return plats;
        }
    }
}
