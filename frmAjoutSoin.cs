using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1MJ
{
    public partial class frmAjoutSoin : Form
    {
        public BDB56Projet1MJDataSet.soinRow unSoin;

        public frmAjoutSoin()
        {
            InitializeComponent();
        }

        private void frmAjoutSoin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1MJDataSet.noEtDescriptionSoin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.noEtDescriptionSoinTableAdapter.Fill(this.bDB56Projet1MJDataSet.noEtDescriptionSoin);

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text.Trim() == "")
                errMessage.SetError(tbDescription, "La description ne peut pas être vide");
            else if (tbPrix.Text.Trim() == "")
                errMessage.SetError(tbPrix, "Le prix ne peut pas être vide");
            else if (cboType.Text.Trim() == "")
                errMessage.SetError(cboType, "Le type ne peut pas être vide");
            else
            {
                unSoin.description = tbDescription.Text.Trim();
                unSoin.dureeMinuteSoin = Convert.ToInt32(tbDuree.Text.Trim());
                unSoin.prix = Convert.ToDecimal(tbPrix.Text.Trim());
                unSoin.noTypeSoin = Convert.ToInt32(cboType.SelectedValue.ToString());
                this.Close();
            }
        }
    }
}
