using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;

namespace AP4_C.Model
{
    internal class ModeleCuisinier
    {
        public static bool NouveauCuisinier(ulong Idcuisinier)
        {
            Cuisinier uneCuisine;
            bool vretour = true;
            try
            {
                uneCuisine = new Cuisinier();
                uneCuisine.Idper = Idcuisinier;
                


                Modele.MonModel.Cuisiniers.Add(uneCuisine);
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
