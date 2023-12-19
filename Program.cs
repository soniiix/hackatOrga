using Microsoft.EntityFrameworkCore;
using hackatOrga.Models;    //// <--- remplacer xxx par le nom de votre projet

namespace hackatOrga
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //connexion � la BD
            MonDbContext cnx = new MonDbContext();

            InscriptionHackathon uneInscriptionHackathon = new InscriptionHackathon();
            uneInscriptionHackathon = cnx.InscriptionHackathons.Find(3);   //album 50 charg�

            System.Diagnostics.Debug.WriteLine(uneInscriptionHackathon.date);   //Ok
            Participant unParticipant = uneInscriptionHackathon.Participant;                   //On veut l'artiste de l'album
            System.Diagnostics.Debug.WriteLine(unParticipant.nom);  //plante : l'artiste n'est pas charg�

            //--- Lancement du formulaire ---
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}