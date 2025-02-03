﻿using AP4_C.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                // Si tu utilises une base de données, tu devras peut-être enregistrer ce changement
                // par exemple : DbContext.SaveChanges();
            }
        }

    }
}
