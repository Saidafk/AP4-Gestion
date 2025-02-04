using AP4_C.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Model;

namespace AP4_C.Model
{
    public static class ModeleTabler
    {
        public static List<Tabler> listeTable()
        {
            return Modele.MonModel.Tablers.ToList();
        }

        public static void MettreTableNonDisponible(int idTable)
        {
            var table = listeTable().FirstOrDefault(t => t.Idtable == idTable);
            if (table != null)
            {
                table.Estdispo = false;
                //Modele.MonModel.SaveChanges();
                // Si tu utilises une base de données, tu devras peut-être enregistrer ce changement
                // par exemple : DbContext.SaveChanges();
            }
        }

        public static void MettreTableDisponible(int Idtable)
        {
            var table = listeTable().FirstOrDefault(t => t.Idtable == Idtable);
            if (table != null)
            {
                table.Estdispo = true;
                Modele.MonModel.SaveChanges();
                //Model.ModeleTabler.SaveChanges();
            }

        }

        /*public static List<Tabler> listeTable()
        {
            return Modele.MonModel.Tablers.ToList();
        }
        */
    }
}
