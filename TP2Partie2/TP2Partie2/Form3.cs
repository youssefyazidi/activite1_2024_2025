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
        private DataSet dsBiblio = ClassDataset.getDatatSet();

        bool charger = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

           

           

            //La liste des adherents
            comboBoxAdherents.DataSource = dsBiblio.Tables["ADHERENT"];
            comboBoxAdherents.DisplayMember = "CodeA";
            comboBoxAdherents.ValueMember = "NomA";


            //La liste des thèmes
            comboBoxTheme.DataSource = dsBiblio.Tables["Theme"];
            comboBoxTheme.DisplayMember = "IntituleTh";
            comboBoxTheme.ValueMember = "CodeTh";


            //Lier la liste des livres
            listBoxLivres.DataSource = dsBiblio.Tables["Livre"];
            listBoxLivres.DisplayMember = "Titre";
            listBoxLivres.ValueMember = "CodeL"; 
            
            //Lier les emprunts au dataGridView
            dataGridView1.DataSource = dsBiblio.Tables["Emprunt"];

            charger = true;


            comboBoxAdherents_SelectedIndexChanged(sender, e);
            comboBoxTheme_SelectedIndexChanged(sender, e);
        }

        private void comboBoxAdherents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charger)
            {
                textBoxNomAderent.Text = (string)comboBoxAdherents.SelectedValue;
                dsBiblio.Tables["Emprunt"].DefaultView.RowFilter =
                    "CodeA='" + ((DataRowView)comboBoxAdherents.SelectedItem)["CodeA"]+"'";
            }
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charger)
            {
                dsBiblio.Tables["Livre"].DefaultView.RowFilter = 
                    "CodeTh=" + comboBoxTheme.SelectedValue;
            }
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = dsBiblio.Tables["Emprunt"].NewRow();
                newRow["CodeA"] = ((DataRowView)comboBoxAdherents.SelectedItem)["CodeA"];
                newRow["CodeL"] = listBoxLivres.SelectedValue;
                newRow["DateEmprunt"] = dateTimePickerEmprunt.Value;

                dsBiblio.Tables["Emprunt"].Rows.Add(newRow);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       

        }
    }
}
