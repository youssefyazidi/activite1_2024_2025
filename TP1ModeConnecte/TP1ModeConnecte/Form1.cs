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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();

        SqlCommand CmdSelect = new SqlCommand();

        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog = Vente_db;Integrated Security =true";
            CmdSelect.Connection = con;

            CmdSelect.CommandText = "SELECT * FROM CLIENT";
            //Ouvrir
            con.Open();
            dr=CmdSelect.ExecuteReader();
            // Representation relationnelle des données
            DataTable dataTable = new DataTable();
            dataTable.Load(dr);
            //MessageBox.Show(dataTable.Columns[0].ColumnName +"");
            //On a créer une liaison entre listbox et le datatable
            listBoxNoms.DataSource = dataTable;
            listBoxNoms.DisplayMember = "Nom";
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
