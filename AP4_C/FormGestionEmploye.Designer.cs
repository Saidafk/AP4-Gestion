namespace AP4_C
{
    partial class FormGestionEmploye
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
            pnlGestionEmploye = new Panel();
            SuspendLayout();
            // 
            // pnlGestionEmploye
            // 
            pnlGestionEmploye.BackColor = Color.Red;
            pnlGestionEmploye.Location = new Point(0, 0);
            pnlGestionEmploye.Name = "pnlGestionEmploye";
            pnlGestionEmploye.Size = new Size(800, 428);
            pnlGestionEmploye.TabIndex = 0;
            pnlGestionEmploye.Paint += pnlGestionEmploye_Paint;
            // 
            // FormGestionEmploye
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 428);
            Controls.Add(pnlGestionEmploye);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionEmploye";
            Text = "FormGestionEmploye";
            ResumeLayout(false);
        }

        #endregion

        public Panel pnlGestionEmploye;
    }
}