namespace GestionBiblio
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxAuteurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLivres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivres)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAuteurs
            // 
            this.comboBoxAuteurs.FormattingEnabled = true;
            this.comboBoxAuteurs.Location = new System.Drawing.Point(217, 45);
            this.comboBoxAuteurs.Name = "comboBoxAuteurs";
            this.comboBoxAuteurs.Size = new System.Drawing.Size(192, 21);
            this.comboBoxAuteurs.TabIndex = 0;
            this.comboBoxAuteurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuteurs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom auteur :";
            // 
            // dataGridViewLivres
            // 
            this.dataGridViewLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivres.Location = new System.Drawing.Point(41, 111);
            this.dataGridViewLivres.Name = "dataGridViewLivres";
            this.dataGridViewLivres.Size = new System.Drawing.Size(377, 150);
            this.dataGridViewLivres.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 330);
            this.Controls.Add(this.dataGridViewLivres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAuteurs);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAuteurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLivres;
    }
}