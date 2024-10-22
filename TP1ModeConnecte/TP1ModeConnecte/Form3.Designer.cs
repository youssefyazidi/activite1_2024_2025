namespace TP1ModeConnecte
{
    partial class Form3
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
            this.comboBoxVilles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombreClients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxVilles
            // 
            this.comboBoxVilles.FormattingEnabled = true;
            this.comboBoxVilles.Location = new System.Drawing.Point(164, 79);
            this.comboBoxVilles.Name = "comboBoxVilles";
            this.comboBoxVilles.Size = new System.Drawing.Size(291, 21);
            this.comboBoxVilles.TabIndex = 3;
            this.comboBoxVilles.SelectedIndexChanged += new System.EventHandler(this.comboBoxVilles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ville :";
            // 
            // labelNombreClients
            // 
            this.labelNombreClients.AutoSize = true;
            this.labelNombreClients.Location = new System.Drawing.Point(201, 165);
            this.labelNombreClients.Name = "labelNombreClients";
            this.labelNombreClients.Size = new System.Drawing.Size(92, 13);
            this.labelNombreClients.TabIndex = 4;
            this.labelNombreClients.Text = "Nombre de clients";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 350);
            this.Controls.Add(this.labelNombreClients);
            this.Controls.Add(this.comboBoxVilles);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Nombre e clients par ville";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVilles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreClients;
    }
}