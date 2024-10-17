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
    public partial class frmGestionChambre : Form
    {
        private bool isDeleting = false;

        public frmGestionChambre()
        {
            InitializeComponent();
        }

        private void frmGestionChambre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1MJDataSet.noEtDescriptionChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.noEtDescriptionChambreTableAdapter.Fill(this.bDB56Projet1MJDataSet.noEtDescriptionChambre);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1MJDataSet.chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.bDB56Projet1MJDataSet.chambre);

        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            chambreBindingSource.MoveFirst();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            chambreBindingSource.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            chambreBindingSource.MoveNext();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            chambreBindingSource.MoveLast();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            chambreBindingSource.ResetCurrentItem();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            BDB56Projet1MJDataSet.chambreRow uneChambre = bDB56Projet1MJDataSet.chambre.NewchambreRow();

            decimal noChambreMax = 0;
            foreach (BDB56Projet1MJDataSet.chambreRow uneLigne in bDB56Projet1MJDataSet.chambre.Rows)
                if (uneLigne.noChambre > noChambreMax) noChambreMax = uneLigne.noChambre;

            uneChambre.noChambre = (int)(noChambreMax + 1);

            uneChambre.emplacement = string.Empty;
            uneChambre.decorations = string.Empty;
            uneChambre.noTypeChambre = 0;

            frmAjoutChambre frmAjout = new frmAjoutChambre();
            frmAjout.uneChambre = uneChambre;
            frmAjout.ShowDialog();

            if (uneChambre.noTypeChambre != 0 || !string.IsNullOrEmpty(uneChambre.decorations) || !string.IsNullOrEmpty(uneChambre.emplacement))
            {
                bDB56Projet1MJDataSet.chambre.AddchambreRow(uneChambre);
                chambreBindingSource.MoveLast();
                MessageBox.Show("La chambre " + uneChambre.noChambre.ToString() + " a été ajouté.", "Ajout d'une chambre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void chambreDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            chambreDataGridView.Rows[e.RowIndex].ErrorText =
                "Le type de données de " + chambreDataGridView.Columns[e.ColumnIndex].HeaderText + " n'est pas valide.";
            e.Cancel = true;
        }

        private void chambreDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (isDeleting)
                return;

            string messageErreur = string.Empty;
            string strEmplacement = chambreDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            string strType = chambreDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string strDeco = chambreDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (string.IsNullOrEmpty(strEmplacement) || string.IsNullOrEmpty(strType) || string.IsNullOrEmpty(strDeco))
                messageErreur = "Aucun champ ne doit être vide";

            chambreDataGridView.Rows[e.RowIndex].ErrorText = messageErreur;
            if (messageErreur != String.Empty)
                e.Cancel = true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bDB56Projet1MJDataSet.chambre.RejectChanges();
            chambreBindingSource.ResetBindings(false);
            MessageBox.Show("Les modifications depuis le dernier enregistrement ont été annulées.", "Annulation des modifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambreBindingSource.EndEdit();
            this.chambreTableAdapter.Update(this.bDB56Projet1MJDataSet.chambre);
            MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", " Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
