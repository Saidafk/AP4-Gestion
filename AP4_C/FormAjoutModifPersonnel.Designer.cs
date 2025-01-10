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
            cbPersonnel = new ComboBox();
            PersonnelBs = new BindingSource(components);
            panelAjoutModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PersonnelBs).BeginInit();
            SuspendLayout();
            // 
            // panelAjoutModif
            // 
            panelAjoutModif.BackColor = SystemColors.ActiveCaption;
            panelAjoutModif.Controls.Add(cbPersonnel);
            panelAjoutModif.Location = new Point(3, 12);
            panelAjoutModif.Name = "panelAjoutModif";
            panelAjoutModif.Size = new Size(800, 428);
            panelAjoutModif.TabIndex = 0;
            panelAjoutModif.Paint += panelAjoutModif_Paint;
            // 
            // cbPersonnel
            // 
            cbPersonnel.FormattingEnabled = true;
            cbPersonnel.Location = new Point(311, 47);
            cbPersonnel.Name = "cbPersonnel";
            cbPersonnel.Size = new Size(121, 23);
            cbPersonnel.TabIndex = 0;
            cbPersonnel.SelectedIndexChanged += cbPersonnel_SelectedIndexChanged;
            // 
            // FormAjoutModifPersonnel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAjoutModif);
            Name = "FormAjoutModifPersonnel";
            Text = "FormAjoutModifPersonnel";
            panelAjoutModif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PersonnelBs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAjoutModif;
        private ComboBox cbPersonnel;
        private BindingSource PersonnelBs;
    }
}