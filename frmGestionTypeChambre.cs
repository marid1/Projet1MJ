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
    public partial class frmGestionTypeChambre : Form
    {
        private bool isDeleting = false;

        public frmGestionTypeChambre()
        {
            InitializeComponent();
        }

        private void typeChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1MJDataSet);

        }

        private void frmGestionTypeChambre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1MJDataSet.chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.bDB56Projet1MJDataSet.chambre);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1MJDataSet.typeChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeChambreTableAdapter.Fill(this.bDB56Projet1MJDataSet.typeChambre);

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeChambreBindingSource.EndEdit();
            this.typeChambreTableAdapter.Update(this.bDB56Projet1MJDataSet.typeChambre);
            MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", " Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bDB56Projet1MJDataSet.typeChambre.RejectChanges();
            typeChambreBindingSource.ResetBindings(false);
            MessageBox.Show("Les modifications depuis le dernier enregistrement ont été annulées.", "Annulation des modifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            typeChambreBindingSource.MoveFirst();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            typeChambreBindingSource.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            typeChambreBindingSource.MoveNext();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            typeChambreBindingSource.MoveLast();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            typeChambreBindingSource.ResetCurrentItem();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            BDB56Projet1MJDataSet.typeChambreRow unTypeChambre = bDB56Projet1MJDataSet.typeChambre.NewtypeChambreRow();

            decimal noTypeChambreMax = 0;
            foreach (BDB56Projet1MJDataSet.typeChambreRow uneLigne in bDB56Projet1MJDataSet.typeChambre.Rows)
                if (uneLigne.noTypeChambre > noTypeChambreMax) noTypeChambreMax = uneLigne.noTypeChambre;

            unTypeChambre.noTypeChambre = (int)(noTypeChambreMax + 1);

            unTypeChambre.descriptionTypeChambre = string.Empty;
            unTypeChambre.prixBasseSaison = -1;
            unTypeChambre.prixHauteSaison = -1;
            unTypeChambre.prixMoyenneSaison = -1;

            frmAjoutTypeChambre frmAjout = new frmAjoutTypeChambre();
            frmAjout.unTypeChambre = unTypeChambre;
            frmAjout.ShowDialog();

            if (unTypeChambre.prixBasseSaison != -1 || unTypeChambre.prixHauteSaison != -1 || unTypeChambre.prixMoyenneSaison != -1 || !string.IsNullOrEmpty(unTypeChambre.descriptionTypeChambre))
            {
                bDB56Projet1MJDataSet.typeChambre.AddtypeChambreRow(unTypeChambre);
                typeChambreBindingSource.MoveLast();
                MessageBox.Show("Le type de chambre " + unTypeChambre.noTypeChambre.ToString() + " a été ajouté.", "Ajout d'une chambre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void typeChambreDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            typeChambreDataGridView.Rows[e.RowIndex].ErrorText =
                "Le type de données de " + typeChambreDataGridView.Columns[e.ColumnIndex].HeaderText + " n'est pas valide.";
            e.Cancel = true;
        }

        private void typeChambreDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (isDeleting)
                return;

            string messageErreur = string.Empty;
            string strDescription = typeChambreDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string strPHaute = typeChambreDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            string strPBasse = typeChambreDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            string strPMoyenne = typeChambreDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (string.IsNullOrEmpty(strDescription) || string.IsNullOrEmpty(strPHaute) || string.IsNullOrEmpty(strPBasse) || string.IsNullOrEmpty(strPMoyenne))
                messageErreur = "Aucun champ ne doit être vide";

            typeChambreDataGridView.Rows[e.RowIndex].ErrorText = messageErreur;
            if (messageErreur != String.Empty)
                e.Cancel = true;
        }
    }
}
