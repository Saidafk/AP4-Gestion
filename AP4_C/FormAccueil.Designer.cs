namespace AP4_C
{
    partial class FormAccueil
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnCommander = new Button();
            btnFacture = new Button();
            btnStocks = new Button();
            btnEmployes = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pixlr_image_generator_b9a44d41_46de_474e_a785_9746a8d36060_720;
            pictureBox1.Location = new Point(47, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 59);
            label1.Name = "label1";
            label1.Size = new Size(420, 29);
            label1.TabIndex = 1;
            label1.Text = "Bienvenue sur l'application de gestion";
            // 
            // btnCommander
            // 
            btnCommander.BackColor = Color.FromArgb(108, 187, 233);
            btnCommander.Location = new Point(348, 168);
            btnCommander.Name = "btnCommander";
            btnCommander.Size = new Size(366, 43);
            btnCommander.TabIndex = 3;
            btnCommander.Text = "Commander";
            btnCommander.UseVisualStyleBackColor = false;
            btnCommander.Click += btnCommander_Click;
            // 
            // btnFacture
            // 
            btnFacture.BackColor = Color.FromArgb(86, 194, 226);
            btnFacture.Location = new Point(348, 217);
            btnFacture.Name = "btnFacture";
            btnFacture.Size = new Size(336, 43);
            btnFacture.TabIndex = 4;
            btnFacture.Text = "Facture";
            btnFacture.UseVisualStyleBackColor = false;
            btnFacture.Click += btnFacture_Click;
            // 
            // btnStocks
            // 
            btnStocks.BackColor = Color.FromArgb(50, 202, 204);
            btnStocks.Location = new Point(348, 266);
            btnStocks.Name = "btnStocks";
            btnStocks.Size = new Size(306, 43);
            btnStocks.TabIndex = 5;
            btnStocks.Text = "Gestion des produits";
            btnStocks.UseVisualStyleBackColor = false;
            btnStocks.Click += btnStocks_Click;
            // 
            // btnEmployes
            // 
            btnEmployes.BackColor = Color.FromArgb(14, 206, 182);
            btnEmployes.Location = new Point(348, 315);
            btnEmployes.Name = "btnEmployes";
            btnEmployes.Size = new Size(276, 43);
            btnEmployes.TabIndex = 6;
            btnEmployes.Text = "Gestion des employés";
            btnEmployes.UseVisualStyleBackColor = false;
            btnEmployes.Click += btnEmployes_Click;
            // 
            // FormAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(130, 181, 239);
            ClientSize = new Size(800, 450);
            Controls.Add(btnEmployes);
            Controls.Add(btnStocks);
            Controls.Add(btnFacture);
            Controls.Add(btnCommander);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormAccueil";
            Text = "FormAccueil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnCommander;
        private Button btnFacture;
        private Button btnStocks;
        private Button btnEmployes;
    }
}