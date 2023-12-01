namespace hackatOrga
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //--- Lancement du formulaire ---
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}