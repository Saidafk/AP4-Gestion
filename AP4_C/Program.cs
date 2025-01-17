// Program.cs
using static AP4_C.Model.ModelUser;
using AP4_C.Entities;
namespace AP4_C
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Model.Modele.init();
            ApplicationConfiguration.Initialize();

            User user = RecupererUserParID(1);
            FormConnexion formConnexion = new FormConnexion();
            //Application.Run(formConnexion);  
            Application.Run(new FormMenu(user));
            
        }
    }
}
