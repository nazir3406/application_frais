using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fraiss
{
    class FicheDeFrais
    {
        // Propriétés
        public int IdFiche { get; set; }
        public DateTime Date { get; set; }
        public List<FraisHorsForfait> FraisHorsForfait { get; set; }

        // Constructeur
        public FicheDeFrais(int idFiche, DateTime date)
        {
            IdFiche = idFiche;
            Date = date;
            FraisHorsForfait = new List<FraisHorsForfait>();
        }

        // Méthode pour ajouter un frais hors forfait

    }
}
