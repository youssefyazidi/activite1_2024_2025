namespace activite1connectedmode
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
            this.buttonCompter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.listBoxPersonnes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCompter
            // 
            this.buttonCompter.Location = new System.Drawing.Point(33, 92);
            this.buttonCompter.Name = "buttonCompter";
            this.buttonCompter.Size = new System.Drawing.Size(151, 23);
            this.buttonCompter.TabIndex = 0;
            this.buttonCompter.Text = "Compte des personnes";
            this.buttonCompter.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(33, 150);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(151, 23);
            this.buttonSupprimer.TabIndex = 1;
            this.buttonSupprimer.Text = "Supprimer la personne";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(33, 213);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(151, 23);
            this.buttonAjouter.TabIndex = 2;
            this.buttonAjouter.Text = "Ajouter une personne";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // listBoxPersonnes
            // 
            this.listBoxPersonnes.FormattingEnabled = true;
            this.listBoxPersonnes.Location = new System.Drawing.Point(233, 89);
            this.listBoxPersonnes.Name = "listBoxPersonnes";
            this.listBoxPersonnes.Size = new System.Drawing.Size(181, 147);
            this.listBoxPersonnes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 355);
            this.Controls.Add(this.listBoxPersonnes);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonCompter);
            this.Name = "Form1";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCompter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.ListBox listBoxPersonnes;
    }
}

