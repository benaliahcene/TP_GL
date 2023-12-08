using SolutionGestionDeProjet.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionDeProjet.core.Interfaces
{
    public interface IGestionClientsService 
    {
        Task AddClientAsync(Client client);
    }
}
