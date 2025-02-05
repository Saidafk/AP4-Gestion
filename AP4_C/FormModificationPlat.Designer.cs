namespace AP4_C
{
    partial class FormModificationPlat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificationPlat));
            panel1 = new Panel();
            gbInfo = new GroupBox();
            ANNULER = new Button();
            label5 = new Label();
            checkBoxVeggie = new CheckBox();
            label6 = new Label();
            tbDescription = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            prixTxt = new TextBox();
            cbTypePlat = new ComboBox();
            nomPlatTxt = new TextBox();
            button1 = new Button();
            label1 = new Label();
            cbPlat = new ComboBox();
            listePlatBs = new BindingSource(components);
            listeTypePlatBs = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listePlatBs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listeTypePlatBs).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(130, 181, 239);
            panel1.Controls.Add(gbInfo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbPlat);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 428);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(ANNULER);
            gbInfo.Controls.Add(label5);
            gbInfo.Controls.Add(checkBoxVeggie);
            gbInfo.Controls.Add(label6);
            gbInfo.Controls.Add(tbDescription);
            gbInfo.Controls.Add(label4);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(prixTxt);
            gbInfo.Controls.Add(cbTypePlat);
            gbInfo.Controls.Add(nomPlatTxt);
            gbInfo.Controls.Add(button1);
            gbInfo.Location = new Point(52, 70);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(682, 319);
            gbInfo.TabIndex = 1;
            gbInfo.TabStop = false;
            gbInfo.Text = "Information sur le plat";
            // 
            // ANNULER
            // 
            ANNULER.Location = new Point(568, 236);
            ANNULER.Name = "ANNULER";
            ANNULER.Size = new Size(95, 61);
            ANNULER.TabIndex = 1;
            ANNULER.UseVisualStyleBackColor = true;
            ANNULER.Click += ANNULER_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(47, 137);
            label5.Name = "label5";
            label5.Size = new Size(58, 18);
            label5.TabIndex = 15;
            label5.Text = "Veggie";
            // 
            // checkBoxVeggie
            // 
            checkBoxVeggie.AutoSize = true;
            checkBoxVeggie.Location = new Point(26, 137);
            checkBoxVeggie.Name = "checkBoxVeggie";
            checkBoxVeggie.Size = new Size(15, 14);
            checkBoxVeggie.TabIndex = 14;
            checkBoxVeggie.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(184, 149);
            label6.Name = "label6";
            label6.Size = new Size(88, 18);
            label6.TabIndex = 13;
            label6.Text = "Description";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(278, 110);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(385, 108);
            tbDescription.TabIndex = 12;
            tbDescription.Text = "";
            tbDescription.TextChanged += richTextBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(361, 55);
            label4.Name = "label4";
            label4.Size = new Size(66, 18);
            label4.TabIndex = 9;
            label4.Text = "type plat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(192, 55);
            label3.Name = "label3";
            label3.Size = new Size(33, 18);
            label3.TabIndex = 8;
            label3.Text = "prix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(38, 18);
            label2.TabIndex = 7;
            label2.Text = "nom";
            label2.Click += label2_Click;
            // 
            // prixTxt
            // 
            prixTxt.Location = new Point(231, 51);
            prixTxt.Name = "prixTxt";
            prixTxt.Size = new Size(100, 23);
            prixTxt.TabIndex = 6;
            // 
            // cbTypePlat
            // 
            cbTypePlat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypePlat.FormattingEnabled = true;
            cbTypePlat.Location = new Point(433, 50);
            cbTypePlat.Name = "cbTypePlat";
            cbTypePlat.Size = new Size(230, 23);
            cbTypePlat.TabIndex = 5;
            // 
            // nomPlatTxt
            // 
            nomPlatTxt.Location = new Point(47, 51);
            nomPlatTxt.Name = "nomPlatTxt";
            nomPlatTxt.Size = new Size(100, 23);
            nomPlatTxt.TabIndex = 4;
            nomPlatTxt.TextChanged += nomPlatTxt_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(468, 236);
            button1.Name = "button1";
            button1.Size = new Size(94, 61);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // cbPlat
            // 
            cbPlat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlat.FormattingEnabled = true;
            cbPlat.Location = new Point(258, 41);
            cbPlat.Name = "cbPlat";
            cbPlat.Size = new Size(257, 23);
            cbPlat.TabIndex = 1;
            cbPlat.SelectedIndexChanged += cbPlat_SelectedIndexChanged;
            // 
            // FormModificationPlat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormModificationPlat";
            Text = "la Detente de Camoel";
            Load += ModificationPlat_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listePlatBs).EndInit();
            ((System.ComponentModel.ISupportInitialize)listeTypePlatBs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cbPlat;
        private BindingSource listePlatBs;
        private GroupBox gbInfo;
        private Button button1;
        private TextBox nomPlatTxt;
        private TextBox prixTxt;
        private ComboBox cbTypePlat;
        private BindingSource listeTypePlatBs;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RichTextBox tbDescription;
        private Label label6;
        private CheckBox checkBoxVeggie;
        private Label label5;
        private Button ANNULER;
    }
}