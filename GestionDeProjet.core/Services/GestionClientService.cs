using SolutionGestionClients.SharedKernel.Interfaces;
using SolutionGestionDeProjet.core.Entities;
using SolutionGestionDeProjet.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionDeProjet.core.Services
{
    public class GestionClientService : IGestionClientsService
    {
        private readonly IClientRepository _clientRepository;

        public GestionClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task AddClientAsync(Client client)
        {
            await _clientRepository.AddAsync(client);        
        }
    }
}
