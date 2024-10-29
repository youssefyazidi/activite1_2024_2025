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

namespace TP1Partie2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();

        SqlCommand Cmd = new SqlCommand();

        SqlDataReader dr;

        //Objet de type Liaison de données
        BindingSource clientBS = new BindingSource();

        // Representer la table client
        DataTable dt = new DataTable();


        private int mode = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //définir la chaine
            con.ConnectionString =
                @"Data Source=.\SQLEXPRESS;Initial Catalog = Vente_db;Integrated Security =true";
            //associer la connexion a la commande
            Cmd.Connection = con;

            //Remplire le Datable


            Cmd.CommandText = "SELECT * FROM CLIENT";

            //Ouvrir
            con.Open();
            dr = Cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            //Créer la liaison de données
            //Binding <=> Datable
            clientBS.DataSource = dt;

            //User Interface <=> Binding Source

            textBoxCode.DataBindings.Add("Text",clientBS,"CodeCl");
            textBoxNom.DataBindings.Add("Text", clientBS, "Nom");
            textBoxVille.DataBindings.Add("Text", clientBS, "Ville");

            Mode_Recherche();

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            clientBS.MoveFirst();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            clientBS.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            clientBS.MoveNext();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            clientBS.MoveLast();
        }


        private void Mode_Recherche()
        {
            mode = 0;
            textBoxCode.Enabled = textBoxNom.Enabled = textBoxVille.Enabled = false;
            buttonSupprimer.Enabled = buttonModifier.Enabled = true;
            buttonAjouter.Enabled = true;
            buttonAjouter.Text = "Nouveau";
            buttonModifier.Text = "Modifier";
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            string codeClient = textBoxCodeAChercher.Text.Trim();

            if (codeClient == "")
            {
                MessageBox.Show("Vous devez saisir un code.");
                return;
            }

            //Rechercher le code
            int index = clientBS.Find("CodeCL", codeClient);
            
            if(index == -1 )
            {
                MessageBox.Show("Pas de client pour le code : "+codeClient);
                return;
            }

            clientBS.Position = index;
        }

        private void Mode_Add()
        {
            mode = 1;
            textBoxCode.Enabled = 
                textBoxNom.Enabled = 
                textBoxVille.Enabled = true;

            //textBoxCode.Text = textBoxNom.Text = textBoxVille.Text = "";
            clientBS.AddNew();
            buttonSupprimer.Enabled = buttonModifier.Enabled = false;
            buttonAjouter.Enabled = true;
            buttonAjouter.Text = "Ajouter";

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                Mode_Add();
            }
            else
            {
                if (textBoxNom.Text.Trim() == "" || textBoxNom.Text.Trim() == ""
                    || textBoxVille.Text.Trim() == "")
                {
                    MessageBox.Show("Les champs sont obligatoires");
                    return;
                }
                //Realiser l'ajout
                //validation au niveau de Binding Source
                clientBS.EndEdit();
                Mode_Recherche();
            }
        }

        private void Mode_Update()
        {
            mode = 2;
            textBoxCode.Enabled = false;
            textBoxNom.Enabled = textBoxVille.Enabled = true;
            buttonSupprimer.Enabled = false;
            buttonAjouter.Enabled = false;
            buttonModifier.Enabled = true;
            buttonModifier.Text = "Valider";
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                Mode_Update();
            }
            else
            {
                if (textBoxNom.Text.Trim() == "" || textBoxNom.Text.Trim() == ""
                   || textBoxVille.Text.Trim() == "")
                {
                    MessageBox.Show("Les champs sont obligatoires");
                    return;
                }

                //Modifier au niveau Binding Source
                clientBS.EndEdit();
                Mode_Recherche();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

            if (mode == 0)
            {
                Cmd.CommandText =
                  "DELETE FROM CLIENT WHERE CodeCL=@code";
                Cmd.Parameters.Clear();
                //1. type
                SqlParameter parameter = new SqlParameter("@code", SqlDbType.VarChar);
                //2.preciser la valeur
                parameter.Value = textBoxCode.Text;
                //associer le parameter a la commande
                Cmd.Parameters.Add(parameter);

                try
                {
                    con.Open();
                    Cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Client supprime!");
                    textBoxCode.Text = textBoxNom.Text = textBoxVille.Text = "";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                clientBS.RemoveAt(clientBS.Position);
                MessageBox.Show("Client supprime!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row.RowState.Equals(DataRowState.Added))
                {
                    Cmd.CommandText = "INSERT INTO CLIENT VALUES (@code,@nom,@ville)";
                    Cmd.Parameters.Clear();
                    //1. type
                    SqlParameter parameter = new SqlParameter("@code", SqlDbType.VarChar);
                    //2.preciser la valeur
                    parameter.Value = row[0];
                    //associer le parameter a la commande
                    Cmd.Parameters.Add(parameter);

                    parameter = new SqlParameter("@Nom", SqlDbType.VarChar);
                    //2.preciser la valeur
                    parameter.Value = row[1];
                    //associer le parameter a la commande
                    Cmd.Parameters.Add(parameter);

                    parameter = new SqlParameter("@ville", SqlDbType.VarChar);
                    //2.preciser la valeur
                    parameter.Value = row[2];
                    //associer le parameter a la commande
                    Cmd.Parameters.Add(parameter);

                    try
                    {
                        con.Open();
                        Cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                

            if (row.RowState.Equals(DataRowState.Modified))
            {
                    Cmd.CommandText =
                        "UPDATE CLIENT SET CodeCL=@code,Nom=@nom,Ville=@ville WHERE CodeCL=@code";
                    Cmd.Parameters.Clear();
                    //1. type
                    SqlParameter parameter = new SqlParameter("@code", SqlDbType.VarChar);
                    //2.preciser la valeur
                    parameter.Value = row[0];
                    //associer le parameter a la commande
                    Cmd.Parameters.Add(parameter);

                    parameter = new SqlParameter("@Nom", SqlDbType.VarChar);
                    //2.preciser la valeur
                    parameter.Value = row[1];
                    //associer le parameter a la commande
                    Cmd.Parameters.Add(parameter);

                    parameter = new SqlParameter("@ville", SqlDbType.VarChar);
                    //2.preciser la valeur
                    parameter.Value = row[2];
                    //associer le parameter a la commande
                    Cmd.Parameters.Add(parameter);

                    try
                    {
                        con.Open();
                        Cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            
        }
    }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
           
        }
    }
}
