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


        // Événement de validation de la commande
        private void btnValiderCommande_Click(object sender, EventArgs e)
        {
            // Validation de la sélection de table
            if (cbTable.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une table.");
                return;
            }

            int Idcommande;
            int Idtable = (int)cbTable.SelectedValue;
            string Commentaireclient = rtbCommentaire.Text;

            // Création de la commande
            if (ModeleCommande.AjouterCommande(Idtable, Commentaireclient))
            {
                // Récupération de l'ID de la commande nouvellement créée
                Idcommande = ModeleCommande.listeCommande().Last().Idcommande;
                MessageBox.Show("Commande ajoutée");

                // Ajout des plats à la commande
                foreach (DataGridViewRow row in dgvChoixPlat.Rows)
                {
                    // Vérifier si le plat est sélectionné
                    if (row.Cells[2].Value != null && bool.TryParse(row.Cells[2].Value.ToString(), out bool isChecked) && isChecked)
                    {
                        int IdPlat = int.Parse(row.Cells[0].Value.ToString());
                        string nomPlat = row.Cells[1].Value.ToString();

                        // Lire la quantité (colonne 3)
                        int quantite;

                        // Si la quantité est vide, utiliser la quantité par défaut (1)
                        if (row.Cells[3].Value == null || string.IsNullOrWhiteSpace(row.Cells[3].Value.ToString()))
                        {
                            quantite = 1;
                        }
                        // Si la quantité est invalide (texte ou nombre négatif), afficher un message d'erreur et passer au plat suivant
                        else if (!int.TryParse(row.Cells[3].Value.ToString(), out quantite) || quantite <= 0)
                        {
                            MessageBox.Show($"Erreur : La quantité pour le plat '{nomPlat}' est invalide. Veuillez entrer un nombre positif.", "Erreur de quantité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue; // Passer au plat suivant
                        }

                        // Ajouter autant d'instances du plat que la quantité spécifiée
                        for (int i = 0; i < quantite; i++)
                        {
                            string Idinstance = Guid.NewGuid().ToString(); // Génère un ID unique pour chaque instance

                            // Ajouter l'instance du plat à la commande
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
                    ReinitialiserFormulaire();
                }

                // Marquer la table comme non disponible
                ModeleTabler.MettreTableNonDisponible(Idtable);

                // Réinitialiser le formulaire
                ReinitialiserFormulaire();

                // Sauvegarder les changements en base de données
                Modele.MonModel.SaveChanges();
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