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
    public partial class Form1 : Form
    {
        TextBox txtLogin = new TextBox();
        TextBox txtMotDePasse = new TextBox();

        private string provider = "localhost";
        private string dataBase = "frais";
        private string uid = "root";
        private string mdp = "";
        private ConnexionSql maConnexionSql;
        private MySqlCommand maRequete;



        public Form1()
        {
            InitializeComponent();
        }
       
        public void comptable()
        {
            
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string motDePasse = textBox2.Text;
            maConnexionSql = ConnexionSql.getInstance ( provider,dataBase,uid,mdp );
            maConnexionSql.OpenConnexion();
            maRequete = maConnexionSql.reqExec("SELECT utilisateur.prenom, fonctione.libele  FROM utilisateur   INNER JOIN fonctione ON utilisateur.idPoste = fonctione.id WHERE utilisateur.login =\""+login+"\" AND utilisateur.motdepasse =\""+ motDePasse+"\"");
           

            MySqlDataReader nomReader = maRequete.ExecuteReader();
            nomReader.Read();
            if (nomReader.HasRows)
            {

                // Récupération de la valeur d’un champ selon son type et son ordre dans la requête
                String champprenom = nomReader.GetString(0);
                String champlibele = nomReader.GetString(1);
                nomReader.Close();

                if (champlibele != "comptable" && champlibele != "visiteur")
                {
                    MessageBox.Show("Bonjour " + champprenom + ", vous êtes " + champlibele + "connexion impossible");
                }
                else
                {

                    this.Hide();
                    // Si l'utilisateur est un comptable ou un visiteur, on lui permet de se connecter
                    if( champlibele == "comptable")
                    {

                        Form comptable = new comptable(champprenom, champlibele, maConnexionSql);
                        comptable.ShowDialog();
                    }
                    

                    else 
                    {
                        Form Visiteur = new Visiteur(champprenom, champlibele);
                        Visiteur.ShowDialog();
                    }

                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Aucun utilisateur trouvé avec ces identifiants.");
            }
            

            
            maConnexionSql.CloseConnexion();



        }
    }
}
