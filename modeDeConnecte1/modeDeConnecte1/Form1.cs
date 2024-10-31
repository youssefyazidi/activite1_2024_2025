using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeDeConnecte1
{
    public partial class Form1 : Form
    {
        DataSet dataSet;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creer la base de données locale
           dataSet = CreateDataSet();
        }


        private DataSet CreateDataSet()
        {
            DataSet ds = new DataSet("LocalDb");

            DataTable dataTable;
            DataColumn dataColumn;
            DataRow dataRow;

            //Creae la table Products
            dataTable = new DataTable("Products");
            ds.Tables.Add(dataTable);
            //Définir le schema de la table Products
            dataColumn = new DataColumn("ProductName");
            dataColumn.DataType = System.Type.GetType("System.String");
            dataColumn.DefaultValue = "";

            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Price");
            dataColumn.DataType = System.Type.GetType("System.Single");
            dataColumn.DefaultValue = 0;

            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("SupplierId");
            dataColumn.DataType = System.Type.GetType("System.String");
            dataColumn.DefaultValue = "";
            dataTable.Columns.Add(dataColumn);

            //Creae la table Suppliers
            dataTable = new DataTable("Suppliers");
            ds.Tables.Add(dataTable);
            //Définir le schema de la table Suppliers
            dataColumn = new DataColumn("SupplierName");
            dataColumn.DataType = System.Type.GetType("System.String");
            dataColumn.DefaultValue = "";

            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("SupplierId");
            dataColumn.DataType = System.Type.GetType("System.String");
            dataColumn.Unique = true;
            dataTable.Columns.Add(dataColumn);

            //Définir la clé primaire
            dataTable.PrimaryKey = new DataColumn[]{ dataColumn};

            //Définir la clé étrangère (Relation)

            DataRelation relation = new DataRelation("fk_pr_sup",
                ds.Tables["Suppliers"].Columns["SupplierId"],
                ds.Tables["Products"].Columns["SupplierId"]);

            ds.Relations.Add(relation);

            //Creation des donnés

            dataRow = ds.Tables["Suppliers"].NewRow();
            dataRow["SupplierId"] = "LIMA";
            dataRow["SupplierName"] = "BEANS,BEANS,BEANS,LCC";
            ds.Tables["Suppliers"].Rows.Add(dataRow);

            dataRow = ds.Tables["Suppliers"].NewRow();
            dataRow["SupplierId"] = "ACME";
            dataRow["SupplierName"] = "ACME Products, Inc.";
            ds.Tables["Suppliers"].Rows.Add(dataRow);


            dataRow = ds.Tables["Products"].NewRow();
            dataRow["ProductName"] = "Bean Bag Chair";
            dataRow["Price"] = 38.29;
            dataRow["SupplierId"] = "LIMA";
            ds.Tables["Products"].Rows.Add(dataRow);

            dataRow = ds.Tables["Products"].NewRow();
            dataRow["ProductName"] = "Rocking Chair";
            dataRow["Price"] = 123.95;
            dataRow["SupplierId"] = "ACME";
            ds.Tables["Products"].Rows.Add(dataRow);

            dataRow = ds.Tables["Products"].NewRow();
            dataRow["ProductName"] = "Bar Stool";
            dataRow["Price"] = 29.99;
            dataRow["SupplierId"] = "ACME";
            ds.Tables["Products"].Rows.Add(dataRow);

            return ds;
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            //Composant consomateur de données
            dataGridView1.DataSource = dataSet.Tables["Products"];
        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "Suppliers";
        }
    }
}
