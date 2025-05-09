using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraiss
{
    class FraisHorsForfait
    {
        // Propriétés
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Montant { get; set; }
        public DateTime Date { get; set; }

        // Constructeur
        public FraisHorsForfait(int id, string description, decimal montant, DateTime date)
        {
            Id = id;
            Description = description;
            Montant = montant;
            Date = date;
        }
    }
}
