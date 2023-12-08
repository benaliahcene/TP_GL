using SolutionGestionClients.SharedKernel.Interfaces;
using SolutionGestionDeProjet.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionDeProjet.core.Interfaces
{
    public interface IClientRepository : IAsyncRepository<Client>, IRepository<Client>
    {
        
    }

}
