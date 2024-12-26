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
            filtreNomTxt = new TextBox();
            dgvFacture = new DataGridView();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvFacture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "nom du client :";
            label1.Click += label1_Click;
            // 
            // filtreNomTxt
            // 
            filtreNomTxt.Location = new Point(116, 20);
            filtreNomTxt.Name = "filtreNomTxt";
            filtreNomTxt.Size = new Size(100, 23);
            filtreNomTxt.TabIndex = 1;
            // 
            // dgvFacture
            // 
            dgvFacture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacture.Location = new Point(130, 90);
            dgvFacture.Name = "dgvFacture";
            dgvFacture.Size = new Size(526, 248);
            dgvFacture.TabIndex = 2;
            dgvFacture.CellContentClick += dgvFacture_CellContentClick;
            // 
            // FormFacture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 428);
            Controls.Add(dgvFacture);
            Controls.Add(filtreNomTxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFacture";
            Text = "FormFacture";
            ((System.ComponentModel.ISupportInitialize)dgvFacture).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox filtreNomTxt;
        private DataGridView dgvFacture;
        private BindingSource bindingSource1;
    }
}