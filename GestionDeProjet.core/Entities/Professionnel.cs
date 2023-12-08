using SolutionGestionClients.SharedKernel.Interfaces;
using SolutionGestionClients.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionDeProjet.core.Entities
{
    public class Professionnel : BaseEntity, IAggregateRoot
    {
        public string Id { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string adresse { get; set; }
        public string Telephone { get; set; }
        public string DateEmbauche { get; set; }
        public string MotDePasse { get; set; }

        public List<Projet> Projets { get; set; }
    }
}
