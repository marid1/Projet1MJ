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
    public partial class frmAjoutChambre : Form
    {
        public BDB56Projet1MJDataSet.chambreRow uneChambre;

        public frmAjoutChambre()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbEmplacement.Text.Trim() == "")
                errMessage.SetError(tbEmplacement, "L'emplacement ne peut pas être vide");
            else if (tbDecorations.Text.Trim() == "")
                errMessage.SetError(tbDecorations, "Les décorations ne peuvent pas être vides");
            else if (cboType.Text.Trim() == "")
                errMessage.SetError(cboType, "Le type ne peut pas être vide");
            else
            {
                uneChambre.emplacement = tbEmplacement.Text.Trim();
                uneChambre.decorations = tbDecorations.Text.Trim();
                uneChambre.noTypeChambre = Convert.ToInt32(cboType.SelectedValue.ToString());
                this.Close();
            }
        }

        private void frmAjoutChambre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1MJDataSet.noEtDescriptionChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.noEtDescriptionChambreTableAdapter.Fill(this.bDB56Projet1MJDataSet.noEtDescriptionChambre);

        }
    }
}
