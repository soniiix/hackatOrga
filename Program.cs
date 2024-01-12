using Microsoft.EntityFrameworkCore;
using hackatOrga.Models;

namespace hackatOrga
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //connexion à la BD
            MonDbContext cnx = new MonDbContext();

            //Création d'un nouvel artiste
            Participant newParticipant = new Participant()
            {
                nom = "Gims",
                prenom = "Rafaelo",
                mail = "Rafaelo.gims@gaild.com",
                tel = 254545484,
                dateNaissance = new DateTime(1999, 02, 12),
                lienPortfolio = "httpRafaelo",
                mdp = "Rafaelo",
                roles =""
            };
            //Ajout de l'objet au dataContext
            cnx.Participants.Add(newParticipant);
            //Enregistrement dans la BD
            cnx.SaveChanges();

            //--- Lancement du formulaire ---
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}