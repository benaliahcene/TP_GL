using SolutionGestionClients.SharedKernel;
using SolutionGestionClients.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionDeProjet.core.Entities
{
    public class Client : BaseEntity, IAggregateRoot
    {

        public int Id { get; set; }
        public string NomCompagnie { get; set; }
        public string Adresse { get; set; }
        public int Tel { get; set; }
        public string MotDePasse { get; set; }
        public List<Projet> Projets { get; set;}


    }
}
