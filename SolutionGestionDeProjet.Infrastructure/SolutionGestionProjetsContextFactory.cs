using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionDeProjet.Infrastructure
{
    public class SolutionGestionProjetsContextFactory : IDesignTimeDbContextFactory<SolutionGestionProjetsContext>
    {
        public SolutionGestionProjetsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new
            DbContextOptionsBuilder<SolutionGestionProjetsContext>();
            optionsBuilder.UseSqlServer(@"Server=.;Database=SolutionGestionProjetsDB;Trusted_Connection=True;");
            return new SolutionGestionProjetsContext(optionsBuilder.Options);
        }
    }



}
 
    
