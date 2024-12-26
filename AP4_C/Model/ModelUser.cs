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
    public partial class ModelUser
    {
        public static bool presenceUser(string login)
        {
            bool present = false;

            List<User> lesUsers = Modele.MonModel.Users.Where(p => p.Email == login).ToList();
            if (lesUsers.Count() == 1)
            {
                present = true;
            }
            return present;
        }

        public static bool estAdmin(string login)
        {
            bool admin = false;
            User unUser = RecupererUser(login);
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

        public static User RecupererUser(string login)
        {
            User unUser = new User();
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
