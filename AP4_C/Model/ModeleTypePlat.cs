using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;

namespace AP4_C.Model
{
    public class ModeleTypePlat
    {
        public static List<Typeplat> listeTypesPlats()
        {
            return Modele.MonModel.Typeplats.ToList();
        }

        public static Typeplat RetourneTypePlat(int idTypePlat)
        {
            Typeplat unTypePlat = new Typeplat();
            try
            {
                unTypePlat = Modele.MonModel.Typeplats.First(x => x.Idtypeplat == idTypePlat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unTypePlat;
        }
    }
}
