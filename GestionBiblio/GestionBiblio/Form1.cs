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

namespace GestionBiblio
{
    public partial class Form1 : Form
    {
        //La connexion
        SqlConnection connexion = new SqlConnection();

        //La commande
        SqlCommand commande = new SqlCommand();

        //Le pond = l'adapter
        SqlDataAdapter adapter = new SqlDataAdapter();

        //La base locale
        DataSet dataSet = new DataSet();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //L'initialisation
            string chaine = @"Data Source = .\SQLEXPRESS; Initial Catalog=BiblioDB;Integrated Security=true";
            connexion.ConnectionString = chaine;

            commande.Connection = connexion;

            adapter.SelectCommand = commande;

            //définir les données à ramener
            commande.CommandText = "SELECT * FROM Livre";

            //Copier la table livre dans le DataSet

            adapter.Fill(dataSet, "Livre");

            //Lier le controle ListBox à la table livre
            listBoxLivres.DataSource = dataSet.Tables["Livre"];
            listBoxLivres.DisplayMember = "Titre";
        }
    }
}
