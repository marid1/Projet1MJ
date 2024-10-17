namespace Projet1MJ
{
    partial class frmGestionClientInvite
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
            this.bDB56Projet1MJDataSet = new Projet1MJ.BDB56Projet1MJDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.clientTableAdapter();
            this.tableAdapterManager = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.TableAdapterManager();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inviteTableAdapter = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.inviteTableAdapter();
            this.inviteDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bDB56Projet1MJDataSet
            // 
            this.bDB56Projet1MJDataSet.DataSetName = "BDB56Projet1MJDataSet";
            this.bDB56Projet1MJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.bDB56Projet1MJDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.inviteTableAdapter = this.inviteTableAdapter;
            this.tableAdapterManager.noEtDescriptionChambreTableAdapter = null;
            this.tableAdapterManager.noEtDescriptionSoinTableAdapter = null;
            this.tableAdapterManager.noEtDescriptionTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1MJ.BDB56Projet1MJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.clientDataGridView.DataSource = this.clientBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(17, 56);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(762, 220);
            this.clientDataGridView.TabIndex = 1;
            // 
            // inviteBindingSource
            // 
            this.inviteBindingSource.DataMember = "FK__invite__noClient__32AB8735";
            this.inviteBindingSource.DataSource = this.clientBindingSource;
            // 
            // inviteTableAdapter
            // 
            this.inviteTableAdapter.ClearBeforeFill = true;
            // 
            // inviteDataGridView
            // 
            this.inviteDataGridView.AutoGenerateColumns = false;
            this.inviteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inviteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inviteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.inviteDataGridView.DataSource = this.inviteBindingSource;
            this.inviteDataGridView.Location = new System.Drawing.Point(17, 395);
            this.inviteDataGridView.Name = "inviteDataGridView";
            this.inviteDataGridView.Size = new System.Drawing.Size(762, 220);
            this.inviteDataGridView.TabIndex = 2;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(486, 14);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(149, 27);
            this.btnAnnuler.TabIndex = 54;
            this.btnAnnuler.Text = "Annuler les modifications";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(640, 14);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(149, 27);
            this.btnEnregistrer.TabIndex = 53;
            this.btnEnregistrer.Text = "Enregistrer les modifications";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "Gestion des clients et leurs invités :";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(121, 332);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(114, 27);
            this.btnFermer.TabIndex = 62;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(565, 332);
            this.btnActualiser.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(114, 27);
            this.btnActualiser.TabIndex = 61;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(417, 332);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(114, 27);
            this.btnSupprimer.TabIndex = 60;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(269, 332);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(114, 27);
            this.btnAjouter.TabIndex = 59;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(565, 301);
            this.btnDernier.Margin = new System.Windows.Forms.Padding(2);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(114, 27);
            this.btnDernier.TabIndex = 58;
            this.btnDernier.Text = "Dernière chambre";
            this.btnDernier.UseVisualStyleBackColor = true;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(417, 300);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(114, 27);
            this.btnSuivant.TabIndex = 57;
            this.btnSuivant.Text = "Chambre suivante";
            this.btnSuivant.UseVisualStyleBackColor = true;
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(269, 300);
            this.btnPrecedent.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(114, 27);
            this.btnPrecedent.TabIndex = 56;
            this.btnPrecedent.Text = "Chambre précédente";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(121, 300);
            this.btnPremier.Margin = new System.Windows.Forms.Padding(2);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(114, 27);
            this.btnPremier.TabIndex = 55;
            this.btnPremier.Text = "Première chambre";
            this.btnPremier.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "noClient";
            this.dataGridViewTextBoxColumn1.HeaderText = "No du client";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomClient";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom du client";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prenomClient";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom du client";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "villeClient";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ville";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "paysClient";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pays";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "adresseClient";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "codePostalClient";
            this.dataGridViewTextBoxColumn7.HeaderText = "Code postal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dateInscriptionClient";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date inscription";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "noInvite";
            this.dataGridViewTextBoxColumn9.HeaderText = "No d\'invite";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "nomPrenomInvite";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nom et prenom de l\'invite";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "noClient";
            this.dataGridViewTextBoxColumn11.HeaderText = "No du client";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // frmGestionClientInvite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inviteDataGridView);
            this.Controls.Add(this.clientDataGridView);
            this.Name = "frmGestionClientInvite";
            this.Text = "Gestion des clients et de leurs invités";
            this.Load += new System.EventHandler(this.frmGestionClientInvite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1MJDataSet bDB56Projet1MJDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BDB56Projet1MJDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private BDB56Projet1MJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private BDB56Projet1MJDataSetTableAdapters.inviteTableAdapter inviteTableAdapter;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private System.Windows.Forms.DataGridView inviteDataGridView;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}