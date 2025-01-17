using AP4_C.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_C.Entities;
using Microsoft.VisualBasic.Logging;
using Microsoft.VisualBasic.ApplicationServices;


namespace AP4_C.Model
{
    public class ModelUser
    {
        public static bool presenceUser(string login)
        {
            bool present = false;

            List<AP4_C.Entities.User> lesUsers = Modele.MonModel.Users.Where(p => p.Email == login).ToList();
            if (lesUsers.Count() == 1)
            {
                present = true;
            }
            return present;
        }

        public static bool estAdmin(string login)
        {
            bool admin = false;
            AP4_C.Entities.User unUser = RecupererUser(login);
            if (Modele.MonModel.Managers.First(x => x.Idper == unUser.Id) != null)
            {
                Manager unAdmin = Modele.MonModel.Managers.First(x => x.Idper == unUser.Id);
                if (unAdmin.Estadmin == true)
                {
                    admin = true;
                }else
                {
                    admin = false;
                }
            }           
            return admin;
        }

      
        public static AP4_C.Entities.User RecupererUser(string login)
        {
            AP4_C.Entities.User unUser = new AP4_C.Entities.User();
            try
            {
                unUser = Modele.MonModel.Users.First(x => x.Email == login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unUser;
        }
    }
}
