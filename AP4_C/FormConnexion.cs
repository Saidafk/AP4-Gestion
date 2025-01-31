using System;
using System.Linq;
using System.Windows.Forms;
using AP4_C.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using static AP4_C.Controller.Controller;
using static AP4_C.Model.ModelUser;


namespace AP4_C
{
    // FormConnexion.cs

    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            string user = userTxt.Text;
            string mdp = passwordTxt.Text;

            if (user != "" && ValidMail(user) && passwordTxt.Text != "")
            {
                if (presenceUser(user))
                {
                    if (estAdmin(user))
                    {
                        User unUser = RecupererUser(user);
                        string hash = unUser.Mdp;

                        if (BCrypt.Net.BCrypt.Verify(mdp, hash))
                        {
                            MessageBox.Show("Connexion réussie !");

                            // Passer l'utilisateur connecté à FormMenu
                            FormMenu Accueil = new FormMenu(unUser);
                            Accueil.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Email ou mot de passe invalide.");
            }
        }
    }
}