using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework1
{
    //Classe entite
    public class Cuisinier
    {
        //Champs données
        public int CuisinierId { get; set; }
        public string NomCui { get; set; }

        public DateTime DateEmbauche { get; set; }

        //Champs relation
        public Atelier Atelier { get; set; }
    }
}
