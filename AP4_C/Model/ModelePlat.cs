using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;

namespace AP4_C.Model
{
    public class ModelePlat
    {
        public static Plat RetournePlat(int idPlat)
        {
            Plat unPlat = new Plat();
            try
            {
                unPlat = Modele.MonModel.Plats.First(x => x.Idplat == idPlat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unPlat;


        }

        public static List<Plat> listePlats()
        {
            return Modele.MonModel.Plats.ToList();
        }
    }
}
