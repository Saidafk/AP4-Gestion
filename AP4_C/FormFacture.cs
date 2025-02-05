using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using AP4_C.Controller;
using AP4_C.Entities;
using AP4_C.Model;
using Microsoft.EntityFrameworkCore;

namespace AP4_C
{
    public partial class FormFacture : Form
    {
        public FormFacture()
        {
            InitializeComponent();
        }


        private void ResetForm()
        {
            cbFacture.SelectedIndex = -1;
            txtTicket.Text = string.Empty;
            dtpDateFacture.Value = DateTime.Now;
            txtTable.Text = string.Empty;
            txtMoyenP.Text = string.Empty;
            dgvCommande.DataSource = null;
            tbPrixTVA.Text = string.Empty;
            txtPrix.Text = string.Empty;
            gbInfoFacture.Visible = false;
        }


        public void RemplirFacture()
        {

            cbFacture.ValueMember = "Idfacture"; // permet de stocker l'identifiant
            cbFacture.DisplayMember = "Idfacture"; // affiche l'identifiant
            bsFacture.DataSource = ModeleFacture.listeFacture().Select(x => new { x.Idfacture }).ToList();
            cbFacture.DataSource = bsFacture;
            cbFacture.SelectedIndex = -1;
        }

        private void cbFacture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFacture.SelectedIndex != -1 && cbFacture.SelectedValue != null)
            {
                int idF = Convert.ToInt32(cbFacture.SelectedValue);
                AP4_C.Entities.Facture F = ModeleFacture.RetourneFacture(idF);
                gbInfoFacture.Visible = true;
            }
            else
            {
                gbInfoFacture.Visible = false;
            }

            if (cbFacture.SelectedValue != null)
            {
                int idFacture = (int)cbFacture.SelectedValue;

                var facture = ModeleFacture.RetourneFacture(idFacture);
                if (facture == null)
                {
                    MessageBox.Show("Aucune facture trouvée pour l'ID sélectionné.");
                    return;
                }

                var commande = ModeleCommande.RetourneCommande(facture.Idcommande);
                if (commande == null)
                {
                    MessageBox.Show("Aucune commande trouvée pour l'ID de la facture.");
                    return;
                }

                txtTicket.Text = facture.Idfacture.ToString();
                if (facture.Datefacture >= dtpDateFacture.MinDate && facture.Datefacture <= dtpDateFacture.MaxDate)
                {
                    dtpDateFacture.Value = facture.Datefacture ?? DateTime.Now;
                }
                else
                {
                    MessageBox.Show("La date de la facture est invalide.");
                }
                txtTable.Text = commande.Idtable.ToString();

                var moyenPaiement = ModeleMoyenP.RetourneMoyenPaiement(facture.Idmoyenpaiement);
                if (moyenPaiement != null)
                {
                    txtMoyenP.Text = moyenPaiement.Libellemoyenpaiement;
                }
                else
                {
                    txtMoyenP.Text = "Moyen de paiement inconnu";
                }

                affichageCommandes();
            }
        }
        private void affichageCommandes()
        {
            try
            {
                if (cbFacture.SelectedValue != null)
                {
                    int idFacture = Convert.ToInt32(cbFacture.SelectedValue);

                    var facture = ModeleFacture.listeFacture()
                        .FirstOrDefault(x => x.Idfacture == idFacture);

                    if (facture == null)
                    {
                        MessageBox.Show("Aucune facture trouvée pour l'ID sélectionné.");
                        return;
                    }

                    int idCommande = facture.Idcommande;

                    var instancesDePlat = ModeleInstancePlat.listeInstancePlat()
                        .Where(x => x.Idcommande == idCommande)
                        .ToList();

                    if (!instancesDePlat.Any())
                    {
                        MessageBox.Show("Aucune instance de plat trouvée pour cette commande.");
                        dgvCommande.DataSource = null;
                        return;
                    }

                    var CommandeAffiches = instancesDePlat
                        .Select(x => new
                        {
                            NomPlat = ModelePlat.RentourneNomPlat(x.Idplat)?.Libelleplat,
                            PrixPlat = ModelePlat.RentourneNomPlat(x.Idplat)?.Prixplatht,
                        })
                        .ToList();

                    
                    dgvCommande.DataSource = CommandeAffiches;

                    decimal totalPrix = CommandeAffiches.Sum(plat => (decimal)(plat.PrixPlat ?? 0));

                    
                    tbPrixTVA.Text = $"Total TVA (20%): {(totalPrix * 0.2m):C}";
                    txtPrix.Text = $"Total Prix: {totalPrix:C}";
                }
                else
                {
                    dgvCommande.DataSource = null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }

        private void FormFacture_Load(object sender, EventArgs e)
        {


        }
        private void FormFacture_Load_1(object sender, EventArgs e)
        {
            RemplirFacture();
            affichageCommandes();

        }

        private void btnGenererPDF_Click(object sender, EventArgs e)
        {
            if (cbFacture.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une facture.");
                return;
            }

            int idFacture = (int)cbFacture.SelectedValue;
            int idTable = int.Parse(txtTable.Text);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Enregistrer la facture";
                saveFileDialog.FileName = $"Facture_{idFacture}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        GenererPDF.CreerPDF(saveFileDialog.FileName, idFacture);
                        MessageBox.Show($"Facture générée avec succès : {saveFileDialog.FileName}");
                        ModeleTabler.MettreTableDisponible(idTable);

                        ResetForm();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la génération du PDF : {ex.Message}");
                    }
                }
            }          
        }
    }
}

