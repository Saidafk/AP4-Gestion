﻿namespace AP4_C
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
            pnlGestionProduit = new Panel();
            SuspendLayout();
            // 
            // pnlGestionProduit
            // 
            pnlGestionProduit.BackColor = Color.Fuchsia;
            pnlGestionProduit.Location = new Point(0, 0);
            pnlGestionProduit.Name = "pnlGestionProduit";
            pnlGestionProduit.Size = new Size(800, 428);
            pnlGestionProduit.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGestionProduit;
    }
}