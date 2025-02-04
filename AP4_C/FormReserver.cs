﻿using AP4_C.Entities;
using AP4_C.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AP4_C
{
    public partial class FormReserver : Form
    {
        public FormReserver()
        {
            InitializeComponent();
            btnValiderCommande.Click += btnValiderCommande_Click;
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
            int Idtable = (int)cbTable.SelectedValue;
            string Commentaireclient = rtbCommentaire.Text;

            if (ModeleCommande.AjouterCommande(Idtable, Commentaireclient))
            {
                Idcommande = ModeleCommande.listeCommande().Last().Idcommande;
                //MessageBox.Show("Commande ajoutée");

                foreach (DataGridViewRow row in dgvChoixPlat.Rows)
                {
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
                            MessageBox.Show($"Erreur : La quantité pour le plat '{nomPlat}' est invalide. Veuillez entrer un nombre positif.", "Erreur de quantité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        for (int i = 0; i < quantite; i++)
                        {
                            string Idinstance = Guid.NewGuid().ToString();

                            if (ModeleInstancePlat.AjouterInstancePlat(Idcommande, IdPlat, Idinstance))
                            {
                                MessageBox.Show($"Plat '{nomPlat}' (instance {i + 1}) ajouté à la commande.");
                            }
                            else
                            {
                                MessageBox.Show($"Erreur lors de l'ajout du plat '{nomPlat}' (instance {i + 1}).");
                            }
                        }
                    }
                }

                //ReinitialiserFormulaire();
                ModeleTabler.MettreTableNonDisponible(Idtable);
                MessageBox.Show("Commande passé");
            }
            else
            {
                MessageBox.Show("Erreur lors de la création de la commande.");
            }
        }


        // Méthode pour réinitialiser le formulaire après une commande
        private void ReinitialiserFormulaire()
        {
            cbTable.SelectedIndex = -1;
            rtbCommentaire.Clear();
            RemplirDataGridViewPlats();
        }

        private void flowLayoutPanelPlats_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}