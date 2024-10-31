namespace modeDeConnecte1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonSuppliers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(89, 211);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(75, 23);
            this.buttonProducts.TabIndex = 1;
            this.buttonProducts.Text = "Products";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.Location = new System.Drawing.Point(322, 211);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Size = new System.Drawing.Size(75, 23);
            this.buttonSuppliers.TabIndex = 2;
            this.buttonSuppliers.Text = "Suppliers";
            this.buttonSuppliers.UseVisualStyleBackColor = true;
            this.buttonSuppliers.Click += new System.EventHandler(this.buttonSuppliers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 261);
            this.Controls.Add(this.buttonSuppliers);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Manual DataSet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonSuppliers;
    }
}

