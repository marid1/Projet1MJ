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
    public partial class frmGestionUtilisateur : Form
    {
        private bool isDeleting = false;

        public frmGestionUtilisateur()
        {
            InitializeComponent();
        }

        private void frmGestionUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1MJDataSet.noEtDescription'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.noEtDescriptionTableAdapter.Fill(this.bDB56Projet1MJDataSet.noEtDescription);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1MJDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.bDB56Projet1MJDataSet.utilisateur);

        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            utilisateurBindingSource.MoveFirst();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            utilisateurBindingSource.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            utilisateurBindingSource.MoveNext();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            utilisateurBindingSource.MoveLast();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            utilisateurBindingSource.ResetCurrentItem();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            BDB56Projet1MJDataSet.utilisateurRow unUtilisateur = bDB56Projet1MJDataSet.utilisateur.NewutilisateurRow();

            decimal noUtilisateurMax = 0;
            foreach (BDB56Projet1MJDataSet.utilisateurRow uneLigne in bDB56Projet1MJDataSet.utilisateur.Rows)
                if (uneLigne.noUtilisateur > noUtilisateurMax) noUtilisateurMax = uneLigne.noUtilisateur;
           
            unUtilisateur.noUtilisateur = (int)(noUtilisateurMax + 1);

            unUtilisateur.nomUtilisateur = string.Empty;
            unUtilisateur.mdpUtilisateur = string.Empty;
            unUtilisateur.noTypeUtilisateur = 0;

            frmAjoutUtilisateur frmAjout = new frmAjoutUtilisateur();
            frmAjout.unUtilisateur = unUtilisateur;
            frmAjout.ShowDialog();

            if (unUtilisateur.noTypeUtilisateur != 0 || !string.IsNullOrEmpty(unUtilisateur.nomUtilisateur) || !string.IsNullOrEmpty(unUtilisateur.mdpUtilisateur))
            {
                bDB56Projet1MJDataSet.utilisateur.AddutilisateurRow(unUtilisateur);
                utilisateurBindingSource.MoveLast();
                MessageBox.Show("L'utilisateur " + unUtilisateur.noUtilisateur.ToString() + " a été ajouté.", "Ajout d'un utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            var currentUser = (DataRowView)utilisateurBindingSource.Current;
            if ((int)currentUser["noUtilisateur"] == 1)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer cet utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur?", "Supprimer un utilisateur", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                isDeleting = true; // Indiquer que vous êtes en mode suppression
                utilisateurBindingSource.RemoveCurrent();
                isDeleting = false; // Réinitialiser après la suppression
            }
        }

        private void utilisateurDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            utilisateurDataGridView.Rows[e.RowIndex].ErrorText =
                "Le type de données de " + utilisateurDataGridView.Columns[e.ColumnIndex].HeaderText + " n'est pas valide.";
            e.Cancel = true;
        }

        private void utilisateurDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (isDeleting)
                return; 
            
            string messageErreur = string.Empty;
            string strMdpUtilisateur = utilisateurDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            string strTypeUtilisateur = utilisateurDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (string.IsNullOrEmpty(strMdpUtilisateur) || string.IsNullOrEmpty(strTypeUtilisateur))
                messageErreur = "Aucun champ ne doit être vide";
            
            utilisateurDataGridView.Rows[e.RowIndex].ErrorText = messageErreur;
            if (messageErreur != String.Empty)
                e.Cancel = true;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            this.utilisateurTableAdapter.Update(this.bDB56Projet1MJDataSet.utilisateur);
            MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", " Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bDB56Projet1MJDataSet.utilisateur.RejectChanges();
            utilisateurBindingSource.ResetBindings(false);
            MessageBox.Show("Les modifications depuis le dernier enregistrement ont été annulées.", "Annulation des modifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*
        private void btnEnregistrerEnXML_Click(object sender, EventArgs e)
        {
            bDB56DiazDataSet.contrat.WriteXml("Contrats.xml");
            bDB56DiazDataSet.contrat.WriteXmlSchema("Contrats.xsd");
        }
        */
    }
}
