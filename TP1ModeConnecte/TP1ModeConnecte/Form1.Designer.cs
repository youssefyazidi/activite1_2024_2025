namespace TP1ModeConnecte
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
            this.listBoxNoms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxNoms
            // 
            this.listBoxNoms.FormattingEnabled = true;
            this.listBoxNoms.Location = new System.Drawing.Point(58, 38);
            this.listBoxNoms.Name = "listBoxNoms";
            this.listBoxNoms.Size = new System.Drawing.Size(333, 134);
            this.listBoxNoms.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 311);
            this.Controls.Add(this.listBoxNoms);
            this.Name = "Form1";
            this.Text = "Liste des noms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNoms;
    }
}

