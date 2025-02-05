using System;
using System.Windows.Forms;
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
                // Vérifier si un plat avec le même nom existe déjà
                if (Modele.MonModel.Plats.Any(x => x.Libelleplat == Libelleplat))
                {
                    throw new DuplicatePlatException("Un plat avec ce nom existe déjà.");
                }

                unPlat = new Plat
                {
                    Libelleplat = Libelleplat,
                    Qte = 0,
                    Description = Description,
                    Prixplatht = Prixplatht,
                    Veggie = Veggie,
                    Lienimg = Lienimg,
                    Idtypeplat = Idtypeplat,
                    Idrestau = 1
                };

                Modele.MonModel.Plats.Add(unPlat);
                Modele.MonModel.SaveChanges();
            }
            catch (DuplicatePlatException ex)
            {
                MessageBox.Show(ex.Message);
                vretour = false;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Erreur de base de données : " + ex.Message);
                vretour = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur inattendue : " + ex.Message);
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


        public static int RetourneQuantite(int Idplat)
        {
            var plat = Modele.MonModel.Plats.FirstOrDefault(x => x.Idplat == Idplat);
            return plat != null ? plat.Qte : 0;
        }


        
public static bool SupprimerPlat(int idPlat)
        {
            bool vretour = true;
            try
            {
                Plat unPlat = Modele.MonModel.Plats.FirstOrDefault(x => x.Idplat == idPlat);
                if (unPlat != null)
                {

                    DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce plat ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Modele.MonModel.Plats.Remove(unPlat);
                        Modele.MonModel.SaveChanges();
                    }
                    else
                    {
                        vretour = false;
                    }

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

        public static bool MettreAJourQuantitePlat(int idPlat, int quantiteASupprimer)
        {

            {
                var plat = Modele.MonModel.Plats.FirstOrDefault(p => p.Idplat == idPlat);
                if (plat == null)
                {
                    return false; // Plat non trouvé
                }

                if (plat.Qte < quantiteASupprimer)
                {
                    return false; // Quantité à supprimer supérieure à la quantité disponible
                }

                plat.Qte -= quantiteASupprimer;
                Modele.MonModel.SaveChanges();
                return true;
            }
        }

        public static int RetourneQuantitePlat(int idPlat)
        {                        
             var plat = Modele.MonModel.Plats.FirstOrDefault(p => p.Idplat == idPlat);
             return plat?.Qte ?? 0;
            
        }


        /*public static List<Plat> RentournePlatsParFacture(int idFacture)
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
        }*/
    }
    public class DuplicatePlatException : Exception
    {
        public DuplicatePlatException(string message) : base(message)
        {
        }
    }
}
