
namespace Fraiss
{
    partial class suivi
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
            this.list_visiteur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Date_mois_annee = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.list_situation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_visiteur
            // 
            this.list_visiteur.FormattingEnabled = true;
            this.list_visiteur.Location = new System.Drawing.Point(273, 50);
            this.list_visiteur.Margin = new System.Windows.Forms.Padding(4);
            this.list_visiteur.Name = "list_visiteur";
            this.list_visiteur.Size = new System.Drawing.Size(265, 24);
            this.list_visiteur.TabIndex = 0;
            this.list_visiteur.SelectedIndexChanged += new System.EventHandler(this.list_visiteur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visiteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mois/année";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Date_mois_annee
            // 
            this.Date_mois_annee.Location = new System.Drawing.Point(273, 88);
            this.Date_mois_annee.Margin = new System.Windows.Forms.Padding(4);
            this.Date_mois_annee.Name = "Date_mois_annee";
            this.Date_mois_annee.Size = new System.Drawing.Size(265, 22);
            this.Date_mois_annee.TabIndex = 5;
            // 
            // list_situation
            // 
            this.list_situation.FormattingEnabled = true;
            this.list_situation.Location = new System.Drawing.Point(273, 125);
            this.list_situation.Margin = new System.Windows.Forms.Padding(4);
            this.list_situation.Name = "list_situation";
            this.list_situation.Size = new System.Drawing.Size(265, 24);
            this.list_situation.TabIndex = 6;
            this.list_situation.SelectedIndexChanged += new System.EventHandler(this.list_situation_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Situation";
            // 
            // suivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 254);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list_situation);
            this.Controls.Add(this.Date_mois_annee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_visiteur);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "suivi";
            this.Text = "suivi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Date_mois_annee;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox list_situation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox list_visiteur;
    }
}