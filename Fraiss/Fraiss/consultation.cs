using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Fraiss
{
    public partial class consultation : Form
    {
        public consultation()
        {
            InitializeComponent();
        }



        private void Consultation_Load(object sender, EventArgs e)
        {
            //// Calendrier.Format = DateTimePickerFormat.Custom;
            ////Calendrier.CustomFormat = "MM/yyyy";

        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            // Connexion à la base de données
            string connectionString = "SqlConnection";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Requête SQL pour obtenir les frais hors forfait
                string query = "SELECT Id, Description, Montant, Date FROM FraisHorsForfait";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Création d'un DataTable pour afficher les données
                        DataTable dataTable = new DataTable();

                        // Ajouter des colonnes à la DataTable
                        dataTable.Columns.Add("Id");
                        dataTable.Columns.Add("Description");
                        dataTable.Columns.Add("Montant");
                        dataTable.Columns.Add("Date");

                        // Lecture des résultats et ajout dans le DataTable
                        while (reader.Read())
                        {
                            DataRow row = dataTable.NewRow();
                            row["Id"] = reader.GetInt32(0);  // Id du frais
                            row["Description"] = reader.GetString(1);  // Description du frais
                            row["Montant"] = reader.GetDecimal(2);  // Montant du frais
                            row["Date"] = reader.GetDateTime(3);  // Date du frais
                            dataTable.Rows.Add(row);
                        }
                    }
                }
            }
        }

      
    }
}
