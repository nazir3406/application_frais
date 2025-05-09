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
    public partial class Visiteur : Form
    {

        private string champprenom;
        private string champlibele;

        public Visiteur(string champprenom, string champlibele)
        {
            InitializeComponent();
            this.champprenom = champprenom;
            this.champlibele = champlibele;
        }

      

        private void Visiteur_Load(object sender, EventArgs e)
        {
            presentation.Text = $"Bonjour  {champprenom}  le  {champlibele}";
        }

        
    }
}
