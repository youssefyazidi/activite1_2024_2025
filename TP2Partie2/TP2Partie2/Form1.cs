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
    public partial class Form1 : Form
    {
        //Le connexion utilisée
        SqlConnection connexion = new SqlConnection();

        //La base locale
        private DataSet dataSet = ClassDataset.dsBiblio;

        //Les adapters 
        SqlDataAdapter livreAdapter = new SqlDataAdapter();
        SqlDataAdapter themeAdapter = new SqlDataAdapter();

        bool chargementData = false;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //définir la chaine de connexion
            connexion.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BiblioDB;Integrated Security=true";

            //parametrer les adapters
            livreAdapter.SelectCommand =
                new SqlCommand("SELECT * FROM Livre", connexion);
            themeAdapter.SelectCommand =
               new SqlCommand("SELECT * FROM Theme", connexion);

            //Remplire le Dataset = Le schéma des tables sans contraints
            livreAdapter.Fill(dataSet, "Livre");
            themeAdapter.Fill(dataSet, "Theme");

            //Définir les contraintes
            //le PRIMARY KEY de Livre
            dataSet.Tables["Livre"].PrimaryKey = new DataColumn[]
                {dataSet.Tables["Livre"].Columns["CodeL"] };

            //le PRIMARY KEY de Theme
            dataSet.Tables["Theme"].PrimaryKey = new DataColumn[]
                {dataSet.Tables["Theme"].Columns["CodeTh"] };

            //Le Foreign Key
            DataRelation relation = new DataRelation("fk_livre_theme",
                dataSet.Tables["Theme"].Columns["CodeTh"],
                dataSet.Tables["Livre"].Columns["CodeTh"]
                );

            dataSet.Relations.Add(relation);

            //Remplir les listes
            remplirComboLivres();
            remplirComboThemes();


            chargementData = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* DataRow row=dataSet.Tables["Livre"].NewRow();
            row["CodeL"]= "L04";
            row["Titre"] = "Decouvrir les reseaux";
            row["Auteur"] = "Rida";
            row["NbExemplaires"] = 5;
            row["CodeTh"] = 2;

            dataSet.Tables["Livre"].Rows.Add(row);

            dataGridViewLivres.DataSource = dataSet.Tables["Livre"];*/
        }

        private void remplirComboLivres()
        {
            comboBoxLivres.DataSource = dataSet.Tables["Livre"];
            comboBoxLivres.DisplayMember = "Titre";
            comboBoxLivres.ValueMember = "CodeTh";
        }
        private void remplirComboThemes()
        {
            comboBoxThemes.DataSource = dataSet.Tables["Theme"];
            comboBoxThemes.DisplayMember = "IntituleTh";
            comboBoxThemes.ValueMember = "CodeTh";
        }

        private void comboBoxThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!chargementData)
            {
                return;
            }

            /*  int rowIndex = comboBoxThemes.SelectedIndex;
              DataRow row=  dataSet.Tables["Theme"].Rows[rowIndex];

             DataRow[] rows = row.GetChildRows("fk_livre_theme");
             dataGridViewLivres.Rows.Clear();
             foreach (DataRow current in rows)
             {
                 dataGridViewLivres.Rows.Add(current["CodeL"], 
                     current["Titre"], 
                     current["Auteur"]);
             }*/

            int codeTh =(int) comboBoxThemes.SelectedValue;

            DataView view = new DataView(dataSet.Tables["Livre"], 
                "CodeTh=" + codeTh, 
                null, 
                DataViewRowState.CurrentRows);
                 dataGridViewLivres.DataSource = view;
        }

        private void comboBoxLivres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chargementData)
            {
                return;
            }
            /* int rowIndex = comboBoxLivres.SelectedIndex;
             DataRow row = dataSet.Tables["Livre"].Rows[rowIndex];*/
            int codeTh = (int)comboBoxLivres.SelectedValue;
            DataRow row = dataSet.Tables["Theme"].Select("CodeTh="+ codeTh)[0];
            labelTheme.Text = "Theme : " + row["IntituleTh"];
        }

        private void buttonGererAdherent_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
