using System;
using Microsoft.EntityFrameworkCore;
using hackatOrga.Models;


namespace hackatOrga
{
    class MonDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ///--- Paramètres de connexion à la BDD ---
            string connectionString = "server=192.168.4.1;database=qcouzinet_hackathon;user=sqlqcouzinet;password=savary;sslmode=required;charset=utf8";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<Hackathon> Hackathons { get; set; }
        public virtual DbSet<InscriptionHackathon> InscriptionHackathons { get; set; }
    }
}