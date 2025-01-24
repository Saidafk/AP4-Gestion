using AP4_C.Entities;
using AP4_C.Model;
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

                tbNom.Visible = true;
                tbPrenom.Visible = true;
                cbEmploye.Visible = false;
                

            }
            else if (etatemploye == EtatGestionEmploye.UpdateEmploye)
            {
                labelemploye.Text = "Modification d'un employé";
                buttonemploye.Text = "MODIFIER";
                gbinfoEmployer.Visible = false;
                cbEmploye.Visible = true;
                
                
            }

            RemplirlesEmploye();

        }

        public void RemplirlesEmploye()
        {

            cbEmploye.ValueMember = "Id";
            cbEmploye.DisplayMember = "NomComplet";
            EmployeBS.DataSource = (ModelEmploye.listeEmployes()).Select(x => new { x.Id, NomComplet = x.Nom+" "+x.Prenom });
            cbEmploye.DataSource = EmployeBS;
            cbEmploye.SelectedIndex = -1;

        }

        private void cbPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (etatemploye==EtatGestionEmploye.UpdateEmploye)
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
                        MessageBox.Show("Erreur lors de la récupération des données du plat.");
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

            
                

                if (etatemploye == EtatGestionEmploye.CreateEmploye)
                {
                    if (string.IsNullOrEmpty(NomPersonnel) || string.IsNullOrEmpty(PrenomPersonnel) || string.IsNullOrEmpty(EmailPersonnel))
                    {
                        MessageBox.Show("Veuillez remplir tous les champs obligatoires");
                        return;
                    }

                    if (ModelUser.AjouterNouveauPersonnel(NomPersonnel, PrenomPersonnel, EmailPersonnel))
                    {
                        MessageBox.Show("Personnel ajouté");
                        RemplirlesEmploye();
                        
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout du personnel");
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
                        MessageBox.Show("Plat modifié");
                        RemplirlesEmploye();
                        
                    }
                }
            }
        
    }
}

