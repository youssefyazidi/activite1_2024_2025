using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {

   // Create a data source by using a collection initializer.
 static List<Student> students = new List<Student>
{
   new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
   new Student {First="Claire", Last="O’Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
   new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
   new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
   new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
   new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
   new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
   new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
   new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
   new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
   new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
   new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91} }
};
static void Main(string[] args)
 {
            statistiques();
            Console.ReadKey();
 }

        //Score du premier test >80
    static void ScoreSup80()
        {
            //Creation de la requete
            /*IEnumerable<Student> studentQuery =
               from student in students
              where student.Scores[0] > 80
              select student;*/
            //Un typage dynamique
            /*var studentQuery =
             from student in students
             where student.Scores[0] > 80
             select student;*/

            var studentQuery = students.Where(st => st.Scores[0] > 80).Select(st => st);
            //Execution de la requete

            foreach (var student in studentQuery)
       Console.WriteLine("nom = {0}, prenom = {1}, score = {2}",
           student.Last, 
           student.First,
           student.Scores[0]);
    }

        //Score du premier test >80 et <90
        static void ScoreSup80inf90()
        {
            var studentQuery =
                    from student in students
                    where student.Scores[0] > 80 && student.Scores[0] < 90
                    select student;

            //Execution de la requete

            foreach (var student in studentQuery)
                Console.WriteLine("nom = {0}, prenom = {1}, score = {2}", student.Last, student.First, student.Scores[0]);
        }
        //Trier la liste des etudiants par nom
        static void ListeEtudiantsTrieeparnom()
        {
            var studentQuery =
                    from student in students
                    orderby student.Last descending
                    select student;

            //Execution de la requete

            foreach (var student in studentQuery)
                Console.WriteLine("nom = {0}, prenom = {1}, score = {2}", student.Last, student.First, student.Scores[0]);
        }

        //Liste des étudiants groupés par score1
        static void GrouperEtidiantsParScore1()
        {
            var studentQuery =
                    from student in students
                    group student by student.First[0];

            //Execution de la requete
            //Parcourir les groupe
            foreach (var studentGroup in studentQuery)
            {
                Console.WriteLine(studentGroup.Key);
                //Parcourir le resultat d'un groupe
                foreach (var student in studentGroup)
                    Console.WriteLine("nom = {0}, prenom = {1}", student.Last, student.First);
            }

        }


        //Liste des étudiants groupés par ordre alphabétique
        //Trier les groupes par clé
        static void GrouperEtidiantsParOrdreAlpha()
        {
            var studentQuery =
                    from student in students
                    group student by student.Last[0] into studentGroup
                    orderby studentGroup.Key
                    select studentGroup;
       
            //Execution de la requete
           foreach (var studentGroup in studentQuery)
           {
                Console.WriteLine(studentGroup.Key);
                foreach (var student in studentGroup)
                    Console.WriteLine("nom = {0}, prenom = {1}", student.Last, student.First);
           }

        }


        //Liste des étudiants dont le score1 est supérieur à la moyenne
        //Introduire un identificateur
        static void EtudiantsAvecTest1SupMoyenne()
        {       
            var studentQuery =
                    from student in students
                    let avgscore = (student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]) / 4
                    where avgscore < student.Scores[0]
                    select student.Last + " " + student.First +" "+ student.Scores[0]+" "+avgscore;

            foreach (string s in studentQuery)
            {
                Console.WriteLine(s);
            }

        }

        //Executer des méthodes sur la requete
        static void statistiques()
        {

            var studentQuery =
                from student in students
                let avgscore = (student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]) / 4
                select avgscore;

            Console.WriteLine("Nombre des étudiants : {0} ", studentQuery.Count());
            Console.WriteLine("Moyenne Max  : {0} ", studentQuery.Max());
            Console.WriteLine("Moyenne Min  : {0} ", studentQuery.Min());
            Console.WriteLine("Moyenne de la classe  : {0}", studentQuery.Average());
        }
    }
}
