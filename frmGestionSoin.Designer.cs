namespace Projet1MJ
{
    partial class frmGestionSoin
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
            this.soinDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.noEtDescriptionSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet1MJDataSet = new Projet1MJ.BDB56Projet1MJDataSet();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.soinTableAdapter();
            this.tableAdapterManager = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.TableAdapterManager();
            this.noEtDescriptionSoinTableAdapter = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.noEtDescriptionSoinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.soinDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(144, 408);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(130, 33);
            this.btnFermer.TabIndex = 28;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(379, 17);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(199, 33);
            this.btnAnnuler.TabIndex = 27;
            this.btnAnnuler.Text = "Annuler les modifications";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(584, 17);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(199, 33);
            this.btnEnregistrer.TabIndex = 26;
            this.btnEnregistrer.Text = "Enregistrer les modifications";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(537, 408);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(130, 33);
            this.btnActualiser.TabIndex = 25;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(406, 408);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 33);
            this.btnSupprimer.TabIndex = 24;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(275, 408);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(130, 33);
            this.btnAjouter.TabIndex = 23;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(557, 369);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(152, 33);
            this.btnDernier.TabIndex = 22;
            this.btnDernier.Text = "Dernier soin";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(405, 369);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(152, 33);
            this.btnSuivant.TabIndex = 21;
            this.btnSuivant.Text = "Soin suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(253, 369);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(152, 33);
            this.btnPrecedent.TabIndex = 20;
            this.btnPrecedent.Text = "Soin précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(101, 369);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(152, 33);
            this.btnPremier.TabIndex = 19;
            this.btnPremier.Text = "Premier soin";
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
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gestion des soins :";
            // 
            // soinDataGridView
            // 
            this.soinDataGridView.AutoGenerateColumns = false;
            this.soinDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.soinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.soinDataGridView.DataSource = this.soinBindingSource;
            this.soinDataGridView.Location = new System.Drawing.Point(16, 60);
            this.soinDataGridView.Name = "soinDataGridView";
            this.soinDataGridView.RowHeadersWidth = 51;
            this.soinDataGridView.RowTemplate.Height = 24;
            this.soinDataGridView.Size = new System.Drawing.Size(767, 294);
            this.soinDataGridView.TabIndex = 29;
            this.soinDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.soinDataGridView_DataError);
            this.soinDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.soinDataGridView_RowValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "noSoin";
            this.dataGridViewTextBoxColumn1.HeaderText = "No de soin";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dureeMinuteSoin";
            this.dataGridViewTextBoxColumn3.HeaderText = "Durée en minutes";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "noTypeSoin";
            this.dataGridViewTextBoxColumn4.DataSource = this.noEtDescriptionSoinBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Type de soin";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "noTypeSoin";
            // 
            // noEtDescriptionSoinBindingSource
            // 
            this.noEtDescriptionSoinBindingSource.DataMember = "noEtDescriptionSoin";
            this.noEtDescriptionSoinBindingSource.DataSource = this.bDB56Projet1MJDataSet;
            // 
            // bDB56Projet1MJDataSet
            // 
            this.bDB56Projet1MJDataSet.DataSetName = "BDB56Projet1MJDataSet";
            this.bDB56Projet1MJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prix";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // soinBindingSource
            // 
            this.soinBindingSource.DataMember = "soin";
            this.soinBindingSource.DataSource = this.bDB56Projet1MJDataSet;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.noEtDescriptionSoinTableAdapter = null;
            this.tableAdapterManager.noEtDescriptionTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = this.soinTableAdapter;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1MJ.BDB56Projet1MJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // noEtDescriptionSoinTableAdapter
            // 
            this.noEtDescriptionSoinTableAdapter.ClearBeforeFill = true;
            // 
            // frmGestionSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 461);
            this.Controls.Add(this.soinDataGridView);
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
            this.Name = "frmGestionSoin";
            this.Text = "Gestion des soins";
            this.Load += new System.EventHandler(this.frmGestionSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soinDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BDB56Projet1MJDataSetTableAdapters.soinTableAdapter soinTableAdapter;
        private BDB56Projet1MJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView soinDataGridView;
        private System.Windows.Forms.BindingSource noEtDescriptionSoinBindingSource;
        private BDB56Projet1MJDataSetTableAdapters.noEtDescriptionSoinTableAdapter noEtDescriptionSoinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}