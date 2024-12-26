// Program.cs

namespace AP4_C
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Model.Modele.init();
            ApplicationConfiguration.Initialize();

            
            FormConnexion formConnexion = new FormConnexion();
            Application.Run(formConnexion);  

            
        }
    }
}
