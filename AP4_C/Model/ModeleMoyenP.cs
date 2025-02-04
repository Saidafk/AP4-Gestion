using AP4_C.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4_C.Model
{
    internal class ModeleMoyenP
    {

        public static List<MoyenPaiement> listeMoyenP()
        {
            return Modele.MonModel.MoyenPaiements.ToList();
        }


    }
}
