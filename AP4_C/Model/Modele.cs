using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;
using Microsoft.EntityFrameworkCore;

namespace AP4_C.Model
{
    public static class Modele
    {
        private static Ap4CamoelContext monModel;

        public static Ap4CamoelContext MonModel { get => monModel; set => monModel = value; }

        public static void init()
        {
            monModel = new Ap4CamoelContext();
        }
    }
}
