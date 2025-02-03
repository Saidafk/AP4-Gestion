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
                Facture F = ModeleFacture.RetourneFacture(idF);
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
                var commande = ModeleCommande.RetourneCommande(idFacture);



                if (facture != null && commande != null)
                {
                    txtTicket.Text = facture.Idfacture.ToString();
                    dtpDateFacture.Value = facture.Datefacture;
                    txtTable.Text = commande.Idtable.ToString();

                    affichageCommandes();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la récupération de la facture.");
                }
            }
        }
        private void affichageCommandes()
        {
            try
            {
                if (cbFacture.SelectedValue != null)
                {
                    int idInstanceDePlat = Convert.ToInt32(cbFacture.SelectedValue);

                    var CommandeAffiches = ModeleInstancePlat.listeInstancePlat()
                        .Where(x => x.Idcommande == idInstanceDePlat)
                        .Select(x => new
                        {
                            NomPlat = ModelePlat.RentourneNomPlat(x.Idplat)?.Libelleplat,
                            PrixPlat = ModelePlat.RentourneNomPlat(x.Idplat)?.Prixplatht,
                        })
                        .ToList();

                    dgvCommande.DataSource = CommandeAffiches;

                    decimal totalPrix = 0;

                    foreach (var plat in CommandeAffiches)
                    {
                        if (plat.PrixPlat.HasValue)
                        {
                            totalPrix = totalPrix + (decimal)plat.PrixPlat;
                        }
                    }

                    //tbPrixTVA.Text = $"Total Prix TTC: {totalPrix * 1.2m:C}";
                    tbPrixTVA.Text = $"Total TVA (20%): {(totalPrix * 0.2m):C}";
                    txtPrix.Text = $"Total Prix: {totalPrix:C}";

                }
                else
                {
                    dgvCommande.DataSource = null; // or clear the datagridview
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

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Enregistrer la facture";
                saveFileDialog.FileName = $"Facture_{idFacture}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Appeler la méthode de génération du PDF
                        GenererPDF.CreerPDF(saveFileDialog.FileName, idFacture);
                        MessageBox.Show($"Facture générée avec succès : {saveFileDialog.FileName}");
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

