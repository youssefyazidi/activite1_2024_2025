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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection();

        SqlCommand CmdSelect = new SqlCommand();

        SqlDataReader dr;

        private bool load = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog = Vente_db;Integrated Security =true";
            CmdSelect.Connection = con;

            CmdSelect.CommandText = "SELECT DISTINCT Ville FROM CLIENT";
            
            //Ouvrir
            con.Open();
            dr = CmdSelect.ExecuteReader();
            // Representation relationnelle des données
            DataTable dataTable = new DataTable();
            dataTable.Load(dr);
            //MessageBox.Show(dataTable.Columns[0].ColumnName +"");
            //On a créer une liaison entre listbox et le datatable
            comboBoxVilles.DataSource = dataTable;
            comboBoxVilles.DisplayMember = "Ville";
            comboBoxVilles.ValueMember = "Ville";
            con.Close();
            load = true;
            comboBoxVilles_SelectedIndexChanged(sender, e);
        }

        private void comboBoxVilles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load)
            {
                string nomVille = (string)comboBoxVilles.SelectedValue;
                //MessageBox.Show(nomVille);


                CmdSelect.CommandText = "SELECT * FROM CLIENT WHERE VILLE='"+nomVille+"'";

                //Ouvrir
                con.Open();
                dr = CmdSelect.ExecuteReader();
                // Representation relationnelle des données
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);
                //Lier le dataGridView au datatable
                dataGridViewClients.DataSource = dataTable;
                con.Close();

            }
        }
    }
}
