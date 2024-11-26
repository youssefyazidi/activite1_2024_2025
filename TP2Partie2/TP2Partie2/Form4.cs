using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2Partie2
{
    public partial class Form4 : Form
    {
        private DataSet dsBiblio = ClassDataset.getDatatSet();
        bool charger = false;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            //La liste des adherents
            comboBoxAdherents.DataSource = dsBiblio.Tables["ADHERENT"];
            comboBoxAdherents.DisplayMember = "CodeA";
            comboBoxAdherents.ValueMember = "NomA";


            //Lier les emprunts au dataGridView
            dataGridView1.DataSource = dsBiblio.Tables["Emprunt"];

            charger = true;

            comboBoxAdherents_SelectedIndexChanged(sender, e);
        }

        private void comboBoxAdherents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charger)
            {
                textBoxNomAderent.Text = (string)comboBoxAdherents.SelectedValue;
                dsBiblio.Tables["Emprunt"].DefaultView.RowFilter =
                    "CodeA='" + ((DataRowView)comboBoxAdherents.SelectedItem)["CodeA"] + "'";
            }
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;

            if (index != -1)
            {
                string codeA = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string codeL = dataGridView1.Rows[index].Cells[1].Value.ToString();

                DataRow row = dsBiblio.Tables["Emprunt"].Select("CodeA='" + codeA + "' and CodeL='" + codeL + "'")[0];

                row["dateRetour"] = dateTimePickerRetour.Value;
            }


        }
    }
}
