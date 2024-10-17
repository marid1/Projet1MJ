namespace Projet1MJ
{
    partial class frmGestionTypeChambre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bDB56Projet1MJDataSet = new Projet1MJ.BDB56Projet1MJDataSet();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreTableAdapter = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.typeChambreTableAdapter();
            this.tableAdapterManager = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.TableAdapterManager();
            this.typeChambreDataGridView = new System.Windows.Forms.DataGridView();
            this.chambreTableAdapter = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.chambreTableAdapter();
            this.chambreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(144, 408);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(130, 33);
            this.btnFermer.TabIndex = 52;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(379, 17);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(199, 33);
            this.btnAnnuler.TabIndex = 51;
            this.btnAnnuler.Text = "Annuler les modifications";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(584, 17);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(199, 33);
            this.btnEnregistrer.TabIndex = 50;
            this.btnEnregistrer.Text = "Enregistrer les modifications";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(537, 408);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(130, 33);
            this.btnActualiser.TabIndex = 49;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(406, 408);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 33);
            this.btnSupprimer.TabIndex = 48;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(275, 408);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(130, 33);
            this.btnAjouter.TabIndex = 47;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(557, 369);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(152, 33);
            this.btnDernier.TabIndex = 46;
            this.btnDernier.Text = "Dernière chambre";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(405, 369);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(152, 33);
            this.btnSuivant.TabIndex = 45;
            this.btnSuivant.Text = "Chambre suivante";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(253, 369);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(152, 33);
            this.btnPrecedent.TabIndex = 44;
            this.btnPrecedent.Text = "Chambre précédente";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(101, 369);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(152, 33);
            this.btnPremier.TabIndex = 43;
            this.btnPremier.Text = "Première chambre";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 36);
            this.label1.TabIndex = 42;
            this.label1.Text = "Gestion des chambres :";
            // 
            // bDB56Projet1MJDataSet
            // 
            this.bDB56Projet1MJDataSet.DataSetName = "BDB56Projet1MJDataSet";
            this.bDB56Projet1MJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeChambreBindingSource
            // 
            this.typeChambreBindingSource.DataMember = "typeChambre";
            this.typeChambreBindingSource.DataSource = this.bDB56Projet1MJDataSet;
            // 
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = this.chambreTableAdapter;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.noEtDescriptionChambreTableAdapter = null;
            this.tableAdapterManager.noEtDescriptionSoinTableAdapter = null;
            this.tableAdapterManager.noEtDescriptionTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = this.typeChambreTableAdapter;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1MJ.BDB56Projet1MJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // typeChambreDataGridView
            // 
            this.typeChambreDataGridView.AutoGenerateColumns = false;
            this.typeChambreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.typeChambreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeChambreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.typeChambreDataGridView.DataSource = this.typeChambreBindingSource;
            this.typeChambreDataGridView.Location = new System.Drawing.Point(24, 72);
            this.typeChambreDataGridView.Name = "typeChambreDataGridView";
            this.typeChambreDataGridView.RowHeadersWidth = 51;
            this.typeChambreDataGridView.RowTemplate.Height = 24;
            this.typeChambreDataGridView.Size = new System.Drawing.Size(759, 280);
            this.typeChambreDataGridView.TabIndex = 53;
            this.typeChambreDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.typeChambreDataGridView_DataError);
            this.typeChambreDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.typeChambreDataGridView_RowValidating);
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // chambreDataGridView
            // 
            this.chambreDataGridView.AutoGenerateColumns = false;
            this.chambreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chambreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chambreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.chambreDataGridView.DataSource = this.chambreBindingSource;
            this.chambreDataGridView.Location = new System.Drawing.Point(24, 462);
            this.chambreDataGridView.Name = "chambreDataGridView";
            this.chambreDataGridView.ReadOnly = true;
            this.chambreDataGridView.RowHeadersWidth = 51;
            this.chambreDataGridView.RowTemplate.Height = 24;
            this.chambreDataGridView.Size = new System.Drawing.Size(759, 250);
            this.chambreDataGridView.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "noTypeChambre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Type de chambre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descriptionTypeChambre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prixHauteSaison";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix en haute saison";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "prixBasseSaison";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prix en basse saison";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prixMoyenneSaison";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prix en moyenne saison";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "noChambre";
            this.dataGridViewTextBoxColumn6.HeaderText = "No de chambre";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "emplacement";
            this.dataGridViewTextBoxColumn8.HeaderText = "Emplacement";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "decorations";
            this.dataGridViewTextBoxColumn9.HeaderText = "Décorations";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "FK__chambre__noTypeC__3D2915A8";
            this.chambreBindingSource.DataSource = this.typeChambreBindingSource;
            // 
            // frmGestionTypeChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 733);
            this.Controls.Add(this.chambreDataGridView);
            this.Controls.Add(this.typeChambreDataGridView);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionTypeChambre";
            this.Text = "frmGestionTypeChambre";
            this.Load += new System.EventHandler(this.frmGestionTypeChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Label label1;
        private BDB56Projet1MJDataSet bDB56Projet1MJDataSet;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private BDB56Projet1MJDataSetTableAdapters.typeChambreTableAdapter typeChambreTableAdapter;
        private BDB56Projet1MJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BDB56Projet1MJDataSetTableAdapters.chambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.DataGridView typeChambreDataGridView;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private System.Windows.Forms.DataGridView chambreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}