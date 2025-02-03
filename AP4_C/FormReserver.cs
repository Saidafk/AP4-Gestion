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
            var tablesDisponibles = ModeleTable.listeTable()
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
            //string Idinstance = Guid.NewGuid().ToString();  // Génère un ID unique pour l'instance

            // Création de la commande
            if (ModeleCommande.AjouterCommande(Idtable, Commentaireclient))
            {
                // Récupération de l'ID de la commande nouvellement créée
                Idcommande = ModeleCommande.listeCommande().Last().Idcommande;
                MessageBox.Show("Commande ajoutée");

                // Ajout des plats à la commande
                foreach (DataGridViewRow row in dgvChoixPlat.Rows)
                {
                    if (row.Cells[2].Value != null && bool.TryParse(row.Cells[2].Value.ToString(), out bool isChecked) && isChecked)
                    {
                        int IdPlat = int.Parse(row.Cells[0].Value.ToString());

                        string Idinstance = Guid.NewGuid().ToString();

                        MessageBox.Show("l'id commande est " + Idcommande);
                        MessageBox.Show("l'id plat est " + IdPlat);
                        MessageBox.Show("l'id instance est " + Idinstance);
                        // Ajouter l'instance du plat à la commande
                        if (ModeleInstancePlat.AjouterInstancePlat(Idcommande, IdPlat, Idinstance))
                        {
                            MessageBox.Show($"Plat {row.Cells[1].Value} ajouté à la commande.");
                        }
                        else
                        {
                            MessageBox.Show($"Erreur lors de l'ajout du plat {row.Cells[1].Value}.");
                        }
                    }
                }

                ReinitialiserFormulaire();
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