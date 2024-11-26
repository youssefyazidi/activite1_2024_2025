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

        DataSet dsBiblio = ClassDataset.getDatatSet();
        bool chargementData = false;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            comboBoxLivres.DataSource = dsBiblio.Tables["Livre"];
            comboBoxLivres.DisplayMember = "Titre";
            comboBoxLivres.ValueMember = "CodeTh";
        }
        private void remplirComboThemes()
        {
            comboBoxThemes.DataSource = dsBiblio.Tables["Theme"];
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

            DataView view = new DataView(dsBiblio.Tables["Livre"], 
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
            DataRow row = dsBiblio.Tables["Theme"].Select("CodeTh="+ codeTh)[0];
            labelTheme.Text = "Theme : " + row["IntituleTh"];
        }

         private void gererLesAdherentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void gererLesEmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void gererLesRetoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void enregistrerLesModificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Transfert des changements vers la base
            ClassDataset.adapterAdherent.Update(dsBiblio.Tables["ADHERENT"]);
            //Transfert des changements vers la base
            ClassDataset.adapterEmprunts.Update(dsBiblio.Tables["Emprunt"]);

            
            //Confirmation au niveau ds
            dsBiblio.AcceptChanges();
            
        }

        private void annulerLesModifictaionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsBiblio.RejectChanges();
        }
    }
}
