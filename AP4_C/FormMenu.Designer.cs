namespace AP4_C
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            menuStrip1 = new MenuStrip();
            DeconnexionBtn = new ToolStripMenuItem();
            toolStripMenuItem0 = new ToolStripMenuItem();
            reserverToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            modificationDesPlatsToolStripMenuItem = new ToolStripMenuItem();
            modificationDunPlatToolStripMenuItem = new ToolStripMenuItem();
            gestionDesEmployésToolStripMenuItem = new ToolStripMenuItem();
            listeDesEmployeToolStripMenuItem = new ToolStripMenuItem();
            ajoutDunEmployéToolStripMenuItem = new ToolStripMenuItem();
            modificationDunEmployéToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            pnlMenu = new Panel();
            supprimerUnPlatToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(130, 181, 239);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { DeconnexionBtn, toolStripMenuItem0, reserverToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem3, gestionDesEmployésToolStripMenuItem, quitterToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // DeconnexionBtn
            // 
            DeconnexionBtn.Name = "DeconnexionBtn";
            DeconnexionBtn.Size = new Size(14, 24);
            // 
            // toolStripMenuItem0
            // 
            toolStripMenuItem0.Name = "toolStripMenuItem0";
            toolStripMenuItem0.Size = new Size(71, 24);
            toolStripMenuItem0.Text = "Accueil";
            toolStripMenuItem0.Click += toolStripMenuItem0_Click;
            // 
            // reserverToolStripMenuItem
            // 
            reserverToolStripMenuItem.Name = "reserverToolStripMenuItem";
            reserverToolStripMenuItem.Size = new Size(79, 24);
            reserverToolStripMenuItem.Text = "Reserver";
            reserverToolStripMenuItem.Click += reserverToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(76, 24);
            toolStripMenuItem2.Text = "Factures";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripMenuItem4, toolStripMenuItem5, modificationDesPlatsToolStripMenuItem, modificationDunPlatToolStripMenuItem, supprimerUnPlatToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(59, 24);
            toolStripMenuItem3.Text = "Stock";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(236, 6);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(239, 26);
            toolStripMenuItem4.Text = "Réaprovissionnement";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(239, 26);
            toolStripMenuItem5.Text = "Liste des Plats";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // modificationDesPlatsToolStripMenuItem
            // 
            modificationDesPlatsToolStripMenuItem.Name = "modificationDesPlatsToolStripMenuItem";
            modificationDesPlatsToolStripMenuItem.Size = new Size(239, 26);
            modificationDesPlatsToolStripMenuItem.Text = "Ajout d'un plat";
            modificationDesPlatsToolStripMenuItem.Click += modificationDesPlatsToolStripMenuItem_Click;
            // 
            // modificationDunPlatToolStripMenuItem
            // 
            modificationDunPlatToolStripMenuItem.Name = "modificationDunPlatToolStripMenuItem";
            modificationDunPlatToolStripMenuItem.Size = new Size(239, 26);
            modificationDunPlatToolStripMenuItem.Text = "Modification d'un plat";
            modificationDunPlatToolStripMenuItem.Click += modificationDunPlatToolStripMenuItem_Click;
            // 
            // gestionDesEmployésToolStripMenuItem
            // 
            gestionDesEmployésToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesEmployeToolStripMenuItem, ajoutDunEmployéToolStripMenuItem, modificationDunEmployéToolStripMenuItem });
            gestionDesEmployésToolStripMenuItem.Name = "gestionDesEmployésToolStripMenuItem";
            gestionDesEmployésToolStripMenuItem.Size = new Size(168, 24);
            gestionDesEmployésToolStripMenuItem.Text = "Gestion des employés";
            gestionDesEmployésToolStripMenuItem.Click += gestionDesEmployésToolStripMenuItem_Click;
            // 
            // listeDesEmployeToolStripMenuItem
            // 
            listeDesEmployeToolStripMenuItem.Name = "listeDesEmployeToolStripMenuItem";
            listeDesEmployeToolStripMenuItem.Size = new Size(271, 26);
            listeDesEmployeToolStripMenuItem.Text = "Liste des employés";
            listeDesEmployeToolStripMenuItem.Click += listeDesEmployeToolStripMenuItem_Click;
            // 
            // ajoutDunEmployéToolStripMenuItem
            // 
            ajoutDunEmployéToolStripMenuItem.Name = "ajoutDunEmployéToolStripMenuItem";
            ajoutDunEmployéToolStripMenuItem.Size = new Size(271, 26);
            ajoutDunEmployéToolStripMenuItem.Text = "Ajout d'un employé";
            ajoutDunEmployéToolStripMenuItem.Click += ajoutDunEmployéToolStripMenuItem_Click;
            // 
            // modificationDunEmployéToolStripMenuItem
            // 
            modificationDunEmployéToolStripMenuItem.Name = "modificationDunEmployéToolStripMenuItem";
            modificationDunEmployéToolStripMenuItem.Size = new Size(271, 26);
            modificationDunEmployéToolStripMenuItem.Text = "Modification d'un employé";
            modificationDunEmployéToolStripMenuItem.Click += modificationDunEmployéToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(69, 24);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(110, 24);
            toolStripMenuItem1.Text = "Deconnexion";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Location = new Point(0, 32);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(914, 568);
            pnlMenu.TabIndex = 1;
            pnlMenu.Paint += pnlMenu_Paint;
            // 
            // supprimerUnPlatToolStripMenuItem
            // 
            supprimerUnPlatToolStripMenuItem.Name = "supprimerUnPlatToolStripMenuItem";
            supprimerUnPlatToolStripMenuItem.Size = new Size(239, 26);
            supprimerUnPlatToolStripMenuItem.Text = "Supprimer un plat";
            supprimerUnPlatToolStripMenuItem.Click += supprimerUnPlatToolStripMenuItem_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlMenu);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            Text = "la Detente de Camoel";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem DeconnexionBtn;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem gestionDesEmployésToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        public Panel pnlMenu;
        private ToolStripMenuItem modificationDesPlatsToolStripMenuItem;
        private ToolStripMenuItem modificationDunPlatToolStripMenuItem;
        private ToolStripMenuItem listeDesEmployeToolStripMenuItem;
        private ToolStripMenuItem ajoutDunEmployéToolStripMenuItem;
        private ToolStripMenuItem modificationDunEmployéToolStripMenuItem;
        private ToolStripMenuItem reserverToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem0;
        private ToolStripMenuItem supprimerUnPlatToolStripMenuItem;
    }
}