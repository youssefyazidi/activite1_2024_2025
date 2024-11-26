namespace TP2Partie2
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewLivres = new System.Windows.Forms.DataGridView();
            this.comboBoxThemes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTheme = new System.Windows.Forms.Label();
            this.comboBoxLivres = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesAdherentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesEmpruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesRetoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrigistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerLesModificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerLesModifictaionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivres)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.dataGridViewLivres);
            this.groupBox1.Controls.Add(this.comboBoxThemes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewLivres
            // 
            this.dataGridViewLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivres.Location = new System.Drawing.Point(26, 117);
            this.dataGridViewLivres.Name = "dataGridViewLivres";
            this.dataGridViewLivres.Size = new System.Drawing.Size(283, 150);
            this.dataGridViewLivres.TabIndex = 3;
            // 
            // comboBoxThemes
            // 
            this.comboBoxThemes.FormattingEnabled = true;
            this.comboBoxThemes.Location = new System.Drawing.Point(135, 66);
            this.comboBoxThemes.Name = "comboBoxThemes";
            this.comboBoxThemes.Size = new System.Drawing.Size(174, 21);
            this.comboBoxThemes.TabIndex = 2;
            this.comboBoxThemes.SelectedIndexChanged += new System.EventHandler(this.comboBoxThemes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Livres de meme theme :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.labelTheme);
            this.groupBox2.Controls.Add(this.comboBoxLivres);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(396, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Location = new System.Drawing.Point(88, 117);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(99, 13);
            this.labelTheme.TabIndex = 4;
            this.labelTheme.Text = "-----------------------";
            // 
            // comboBoxLivres
            // 
            this.comboBoxLivres.FormattingEnabled = true;
            this.comboBoxLivres.Location = new System.Drawing.Point(127, 63);
            this.comboBoxLivres.Name = "comboBoxLivres";
            this.comboBoxLivres.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLivres.TabIndex = 3;
            this.comboBoxLivres.SelectedIndexChanged += new System.EventHandler(this.comboBoxLivres_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Livre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thème d\'un Livre:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.enrigistrerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererLesAdherentsToolStripMenuItem,
            this.gererLesEmpruntsToolStripMenuItem,
            this.gererLesRetoursToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem1.Text = "Gérer";
            // 
            // gererLesAdherentsToolStripMenuItem
            // 
            this.gererLesAdherentsToolStripMenuItem.Name = "gererLesAdherentsToolStripMenuItem";
            this.gererLesAdherentsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gererLesAdherentsToolStripMenuItem.Text = "Gerer les adherents";
            this.gererLesAdherentsToolStripMenuItem.Click += new System.EventHandler(this.gererLesAdherentsToolStripMenuItem_Click);
            // 
            // gererLesEmpruntsToolStripMenuItem
            // 
            this.gererLesEmpruntsToolStripMenuItem.Name = "gererLesEmpruntsToolStripMenuItem";
            this.gererLesEmpruntsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gererLesEmpruntsToolStripMenuItem.Text = "Gerer les emprunts";
            this.gererLesEmpruntsToolStripMenuItem.Click += new System.EventHandler(this.gererLesEmpruntsToolStripMenuItem_Click);
            // 
            // gererLesRetoursToolStripMenuItem
            // 
            this.gererLesRetoursToolStripMenuItem.Name = "gererLesRetoursToolStripMenuItem";
            this.gererLesRetoursToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gererLesRetoursToolStripMenuItem.Text = "Gerer les retours";
            this.gererLesRetoursToolStripMenuItem.Click += new System.EventHandler(this.gererLesRetoursToolStripMenuItem_Click);
            // 
            // enrigistrerToolStripMenuItem
            // 
            this.enrigistrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerLesModificationsToolStripMenuItem,
            this.annulerLesModifictaionsToolStripMenuItem});
            this.enrigistrerToolStripMenuItem.Name = "enrigistrerToolStripMenuItem";
            this.enrigistrerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.enrigistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // enregistrerLesModificationsToolStripMenuItem
            // 
            this.enregistrerLesModificationsToolStripMenuItem.Name = "enregistrerLesModificationsToolStripMenuItem";
            this.enregistrerLesModificationsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.enregistrerLesModificationsToolStripMenuItem.Text = "Enregistrer les modifications";
            this.enregistrerLesModificationsToolStripMenuItem.Click += new System.EventHandler(this.enregistrerLesModificationsToolStripMenuItem_Click);
            // 
            // annulerLesModifictaionsToolStripMenuItem
            // 
            this.annulerLesModifictaionsToolStripMenuItem.Name = "annulerLesModifictaionsToolStripMenuItem";
            this.annulerLesModifictaionsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.annulerLesModifictaionsToolStripMenuItem.Text = "Annuler les modifictaions";
            this.annulerLesModifictaionsToolStripMenuItem.Click += new System.EventHandler(this.annulerLesModifictaionsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Livres et Themes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivres)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewLivres;
        private System.Windows.Forms.ComboBox comboBoxThemes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.ComboBox comboBoxLivres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gererLesAdherentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesEmpruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesRetoursToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enrigistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerLesModificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerLesModifictaionsToolStripMenuItem;
    }
}

