using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;

namespace AP4_C.Model
{
    internal class ModeleCommande
    {
        public static List<Commande> listeCommande()
        {
            return Modele.MonModel.Commandes.ToList();
        }

        public static Commande RetourneCommande(int idCommande)
        {
            Commande uneCommande = new Commande();
            try
            {
                uneCommande = Modele.MonModel.Commandes.First(x => x.Idcommande == idCommande);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneCommande;
        }

        public static Commande RetourneTableCommande(int idTable)
        {
            Commande uneCommande = new Commande();
            try
            {
                uneCommande = Modele.MonModel.Commandes.First(x => x.Idtable == idTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneCommande;
        }

        public static bool AjouterCommande(int Idtable, string Commentaireclient)
        {
            Commande uneCommande;
            bool vretour = true;
            try
            {

                uneCommande = new Commande();
                uneCommande.Idtable = Idtable;
                uneCommande.Commentaireclient = Commentaireclient;

                var table = ModeleTabler.listeTable().First(x => x.Idtable == Idtable);
                if(table.Estdispo != null)
                {

                   table.Estdispo = false;
                }
                else
                {
                    table.Estdispo = true;
                }

                Modele.MonModel.Commandes.Add(uneCommande);
                Modele.MonModel.SaveChanges();

            }
            catch (Exception)
            {
                vretour = false;
            }
            return vretour;
        }

        /*public static List<Commande> RetourneCommandesParFacture(int idFacture)
        {
            try
            {
                return Modele.MonModel.Commandes.Where(c => c.Idfacture == idFacture).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return new List<Commande>();
            }
    }*/
    }
}
