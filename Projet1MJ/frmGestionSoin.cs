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
    public partial class frmGestionSoin : Form
    {
        private bool isDeleting = false;

        public frmGestionSoin()
        {
            InitializeComponent();
        }

        private void frmGestionSoin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1MJDataSet.noEtDescriptionSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.noEtDescriptionSoinTableAdapter.Fill(this.bDB56Projet1MJDataSet.noEtDescriptionSoin);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1MJDataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bDB56Projet1MJDataSet.soin);

        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            soinBindingSource.MoveFirst();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            soinBindingSource.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            soinBindingSource.MoveNext();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            soinBindingSource.MoveLast();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            BDB56Projet1MJDataSet.soinRow unSoin = bDB56Projet1MJDataSet.soin.NewsoinRow();

            decimal noSoinMax = 0;
            foreach (BDB56Projet1MJDataSet.soinRow uneLigne in bDB56Projet1MJDataSet.soin.Rows)
                if (uneLigne.noSoin > noSoinMax) noSoinMax = uneLigne.noSoin;

            unSoin.noSoin = (int)(noSoinMax + 1);

            unSoin.description = string.Empty;
            unSoin.prix = -1;
            unSoin.noTypeSoin = 0;
            unSoin.dureeMinuteSoin = 0;

            frmAjoutSoin frmAjout = new frmAjoutSoin();
            frmAjout.unSoin = unSoin;
            frmAjout.ShowDialog();

            if (unSoin.noTypeSoin != 0 || unSoin.dureeMinuteSoin != 0 || unSoin.prix != -1|| !string.IsNullOrEmpty(unSoin.description))
            {
                bDB56Projet1MJDataSet.soin.AddsoinRow(unSoin);
                soinBindingSource.MoveLast();
                MessageBox.Show("Le soin " + unSoin.noSoin.ToString() + " a été ajouté.", "Ajout d'un soin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            /*var currentUser = (DataRowView)utilisateurBindingSource.Current;
            if ((int)currentUser["No d'utilisateur"] == 1)
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
            }*/
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            soinBindingSource.ResetCurrentItem();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bDB56Projet1MJDataSet.soin.RejectChanges();
            soinBindingSource.ResetBindings(false);
            MessageBox.Show("Les modifications depuis le dernier enregistrement ont été annulées.", "Annulation des modifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            this.soinTableAdapter.Update(this.bDB56Projet1MJDataSet.soin);
            MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", " Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void soinDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            soinDataGridView.Rows[e.RowIndex].ErrorText =
                "Le type de données de " + soinDataGridView.Columns[e.ColumnIndex].HeaderText + " n'est pas valide.";
            e.Cancel = true;
        }

        private void soinDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (isDeleting)
                return;

            string messageErreur = string.Empty;
            string strDescription = soinDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string strType = soinDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            string strPrix = soinDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (string.IsNullOrEmpty(strDescription) || string.IsNullOrEmpty(strType) || string.IsNullOrEmpty(strPrix))
                messageErreur = "Aucun champ ne doit être vide";

            soinDataGridView.Rows[e.RowIndex].ErrorText = messageErreur;
            if (messageErreur != String.Empty)
                e.Cancel = true;
        }
    }
}
