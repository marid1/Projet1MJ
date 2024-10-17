namespace Projet1MJ
{
    partial class frmGestionUtilisateur
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
            this.label1 = new System.Windows.Forms.Label();
            this.utilisateurDataGridView = new System.Windows.Forms.DataGridView();
            this.noEtDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet1MJDataSet = new Projet1MJ.BDB56Projet1MJDataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.utilisateurTableAdapter = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.utilisateurTableAdapter();
            this.tableAdapterManager = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.TableAdapterManager();
            this.noEtDescriptionTableAdapter = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.noEtDescriptionTableAdapter();
            this.dgNoUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMdpUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTypeUtilisateur = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestion des utilisateurs :";
            // 
            // utilisateurDataGridView
            // 
            this.utilisateurDataGridView.AutoGenerateColumns = false;
            this.utilisateurDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.utilisateurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utilisateurDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgNoUtilisateur,
            this.dgNomUtilisateur,
            this.dgMdpUtilisateur,
            this.dgTypeUtilisateur});
            this.utilisateurDataGridView.DataSource = this.utilisateurBindingSource;
            this.utilisateurDataGridView.Location = new System.Drawing.Point(22, 72);
            this.utilisateurDataGridView.Name = "utilisateurDataGridView";
            this.utilisateurDataGridView.RowHeadersWidth = 51;
            this.utilisateurDataGridView.RowTemplate.Height = 24;
            this.utilisateurDataGridView.Size = new System.Drawing.Size(756, 289);
            this.utilisateurDataGridView.TabIndex = 6;
            this.utilisateurDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.utilisateurDataGridView_DataError);
            this.utilisateurDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.utilisateurDataGridView_RowValidating);
            // 
            // noEtDescriptionBindingSource
            // 
            this.noEtDescriptionBindingSource.DataMember = "noEtDescription";
            this.noEtDescriptionBindingSource.DataSource = this.bDB56Projet1MJDataSet;
            // 
            // bDB56Projet1MJDataSet
            // 
            this.bDB56Projet1MJDataSet.DataSetName = "BDB56Projet1MJDataSet";
            this.bDB56Projet1MJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.bDB56Projet1MJDataSet;
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(96, 369);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(152, 33);
            this.btnPremier.TabIndex = 7;
            this.btnPremier.Text = "Premier utilisateur";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(248, 369);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(152, 33);
            this.btnPrecedent.TabIndex = 8;
            this.btnPrecedent.Text = "Utilisateur précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(400, 369);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(152, 33);
            this.btnSuivant.TabIndex = 9;
            this.btnSuivant.Text = "Utilisateur suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(552, 369);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(152, 33);
            this.btnDernier.TabIndex = 10;
            this.btnDernier.Text = "Dernier utilisateur";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(270, 408);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(130, 33);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(401, 408);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 33);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(532, 408);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(130, 33);
            this.btnActualiser.TabIndex = 13;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(579, 17);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(199, 33);
            this.btnEnregistrer.TabIndex = 14;
            this.btnEnregistrer.Text = "Enregistrer les modifications";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(374, 17);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(199, 33);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler les modifications";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(139, 408);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(130, 33);
            this.btnFermer.TabIndex = 16;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.noEtDescriptionTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1MJ.BDB56Projet1MJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = this.utilisateurTableAdapter;
            // 
            // noEtDescriptionTableAdapter
            // 
            this.noEtDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // dgNoUtilisateur
            // 
            this.dgNoUtilisateur.DataPropertyName = "noUtilisateur";
            this.dgNoUtilisateur.HeaderText = "No d\'utilisateur";
            this.dgNoUtilisateur.MinimumWidth = 6;
            this.dgNoUtilisateur.Name = "dgNoUtilisateur";
            this.dgNoUtilisateur.ReadOnly = true;
            // 
            // dgNomUtilisateur
            // 
            this.dgNomUtilisateur.DataPropertyName = "nomUtilisateur";
            this.dgNomUtilisateur.HeaderText = "Nom d\'utilisateur";
            this.dgNomUtilisateur.MinimumWidth = 6;
            this.dgNomUtilisateur.Name = "dgNomUtilisateur";
            this.dgNomUtilisateur.ReadOnly = true;
            // 
            // dgMdpUtilisateur
            // 
            this.dgMdpUtilisateur.DataPropertyName = "mdpUtilisateur";
            this.dgMdpUtilisateur.HeaderText = "Mot de passe utilisateur";
            this.dgMdpUtilisateur.MinimumWidth = 6;
            this.dgMdpUtilisateur.Name = "dgMdpUtilisateur";
            // 
            // dgTypeUtilisateur
            // 
            this.dgTypeUtilisateur.DataPropertyName = "noTypeUtilisateur";
            this.dgTypeUtilisateur.DataSource = this.noEtDescriptionBindingSource;
            this.dgTypeUtilisateur.DisplayMember = "description";
            this.dgTypeUtilisateur.HeaderText = "Type d\'utilisateur";
            this.dgTypeUtilisateur.MinimumWidth = 6;
            this.dgTypeUtilisateur.Name = "dgTypeUtilisateur";
            this.dgTypeUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTypeUtilisateur.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgTypeUtilisateur.ValueMember = "noTypeUtilisateur";
            // 
            // frmGestionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.utilisateurDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionUtilisateur";
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.frmGestionUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BDB56Projet1MJDataSet bDB56Projet1MJDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private BDB56Projet1MJDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private BDB56Projet1MJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView utilisateurDataGridView;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.BindingSource noEtDescriptionBindingSource;
        private BDB56Projet1MJDataSetTableAdapters.noEtDescriptionTableAdapter noEtDescriptionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNoUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMdpUtilisateur;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgTypeUtilisateur;
    }
}