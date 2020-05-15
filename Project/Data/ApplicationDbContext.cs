using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
     
        public DbSet<Utilisateur> Utilisateur{ get; set;}
          public DbSet<Etudiant> Etudiants{ get; set;}
        public DbSet<Classe> Classe{ get; set;}
        public DbSet<Classematiere> Classematiere{ get; set;}
        public DbSet<Publication> Publication{ get; set;}
        public DbSet<Admin> Admin{ get; set;}
        public DbSet<Professeur> Professeur{ get; set;}
        public DbSet<Absence> Absence{ get; set;}
        public DbSet<Presence> Presence{ get; set;}
        public DbSet<Matiere> Matiere{ get; set;}
        public DbSet<Seance> Seance{ get; set;}
        public DbSet<MatiereProf> MatiereProf{ get; set;}

    }
}
