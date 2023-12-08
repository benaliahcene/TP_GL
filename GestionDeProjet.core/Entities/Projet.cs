using SolutionGestionClients.SharedKernel;
using SolutionGestionClients.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionGestionDeProjet.core.Entities
{
    public class Projet : BaseEntity, IAggregateRoot
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public double BudgetTotal { get; set; }
        public int ClientId { get; set; }

        public Client Client { get; set; }
        public int GestionnaireId { get; set; }

        public Gestionnaire Gestionnaire { get; set; }
        public int ProfessionnelId { get; set; }

        public Professionnel Professionnel { get; set; }

    }
}
