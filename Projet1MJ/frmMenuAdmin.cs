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
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion fConnexion = new frmConnexion();
            this.Hide();
            fConnexion.ShowDialog();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gérerLesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionUtilisateur fGestionUtilisateur = new frmGestionUtilisateur();   
            this.Hide();
            fGestionUtilisateur.ShowDialog();
            this.Show();
        }

        private void gérerLesSoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionSoin fGestionSoin = new frmGestionSoin();
            this.Hide();
            fGestionSoin.ShowDialog();
            this.Show();
        }

        private void gérerLesTypesDeChambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionTypeChambre fGestionTypeChambre = new frmGestionTypeChambre();
            this.Hide();
            fGestionTypeChambre.ShowDialog();
            this.Show();
        }

        private void gérerLesChambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionChambre fGestionChambre = new frmGestionChambre();
            this.Hide();
            fGestionChambre.ShowDialog();
            this.Show();
        }
    }
}
