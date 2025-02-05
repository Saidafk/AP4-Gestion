﻿using AP4_C.Controller;
using AP4_C.Entities;
using AP4_C.Model;
using Aspose.Pdf.Operators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP4_C
{

    public enum EtatGestionEmploye
    {
        CreateEmploye,
        UpdateEmploye
    }
    public partial class FormAjoutModifPersonnel : Form
    {
        private EtatGestionEmploye etatemploye;
        public FormAjoutModifPersonnel(EtatGestionEmploye etatemploye)
        {
            InitializeComponent();
            this.etatemploye = etatemploye;

        }


        private void FormAjoutModifPersonnel_Load(object sender, EventArgs e)
        {

            if (etatemploye == EtatGestionEmploye.CreateEmploye) // cas etat create
            {
                labelemploye.Text = "Ajout d'un nouvel employé";
                buttonemploye.Text = "AJOUTER";
                btnMDP.Text = "Generer un mot de passe";

                tbNom.Visible = true;
                tbPrenom.Visible = true;
                cbEmploye.Visible = false;
                btnMDP.Visible = true;

            }
            else if (etatemploye == EtatGestionEmploye.UpdateEmploye)
            {
                labelemploye.Text = "Modification d'un employé";
                buttonemploye.Text = "MODIFIER";
                btnMDP.Text = "Re generer un mot de passe";
                //labelMDP.Text = "Re generer un mot de passe"; 

                ckbCuisinier.Visible = false;
                ckbServeur.Visible = false;
                lbCuisinier.Visible = false;
                lbServeur.Visible = false;  
                gbinfoEmployer.Visible = false;
                cbEmploye.Visible = true;
            }
            RemplirlesEmploye();
        }

        public void RemplirlesEmploye()
        {
            cbEmploye.ValueMember = "Id";
            cbEmploye.DisplayMember = "NomComplet";
            EmployeBS.DataSource = (ModelEmploye.listeEmployes()).Select(x => new { x.Id, NomComplet = x.Nom + " " + x.Prenom });
            cbEmploye.DataSource = EmployeBS;
            cbEmploye.SelectedIndex = -1;
        }

        private void cbPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (etatemploye == EtatGestionEmploye.UpdateEmploye)
            {
                if (cbEmploye.SelectedIndex != -1 && cbEmploye.SelectedValue != null)
                {
                    ulong idEmploye = Convert.ToUInt64(cbEmploye.SelectedValue);
                    Employe E = ModelEmploye.RetourneEmploye(idEmploye);
                    cbEmploye.Visible = true;
                    gbinfoEmployer.Visible = true;
                }
                else
                {
                    gbinfoEmployer.Visible = false;
                }

                if (cbEmploye.SelectedValue != null)
                {
                    ulong idPer;
                    idPer = (ulong)cbEmploye.SelectedValue;

                    var employe = ModelUser.RetourneUser(idPer);

                    if (employe != null)
                    {

                        tbNom.Text = employe.Nom;
                        tbPrenom.Text = employe.Prenom;
                        tbEmail.Text = employe.Email;

                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données du personnel.");
                    }
                }
            }
        }

        public static void EnvoyerEmailNouveauMembre(string destinataire, string sujet, string corps)
        {

            string to = destinataire;
            string from = "Camoel@gmail.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "";
            message.Body = "";
            SmtpClient client = new SmtpClient();

            client.Host = "mail.dombtsig.local";
            client.Port = 1025;

            client.UseDefaultCredentials = true;
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());

            }
        }

        private void buttonemploye_Click(object sender, EventArgs e)
        {
            ulong Idper;
            string NomPersonnel = tbNom.Text;
            string PrenomPersonnel = tbPrenom.Text;
            string EmailPersonnel = tbEmail.Text;
            string motDePasseHache = txtMDP.Text;
            bool estCuisinier = ckbCuisinier.Checked;
            bool estServeur = ckbServeur.Checked;

            if (etatemploye == EtatGestionEmploye.CreateEmploye)
            {
                if (string.IsNullOrEmpty(NomPersonnel) || string.IsNullOrEmpty(PrenomPersonnel) || string.IsNullOrEmpty(EmailPersonnel))
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires");
                    return;
                }

                //MessageBox.Show("serveur : " + estServeur);
                //MessageBox.Show("cuisinier : " + estCuisinier);

                if (ModelUser.AjouterNouveauPersonnel(NomPersonnel, PrenomPersonnel, EmailPersonnel))
                {
                    if (!Email.ValidMail(EmailPersonnel))
                    {
                        MessageBox.Show("Adresse e-mail invalide");
                        return;
                    }

                    string email = EmailPersonnel;
                    string sujet = "Bienvenue dans l'équipe";
                    string corps = $"Bonjour {PrenomPersonnel} {NomPersonnel},\n\nBienvenue dans l'équipe !\n\nVoici vos identifiants de connexion :\nUtilisateur: {EmailPersonnel}\nMot de passe : {motDePasseHache}\n\nCordialement,\nL'équipe RH";

                    MessageBox.Show("Personnel ajouté");
                    RemplirlesEmploye();

                    Email.EnvoyerEmailNouveauMembre(email, sujet, corps);
                    ResetForm();
                }
                //Idper = ModelUser.listeUsers().Last().Id;
                //MessageBox.Show("id personnel : " + Idper);

                /*if (ckbCuisinier.Checked == true && ckbServeur.Checked == true)
                {
                    MessageBox.Show("Il ne peut pas être les deux à la fois");
                    return;
                }
                if (ckbServeur.Checked)
                {
                    estServeur = true;
                }
                if (ckbCuisinier.Checked)
                {
                    ModeleCuisinier.NouveauCuisinier(Idper);
                    MessageBox.Show("Cuisinier ajouté");
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du personnel");
                }
            */
                else if (etatemploye == EtatGestionEmploye.UpdateEmploye)
                {
                    if (cbEmploye.SelectedValue != null)
                    {
                        Idper = (ulong)cbEmploye.SelectedValue;
                    }
                    else
                    {
                        MessageBox.Show("Veuillez sélectionner un personnel à modifier.");
                        return;
                    }

                    if (ModelUser.ModifierUser(Idper, NomPersonnel, PrenomPersonnel, EmailPersonnel))
                    {
                        MessageBox.Show("Personnel modifié");
                        RemplirlesEmploye();
                        ResetForm();
                    }
                }
            }
        }

        private void ResetForm()
        {
            tbNom.Text = "";
            tbPrenom.Text = "";
            tbEmail.Text = "";
            ckbCuisinier.Checked = false;
            ckbServeur.Checked = false;
        }
        private void panelAjoutModif_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMDP_Click(object sender, EventArgs e)
        {
            
            string motDePasse = GenererUnMDP.GenerateRandomPassword();
            txtMDP.Text = motDePasse;
        }
    }
}

