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

namespace TP1ModeConnecte
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection();

        SqlCommand Cmd = new SqlCommand();

        SqlDataReader dr;

        private int mode = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //définir la chaine
            con.ConnectionString = 
                @"Data Source=.\SQLEXPRESS;Initial Catalog = Vente_db;Integrated Security =true";
            //associer la connexion a la commande
            Cmd.Connection = con;

            //Activer le mode rechercher
            Mode_Recherche();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            string codeClient = textBoxCodeAChercher.Text.Trim();

            if (codeClient == "")
            {
                MessageBox.Show("Vous devez saisir un code.");
                return;
            }
            //Définir la requete
            //requetes paramètrèes - parametre code
            Cmd.CommandText = "SELECT * FROM CLIENT WHERE CodeCL=@code";
            //avant d'executer la requete, il faut définir le parametre
            //definition de parametre :
            Cmd.Parameters.Clear();
            //1. type
            SqlParameter parameter = new SqlParameter("@code", SqlDbType.VarChar);
            //2.preciser la valeur
            parameter.Value = codeClient;
            //associer le parameter a la commande
            Cmd.Parameters.Add(parameter);
            System.Diagnostics.Debug.WriteLine(Cmd.CommandText);
            // MessageBox.Show(Cmd.CommandText);

            con.Open();
            dr=Cmd.ExecuteReader();
            if(dr.Read())
            {
                textBoxCode.Text = (string)dr["codecl"];
                textBoxNom.Text = (string)dr["nom"];
                textBoxVille.Text = (string)dr["ville"];
            }
            else
            {
                MessageBox.Show("Aucun client trouver pour ce code");
            }
            con.Close();

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                Mode_Add();
            }
            else
            {
                if(textBoxNom.Text.Trim()=="" || textBoxNom.Text.Trim() == ""
                    || textBoxVille.Text.Trim() == "")
                {
                    MessageBox.Show("Les champs sont obligatoires");
                    return;
                }
                Cmd.CommandText = "INSERT INTO CLIENT VALUES (@code,@nom,@ville)";
                Cmd.Parameters.Clear();
                //1. type
                SqlParameter parameter = new SqlParameter("@code", SqlDbType.VarChar);
                //2.preciser la valeur
                parameter.Value = textBoxCode.Text;
                //associer le parameter a la commande
                Cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@Nom", SqlDbType.VarChar);
                //2.preciser la valeur
                parameter.Value = textBoxNom.Text;
                //associer le parameter a la commande
                Cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@ville", SqlDbType.VarChar);
                //2.preciser la valeur
                parameter.Value = textBoxVille.Text;
                //associer le parameter a la commande
                Cmd.Parameters.Add(parameter);

                try
                {
                    con.Open();
                    Cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Mode_Recherche();
            }
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
        private void Mode_Add()
        {
            mode = 1;
            textBoxCode.Enabled = textBoxNom.Enabled = textBoxVille.Enabled = true;
            textBoxCode.Text = textBoxNom.Text = textBoxVille.Text = "";
            buttonSupprimer.Enabled = buttonModifier.Enabled = false;
            buttonAjouter.Enabled = true;
            buttonAjouter.Text = "Ajouter";
           
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
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Mode_Recherche();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if(mode==0)
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
                Cmd.CommandText = 
                    "UPDATE CLIENT SET CodeCL=@code,Nom=@nom,Ville=@ville WHERE CodeCL=@code";
                Cmd.Parameters.Clear();
                //1. type
                SqlParameter parameter = new SqlParameter("@code", SqlDbType.VarChar);
                //2.preciser la valeur
                parameter.Value = textBoxCode.Text;
                //associer le parameter a la commande
                Cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@Nom", SqlDbType.VarChar);
                //2.preciser la valeur
                parameter.Value = textBoxNom.Text;
                //associer le parameter a la commande
                Cmd.Parameters.Add(parameter);

                parameter = new SqlParameter("@ville", SqlDbType.VarChar);
                //2.preciser la valeur
                parameter.Value = textBoxVille.Text;
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
                Mode_Recherche();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if(mode == 0)
            {
                if (textBoxNom.Text.Trim()=="")
                    {
                    return;
                }
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
            }
        }
    }
}
