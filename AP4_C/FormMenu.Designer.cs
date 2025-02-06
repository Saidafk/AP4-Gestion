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
            supprimerUnPlatToolStripMenuItem = new ToolStripMenuItem();
            gestionDesEmployésToolStripMenuItem = new ToolStripMenuItem();
            listeDesEmployeToolStripMenuItem = new ToolStripMenuItem();
            ajoutDunEmployéToolStripMenuItem = new ToolStripMenuItem();
            modificationDunEmployéToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            pnlMenu = new Panel();
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
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // DeconnexionBtn
            // 
            DeconnexionBtn.Name = "DeconnexionBtn";
            DeconnexionBtn.Size = new Size(12, 20);
            // 
            // toolStripMenuItem0
            // 
            toolStripMenuItem0.Name = "toolStripMenuItem0";
            toolStripMenuItem0.Size = new Size(58, 20);
            toolStripMenuItem0.Text = "Accueil";
            toolStripMenuItem0.Click += toolStripMenuItem0_Click;
            // 
            // reserverToolStripMenuItem
            // 
            reserverToolStripMenuItem.Name = "reserverToolStripMenuItem";
            reserverToolStripMenuItem.Size = new Size(86, 20);
            reserverToolStripMenuItem.Text = "Commander";
            reserverToolStripMenuItem.Click += reserverToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(63, 20);
            toolStripMenuItem2.Text = "Factures";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripMenuItem4, toolStripMenuItem5, modificationDesPlatsToolStripMenuItem, modificationDunPlatToolStripMenuItem, supprimerUnPlatToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(127, 20);
            toolStripMenuItem3.Text = "Gestion des produits";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(189, 6);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(192, 22);
            toolStripMenuItem4.Text = "Réaprovissionnement";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(192, 22);
            toolStripMenuItem5.Text = "Liste des Plats";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // modificationDesPlatsToolStripMenuItem
            // 
            modificationDesPlatsToolStripMenuItem.Name = "modificationDesPlatsToolStripMenuItem";
            modificationDesPlatsToolStripMenuItem.Size = new Size(192, 22);
            modificationDesPlatsToolStripMenuItem.Text = "Ajout d'un plat";
            modificationDesPlatsToolStripMenuItem.Click += modificationDesPlatsToolStripMenuItem_Click;
            // 
            // modificationDunPlatToolStripMenuItem
            // 
            modificationDunPlatToolStripMenuItem.Name = "modificationDunPlatToolStripMenuItem";
            modificationDunPlatToolStripMenuItem.Size = new Size(192, 22);
            modificationDunPlatToolStripMenuItem.Text = "Modification d'un plat";
            modificationDunPlatToolStripMenuItem.Click += modificationDunPlatToolStripMenuItem_Click;
            // 
            // supprimerUnPlatToolStripMenuItem
            // 
            supprimerUnPlatToolStripMenuItem.Name = "supprimerUnPlatToolStripMenuItem";
            supprimerUnPlatToolStripMenuItem.Size = new Size(192, 22);
            supprimerUnPlatToolStripMenuItem.Text = "Supprimer un plat";
            supprimerUnPlatToolStripMenuItem.Click += supprimerUnPlatToolStripMenuItem_Click;
            // 
            // gestionDesEmployésToolStripMenuItem
            // 
            gestionDesEmployésToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesEmployeToolStripMenuItem, ajoutDunEmployéToolStripMenuItem, modificationDunEmployéToolStripMenuItem });
            gestionDesEmployésToolStripMenuItem.Name = "gestionDesEmployésToolStripMenuItem";
            gestionDesEmployésToolStripMenuItem.Size = new Size(134, 20);
            gestionDesEmployésToolStripMenuItem.Text = "Gestion des employés";
            gestionDesEmployésToolStripMenuItem.Click += gestionDesEmployésToolStripMenuItem_Click;
            // 
            // listeDesEmployeToolStripMenuItem
            // 
            listeDesEmployeToolStripMenuItem.Name = "listeDesEmployeToolStripMenuItem";
            listeDesEmployeToolStripMenuItem.Size = new Size(218, 22);
            listeDesEmployeToolStripMenuItem.Text = "Liste des employés";
            listeDesEmployeToolStripMenuItem.Click += listeDesEmployeToolStripMenuItem_Click;
            // 
            // ajoutDunEmployéToolStripMenuItem
            // 
            ajoutDunEmployéToolStripMenuItem.Name = "ajoutDunEmployéToolStripMenuItem";
            ajoutDunEmployéToolStripMenuItem.Size = new Size(218, 22);
            ajoutDunEmployéToolStripMenuItem.Text = "Ajout d'un employé";
            ajoutDunEmployéToolStripMenuItem.Click += ajoutDunEmployéToolStripMenuItem_Click;
            // 
            // modificationDunEmployéToolStripMenuItem
            // 
            modificationDunEmployéToolStripMenuItem.Name = "modificationDunEmployéToolStripMenuItem";
            modificationDunEmployéToolStripMenuItem.Size = new Size(218, 22);
            modificationDunEmployéToolStripMenuItem.Text = "Modification d'un employé";
            modificationDunEmployéToolStripMenuItem.Click += modificationDunEmployéToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(56, 20);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(89, 20);
            toolStripMenuItem1.Text = "Deconnexion";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Location = new Point(0, 24);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(800, 426);
            pnlMenu.TabIndex = 1;
            pnlMenu.Paint += pnlMenu_Paint;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMenu);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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