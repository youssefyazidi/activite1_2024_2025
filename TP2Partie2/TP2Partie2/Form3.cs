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

namespace TP2Partie2
{
    public partial class Form3 : Form
    {
        private DataSet ds = ClassDataset.dsBiblio;


        private SqlConnection connexion = new SqlConnection();

        private SqlDataAdapter adapterEmprunts = new SqlDataAdapter();


        bool charger = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            //Remplir le Dataset par les Emprunts
            //définir la chaine de connexion
            connexion.ConnectionString =
                @"Data Source=.\SQLEXPRESS;Initial Catalog=BiblioDB;Integrated Security=true";

            //Definir la commande de l'adapter
            adapterEmprunts.SelectCommand =
                new SqlCommand("SELECT * FROM Emprunt", connexion);

            //générer les commandes de MAJ
            SqlCommandBuilder builder = new SqlCommandBuilder(adapterEmprunts);

            adapterEmprunts.Fill(ds,"Emprunt");

            //La liste des adherents
            comboBoxAdherents.DataSource = ds.Tables["ADHERENT"];
            comboBoxAdherents.DisplayMember = "CodeA";
            comboBoxAdherents.ValueMember = "NomA";


            //La liste des thèmes
            comboBoxTheme.DataSource = ds.Tables["Theme"];
            comboBoxTheme.DisplayMember = "IntituleTh";
            comboBoxTheme.ValueMember = "CodeTh";


            //Lier la liste des livres
            listBoxLivres.DataSource = ds.Tables["Livre"];
            listBoxLivres.DisplayMember = "Titre";
            listBoxLivres.ValueMember = "CodeL"; 
            
            //Lier les emprunts au dataGridView
            dataGridView1.DataSource = ds.Tables["Emprunt"];

            charger = true;


           

            comboBoxAdherents_SelectedIndexChanged(sender, e);
            comboBoxTheme_SelectedIndexChanged(sender, e);
        }

        private void comboBoxAdherents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charger)
            {
                textBoxNomAderent.Text = (string)comboBoxAdherents.SelectedValue;
                ds.Tables["Emprunt"].DefaultView.RowFilter =
                    "CodeA='" + ((DataRowView)comboBoxAdherents.SelectedItem)["CodeA"]+"'";
            }
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charger)
            {
                ds.Tables["Livre"].DefaultView.RowFilter = 
                    "CodeTh=" + comboBoxTheme.SelectedValue;
                    }
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = ds.Tables["Emprunt"].NewRow();
                newRow["CodeA"] = ((DataRowView)comboBoxAdherents.SelectedItem)["CodeA"];
                newRow["CodeL"] = listBoxLivres.SelectedValue;
                newRow["DateEmprunt"] = dateTimePickerEmprunt.Value;

                ds.Tables["Emprunt"].Rows.Add(newRow);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       

        }
    }
}
