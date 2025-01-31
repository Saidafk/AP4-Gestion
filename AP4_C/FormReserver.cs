using AP4_C.Entities;
using AP4_C.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP4_C
{
    public partial class FormReserver : Form
    {
        public FormReserver()
        {
            InitializeComponent();
            btnAjouterPlat.Click += btnAjouterPlat_Click;
        }

        private void FormReserver_Load(object sender, EventArgs e)
        {
            RemplirTable();
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

            /*cbTable.ValueMember = "Idtable"; // permet de stocker l'identifiant
            cbTable.DisplayMember = "Idtable"; // affiche l'identifiant
            bsTable.DataSource = ModeleTable.listeTable().Select(x => new { x.Idtable }).ToList();
            cbTable.DataSource = bsTable;
            cbTable.SelectedIndex = -1;*/
        }

        public void button1_Click(object sender, EventArgs e)
        {
            AjouterComboBoxPlat();
            ulong Idcommande;
            int Idtable = (int)cbTable.SelectedValue;
            int Idplat = (int)cbPlat.SelectedValue;
            string Commentaireclient = rtbCommentaire.Text;

            if (ModeleCommande.AjouterCommande(Idtable, Commentaireclient) && ModeleInstancePlat.AjouterInstancePlat(Idplat))
            {
                RemplirTable();
                
                MessageBox.Show("Commande ajouté");

            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de la commande");
            }
        }

        private void flowLayoutPanelPlats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAjouterPlat_Click(object sender, EventArgs e)
        {
            AjouterComboBoxPlat();
        }

        /*private List<int> ObtenirPlatsSelectionnes()
        {
            List<int> platsSelectionnes = new List<int>();

            foreach (Control control in flowLayoutPanelPlats.Controls)
            {
                if (control is ComboBox cbPlat && cbPlat.SelectedValue != null)
                {
                    platsSelectionnes.Add((int)cbPlat.SelectedValue);
                }
            }
            return platsSelectionnes;
        }*/

        public void AjouterComboBoxPlat()
        {
            ComboBox cbPlat = new ComboBox();
            cbPlat.Width = 200;
            cbPlat.DropDownStyle = ComboBoxStyle.DropDownList;

            cbPlat.ValueMember = "Idplat"; // permet de stocker l'identifiant
            cbPlat.DisplayMember = "Libelleplat"; // affiche l'identifiant
            bsListePlats.DataSource = ModelePlat.listePlats().Select(x => new { x.Idplat, x.Libelleplat }).ToList();
            cbPlat.DataSource = bsListePlats;
            cbPlat.SelectedIndex = -1;

            flowLayoutPanelPlats.Controls.Add(cbPlat);
        }

        /*private void CreerCommande()
        {
            List<int> platsSelectionnes = ObtenirPlatsSelectionnes();

            if (platsSelectionnes.Count > 0)
            {
                Commande commande = new Commande();
                InstancePlat instancePlat = new InstancePlat();

                foreach (int platId in platsSelectionnes)
                {
                    Plat plat = ModelePlat.RetournePlat(platId);
                    if (plat != null)
                    {
                        string Libelleplat = plat.Libelleplat;

                    }
                }

                SystemeReservation systemeReservation = new SystemeReservation();
                systemeReservation.CreerReservation(commande);

                MessageBox.Show("Commande créée avec succès !");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner au moins un plat.");
            }*/
    }
}


