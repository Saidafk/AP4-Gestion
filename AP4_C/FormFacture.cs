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

        /*public void RemplirTicket()
        {

            cbTicket.ValueMember = "Idfacture"; // permet de stocker l'identifiant
            cbTicket.DisplayMember = "Idfacture"; // affiche l'identifiant
            bsFacture.DataSource = ModeleFacture.listeFacture().Select(x => new { x.Idfacture }).ToList();
            cbTicket.DataSource = bsFacture;
            cbTicket.SelectedIndex = -1;
        }*/

        public void RemplirTable()
        {

            cbTable.ValueMember = "Idtable"; // permet de stocker l'identifiant
            cbTable.DisplayMember = "Idtable"; // affiche l'identifiant
            bsTable.DataSource = ModeleTable.listeTable().Select(x => new { x.Idtable }).ToList();
            cbTable.DataSource = bsTable;
            cbTable.SelectedIndex = -1;
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


                if (facture != null)
                {
                    cbTicket.Text = facture.Idfacture.ToString();
                    dtpDateFacture.Value = facture.Datefacture;
                    cbTable.Text = facture.Idtable.ToString();

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
                    int idFacture = Convert.ToInt32(cbFacture.SelectedValue);

                    var CommandeAffiches = ModeleCommande.listeCommande()
                        .Where(x => x.Idfacture == idFacture)
                        .Select(x => new
                        {
                            NomPlat = ModelePlat.RentourneNomPlat(x.Idplat)?.Libelleplat
                        })
                        .ToList();

                    dgvCommande.DataSource = CommandeAffiches;
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
            RemplirFacture();
            RemplirTable();
            affichageCommandes();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbFacture.SelectedValue != null)
            {
                int Idfacture = (int)cbFacture.SelectedValue;
                int Idtable = int.Parse(cbTable.Text);
                DateTime Datefacture = dtpDateFacture.Value;

                if (ModeleFacture.ModifierFacture(Idfacture, Datefacture, Idtable))
                {
                    MessageBox.Show("Facture modifiée");
                    RemplirFacture();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une facture.");
            }
        }
    }
}

