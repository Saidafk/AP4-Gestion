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
            panel1 = new Panel();
            gbInfo = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbVeggie = new ComboBox();
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
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(gbInfo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbPlat);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 428);
            panel1.TabIndex = 0;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(label5);
            gbInfo.Controls.Add(label4);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(cbVeggie);
            gbInfo.Controls.Add(prixTxt);
            gbInfo.Controls.Add(cbTypePlat);
            gbInfo.Controls.Add(nomPlatTxt);
            gbInfo.Controls.Add(button1);
            gbInfo.Location = new Point(52, 70);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(669, 242);
            gbInfo.TabIndex = 1;
            gbInfo.TabStop = false;
            gbInfo.Text = "Information sur le plat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 141);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 10;
            label5.Text = "veggie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 58);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "type plat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 58);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 8;
            label3.Text = "prix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 60);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 7;
            label2.Text = "nom";
            // 
            // cbVeggie
            // 
            cbVeggie.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVeggie.FormattingEnabled = true;
            cbVeggie.Location = new Point(47, 138);
            cbVeggie.Name = "cbVeggie";
            cbVeggie.Size = new Size(121, 23);
            cbVeggie.TabIndex = 4;
            // 
            // prixTxt
            // 
            prixTxt.Location = new Point(243, 51);
            prixTxt.Name = "prixTxt";
            prixTxt.Size = new Size(100, 23);
            prixTxt.TabIndex = 6;
            // 
            // cbTypePlat
            // 
            cbTypePlat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypePlat.FormattingEnabled = true;
            cbTypePlat.Location = new Point(433, 51);
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
            // 
            // button1
            // 
            button1.Location = new Point(549, 164);
            button1.Name = "button1";
            button1.Size = new Size(94, 61);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
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
            Name = "FormModificationPlat";
            Text = "ModificationPlat";
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
        private ComboBox cbVeggie;
        private TextBox prixTxt;
        private ComboBox cbTypePlat;
        private BindingSource listeTypePlatBs;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}