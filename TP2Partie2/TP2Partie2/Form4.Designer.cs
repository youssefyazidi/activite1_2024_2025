namespace TP2Partie2
{
    partial class Form4
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
            this.textBoxNomAderent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAdherents = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.dateTimePickerRetour = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir Retour";
            // 
            // textBoxNomAderent
            // 
            this.textBoxNomAderent.Enabled = false;
            this.textBoxNomAderent.Location = new System.Drawing.Point(155, 151);
            this.textBoxNomAderent.Name = "textBoxNomAderent";
            this.textBoxNomAderent.Size = new System.Drawing.Size(121, 20);
            this.textBoxNomAderent.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nom Adherent :";
            // 
            // comboBoxAdherents
            // 
            this.comboBoxAdherents.FormattingEnabled = true;
            this.comboBoxAdherents.Location = new System.Drawing.Point(155, 115);
            this.comboBoxAdherents.Name = "comboBoxAdherents";
            this.comboBoxAdherents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdherents.TabIndex = 6;
            this.comboBoxAdherents.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdherents_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Code Adherent :";
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(480, 190);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(188, 23);
            this.buttonEnregistrer.TabIndex = 14;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // dateTimePickerRetour
            // 
            this.dateTimePickerRetour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRetour.Location = new System.Drawing.Point(490, 131);
            this.dateTimePickerRetour.Name = "dateTimePickerRetour";
            this.dateTimePickerRetour.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerRetour.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date Retour :";
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(480, 258);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(188, 23);
            this.buttonQuitter.TabIndex = 17;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 232);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 88);
            this.dataGridView1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Emprunts de l\'adherent:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 472);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.dateTimePickerRetour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNomAderent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAdherents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Saisir les retours";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomAderent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAdherents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.DateTimePicker dateTimePickerRetour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
    }
}