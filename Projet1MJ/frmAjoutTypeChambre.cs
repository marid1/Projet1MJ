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
    public partial class frmAjoutTypeChambre : Form
    {
        public BDB56Projet1MJDataSet.typeChambreRow unTypeChambre;

        public frmAjoutTypeChambre()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text.Trim() == "")
                errMessage.SetError(tbDescription, "La description ne peut pas être vide");
            else if (tbHaute.Text.Trim() == "")
                errMessage.SetError(tbHaute, "Le prix en haute saison ne peut pas être vide");
            else if (tbBasse.Text.Trim() == "")
                errMessage.SetError(tbBasse, "Le prix en basse saison ne peut pas être vide");
            else if (tbMoyenne.Text.Trim() == "")
                errMessage.SetError(tbMoyenne, "Le prix en moyenne saison ne peut pas être vide");
            else
            {
                unTypeChambre.descriptionTypeChambre = tbDescription.Text.Trim();
                unTypeChambre.prixHauteSaison = Convert.ToDecimal(tbHaute.Text.Trim());
                unTypeChambre.prixBasseSaison = Convert.ToDecimal(tbBasse.Text.Trim());
                unTypeChambre.prixMoyenneSaison = Convert.ToDecimal(tbMoyenne.Text.Trim());
                this.Close();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
