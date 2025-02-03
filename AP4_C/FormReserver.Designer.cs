namespace AP4_C
{
    partial class FormReserver
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
            flowLayoutPanelPlats = new Panel();
            dgvChoixPlat = new DataGridView();
            btnValiderCommande = new Button();
            label3 = new Label();
            label2 = new Label();
            cbTable = new ComboBox();
            rtbCommentaire = new RichTextBox();
            label1 = new Label();
            bsTable = new BindingSource(components);
            bsListePlats = new BindingSource(components);
            flowLayoutPanelPlats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChoixPlat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsListePlats).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelPlats
            // 
            flowLayoutPanelPlats.Controls.Add(dgvChoixPlat);
            flowLayoutPanelPlats.Controls.Add(btnValiderCommande);
            flowLayoutPanelPlats.Controls.Add(label3);
            flowLayoutPanelPlats.Controls.Add(label2);
            flowLayoutPanelPlats.Controls.Add(cbTable);
            flowLayoutPanelPlats.Controls.Add(rtbCommentaire);
            flowLayoutPanelPlats.Controls.Add(label1);
            flowLayoutPanelPlats.Location = new Point(1, 10);
            flowLayoutPanelPlats.Name = "flowLayoutPanelPlats";
            flowLayoutPanelPlats.Size = new Size(800, 428);
            flowLayoutPanelPlats.TabIndex = 0;
            flowLayoutPanelPlats.Paint += flowLayoutPanelPlats_Paint;
            // 
            // dgvChoixPlat
            // 
            dgvChoixPlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChoixPlat.Location = new Point(162, 132);
            dgvChoixPlat.Name = "dgvChoixPlat";
            dgvChoixPlat.Size = new Size(463, 265);
            dgvChoixPlat.TabIndex = 7;
            // 
            // btnValiderCommande
            // 
            btnValiderCommande.Location = new Point(700, 374);
            btnValiderCommande.Name = "btnValiderCommande";
            btnValiderCommande.Size = new Size(75, 23);
            btnValiderCommande.TabIndex = 6;
            btnValiderCommande.Text = "button1";
            btnValiderCommande.UseVisualStyleBackColor = true;
            btnValiderCommande.Click += btnValiderCommande_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 40);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 5;
            label3.Text = "Commentaire";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 54);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "table";
            // 
            // cbTable
            // 
            cbTable.FormattingEnabled = true;
            cbTable.Location = new Point(11, 72);
            cbTable.Name = "cbTable";
            cbTable.Size = new Size(121, 23);
            cbTable.TabIndex = 3;
            // 
            // rtbCommentaire
            // 
            rtbCommentaire.Location = new Point(162, 67);
            rtbCommentaire.Name = "rtbCommentaire";
            rtbCommentaire.Size = new Size(463, 46);
            rtbCommentaire.TabIndex = 2;
            rtbCommentaire.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 11);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 1;
            label1.Text = "Reserver une commande";
            // 
            // FormReserver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelPlats);
            Name = "FormReserver";
            Text = "FormReserver";
            Load += FormReserver_Load;
            flowLayoutPanelPlats.ResumeLayout(false);
            flowLayoutPanelPlats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChoixPlat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsListePlats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel flowLayoutPanelPlats;
        private Label label1;
        private Label label3;
        private Label label2;
        private ComboBox cbTable;
        private RichTextBox rtbCommentaire;
        private BindingSource bsTable;
        private BindingSource bsListePlats;
        private Button btnValiderCommande;
        private DataGridView dgvChoixPlat;
    }
}