﻿namespace AP4_C
{
    partial class FormReapprovisionnement
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
            pnlReap = new Panel();
            gbInfo = new GroupBox();
            txtQteStock = new TextBox();
            label3 = new Label();
            btnAjouter = new Button();
            label2 = new Label();
            tbQte = new TextBox();
            label1 = new Label();
            cbPlat = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            bsPlat = new BindingSource(components);
            pnlReap.SuspendLayout();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsPlat).BeginInit();
            SuspendLayout();
            // 
            // pnlReap
            // 
            pnlReap.BackColor = Color.FromArgb(130, 181, 239);
            pnlReap.Controls.Add(gbInfo);
            pnlReap.Controls.Add(label1);
            pnlReap.Controls.Add(cbPlat);
            pnlReap.Location = new Point(0, 0);
            pnlReap.Name = "pnlReap";
            pnlReap.Size = new Size(800, 428);
            pnlReap.TabIndex = 0;
            pnlReap.Paint += pnlReap_Paint;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(txtQteStock);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(btnAjouter);
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(tbQte);
            gbInfo.Location = new Point(50, 75);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(640, 266);
            gbInfo.TabIndex = 4;
            gbInfo.TabStop = false;
            gbInfo.Enter += gbInfo_Enter;
            // 
            // txtQteStock
            // 
            txtQteStock.Location = new Point(280, 39);
            txtQteStock.Name = "txtQteStock";
            txtQteStock.ReadOnly = true;
            txtQteStock.Size = new Size(100, 23);
            txtQteStock.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(14, 39);
            label3.Name = "label3";
            label3.Size = new Size(260, 18);
            label3.TabIndex = 3;
            label3.Text = "Quantité déjà présente dans le stock";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(405, 121);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 61);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(70, 79);
            label2.Name = "label2";
            label2.Size = new Size(166, 18);
            label2.TabIndex = 1;
            label2.Text = "Quantité a commander";
            // 
            // tbQte
            // 
            tbQte.Location = new Point(280, 79);
            tbQte.Name = "tbQte";
            tbQte.Size = new Size(100, 23);
            tbQte.TabIndex = 0;
            tbQte.TextChanged += tbQte_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(318, 19);
            label1.TabIndex = 3;
            label1.Text = "Veuillez choisir le produit à commander :";
            // 
            // cbPlat
            // 
            cbPlat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlat.FormattingEnabled = true;
            cbPlat.Location = new Point(330, 21);
            cbPlat.Name = "cbPlat";
            cbPlat.Size = new Size(229, 23);
            cbPlat.TabIndex = 2;
            cbPlat.SelectedIndexChanged += cbProduit_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(763, 447);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // bsPlat
            // 
            bsPlat.CurrentChanged += bsPlat_CurrentChanged;
            // 
            // FormReapprovisionnement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 428);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlReap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReapprovisionnement";
            Text = "FormStock";
            Load += FormReapprovisionnement_Load;
            pnlReap.ResumeLayout(false);
            pnlReap.PerformLayout();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsPlat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlReap;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ComboBox cbPlat;
        private GroupBox gbInfo;
        private BindingSource bsPlat;
        private TextBox tbQte;
        private Label label2;
        private Button btnAjouter;
        private TextBox txtQteStock;
        private Label label3;
    }
}