using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeConnecteConnection1
{
    class Program
    {
        static void Main(string[] args)
        {
            addAccount("Mohamed", 1500, "C");
            Console.ReadKey();
        }
        static void addAccount(string owner, float bal, string atype)
        {
            //Chaine de connexion
            string connectionString =
              @"Data Source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=ACCOUNTDB";
            //Représente une session de travail sur le serveur
            SqlConnection connexion = new SqlConnection();
            //Associer la chaine de connexion à l'objet Connection
            connexion.ConnectionString = connectionString;
            Console.WriteLine("Database state is : " + connexion.State);

            //parametrer la commande

            string query = "INSERT INTO ACCOUNT(OWNER,BALANCE,AccountType) VALUES ('" + owner + "'," + bal + ",'" + atype + "')";
            Console.WriteLine(query);
            SqlCommand commande = new SqlCommand();
            //definir le code sql de la commande
            commande.CommandText = query;
            commande.Connection = connexion;

            //Ouvrir la connexion
            connexion.Open();
            Console.WriteLine("Database state is : " + connexion.State);

            int res=commande.ExecuteNonQuery();
            Console.WriteLine("Nombre de lignes inserées "+ res);

           
            //Fermer la connexion
            connexion.Close();
            Console.WriteLine("Database state is : " + connexion.State);

        }
    }
}
