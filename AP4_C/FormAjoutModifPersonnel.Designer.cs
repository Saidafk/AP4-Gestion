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
            cbEmploye = new ComboBox();
            EmployeBS = new BindingSource(components);
            groupBox1 = new GroupBox();
            labelemploye = new Label();
            buttonemploye = new Button();
            panelAjoutModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeBS).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelAjoutModif
            // 
            panelAjoutModif.BackColor = SystemColors.ActiveCaption;
            panelAjoutModif.Controls.Add(labelemploye);
            panelAjoutModif.Controls.Add(groupBox1);
            panelAjoutModif.Controls.Add(cbEmploye);
            panelAjoutModif.Location = new Point(3, 12);
            panelAjoutModif.Name = "panelAjoutModif";
            panelAjoutModif.Size = new Size(800, 428);
            panelAjoutModif.TabIndex = 0;
            // 
            // cbEmploye
            // 
            cbEmploye.FormattingEnabled = true;
            cbEmploye.Location = new Point(325, 54);
            cbEmploye.Name = "cbEmploye";
            cbEmploye.Size = new Size(121, 23);
            cbEmploye.TabIndex = 0;
            cbEmploye.SelectedIndexChanged += cbPersonnel_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonemploye);
            groupBox1.Location = new Point(62, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(636, 264);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion Employe";
            // 
            // labelemploye
            // 
            labelemploye.AutoSize = true;
            labelemploye.Location = new Point(352, 13);
            labelemploye.Name = "labelemploye";
            labelemploye.Size = new Size(78, 15);
            labelemploye.TabIndex = 2;
            labelemploye.Text = "labelemploye";
            // 
            // buttonemploye
            // 
            buttonemploye.Location = new Point(488, 173);
            buttonemploye.Name = "buttonemploye";
            buttonemploye.Size = new Size(121, 73);
            buttonemploye.TabIndex = 0;
            buttonemploye.Text = "button1";
            buttonemploye.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)EmployeBS).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAjoutModif;
        private ComboBox cbEmploye;
        private BindingSource EmployeBS;
        private Label labelemploye;
        private GroupBox groupBox1;
        private Button buttonemploye;
    }
}