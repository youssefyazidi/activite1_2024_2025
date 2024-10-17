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
            listBoxPersonnes.Sorted = true;

            //Parameter la connexion
            string chaine = 
                @"Data Source = .\SQLEXPRESS;Initial Catalog=MABASE;Integrated Security=true";
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


        //Fonction qui execute le code passé en paramètre dans la base (LMD)
        //INSERT UPDATE DELETE
        private bool executeCmd(string text)
        {
            try
            {
                commande.CommandText = text;
                //Ouvrir la connexion
                connexion.Open();
                //Envoyer la commande
                int numRows = commande.ExecuteNonQuery();
                //Fermeture de la connexion
                connexion.Close();
                return false;
            }
            catch(SqlException e)
            {
                return true;
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if(textBoxPersonne.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez remplir le champs!!!!");
                return;
            }

            if (executeCmd("INSERT INTO PERSONNE VALUES('" + textBoxPersonne.Text.Trim() + "')"))
            {
                MessageBox.Show("Probleme d'insertion  de l 'élément");
            }
            else
            {
                listBoxPersonnes.Items.Add(textBoxPersonne.Text.Trim());
               
            }

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("DELETE FROM PERSONNE WHERE nom='" + listBoxPersonnes.SelectedItem + "'");

            if(executeCmd("DELETE FROM PERSONNE WHERE nom='"+listBoxPersonnes.SelectedItem+"'"))
            {
                MessageBox.Show("Probeme de suppression de l 'élément");
            }
            else
            {
                listBoxPersonnes.Items.Remove(listBoxPersonnes.SelectedItem);
            }
        }

        private void buttonCompter_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM PERSONNE";
            commande.CommandText = query;
            try
            {
                connexion.Open();
                int count = (int)commande.ExecuteScalar();
                MessageBox.Show("Le nombre de personne est : " + count);
             
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connexion.Close();
            }
        }
    }
}
