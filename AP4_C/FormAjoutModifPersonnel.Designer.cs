namespace AP4_C
{
    partial class FormAjoutModifPersonnel
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
            components = new System.ComponentModel.Container();
            panelAjoutModif = new Panel();
            labelemploye = new Label();
            gbinfoEmployer = new GroupBox();
            lbServeur = new Label();
            lbCuisinier = new Label();
            ckbServeur = new CheckBox();
            ckbCuisinier = new CheckBox();
            btnMDP = new Button();
            txtMDP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Nom = new Label();
            tbEmail = new TextBox();
            tbPrenom = new TextBox();
            tbNom = new TextBox();
            buttonemploye = new Button();
            cbEmploye = new ComboBox();
            EmployeBS = new BindingSource(components);
            panelAjoutModif.SuspendLayout();
            gbinfoEmployer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeBS).BeginInit();
            SuspendLayout();
            // 
            // panelAjoutModif
            // 
            panelAjoutModif.BackColor = SystemColors.ActiveCaption;
            panelAjoutModif.Controls.Add(labelemploye);
            panelAjoutModif.Controls.Add(gbinfoEmployer);
            panelAjoutModif.Controls.Add(cbEmploye);
            panelAjoutModif.Location = new Point(1, 0);
            panelAjoutModif.Name = "panelAjoutModif";
            panelAjoutModif.Size = new Size(799, 451);
            panelAjoutModif.TabIndex = 0;
            panelAjoutModif.Paint += panelAjoutModif_Paint;
            // 
            // labelemploye
            // 
            labelemploye.AutoSize = true;
            labelemploye.Location = new Point(98, 31);
            labelemploye.Name = "labelemploye";
            labelemploye.Size = new Size(53, 15);
            labelemploye.TabIndex = 2;
            labelemploye.Text = "Employe";
            // 
            // gbinfoEmployer
            // 
            gbinfoEmployer.Controls.Add(lbServeur);
            gbinfoEmployer.Controls.Add(lbCuisinier);
            gbinfoEmployer.Controls.Add(ckbServeur);
            gbinfoEmployer.Controls.Add(ckbCuisinier);
            gbinfoEmployer.Controls.Add(btnMDP);
            gbinfoEmployer.Controls.Add(txtMDP);
            gbinfoEmployer.Controls.Add(label2);
            gbinfoEmployer.Controls.Add(label1);
            gbinfoEmployer.Controls.Add(Nom);
            gbinfoEmployer.Controls.Add(tbEmail);
            gbinfoEmployer.Controls.Add(tbPrenom);
            gbinfoEmployer.Controls.Add(tbNom);
            gbinfoEmployer.Controls.Add(buttonemploye);
            gbinfoEmployer.Location = new Point(26, 92);
            gbinfoEmployer.Name = "gbinfoEmployer";
            gbinfoEmployer.Size = new Size(734, 315);
            gbinfoEmployer.TabIndex = 1;
            gbinfoEmployer.TabStop = false;
            gbinfoEmployer.Text = "Gestion Employe";
            // 
            // lbServeur
            // 
            lbServeur.AutoSize = true;
            lbServeur.Location = new Point(72, 255);
            lbServeur.Name = "lbServeur";
            lbServeur.Size = new Size(46, 15);
            lbServeur.TabIndex = 12;
            lbServeur.Text = "Serveur";
            // 
            // lbCuisinier
            // 
            lbCuisinier.AutoSize = true;
            lbCuisinier.Location = new Point(72, 223);
            lbCuisinier.Name = "lbCuisinier";
            lbCuisinier.Size = new Size(53, 15);
            lbCuisinier.TabIndex = 11;
            lbCuisinier.Text = "Cuisinier";
            // 
            // ckbServeur
            // 
            ckbServeur.AutoSize = true;
            ckbServeur.Location = new Point(132, 255);
            ckbServeur.Name = "ckbServeur";
            ckbServeur.Size = new Size(15, 14);
            ckbServeur.TabIndex = 10;
            ckbServeur.UseVisualStyleBackColor = true;
            // 
            // ckbCuisinier
            // 
            ckbCuisinier.AutoSize = true;
            ckbCuisinier.Location = new Point(132, 223);
            ckbCuisinier.Name = "ckbCuisinier";
            ckbCuisinier.Size = new Size(15, 14);
            ckbCuisinier.TabIndex = 1;
            ckbCuisinier.UseVisualStyleBackColor = true;
            // 
            // btnMDP
            // 
            btnMDP.Location = new Point(6, 157);
            btnMDP.Name = "btnMDP";
            btnMDP.Size = new Size(276, 23);
            btnMDP.TabIndex = 9;
            btnMDP.Text = "button1";
            btnMDP.UseVisualStyleBackColor = true;
            btnMDP.Click += btnMDP_Click;
            // 
            // txtMDP
            // 
            txtMDP.Location = new Point(305, 157);
            txtMDP.Name = "txtMDP";
            txtMDP.ReadOnly = true;
            txtMDP.Size = new Size(287, 23);
            txtMDP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 50);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 50);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 7;
            label1.Text = "Prénom";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(36, 50);
            Nom.Name = "Nom";
            Nom.Size = new Size(34, 15);
            Nom.TabIndex = 6;
            Nom.Text = "Nom";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(305, 68);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(195, 23);
            tbEmail.TabIndex = 5;
            // 
            // tbPrenom
            // 
            tbPrenom.Location = new Point(165, 68);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(100, 23);
            tbPrenom.TabIndex = 4;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(36, 68);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(100, 23);
            tbNom.TabIndex = 3;
            // 
            // buttonemploye
            // 
            buttonemploye.Location = new Point(593, 223);
            buttonemploye.Name = "buttonemploye";
            buttonemploye.Size = new Size(121, 73);
            buttonemploye.TabIndex = 0;
            buttonemploye.UseVisualStyleBackColor = true;
            buttonemploye.Click += buttonemploye_Click;
            // 
            // cbEmploye
            // 
            cbEmploye.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmploye.FormattingEnabled = true;
            cbEmploye.Location = new Point(98, 49);
            cbEmploye.Name = "cbEmploye";
            cbEmploye.Size = new Size(121, 23);
            cbEmploye.TabIndex = 0;
            cbEmploye.SelectedIndexChanged += cbPersonnel_SelectedIndexChanged;
            // 
            // FormAjoutModifPersonnel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAjoutModif);
            Name = "FormAjoutModifPersonnel";
            Text = "FormAjoutModifPersonnel";
            Load += FormAjoutModifPersonnel_Load;
            panelAjoutModif.ResumeLayout(false);
            panelAjoutModif.PerformLayout();
            gbinfoEmployer.ResumeLayout(false);
            gbinfoEmployer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeBS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAjoutModif;
        private ComboBox cbEmploye;
        private BindingSource EmployeBS;
        private Label labelemploye;
        private GroupBox gbinfoEmployer;
        private Button buttonemploye;
        private TextBox tbPrenom;
        private TextBox tbNom;
        private TextBox tbEmail;
        private Label label2;
        private Label label1;
        private Label Nom;
        private TextBox txtMDP;
        private Button btnMDP;
        private Label lbServeur;
        private Label lbCuisinier;
        private CheckBox ckbServeur;
        private CheckBox ckbCuisinier;
    }
}