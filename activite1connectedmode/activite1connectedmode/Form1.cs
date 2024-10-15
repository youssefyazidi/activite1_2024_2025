using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activite1connectedmode
{
    public partial class Form1 : Form
    {
        //Represente la connexion(session) vers la base
        private SqlConnection connexion;
        //Representer les requetes vers la base
        private SqlCommand commande;
        //Permet de stocker en mémoire le resultat d'un select
        private SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Parameter la connexion
            string chaine = @"Data Source = .\SQLEXPRESS;Initial Catalog=MABASE;Integrated Security=true";
            connexion = new SqlConnection(chaine);
            // connexion.ConnectionString = chaine;
            commande = new SqlCommand();
            //Associer la connexion à l'objet commande
            commande.Connection = connexion;

            //Remplir la liste
            commande.CommandText = "SELECT nom FROM PERSONNE";

            //Ouvrir la connexion
            connexion.Open();

            //Envoyer la commande
            //Le reader est un curseur de données
            reader = commande.ExecuteReader();

            while (reader.Read())
            {
                listBoxPersonnes.Items.Add(reader["nom"]);
                //listBoxPersonnes.Items.Add(reader[0]);
                //listBoxPersonnes.Items.Add(reader.GetString(0));
                /*string nom = reader["nom"];
                string nom = reader.GetString(0);
                listBoxPersonnes.Items.Add(nom);*/

            }
            //Fermeture de la connexion
            connexion.Close();

        }
    }
}
