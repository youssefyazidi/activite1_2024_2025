using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = 
                @"Data Source=.\SQLEXPRESS;Initial Catalog=EF1;Integrated Security=true";

            //Represente le context de données
            // = Façade -> Toutes les operations data passent par le contexte
            CuisiniersContext context = new CuisiniersContext(connString);

            //Creer une objet cuisinier
            //Une nouvelle creation d'un cuisinier
            Cuisinier cuisinier = new Cuisinier()
            {
                NomCui = "Ahmed",
                DateEmbauche = DateTime.Now
            };
            //Associer l'objet a son context
            context.Cuisiniers.Add(cuisinier);
            //Afficher le Log au console 
            context.Database.Log = Console.Write;
            //Sauvegarder les modification appartées au context
            context.SaveChanges();

            Console.WriteLine("Cuisinier ajouté !!!");
            Console.ReadKey();
        }
    }
}
