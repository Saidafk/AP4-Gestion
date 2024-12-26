namespace AP4_C
{
    partial class FormConnexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            userTxt = new TextBox();
            passwordTxt = new TextBox();
            connect = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pixlr_image_generator_b9a44d41_46de_474e_a785_9746a8d36060_720;
            pictureBox1.Location = new Point(304, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(257, 186);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(96, 19);
            label1.TabIndex = 1;
            label1.Text = "Utilisateur :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(257, 269);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(120, 19);
            label2.TabIndex = 2;
            label2.Text = "Mot de passe :";
            // 
            // userTxt
            // 
            userTxt.Location = new Point(257, 222);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(230, 23);
            userTxt.TabIndex = 3;
            
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(257, 317);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(230, 23);
            passwordTxt.TabIndex = 4;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // connect
            // 
            connect.BackColor = Color.DodgerBlue;
            connect.Location = new Point(388, 376);
            connect.Name = "connect";
            connect.Size = new Size(99, 47);
            connect.TabIndex = 5;
            connect.Text = "Connecter";
            connect.UseVisualStyleBackColor = false;
            connect.Click += connect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(connect);
            Controls.Add(passwordTxt);
            Controls.Add(userTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Connexion";
            
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox userTxt;
        private TextBox passwordTxt;
        private Button connect;
    }
}
