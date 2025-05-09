using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fraiss
{
    public partial class suivi : Form
    {
        private string champprenom;
        private string champlibele;

        private ConnexionSql maConnexionSql;
        private MySqlCommand maRequete;

        // Constructeur qui reçoit le prénom et le rôle
        public suivi(string champprenom, string champlibele, ConnexionSql maConnexionSql)
        {
            InitializeComponent();
            this.champprenom = champprenom;
            this.champlibele = champlibele;
            this.maConnexionSql = maConnexionSql;
        }

        // Événement qui se déclenche au chargement du formulaire
        public void suivi_Load_1(object sender, EventArgs e)
        {
            // Afficher les informations reçues dans un label ou un autre contrôle
            //label1.Text = $" Bonjour {champprenom} -  {champlibele}";

            // Charger les visiteurs dans la liste déroulante
            ChargerVisiteurs();
            ChargerSituation();

        }

        // Fonction pour charger les visiteurs dans la ComboBox
        private void ChargerVisiteurs()
        {

            try
            {
                // Connexion à la base
                //maConnexionSql = ConnexionSql.getInstance("localhost", "frais", "root", "");
                //maConnexionSql.OpenConnexion();

                // Requête pour récupérer les visiteurs
                string sql = "SELECT nom, prenom FROM utilisateur INNER JOIN fonctione ON utilisateur.idPoste = fonctione.id WHERE fonctione.libele = 'visiteur'";

                //maRequete = maConnexionSql.reqExec(sql);
                maRequete = maConnexionSql.reqExec(sql);
                MySqlDataReader reader = maRequete.ExecuteReader();

                // Nettoyer la ComboBox avant d'ajouter les éléments
                list_visiteur.Items.Clear();

                // Ajouter les visiteurs à la ComboBox
                while (reader.Read())
                {
                    string nom = reader.GetString("nom");
                    string prenom = reader.GetString("prenom");
                    list_visiteur.Items.Add(prenom + " " + nom); // Affiche "Prenom Nom"
                }

                reader.Close();
                maConnexionSql.CloseConnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
        private void ChargerSituation()
        {
            try
            {
                maConnexionSql.OpenConnexion();
                // Requête SQL
                string sql = "SELECT description FROM situation";

                // Exécution de la requête
                maRequete = maConnexionSql.reqExec(sql);
                MySqlDataReader reader = maRequete.ExecuteReader();

                // Nettoyer la ComboBox avant d’ajouter les éléments
                list_situation.Items.Clear();

                // Remplir la liste avec les descriptions
                while (reader.Read())
                {
                    string description = reader.GetString("description");
                    list_situation.Items.Add(description);
                }

                reader.Close();
                maConnexionSql.CloseConnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des situations : " + ex.Message);
            }
        }


        // Méthode pour gérer les actions de la page de suivi (exemple)
        private void button1_Click(object sender, EventArgs e)
        {
            // Exemple de code pour effectuer une action lorsque le bouton est cliqué
            MessageBox.Show("Suivi des paiements en cours...");
        }

        // Événement déclenché lorsque l'index de la ComboBox change (c'est-à-dire lorsque l'utilisateur sélectionne un visiteur)
        private void list_visiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ajouter ici ce que tu veux faire lorsque l'utilisateur sélectionne un visiteur.
            string visiteurSelectionne = list_visiteur.SelectedItem.ToString();
            MessageBox.Show($"Visiteur sélectionné : {visiteurSelectionne}");
        }

        private void list_situation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ajouter ici ce que tu veux faire lorsque l'utilisateur sélectionne un visiteur.
            string situationSelectionne = list_situation.SelectedItem.ToString();
            MessageBox.Show($"Situation sélectionné : {situationSelectionne}");
        }

    }
}
