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
            panelAjoutModif.Location = new Point(3, 12);
            panelAjoutModif.Name = "panelAjoutModif";
            panelAjoutModif.Size = new Size(800, 428);
            panelAjoutModif.TabIndex = 0;
            // 
            // labelemploye
            // 
            labelemploye.AutoSize = true;
            labelemploye.Location = new Point(342, 11);
            labelemploye.Name = "labelemploye";
            labelemploye.Size = new Size(78, 15);
            labelemploye.TabIndex = 2;
            labelemploye.Text = "labelemploye";
            // 
            // gbinfoEmployer
            // 
            gbinfoEmployer.Controls.Add(label2);
            gbinfoEmployer.Controls.Add(label1);
            gbinfoEmployer.Controls.Add(Nom);
            gbinfoEmployer.Controls.Add(tbEmail);
            gbinfoEmployer.Controls.Add(tbPrenom);
            gbinfoEmployer.Controls.Add(tbNom);
            gbinfoEmployer.Controls.Add(buttonemploye);
            gbinfoEmployer.Location = new Point(62, 92);
            gbinfoEmployer.Name = "gbinfoEmployer";
            gbinfoEmployer.Size = new Size(636, 264);
            gbinfoEmployer.TabIndex = 1;
            gbinfoEmployer.TabStop = false;
            gbinfoEmployer.Text = "Gestion Employe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 55);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 55);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 7;
            label1.Text = "Prénom";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(36, 55);
            Nom.Name = "Nom";
            Nom.Size = new Size(34, 15);
            Nom.TabIndex = 6;
            Nom.Text = "Nom";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(435, 52);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(195, 23);
            tbEmail.TabIndex = 5;
            // 
            // tbPrenom
            // 
            tbPrenom.Location = new Point(258, 52);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(100, 23);
            tbPrenom.TabIndex = 4;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(85, 52);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(100, 23);
            tbNom.TabIndex = 3;
            // 
            // buttonemploye
            // 
            buttonemploye.Location = new Point(488, 173);
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
            cbEmploye.Location = new Point(324, 42);
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
    }
}