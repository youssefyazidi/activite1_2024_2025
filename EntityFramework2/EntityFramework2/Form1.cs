using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework2
{
    public partial class Form1 : Form
    {
        ModelBiblio modelBiblio = new ModelBiblio();
        bool charger = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Remplir les combobox

            comboBoxThemes.DataSource =
                modelBiblio.Themes.ToList();
            comboBoxThemes.DisplayMember = "IntituleTh";
            comboBoxThemes.ValueMember = "CodeTh";


            comboBoxLivres.DataSource =
                modelBiblio.Livres.ToList();

            comboBoxLivres.DisplayMember = "Titre";
            comboBoxLivres.ValueMember = "CodeL";

            charger = true;
        }

        private void comboBoxThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(charger)
            {
                int codeth = (int)comboBoxThemes.SelectedValue;

                //requete Linq
                var query= from livre in modelBiblio.Livres
                           where  livre.CodeTh == codeth
                           select new {livre.CodeL, livre.Titre, livre.Auteur};

                /* foreach (var livre in query)
                 {
                     dataGridViewLivres.Rows.Add(livre.CodeL, livre.Titre, livre.Auteur);
                 }*/

                dataGridViewLivres.DataSource = query.ToList();
            }
        }

        private void comboBoxLivres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charger)
            {
               // int codeLivre = (int)comboBoxLivres.SelectedValue;

                Livre livre = (Livre)comboBoxLivres.SelectedItem;

                 var query = from theme in modelBiblio.Themes
                             where theme.CodeTh == livre.CodeTh
                             select theme;

                /* foreach(var th in query)
                 {
                     labelTheme.Text = th.IntituleTh;
                     break;
                 }*/

                labelTheme.Text = query.FirstOrDefault().IntituleTh;



            }

        }
    }
}
