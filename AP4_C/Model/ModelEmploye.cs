using AP4_C.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4_C.Model
{
    public class ModelEmploye
    {
        public static Employe RetourneEmploye(ulong idEmp)
        {
            Employe unEmploye = new Employe();
            try
            {
                unEmploye = Modele.MonModel.Employes.First(x => x.Idper == idEmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unEmploye;
        }

        public static List<Employe> listeEmployes()
        {
            return Modele.MonModel.Employes.ToList();
        }

    }


}


