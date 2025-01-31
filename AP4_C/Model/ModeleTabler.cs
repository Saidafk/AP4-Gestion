using AP4_C.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4_C.Model
{
    internal class ModeleTabler
    {
        public static List<Tabler> listeTable()
        {
            return Modele.MonModel.Tablers.ToList();
        }

        
    }
}
