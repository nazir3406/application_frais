namespace Fraiss
{
    partial class consultation
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
            this.Période = new System.Windows.Forms.Label();
            this.mois = new System.Windows.Forms.Label();
            this.frais = new System.Windows.Forms.Label();
            this.hors = new System.Windows.Forms.Label();
            this.classification = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Calendrier = new System.Windows.Forms.MonthCalendar();
            this.Afficher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Repas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nuitée = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Étape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nbjustificatifs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situation3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateoperation3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siuation2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateoperation0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Période
            // 
            this.Période.AutoSize = true;
            this.Période.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Période.ForeColor = System.Drawing.SystemColors.Control;
            this.Période.Location = new System.Drawing.Point(12, 9);
            this.Période.Name = "Période";
            this.Période.Size = new System.Drawing.Size(93, 25);
            this.Période.TabIndex = 0;
            this.Période.Text = "Période";
            // 
            // mois
            // 
            this.mois.AutoSize = true;
            this.mois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mois.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mois.Location = new System.Drawing.Point(14, 52);
            this.mois.Name = "mois";
            this.mois.Size = new System.Drawing.Size(89, 16);
            this.mois.TabIndex = 1;
            this.mois.Text = "Mois/année";
            // 
            // frais
            // 
            this.frais.AutoSize = true;
            this.frais.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frais.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.frais.Location = new System.Drawing.Point(10, 99);
            this.frais.Name = "frais";
            this.frais.Size = new System.Drawing.Size(180, 29);
            this.frais.TabIndex = 2;
            this.frais.Text = "Frais au forfait";
            // 
            // hors
            // 
            this.hors.AutoSize = true;
            this.hors.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hors.Location = new System.Drawing.Point(10, 239);
            this.hors.Name = "hors";
            this.hors.Size = new System.Drawing.Size(203, 29);
            this.hors.TabIndex = 3;
            this.hors.Text = "Frais hors forfait";
            // 
            // classification
            // 
            this.classification.AutoSize = true;
            this.classification.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classification.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.classification.Location = new System.Drawing.Point(12, 418);
            this.classification.Name = "classification";
            this.classification.Size = new System.Drawing.Size(288, 29);
            this.classification.TabIndex = 4;
            this.classification.Text = "Frais hors classification";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Libele,
            this.Quantité1,
            this.Siuation2,
            this.Dateoperation0});
            this.dataGridView2.Location = new System.Drawing.Point(12, 271);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(599, 118);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nbjustificatifs,
            this.Quantité,
            this.Situation3,
            this.Dateoperation3});
            this.dataGridView3.Location = new System.Drawing.Point(15, 472);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(596, 77);
            this.dataGridView3.TabIndex = 8;
            // 
            // Calendrier
            // 
            this.Calendrier.Location = new System.Drawing.Point(139, 9);
            this.Calendrier.Name = "Calendrier";
            this.Calendrier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Calendrier.TabIndex = 9;
            // 
            // Afficher
            // 
            this.Afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afficher.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Afficher.Location = new System.Drawing.Point(470, 81);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(100, 35);
            this.Afficher.TabIndex = 10;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = true;
            this.Afficher.Click += new System.EventHandler(this.Afficher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Repas,
            this.Nuitée,
            this.Étape,
            this.Situation,
            this.dateoperation});
            this.dataGridView1.Location = new System.Drawing.Point(17, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 84);
            this.dataGridView1.TabIndex = 11;
            // 
            // Repas
            // 
            this.Repas.HeaderText = "Repas Midi";
            this.Repas.Name = "Repas";
            // 
            // Nuitée
            // 
            this.Nuitée.HeaderText = "Nuitée";
            this.Nuitée.Name = "Nuitée";
            // 
            // Étape
            // 
            this.Étape.HeaderText = "Étape";
            this.Étape.Name = "Étape";
            // 
            // Situation
            // 
            this.Situation.HeaderText = "Situation";
            this.Situation.Name = "Situation";
            // 
            // dateoperation
            // 
            this.dateoperation.HeaderText = "Date operation";
            this.dateoperation.Name = "dateoperation";
            // 
            // Nbjustificatifs
            // 
            this.Nbjustificatifs.HeaderText = "Nb justificatifs";
            this.Nbjustificatifs.Name = "Nbjustificatifs";
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.Name = "Quantité";
            // 
            // Situation3
            // 
            this.Situation3.HeaderText = "Situation";
            this.Situation3.Name = "Situation3";
            // 
            // Dateoperation3
            // 
            this.Dateoperation3.HeaderText = "Date operation";
            this.Dateoperation3.Name = "Dateoperation3";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Libele
            // 
            this.Libele.HeaderText = "Libele";
            this.Libele.Name = "Libele";
            // 
            // Quantité1
            // 
            this.Quantité1.HeaderText = "Quantité";
            this.Quantité1.Name = "Quantité1";
            // 
            // Siuation2
            // 
            this.Siuation2.HeaderText = "Situation";
            this.Siuation2.Name = "Siuation2";
            // 
            // Dateoperation0
            // 
            this.Dateoperation0.HeaderText = "Date operation";
            this.Dateoperation0.Name = "Dateoperation0";
            // 
            // consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Afficher);
            this.Controls.Add(this.Calendrier);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.classification);
            this.Controls.Add(this.hors);
            this.Controls.Add(this.frais);
            this.Controls.Add(this.mois);
            this.Controls.Add(this.Période);
            this.Name = "consultation";
            this.Text = "è";
            this.Load += new System.EventHandler(this.Consultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Période;
        private System.Windows.Forms.Label mois;
        private System.Windows.Forms.Label frais;
        private System.Windows.Forms.Label hors;
        private System.Windows.Forms.Label classification;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.MonthCalendar Calendrier;
        private System.Windows.Forms.Button Afficher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nuitée;
        private System.Windows.Forms.DataGridViewTextBoxColumn Étape;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libele;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siuation2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateoperation0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nbjustificatifs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situation3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateoperation3;
    }
}