using Microsoft.EntityFrameworkCore;
using hackatOrga.Models;    //// <--- remplacer xxx par le nom de votre projet

namespace hackatOrga
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //connexion à la BD
            MonDbContext cnx = new MonDbContext();

            InscriptionHackathon uneInscriptionHackathon = new InscriptionHackathon();
            uneInscriptionHackathon = cnx.InscriptionHackathons.Find(3);   //album 50 chargé

            System.Diagnostics.Debug.WriteLine(uneInscriptionHackathon.date);
            Participant unParticipant = uneInscriptionHackathon.Participant;
            System.Diagnostics.Debug.WriteLine(unParticipant.nom);

            //--- Lancement du formulaire ---
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}