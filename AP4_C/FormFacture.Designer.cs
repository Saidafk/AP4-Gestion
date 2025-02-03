namespace AP4_C
{
    partial class FormFacture
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
            label1 = new Label();
            bsFacture = new BindingSource(components);
            cbFacture = new ComboBox();
            gbInfoFacture = new GroupBox();
            tbPrixTVA = new TextBox();
            btnGenererPDF = new Button();
            txtPrix = new TextBox();
            txtTable = new TextBox();
            txtTicket = new TextBox();
            dgvCommande = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            dtpDateFacture = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            bsCommande = new BindingSource(components);
            bsTable = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsFacture).BeginInit();
            gbInfoFacture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "numéro de facture :";
            // 
            // cbFacture
            // 
            cbFacture.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFacture.FormattingEnabled = true;
            cbFacture.Location = new Point(157, 20);
            cbFacture.Name = "cbFacture";
            cbFacture.Size = new Size(121, 23);
            cbFacture.TabIndex = 3;
            cbFacture.SelectedIndexChanged += cbFacture_SelectedIndexChanged;
            // 
            // gbInfoFacture
            // 
            gbInfoFacture.Controls.Add(tbPrixTVA);
            gbInfoFacture.Controls.Add(btnGenererPDF);
            gbInfoFacture.Controls.Add(txtPrix);
            gbInfoFacture.Controls.Add(txtTable);
            gbInfoFacture.Controls.Add(txtTicket);
            gbInfoFacture.Controls.Add(dgvCommande);
            gbInfoFacture.Controls.Add(label6);
            gbInfoFacture.Controls.Add(label5);
            gbInfoFacture.Controls.Add(dtpDateFacture);
            gbInfoFacture.Controls.Add(label4);
            gbInfoFacture.Controls.Add(label3);
            gbInfoFacture.Controls.Add(label2);
            gbInfoFacture.Location = new Point(36, 73);
            gbInfoFacture.Name = "gbInfoFacture";
            gbInfoFacture.Size = new Size(736, 330);
            gbInfoFacture.TabIndex = 4;
            gbInfoFacture.TabStop = false;
            gbInfoFacture.Text = "Facture";
            // 
            // tbPrixTVA
            // 
            tbPrixTVA.Location = new Point(530, 176);
            tbPrixTVA.Name = "tbPrixTVA";
            tbPrixTVA.Size = new Size(162, 23);
            tbPrixTVA.TabIndex = 5;
            // 
            // btnGenererPDF
            // 
            btnGenererPDF.Location = new Point(643, 283);
            btnGenererPDF.Name = "btnGenererPDF";
            btnGenererPDF.Size = new Size(75, 23);
            btnGenererPDF.TabIndex = 26;
            btnGenererPDF.Text = "button1";
            btnGenererPDF.UseVisualStyleBackColor = true;
            btnGenererPDF.Click += btnGenererPDF_Click;
            // 
            // txtPrix
            // 
            txtPrix.Location = new Point(530, 214);
            txtPrix.Name = "txtPrix";
            txtPrix.ReadOnly = true;
            txtPrix.Size = new Size(162, 23);
            txtPrix.TabIndex = 25;
            // 
            // txtTable
            // 
            txtTable.Location = new Point(121, 95);
            txtTable.Name = "txtTable";
            txtTable.ReadOnly = true;
            txtTable.Size = new Size(100, 23);
            txtTable.TabIndex = 24;
            // 
            // txtTicket
            // 
            txtTicket.Location = new Point(121, 57);
            txtTicket.Name = "txtTicket";
            txtTicket.ReadOnly = true;
            txtTicket.Size = new Size(100, 23);
            txtTicket.TabIndex = 23;
            // 
            // dgvCommande
            // 
            dgvCommande.AllowDrop = true;
            dgvCommande.AllowUserToOrderColumns = true;
            dgvCommande.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCommande.BackgroundColor = SystemColors.InactiveCaption;
            dgvCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCommande.Location = new Point(274, 98);
            dgvCommande.Name = "dgvCommande";
            dgvCommande.Size = new Size(185, 169);
            dgvCommande.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 65);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 8;
            label6.Text = "Plat commandé";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 28);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 6;
            label5.Text = "date";
            // 
            // dtpDateFacture
            // 
            dtpDateFacture.Location = new Point(530, 22);
            dtpDateFacture.Name = "dtpDateFacture";
            dtpDateFacture.Size = new Size(200, 23);
            dtpDateFacture.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 98);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 3;
            label4.Text = "Numéro de table";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 60);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "Numéro du ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 19);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 0;
            label2.Text = "Restaurant Camoel";
            // 
            // FormFacture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 428);
            Controls.Add(gbInfoFacture);
            Controls.Add(cbFacture);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFacture";
            Text = "FormFacture";
            Load += FormFacture_Load_1;
            ((System.ComponentModel.ISupportInitialize)bsFacture).EndInit();
            gbInfoFacture.ResumeLayout(false);
            gbInfoFacture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private BindingSource bsFacture;
        private ComboBox cbFacture;
        private GroupBox gbInfoFacture;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpDateFacture;
        private Label label4;
        private DataGridView dgvCommande;
        private BindingSource bsCommande;
        private BindingSource bsTable;
        private TextBox txtTable;
        private TextBox txtTicket;
        private TextBox txtPrix;
        private Button btnGenererPDF;
        private TextBox tbPrixTVA;
    }
}