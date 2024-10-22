namespace TP1ModeConnecte
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVilles = new System.Windows.Forms.ComboBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ville :";
            // 
            // comboBoxVilles
            // 
            this.comboBoxVilles.FormattingEnabled = true;
            this.comboBoxVilles.Location = new System.Drawing.Point(120, 52);
            this.comboBoxVilles.Name = "comboBoxVilles";
            this.comboBoxVilles.Size = new System.Drawing.Size(291, 21);
            this.comboBoxVilles.TabIndex = 1;
            this.comboBoxVilles.SelectedIndexChanged += new System.EventHandler(this.comboBoxVilles_SelectedIndexChanged);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(33, 113);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(378, 106);
            this.dataGridViewClients.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 343);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.comboBoxVilles);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Liste des client d\'une ville";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVilles;
        private System.Windows.Forms.DataGridView dataGridViewClients;
    }
}