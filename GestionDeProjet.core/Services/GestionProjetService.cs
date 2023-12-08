using SolutionGestionDeProjet.core.Entities;
using SolutionGestionDeProjet.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionDeProjet.core.Services
{
    public class GestionProjetService : IGestionProjetsService
    {
        private readonly IProjetRepository _projetRepository;

        public  GestionProjetService (IProjetRepository projetRepository)
        {
            _projetRepository = projetRepository;
        }
        public async Task AddProjetAsync(Projet projet)
        {
            await _projetRepository.AddAsync(projet);
        }

        public async Task DeleteProjetAsync(Projet projet)
        {
            await _projetRepository.DeleteAsync(projet);
        }

        public async Task UpdateProjetAsync(Projet projet)
        {
            await _projetRepository.UpdateAsync(projet);
        }
    }
}
