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
            btnAjouterPlat = new Button();
            BntAjouterCommande = new Button();
            label3 = new Label();
            label2 = new Label();
            cbTable = new ComboBox();
            rtbCommentaire = new RichTextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            bsTable = new BindingSource(components);
            bsListePlats = new BindingSource(components);
            flowLayoutPanelPlats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsListePlats).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelPlats
            // 
            flowLayoutPanelPlats.Controls.Add(btnAjouterPlat);
            flowLayoutPanelPlats.Controls.Add(BntAjouterCommande);
            flowLayoutPanelPlats.Controls.Add(label3);
            flowLayoutPanelPlats.Controls.Add(label2);
            flowLayoutPanelPlats.Controls.Add(cbTable);
            flowLayoutPanelPlats.Controls.Add(rtbCommentaire);
            flowLayoutPanelPlats.Controls.Add(label1);
            flowLayoutPanelPlats.Controls.Add(textBox1);
            flowLayoutPanelPlats.Location = new Point(1, 10);
            flowLayoutPanelPlats.Name = "flowLayoutPanelPlats";
            flowLayoutPanelPlats.Size = new Size(800, 428);
            flowLayoutPanelPlats.TabIndex = 0;
            flowLayoutPanelPlats.Paint += flowLayoutPanelPlats_Paint;
            // 
            // btnAjouterPlat
            // 
            btnAjouterPlat.Location = new Point(433, 225);
            btnAjouterPlat.Name = "btnAjouterPlat";
            btnAjouterPlat.Size = new Size(75, 23);
            btnAjouterPlat.TabIndex = 1;
            btnAjouterPlat.Text = "button2";
            btnAjouterPlat.UseVisualStyleBackColor = true;
            // 
            // BntAjouterCommande
            // 
            BntAjouterCommande.Location = new Point(703, 374);
            BntAjouterCommande.Name = "BntAjouterCommande";
            BntAjouterCommande.Size = new Size(75, 23);
            BntAjouterCommande.TabIndex = 1;
            BntAjouterCommande.Text = "Ajouter";
            BntAjouterCommande.UseVisualStyleBackColor = true;
            BntAjouterCommande.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 54);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 5;
            label3.Text = "Commentaire";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 127);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "table";
            // 
            // cbTable
            // 
            cbTable.FormattingEnabled = true;
            cbTable.Location = new Point(11, 154);
            cbTable.Name = "cbTable";
            cbTable.Size = new Size(121, 23);
            cbTable.TabIndex = 3;
            // 
            // rtbCommentaire
            // 
            rtbCommentaire.Location = new Point(161, 81);
            rtbCommentaire.Name = "rtbCommentaire";
            rtbCommentaire.Size = new Size(463, 96);
            rtbCommentaire.TabIndex = 2;
            rtbCommentaire.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 19);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 1;
            label1.Text = "Reserver une commande";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)bsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsListePlats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel flowLayoutPanelPlats;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private ComboBox cbTable;
        private RichTextBox rtbCommentaire;
        private Button BntAjouterCommande;
        private BindingSource bsTable;
        private BindingSource bsListePlats;
        private Button btnAjouterPlat;
    }
}