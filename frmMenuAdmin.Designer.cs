namespace Projet1MJ
{
    partial class frmMenuAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionParLadminitrateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesAssistantsEtLeursSoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesSoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planifierDesSoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesChambresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réserverDesChambresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserLesRapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.gérerLesTypesDeChambresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionParLadminitrateurToolStripMenuItem,
            this.déconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(552, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(267, 401);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionParLadminitrateurToolStripMenuItem
            // 
            this.gestionParLadminitrateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesUtilisateursToolStripMenuItem,
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem,
            this.gérerLesAssistantsEtLeursSoinsToolStripMenuItem,
            this.gérerLesSoinsToolStripMenuItem,
            this.gérerLesChambresToolStripMenuItem,
            this.gérerLesTypesDeChambresToolStripMenuItem,
            this.planifierDesSoinsToolStripMenuItem,
            this.réserverDesChambresToolStripMenuItem,
            this.visualiserLesRapportsToolStripMenuItem});
            this.gestionParLadminitrateurToolStripMenuItem.Name = "gestionParLadminitrateurToolStripMenuItem";
            this.gestionParLadminitrateurToolStripMenuItem.Size = new System.Drawing.Size(254, 29);
            this.gestionParLadminitrateurToolStripMenuItem.Text = "Gestion par l\'administrateur";
            // 
            // gérerLesUtilisateursToolStripMenuItem
            // 
            this.gérerLesUtilisateursToolStripMenuItem.Name = "gérerLesUtilisateursToolStripMenuItem";
            this.gérerLesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.gérerLesUtilisateursToolStripMenuItem.Text = "Gérer les utilisateurs";
            this.gérerLesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gérerLesUtilisateursToolStripMenuItem_Click);
            // 
            // gérerLesClientsEtLeursInvitésToolStripMenuItem
            // 
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Name = "gérerLesClientsEtLeursInvitésToolStripMenuItem";
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Text = "Gérer les clients et leurs invités";
            // 
            // gérerLesAssistantsEtLeursSoinsToolStripMenuItem
            // 
            this.gérerLesAssistantsEtLeursSoinsToolStripMenuItem.Name = "gérerLesAssistantsEtLeursSoinsToolStripMenuItem";
            this.gérerLesAssistantsEtLeursSoinsToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.gérerLesAssistantsEtLeursSoinsToolStripMenuItem.Text = "Gérer les assistants et leurs soins";
            // 
            // gérerLesSoinsToolStripMenuItem
            // 
            this.gérerLesSoinsToolStripMenuItem.Name = "gérerLesSoinsToolStripMenuItem";
            this.gérerLesSoinsToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.gérerLesSoinsToolStripMenuItem.Text = "Gérer les soins";
            this.gérerLesSoinsToolStripMenuItem.Click += new System.EventHandler(this.gérerLesSoinsToolStripMenuItem_Click);
            // 
            // planifierDesSoinsToolStripMenuItem
            // 
            this.planifierDesSoinsToolStripMenuItem.Name = "planifierDesSoinsToolStripMenuItem";
            this.planifierDesSoinsToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.planifierDesSoinsToolStripMenuItem.Text = "Planifier des soins";
            // 
            // gérerLesChambresToolStripMenuItem
            // 
            this.gérerLesChambresToolStripMenuItem.Name = "gérerLesChambresToolStripMenuItem";
            this.gérerLesChambresToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.gérerLesChambresToolStripMenuItem.Text = "Gérer les chambres";
            this.gérerLesChambresToolStripMenuItem.Click += new System.EventHandler(this.gérerLesChambresToolStripMenuItem_Click);
            // 
            // réserverDesChambresToolStripMenuItem
            // 
            this.réserverDesChambresToolStripMenuItem.Name = "réserverDesChambresToolStripMenuItem";
            this.réserverDesChambresToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.réserverDesChambresToolStripMenuItem.Text = "Réserver des chambres";
            // 
            // visualiserLesRapportsToolStripMenuItem
            // 
            this.visualiserLesRapportsToolStripMenuItem.Name = "visualiserLesRapportsToolStripMenuItem";
            this.visualiserLesRapportsToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.visualiserLesRapportsToolStripMenuItem.Text = "Visualiser les rapports";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(254, 29);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(254, 29);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu administrateur :";
            // 
            // gérerLesTypesDeChambresToolStripMenuItem
            // 
            this.gérerLesTypesDeChambresToolStripMenuItem.Name = "gérerLesTypesDeChambresToolStripMenuItem";
            this.gérerLesTypesDeChambresToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.gérerLesTypesDeChambresToolStripMenuItem.Text = "Gérer les types de chambres";
            this.gérerLesTypesDeChambresToolStripMenuItem.Click += new System.EventHandler(this.gérerLesTypesDeChambresToolStripMenuItem_Click);
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMenuAdmin";
            this.Text = "Menu administrateur (Projet1MJ)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionParLadminitrateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesClientsEtLeursInvitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesAssistantsEtLeursSoinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesSoinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planifierDesSoinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesChambresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réserverDesChambresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserLesRapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem gérerLesTypesDeChambresToolStripMenuItem;
    }
}