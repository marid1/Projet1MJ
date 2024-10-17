namespace Projet1MJ
{
    partial class frmAjoutSoin
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
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.noEtDescriptionSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet1MJDataSet = new Projet1MJ.BDB56Projet1MJDataSet();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.noEtDescriptionSoinTableAdapter = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.noEtDescriptionSoinTableAdapter();
            this.tableAdapterManager = new Projet1MJ.BDB56Projet1MJDataSetTableAdapters.TableAdapterManager();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboType = new System.Windows.Forms.ComboBox();
            this.noEtDescriptionSoinBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.noEtDescriptionSoinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.noEtDescriptionSoinBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(430, 75);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(93, 33);
            this.btnFermer.TabIndex = 15;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // tbDuree
            // 
            this.tbDuree.Location = new System.Drawing.Point(190, 72);
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.ReadOnly = true;
            this.tbDuree.Size = new System.Drawing.Size(204, 22);
            this.tbDuree.TabIndex = 14;
            this.tbDuree.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Type de soin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Durée du soin :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(430, 25);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(93, 33);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
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
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(190, 25);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(204, 22);
            this.tbDescription.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description :";
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(190, 168);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(204, 22);
            this.tbPrix.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Prix :";
            // 
            // noEtDescriptionSoinTableAdapter
            // 
            this.noEtDescriptionSoinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.noEtDescriptionSoinTableAdapter = this.noEtDescriptionSoinTableAdapter;
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
            // cboType
            // 
            this.cboType.DataSource = this.noEtDescriptionSoinBindingSource3;
            this.cboType.DisplayMember = "description";
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(190, 118);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(204, 24);
            this.cboType.TabIndex = 18;
            this.cboType.ValueMember = "noTypeSoin";
            // 
            // noEtDescriptionSoinBindingSource2
            // 
            this.noEtDescriptionSoinBindingSource2.DataMember = "noEtDescriptionSoin";
            this.noEtDescriptionSoinBindingSource2.DataSource = this.bDB56Projet1MJDataSet;
            // 
            // noEtDescriptionSoinBindingSource1
            // 
            this.noEtDescriptionSoinBindingSource1.DataMember = "noEtDescriptionSoin";
            this.noEtDescriptionSoinBindingSource1.DataSource = this.bDB56Projet1MJDataSet;
            // 
            // noEtDescriptionSoinBindingSource3
            // 
            this.noEtDescriptionSoinBindingSource3.DataMember = "noEtDescriptionSoin";
            this.noEtDescriptionSoinBindingSource3.DataSource = this.bDB56Projet1MJDataSet;
            // 
            // frmAjoutSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 231);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.tbDuree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.Name = "frmAjoutSoin";
            this.Text = "Ajout d\'un soin";
            this.Load += new System.EventHandler(this.frmAjoutSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1MJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label label4;
        private BDB56Projet1MJDataSet bDB56Projet1MJDataSet;
        private System.Windows.Forms.BindingSource noEtDescriptionSoinBindingSource;
        private BDB56Projet1MJDataSetTableAdapters.noEtDescriptionSoinTableAdapter noEtDescriptionSoinTableAdapter;
        private BDB56Projet1MJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.BindingSource noEtDescriptionSoinBindingSource1;
        private System.Windows.Forms.BindingSource noEtDescriptionSoinBindingSource2;
        private System.Windows.Forms.BindingSource noEtDescriptionSoinBindingSource3;
    }
}