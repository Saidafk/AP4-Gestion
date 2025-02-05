using AP4_C.Controller;
using static AP4_C.Controller.Controller;
using AP4_C.Entities;
using AP4_C.Model;
using Aspose.Pdf.Operators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                if (!Controller.Controller.ValidMail(EmailPersonnel))
                {
                    MessageBox.Show("Veuillez saisir une adresse e-mail valide.");
                    return;
                }
                if (ModelUser.RecupererUser(EmailPersonnel)!=null)
                {
                    MessageBox.Show("Cet e-mail est déjà utilisé par un autre employé.");
                    return;
                }

                MessageBox.Show("serveur : " + estServeur);
                MessageBox.Show("cuisinier : " + estCuisinier);

                if (ModelUser.AjouterNouveauPersonnel(NomPersonnel, PrenomPersonnel, EmailPersonnel))
                {
                    MessageBox.Show("Personnel ajouté");
                    
                    RemplirlesEmploye();
                    ResetForm();
                    

                }
                Idper = ModelUser.listeUsers().Last().Id;
                MessageBox.Show("id personnel : " + Idper);
                ModelePersonnel.ajoutPers(Idper);
                ModelEmploye.ajoutEmp(Idper);

                if (estCuisinier == true && estServeur == true)
                {
                    MessageBox.Show("Il ne peut pas être les deux à la fois");
                    return;
                }
                else if (estServeur)
                {
                    ModeleServeur.NouveauServeur(Idper);
                    MessageBox.Show("Serveur ajouté");
                    return;
                }
                else if (estCuisinier)
                {
                    ModeleCuisinier.NouveauCuisinier(Idper);
                    MessageBox.Show("Cuisinier ajouté");
                    return;
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du personnel");
                    return;
                }
            }
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

