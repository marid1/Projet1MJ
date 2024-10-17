using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1MJ
{
    public partial class frmAjoutUtilisateur : Form
    {
        public BDB56Projet1MJDataSet.utilisateurRow unUtilisateur;

        public frmAjoutUtilisateur()
        {
            InitializeComponent();
        }

        private void frmAjoutUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1MJDataSet.noEtDescription'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.noEtDescriptionTableAdapter.Fill(this.bDB56Projet1MJDataSet.noEtDescription);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "")
                errMessage.SetError(tbNom, "Le nom d'utilisateur ne peut pas être vide");
            else if (tbMdp.Text.Trim() == "")
                errMessage.SetError(tbMdp, "Le mot de passe ne peut pas être vide");
            else if (cboType.Text.Trim() == "")
                errMessage.SetError(cboType, "Le type ne peut pas être vide");
            else
            {
                unUtilisateur.nomUtilisateur = tbNom.Text.Trim();
                unUtilisateur.mdpUtilisateur = tbMdp.Text.Trim();
                unUtilisateur.noTypeUtilisateur = Convert.ToInt32(cboType.SelectedValue.ToString());
                this.Close();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
