using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AP4_C.Model
{
    internal class ModeleTable
    {

        public static List<Tabler> listeTable()
        {
            return Modele.MonModel.Tablers.ToList();
        }

    }
}
