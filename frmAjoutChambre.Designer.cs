namespace Projet1MJ
{
    partial class frmAjoutChambre
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.noEtDescriptionChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet1MJDataSet = new Projet1MJ.BDB56Projet1MJDataSet();
            this.tbDecorations = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tbEmplacement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noEtDescriptionChambreTableAdapter = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.noEtDescriptionChambreTableAdapter();
            this.tableAdapterManager = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.TableAdapterManager();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.DataSource = this.noEtDescriptionChambreBindingSource;
            this.cboType.DisplayMember = "description";
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(200, 70);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(204, 24);
            this.cboType.TabIndex = 28;
            this.cboType.ValueMember = "noTypeChambre";
            // 
            // noEtDescriptionChambreBindingSource
            // 
            this.noEtDescriptionChambreBindingSource.DataMember = "noEtDescriptionChambre";
            this.noEtDescriptionChambreBindingSource.DataSource = this.bDB56Projet1MJDataSet;
            // 
            // bDB56Projet1MJDataSet
            // 
            this.bDB56Projet1MJDataSet.DataSetName = "BDB56Projet1MJDataSet";
            this.bDB56Projet1MJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDecorations
            // 
            this.tbDecorations.Location = new System.Drawing.Point(200, 129);
            this.tbDecorations.Name = "tbDecorations";
            this.tbDecorations.Size = new System.Drawing.Size(204, 22);
            this.tbDecorations.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Décorations :";
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(438, 63);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(93, 33);
            this.btnFermer.TabIndex = 25;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Type de chambre :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(438, 13);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(93, 33);
            this.btnAjouter.TabIndex = 21;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // tbEmplacement
            // 
            this.tbEmplacement.Location = new System.Drawing.Point(200, 13);
            this.tbEmplacement.Name = "tbEmplacement";
            this.tbEmplacement.Size = new System.Drawing.Size(204, 22);
            this.tbEmplacement.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Emplacement :";
            // 
            // noEtDescriptionChambreTableAdapter
            // 
            this.noEtDescriptionChambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.noEtDescriptionChambreTableAdapter = this.noEtDescriptionChambreTableAdapter;
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
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjoutChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 184);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.tbDecorations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbEmplacement);
            this.Controls.Add(this.label1);
            this.Name = "frmAjoutChambre";
            this.Text = "Ajout d\'une chambre";
            this.Load += new System.EventHandler(this.frmAjoutChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox tbDecorations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox tbEmplacement;
        private System.Windows.Forms.Label label1;
        private BDB56Projet1MJDataSet bDB56Projet1MJDataSet;
        private System.Windows.Forms.BindingSource noEtDescriptionChambreBindingSource;
        private BDB56Projet1MJDataSetTableAdapters.noEtDescriptionChambreTableAdapter noEtDescriptionChambreTableAdapter;
        private BDB56Projet1MJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}