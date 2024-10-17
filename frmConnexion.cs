using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1MJ
{
    public partial class frmConnexion : Form
    {
        String maChaineDeConnexion = Properties.Settings.Default.BDB56Projet1MJConnectionString;//"Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet1MJ;User ID=B56Projet1MJ; Password=Projet1BD";
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            String maRequeteSQL = " SELECT noTypeUtilisateur FROM utilisateur WHERE nomUtilisateur = '" + tbNomUtilisateur.Text + "' AND mdpUtilisateur = '" + tbMdpUtilisateur.Text + "'";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            dynamic noTypeUser = maCommande.ExecuteScalar();

            if (noTypeUser == null)
                lblConnexion.Text = "Connexion échouée";
            else
            {
                if (noTypeUser == 1)
                {
                    // Admin
                    frmMenuAdmin fAdmin = new frmMenuAdmin();
                    this.Hide();
                    fAdmin.ShowDialog();
                }
                else
                {
                    //Prepose
                    Form1 fPrepose = new Form1();
                    this.Hide();
                    fPrepose.ShowDialog();
                }                
            }
            maConnexion.Close();
        }
    }
}