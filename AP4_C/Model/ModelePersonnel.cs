using AP4_C.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Model;

namespace AP4_C.Model

    //user -> personnel qui hérite de user -> employe et cuisinier qui héritent de personnel avec contraite XT -> cuisinier et serveur dans employe
{
    public class ModelePersonnel : ModelUser
    {
        
            public static Personnel RetournePersonnel(ulong idPersonnel)
            {
                Personnel unPersonnel = new Personnel();
                try
                {
                    unPersonnel = Modele.MonModel.Personnel.First(x => x.Idper == idPersonnel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                return unPersonnel;
            }

        public static List<Personnel> listePersonnels()
        {
            return Modele.MonModel.Personnel.ToList();
        }
    }
}

