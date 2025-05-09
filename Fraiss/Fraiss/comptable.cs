using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraiss
{
    public partial class comptable : Form
    {
       
        private string champprenom;
        private string champlibele;
        ConnexionSql maConnexionSql;

        public comptable(string champprenom, string champlibele, ConnexionSql maConnexionSql)
        {
            
            InitializeComponent();
            this.champprenom = champprenom;
            this.champlibele = champlibele;
            this.maConnexionSql = maConnexionSql;
        }

        private void comptable_Load(object sender, EventArgs e)
        {
            presentation.Text = $"Bonjour  {champprenom}  le  {champlibele}";

        }

        private void validationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void suivieDePaiementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            // Créer une nouvelle instance de la page "suivi"
            suivi pageSuivi = new suivi(champprenom, champlibele, maConnexionSql); // Passer les infos si nécessaire

            pageSuivi.suivi_Load_1(this, e);
            // Afficher la page "suivi" en modale
            pageSuivi.ShowDialog();

        }
    }

    
}
