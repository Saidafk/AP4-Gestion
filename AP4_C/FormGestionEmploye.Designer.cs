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
            components = new System.ComponentModel.Container();
            pnlGestionEmploye = new Panel();
            EmployeDgv = new DataGridView();
            EmployeBs = new BindingSource(components);
            pnlGestionEmploye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeBs).BeginInit();
            SuspendLayout();
            // 
            // pnlGestionEmploye
            // 
            pnlGestionEmploye.BackColor = Color.White;
            pnlGestionEmploye.Controls.Add(EmployeDgv);
            pnlGestionEmploye.Location = new Point(0, 0);
            pnlGestionEmploye.Name = "pnlGestionEmploye";
            pnlGestionEmploye.Size = new Size(800, 428);
            pnlGestionEmploye.TabIndex = 0;
            pnlGestionEmploye.Paint += pnlGestionEmploye_Paint;
            // 
            // EmployeDgv
            // 
            EmployeDgv.BackgroundColor = SystemColors.ControlLightLight;
            EmployeDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeDgv.Location = new Point(86, 46);
            EmployeDgv.Name = "EmployeDgv";
            EmployeDgv.Size = new Size(612, 327);
            EmployeDgv.TabIndex = 0;
            EmployeDgv.CellContentClick += EmployeDgv_CellContentClick;
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
            Load += FormGestionEmploye_Load;
            pnlGestionEmploye.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EmployeDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeBs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnlGestionEmploye;
        private DataGridView EmployeDgv;
        private BindingSource EmployeBs;
    }
}