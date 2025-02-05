namespace AP4_C
{
    partial class FormGestionProduit
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
            pnlGestionProduit = new Panel();
            tbNomPlat = new TextBox();
            label1 = new Label();
            PlatDgv = new DataGridView();
            PlatBs = new BindingSource(components);
            pnlGestionProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlatDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlatBs).BeginInit();
            SuspendLayout();
            // 
            // pnlGestionProduit
            // 
            pnlGestionProduit.BackColor = Color.FromArgb(130, 181, 239);
            pnlGestionProduit.Controls.Add(tbNomPlat);
            pnlGestionProduit.Controls.Add(label1);
            pnlGestionProduit.Controls.Add(PlatDgv);
            pnlGestionProduit.Location = new Point(0, 0);
            pnlGestionProduit.Name = "pnlGestionProduit";
            pnlGestionProduit.Size = new Size(800, 428);
            pnlGestionProduit.TabIndex = 0;
            pnlGestionProduit.Paint += pnlGestionProduit_Paint;
            // 
            // tbNomPlat
            // 
            tbNomPlat.Location = new Point(152, 21);
            tbNomPlat.Name = "tbNomPlat";
            tbNomPlat.Size = new Size(115, 23);
            tbNomPlat.TabIndex = 3;
            tbNomPlat.TextChanged += tbNomPlat_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(45, 21);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 2;
            label1.Text = "Nom du plat";
            // 
            // PlatDgv
            // 
            PlatDgv.AllowUserToOrderColumns = true;
            PlatDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PlatDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            PlatDgv.BackgroundColor = Color.FromArgb(130, 181, 239);
            PlatDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlatDgv.Location = new Point(57, 57);
            PlatDgv.Name = "PlatDgv";
            PlatDgv.Size = new Size(677, 339);
            PlatDgv.TabIndex = 1;
            PlatDgv.CellContentClick += PlatDgv_CellContentClick;
            // 
            // PlatBs
            // 
            PlatBs.DataSource = typeof(Entities.Plat);
            // 
            // FormGestionProduit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 428);
            Controls.Add(pnlGestionProduit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionProduit";
            Text = "FormGestionProduit";
            Load += FormGestionProduit_Load;
            pnlGestionProduit.ResumeLayout(false);
            pnlGestionProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PlatDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlatBs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGestionProduit;
        private DataGridView PlatDgv;
        private BindingSource PlatBs;
        private TextBox tbNomPlat;
        private Label label1;
    }
}