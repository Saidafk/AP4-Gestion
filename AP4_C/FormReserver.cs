using AP4_C.Entities;
using AP4_C.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AP4_C
{
    public partial class FormReserver : Form
    {

        private bool isCommandeButtonPressed = false;
        public FormReserver()
        {
            InitializeComponent();            
        }

        public void RemplirDataGridViewPlats()
        {
            // Récupère la liste des plats avec leur ID et libellé
            var plats = ModelePlat.listePlats().Select(x => new { x.Idplat, x.Libelleplat }).ToList();

            // Nettoie les colonnes existantes
            dgvChoixPlat.Columns.Clear();
            dgvChoixPlat.AutoGenerateColumns = false;

            // Colonne ID (cachée)
            DataGridViewTextBoxColumn colIdPlat = new DataGridViewTextBoxColumn();
            colIdPlat.HeaderText = "ID";
            colIdPlat.DataPropertyName = "Idplat";
            colIdPlat.Visible = false;
            dgvChoixPlat.Columns.Add(colIdPlat);

            // Colonne Nom du Plat
            DataGridViewTextBoxColumn colNomPlat = new DataGridViewTextBoxColumn();
            colNomPlat.HeaderText = "Nom du Plat";
            colNomPlat.DataPropertyName = "Libelleplat";
            dgvChoixPlat.Columns.Add(colNomPlat);

            // Colonne Sélection (Checkbox)
            DataGridViewCheckBoxColumn colSelection = new DataGridViewCheckBoxColumn();
            colSelection.HeaderText = "Sélectionner";
            dgvChoixPlat.Columns.Add(colSelection);

            // Colonne Quantité
            DataGridViewTextBoxColumn colQuantite = new DataGridViewTextBoxColumn();
            colQuantite.HeaderText = "Quantité";
            dgvChoixPlat.Columns.Add(colQuantite);

            dgvChoixPlat.DataSource = plats;
        }


        private void FormReserver_Load(object sender, EventArgs e)
        {
            RemplirTable();
            RemplirDataGridViewPlats();
            RemplirMoyenP();
        }

        public void RemplirTable()
        {
            var tablesDisponibles = ModeleTabler.listeTable()
                .Where(t => t.Estdispo == true)
                .Select(t => new { t.Idtable })
                .ToList();

            cbTable.DataSource = tablesDisponibles;
            cbTable.ValueMember = "Idtable";
            cbTable.DisplayMember = "Nomtable";
            cbTable.SelectedIndex = -1;
        }

        public void RemplirMoyenP()
        {
            cbMoyenP.ValueMember = "Idmoyenpaiement";
            cbMoyenP.DisplayMember = "Libellemoyenpaiement";
            bsMoyenP.DataSource = (ModeleMoyenP.listeMoyenP()).Select(x => new { x.Idmoyenpaiement, x.Libellemoyenpaiement });
            cbMoyenP.DataSource = bsMoyenP;
            cbMoyenP.SelectedIndex = -1;
        }

        // Événement de validation de la commande
        private void btnValiderCommande_Click(object sender, EventArgs e)
        {
            int Idcommande;
            string Commentaireclient = rtbCommentaire.Text;

            int idMoyenPaiement = cbMoyenP.SelectedValue != null ? (int)cbMoyenP.SelectedValue : -1;
            if (idMoyenPaiement == -1)
            {
                MessageBox.Show("Veuillez sélectionner un moyen de paiement.");
                return;
            }

            int Idtable = cbTable.SelectedValue != null ? (int)cbTable.SelectedValue : -1;
            if (Idtable == -1)
            {
                MessageBox.Show("Veuillez sélectionner une table.");
                return;
            }

            if (ModeleCommande.AjouterCommande(Idtable, Commentaireclient))
            {
                Idcommande = ModeleCommande.listeCommande().Last().Idcommande;
                bool tousLesPlatsAjoutes = true;

                for (int i = 0; i < dgvChoixPlat.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvChoixPlat.Rows[i];
                    if (row.Cells[2].Value != null && bool.TryParse(row.Cells[2].Value.ToString(), out bool isChecked) && isChecked)
                    {
                        int IdPlat = int.Parse(row.Cells[0].Value.ToString());
                        string nomPlat = row.Cells[1].Value.ToString();
                        int quantite;

                        if (row.Cells[3].Value == null || string.IsNullOrWhiteSpace(row.Cells[3].Value.ToString()))
                        {
                            quantite = 1;
                        }
                        else if (!int.TryParse(row.Cells[3].Value.ToString(), out quantite) || quantite <= 0)
                        {
                            MessageBox.Show($"Erreur : La quantité pour le plat '{nomPlat}' est invalide.");
                            continue;
                        }

                        // Ajout des instances sans messages individuels
                        for (int j = 0; j < quantite; j++)
                        {
                            string Idinstance = Guid.NewGuid().ToString();
                            if (!ModeleInstancePlat.AjouterInstancePlat(Idcommande, IdPlat, Idinstance))
                            {
                                tousLesPlatsAjoutes = false;
                                MessageBox.Show($"Erreur lors de l'ajout du plat '{nomPlat}'.");
                                break;
                            }
                        }

                        // Mettre à jour la quantité du plat
                        bool quantiteMiseAJour = ModelePlat.MettreAJourQuantitePlat(IdPlat, quantite);
                        if (!quantiteMiseAJour)
                        {
                            MessageBox.Show($"Erreur lors de la mise à jour de la quantité du plat '{nomPlat}'.");
                            tousLesPlatsAjoutes = false;
                        }
                    }
                }

                DateTime dateFacture = DateTime.Now;
                ModeleFacture.NouvelleFacture(Idcommande, idMoyenPaiement, 20, dateFacture);
                ModeleTabler.MettreTableNonDisponible(Idtable);
                RemplirTable();

                if (tousLesPlatsAjoutes)
                {
                    MessageBox.Show("Commande passée avec succès!");
                    ReinitialiserFormulaire();
                }
            }
            else
            {
                MessageBox.Show("Erreur lors de la création de la commande.");
            }
            isCommandeButtonPressed = false;
        }




        // Méthode pour réinitialiser le formulaire après une commande
        private void ReinitialiserFormulaire()
        {
            cbTable.SelectedIndex = -1;
            cbMoyenP.SelectedIndex = -1;
            rtbCommentaire.Clear();
            RemplirDataGridViewPlats();
        }

        private void flowLayoutPanelPlats_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}