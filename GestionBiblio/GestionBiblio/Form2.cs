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
    public partial class Form2 : Form
    {
        //La connexion
        SqlConnection connexion = new SqlConnection();

        //La commande
        SqlCommand commande = new SqlCommand();

        //Le pond = l'adapter
        SqlDataAdapter adapter = new SqlDataAdapter();

        //La base locale
        DataSet dataSet = new DataSet();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

            //Remplir le combo

            comboBoxAuteurs.DataSource = dataSet.Tables["Livre"].DefaultView;
            comboBoxAuteurs.DisplayMember = "Auteur";
            comboBoxAuteurs.ValueMember = "CodeL";


            // dataGridViewLivres.DataSource = dataSet.Tables["Livre"];

        }

        private void comboBoxAuteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomAuteur = 
                ((DataRowView)comboBoxAuteurs.SelectedItem).Row["Auteur"].ToString();

            string valueAuteur = comboBoxAuteurs.SelectedValue.ToString();

            //La notion de DataView = des fenetres de données
            //view par datatable
            DataView monView1 = 
                new DataView(dataSet.Tables["Livre"], "auteur ='" + nomAuteur + "'", null, DataViewRowState.CurrentRows);

            dataGridViewLivres.DataSource = monView1;

            //dataSet.Tables["Livre"].DefaultView.RowFilter = "auteur ='" + nomAuteur + "'";
            MessageBox.Show(valueAuteur);
        }
    }
}
