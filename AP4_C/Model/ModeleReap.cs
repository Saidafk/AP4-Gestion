using AP4_C.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;
using Microsoft.VisualBasic.Logging;

namespace AP4_C.Model
{
    internal class ModeleReap
    {
        public static bool AjouterReap(ulong idPer,int idPlat, int Qtereap)
        {
            Reaprovision unReap;
            bool vretour = true;
            try
            {
                unReap = new Reaprovision();
                unReap.Idper = idPer;
                unReap.Idplat = idPlat;
                unReap.Ddmmyyyy = DateTime.Now ;
                unReap.Qtereap = Qtereap;
                

                Modele.MonModel.Reaprovisions.Add(unReap);
                Modele.MonModel.SaveChanges();
            }
            catch (Exception)
            {
                vretour = false;
            }
            return vretour;
        }

    }
}
