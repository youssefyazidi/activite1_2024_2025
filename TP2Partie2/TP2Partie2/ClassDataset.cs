using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Partie2
{
    class ClassDataset
    {
        private static DataSet dsBiblio = null;

        //Le connexion utilisée
        private  static SqlConnection connexion = new SqlConnection();

        //Les adapters 
        public static SqlDataAdapter livreAdapter = new SqlDataAdapter();
        public static  SqlDataAdapter themeAdapter = new SqlDataAdapter();
        public static SqlDataAdapter adapterAdherent = new SqlDataAdapter();
        public static SqlDataAdapter adapterEmprunts = new SqlDataAdapter();


        public static DataSet getDatatSet()
        {
            if (dsBiblio == null)
            {

                dsBiblio = new DataSet();

                //définir la chaine de connexion
                connexion.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BiblioDB;Integrated Security=true";

                //parametrer les adapters
                livreAdapter.SelectCommand =
                    new SqlCommand("SELECT * FROM Livre", connexion);
                themeAdapter.SelectCommand =
                   new SqlCommand("SELECT * FROM Theme", connexion);

                //Remplire le Dataset = Le schéma des tables sans contraints
                livreAdapter.Fill(dsBiblio, "Livre");
                themeAdapter.Fill(dsBiblio, "Theme");

                //Definir la commande de l'adapter
                adapterAdherent.SelectCommand =
                    new SqlCommand("SELECT * FROM ADHERENT", connexion);

                //générer les commandes de MAJ
                SqlCommandBuilder builder = new SqlCommandBuilder(adapterAdherent);
                /* MessageBox.Show(builder.GetInsertCommand().CommandText);
                 MessageBox.Show(builder.GetDeleteCommand().CommandText);
                 MessageBox.Show(builder.GetUpdateCommand().CommandText);*/

                //remplir le DataSet
                adapterAdherent.Fill(dsBiblio, "ADHERENT");

                //Definir la commande de l'adapter
                adapterEmprunts.SelectCommand =
                    new SqlCommand("SELECT * FROM Emprunt", connexion);

                //générer les commandes de MAJ
                builder = new SqlCommandBuilder(adapterEmprunts);

                adapterEmprunts.Fill(dsBiblio, "Emprunt");

                //Définir les contraintes
                //le PRIMARY KEY de Livre
                dsBiblio.Tables["Livre"].PrimaryKey = new DataColumn[]
                    {dsBiblio.Tables["Livre"].Columns["CodeL"] };

                //le PRIMARY KEY de Theme
                dsBiblio.Tables["Theme"].PrimaryKey = new DataColumn[]
                    {dsBiblio.Tables["Theme"].Columns["CodeTh"] };

                //Le Foreign Key
                DataRelation relation = new DataRelation("fk_livre_theme",
                    dsBiblio.Tables["Theme"].Columns["CodeTh"],
                    dsBiblio.Tables["Livre"].Columns["CodeTh"]
                    );

                dsBiblio.Relations.Add(relation);
            }
            return dsBiblio;
        }
    }
}
