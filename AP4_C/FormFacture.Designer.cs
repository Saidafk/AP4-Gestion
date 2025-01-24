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
            bindingSource1 = new BindingSource(components);
            cbFacture = new ComboBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            tbCommande = new TextBox();
            tbTicket = new TextBox();
            tbTable = new TextBox();
            tbPrix = new TextBox();
            Prix = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbTTC = new TextBox();
            tbTVA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
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
            label1.Click += label1_Click;
            // 
            // cbFacture
            // 
            cbFacture.FormattingEnabled = true;
            cbFacture.Location = new Point(157, 20);
            cbFacture.Name = "cbFacture";
            cbFacture.Size = new Size(121, 23);
            cbFacture.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbTVA);
            groupBox1.Controls.Add(tbTTC);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(Prix);
            groupBox1.Controls.Add(tbPrix);
            groupBox1.Controls.Add(tbTable);
            groupBox1.Controls.Add(tbTicket);
            groupBox1.Controls.Add(tbCommande);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(36, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(736, 330);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Facture";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 19);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 0;
            label2.Text = "Restaurant Camoel";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 98);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 3;
            label4.Text = "Numéro de table";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(530, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 146);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 8;
            label6.Text = "Plat commandé";
            // 
            // tbCommande
            // 
            tbCommande.Location = new Point(269, 143);
            tbCommande.Name = "tbCommande";
            tbCommande.Size = new Size(163, 23);
            tbCommande.TabIndex = 9;
            // 
            // tbTicket
            // 
            tbTicket.Location = new Point(121, 57);
            tbTicket.Name = "tbTicket";
            tbTicket.Size = new Size(100, 23);
            tbTicket.TabIndex = 10;
            // 
            // tbTable
            // 
            tbTable.Location = new Point(121, 95);
            tbTable.Name = "tbTable";
            tbTable.Size = new Size(100, 23);
            tbTable.TabIndex = 11;
            // 
            // tbPrix
            // 
            tbPrix.Location = new Point(466, 143);
            tbPrix.Name = "tbPrix";
            tbPrix.Size = new Size(83, 23);
            tbPrix.TabIndex = 12;
            // 
            // Prix
            // 
            Prix.AutoSize = true;
            Prix.Location = new Point(480, 103);
            Prix.Name = "Prix";
            Prix.Size = new Size(27, 15);
            Prix.TabIndex = 13;
            Prix.Text = "Prix";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 197);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 14;
            label7.Text = "Montant TTC";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 19);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 15;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(379, 230);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 16;
            label9.Text = "TVA";
            // 
            // tbTTC
            // 
            tbTTC.Location = new Point(449, 194);
            tbTTC.Name = "tbTTC";
            tbTTC.Size = new Size(100, 23);
            tbTTC.TabIndex = 17;
            // 
            // tbTVA
            // 
            tbTVA.Location = new Point(449, 230);
            tbTVA.Name = "tbTVA";
            tbTVA.Size = new Size(100, 23);
            tbTVA.TabIndex = 18;
            // 
            // FormFacture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 428);
            Controls.Add(groupBox1);
            Controls.Add(cbFacture);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFacture";
            Text = "FormFacture";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private BindingSource bindingSource1;
        private ComboBox cbFacture;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox tbTable;
        private TextBox tbTicket;
        private TextBox tbCommande;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox tbTVA;
        private TextBox tbTTC;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label Prix;
        private TextBox tbPrix;
    }
}