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
    public partial class Form2 : Form
    {
        private DataSet dsBiblio = new DataSet();

        private SqlConnection connexion = new SqlConnection();

        private SqlDataAdapter adapterAdherent = new SqlDataAdapter();


        //un objet BindinSource
        BindingSource AdherentBS = new BindingSource();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //définir la chaine de connexion
            connexion.ConnectionString = 
                @"Data Source=.\SQLEXPRESS;Initial Catalog=BiblioDB;Integrated Security=true";

            //Definir la commande de l'adapter
            adapterAdherent.SelectCommand =
                new SqlCommand("SELECT * FROM ADHERENT",connexion);

            //remplir le DataSet
            adapterAdherent.Fill(dsBiblio, "ADHERENT");

            //Liaison des données

            AdherentBS.DataSource = dsBiblio.Tables["ADHERENT"];

            textBoxCode.DataBindings.Add("Text", AdherentBS, "CodeA");
            textBoxNom.DataBindings.Add("Text", AdherentBS, "NomA");
            textBoxAdresse.DataBindings.Add("Text", AdherentBS, "Adresse");
            dateTimePickerInsciption.DataBindings.Add("Value", AdherentBS, "DateInscription");

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePickerInsciption.Value.ToString());
        }

        private void buttonPremier_Click(object sender, EventArgs e)
        {
            AdherentBS.MoveFirst();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            AdherentBS.MovePrevious();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            AdherentBS.MoveNext();
        }

        private void buttonDernier_Click(object sender, EventArgs e)
        {
            AdherentBS.MoveLast();
        }
    }
}
