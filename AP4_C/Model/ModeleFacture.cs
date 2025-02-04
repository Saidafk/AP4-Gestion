using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;

namespace AP4_C.Model
{
    internal class ModeleFacture
    {
        public static Facture RetourneFacture(int idFacture)
        {
            Facture uneFacture = new Facture();
            try
            {
                uneFacture = Modele.MonModel.Factures.First(x => x.Idfacture == idFacture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneFacture;
        }

        public static List<Facture> listeFacture()
        {
            return Modele.MonModel.Factures.ToList();
        }


        public static bool NouvelleFacture(int Idcommande, int Idmoyenpaiement, int TVA, DateTime dateFacture)
        {
            Facture uneFacture;
            bool vretour = true;
            try
            {
                uneFacture = new Facture();
                uneFacture.Idcommande = Idcommande;
                uneFacture.Idmoyenpaiement = Idmoyenpaiement;
                uneFacture.Tva = 20;
                uneFacture.Datefacture = dateFacture;


                Modele.MonModel.Factures.Add(uneFacture);
                Modele.MonModel.SaveChanges();
            }
            catch (Exception)
            {
                vretour = false;
            }
            return vretour;
        }

        /*public static bool ModifierFacture(int Idfacture, DateTime Datefacture, int Idtable)
           {
               Facture uneFacture;
               bool vretour = true;
               try
               {
                   uneFacture = RetourneFacture(Idfacture);
                   uneFacture.Datefacture = Datefacture;
                   uneFacture.Idtable = Idtable;


                   Modele.MonModel.SaveChanges();
               }
               catch (Exception)
               {
                   vretour = false;
               }
               return vretour;
           }*/

    }
}
