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
        private DataSet dsBiblio = ClassDataset.dsBiblio;

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

            //générer les commandes de MAJ
            SqlCommandBuilder builder = new SqlCommandBuilder(adapterAdherent);
           /* MessageBox.Show(builder.GetInsertCommand().CommandText);
            MessageBox.Show(builder.GetDeleteCommand().CommandText);
            MessageBox.Show(builder.GetUpdateCommand().CommandText);*/
            //remplir le DataSet
            adapterAdherent.Fill(dsBiblio, "ADHERENT");

            //Liaison des données

            AdherentBS.DataSource = dsBiblio.Tables["ADHERENT"];


            //Attribuer une valeur default ç la date d'inscription
            dsBiblio.Tables["ADHERENT"].Columns["DateInscription"].DefaultValue =
                DateTime.Now;


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

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            string codeArechercher = textBoxCodeRecherche.Text.Trim();

            /* DataRow row=
                  dsBiblio.Tables["ADEHRENT"].Select("CodeA='"+codeArechercher+"'")[0];*/

           int position = AdherentBS.Find("CodeA", codeArechercher);
            //Modifier la position du Binding Source
            if (position != -1)
            {
                AdherentBS.Position = position;
            }
            else
            {
                MessageBox.Show("Le code n 'existe pas!!");
            }
           

        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            if (buttonNouveau.Text == "Nouveau")
            {
                AdherentBS.AddNew();
                buttonNouveau.Text = "Ajouter";
            }
            else
            {
                AdherentBS.EndEdit();
                buttonNouveau.Text = "Nouveau";
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (buttonModifier.Text == "Modifier")
            {
                buttonModifier.Text = "Valider";
            }
            else
            {
                AdherentBS.EndEdit();
                buttonModifier.Text = "Modifier";
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Confirmer la suppression ?", "suppression", MessageBoxButtons.OKCancel) == DialogResult.OK
                )

            {
                AdherentBS.RemoveAt(AdherentBS.Position);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Avant cancel");
            foreach (DataRow row in dsBiblio.Tables["ADHERENT"].Rows)
            {
                System.Diagnostics.Debug.WriteLine(row.RowState);
            }
            dsBiblio.RejectChanges();

            System.Diagnostics.Debug.WriteLine("Apres cancel");
            foreach (DataRow row in dsBiblio.Tables["ADHERENT"].Rows)
            {
                System.Diagnostics.Debug.WriteLine(row.RowState);
            }
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
                      
           

            System.Diagnostics.Debug.WriteLine("Avant accept");
            foreach (DataRow row in dsBiblio.Tables["ADHERENT"].Rows)
            {
                System.Diagnostics.Debug.WriteLine(row.RowState);
            }
            //Confirmation au niveau ds
            dsBiblio.AcceptChanges();
            System.Diagnostics.Debug.WriteLine("Apres accept");
            foreach (DataRow row in dsBiblio.Tables["ADHERENT"].Rows)
            {
                System.Diagnostics.Debug.WriteLine(row.RowState);
            }


            //Transfert des changements vers la base
            adapterAdherent.Update(dsBiblio.Tables["ADHERENT"]);

        }

        private void buttonGererEmprunts_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
