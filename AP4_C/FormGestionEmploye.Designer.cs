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
            label2 = new Label();
            cmbFiltreRole = new ComboBox();
            label1 = new Label();
            txtFiltreEmp = new TextBox();
            EmployeDgv = new DataGridView();
            EmployeBs = new BindingSource(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            pnlGestionEmploye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeBs).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGestionEmploye
            // 
            pnlGestionEmploye.BackColor = Color.White;
            pnlGestionEmploye.Controls.Add(label2);
            pnlGestionEmploye.Controls.Add(cmbFiltreRole);
            pnlGestionEmploye.Controls.Add(label1);
            pnlGestionEmploye.Controls.Add(txtFiltreEmp);
            pnlGestionEmploye.Controls.Add(EmployeDgv);
            pnlGestionEmploye.Location = new Point(0, 0);
            pnlGestionEmploye.Name = "pnlGestionEmploye";
            pnlGestionEmploye.Size = new Size(800, 428);
            pnlGestionEmploye.TabIndex = 0;
            pnlGestionEmploye.Paint += pnlGestionEmploye_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 32);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 4;
            label2.Text = "Afficher uniquement";
            // 
            // cmbFiltreRole
            // 
            cmbFiltreRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltreRole.FormattingEnabled = true;
            cmbFiltreRole.Location = new Point(598, 29);
            cmbFiltreRole.Name = "cmbFiltreRole";
            cmbFiltreRole.Size = new Size(121, 23);
            cmbFiltreRole.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 29);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 2;
            label1.Text = "Nom de l'employe";
            // 
            // txtFiltreEmp
            // 
            txtFiltreEmp.Location = new Point(173, 26);
            txtFiltreEmp.Name = "txtFiltreEmp";
            txtFiltreEmp.Size = new Size(100, 23);
            txtFiltreEmp.TabIndex = 1;
            txtFiltreEmp.TextChanged += txtFiltreEmp_TextChanged;
            // 
            // EmployeDgv
            // 
            EmployeDgv.BackgroundColor = SystemColors.ControlLightLight;
            EmployeDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeDgv.Location = new Point(62, 78);
            EmployeDgv.Name = "EmployeDgv";
            EmployeDgv.Size = new Size(657, 327);
            EmployeDgv.TabIndex = 0;
            EmployeDgv.CellContentClick += EmployeDgv_CellContentClick;
            // 
            // EmployeBs
            // 
            EmployeBs.CurrentChanged += EmployeBs_CurrentChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { supprimerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(180, 22);
            supprimerToolStripMenuItem.Text = "Supprimer";
            supprimerToolStripMenuItem.Click += supprimerToolStripMenuItem_Click;
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
            pnlGestionEmploye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeBs).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel pnlGestionEmploye;
        private DataGridView EmployeDgv;
        private BindingSource EmployeBs;
        private Label label1;
        private TextBox txtFiltreEmp;
        private Label label2;
        private ComboBox cmbFiltreRole;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem supprimerToolStripMenuItem;
    }
}