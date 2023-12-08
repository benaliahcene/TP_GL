using SolutionGestionDeProjet.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionDeProjet.core.Interfaces
{
    public interface IGestionProjetsService
    {

        Task AddProjetAsync(Projet projet);
        Task DeleteProjetAsync(Projet projet);
        Task UpdateProjetAsync(Projet projet);




    }
}
