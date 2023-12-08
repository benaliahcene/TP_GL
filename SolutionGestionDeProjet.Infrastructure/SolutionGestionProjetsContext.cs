using Microsoft.EntityFrameworkCore;
using SolutionGestionDeProjet.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionDeProjet.Infrastructure
{
    public class SolutionGestionProjetsContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Projet> Projets { get; set; }
        public DbSet<Gestionnaire> Gestionnaires { get; set; }
        public DbSet<Professionnel> Professionnels { get; set; }


        public SolutionGestionProjetsContext(DbContextOptions options) :
                        base(options)
        { }

        public SolutionGestionProjetsContext() : base(new DbContextOptionsBuilder<SolutionGestionProjetsContext>()

               .UseSqlServer(@"Server=.;Database=SolutionGestionProjetsDB;Trusted_Connection=True;")
               .Options)
        { }


    }
}
