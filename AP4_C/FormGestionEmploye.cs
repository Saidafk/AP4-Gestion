using AP4_C.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP4_C.Entities;


namespace AP4_C
{
    public partial class FormGestionEmploye : Form
    {
        public FormGestionEmploye()
        {
            InitializeComponent();
            label2.Visible = false;
            cmbFiltreRole.Visible = false;
        }

        private void pnlGestionEmploye_Paint(object sender, PaintEventArgs e)
        {

        }

        public void affichageEmploye(string? filtreNom = null, string? filtreRole = null)
        {
            try
            {
                var EmployeAffiches = ModelEmploye.listeEmployes()
                    .Where(x => string.IsNullOrEmpty(filtreNom) || x.Nom.Contains(filtreNom, StringComparison.OrdinalIgnoreCase))
                    .Select(x => new
                    {
                        //Id = x.Id,
                        Nom = x.Nom,
                        Prenom = x.Prenom,
                        Email = x.Email,
                        Cuisinier = ModelEmploye.listeCuisiniers().Any(c => c.Idper == x.Id),
                        Serveur = ModelEmploye.listeServeurs().Any(s => s.Idper == x.Id)
                    })
                    .ToList();

                //Console.WriteLine($"Valeur de filtreRole : '{filtreNom}'");

                if (filtreRole == "Cuisinier")
                {
                    EmployeAffiches = EmployeAffiches.Where(x => x.Cuisinier).ToList();
                    var cuisiniers = ModelEmploye.listeCuisiniers();
                    var employes = ModelEmploye.listeEmployes();

                    foreach (var employe in employes)
                    {
                        bool estCuisinier = cuisiniers.Any(c => c.Idper == employe.Id);
                        Console.WriteLine($"Employé {employe.Nom} est cuisinier : {estCuisinier}");
                    }
                }

                else if (filtreRole == "Serveur")
                {
                    EmployeAffiches = EmployeAffiches.Where(x => x.Serveur).ToList();
                }

                EmployeDgv.DataSource = EmployeAffiches;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }

        public void Filtre()
        {
            string filtreRole = cmbFiltreRole.SelectedItem?.ToString();
            string filtreNom = txtFiltreEmp.Text.Trim();
            affichageEmploye(filtreNom, filtreRole);
        }

        private void FormGestionEmploye_Load(object sender, EventArgs e)
        {


            cmbFiltreRole.Items.AddRange(new string[] { "Tous", "Cuisinier", "Serveur" });
            cmbFiltreRole.SelectedIndex = 0;
            string filtreRole = cmbFiltreRole.SelectedItem?.ToString();
            Console.WriteLine($"Valeur sélectionnée : '{filtreRole}'");


            affichageEmploye();
        }

        private void EmployeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFiltreEmp_TextChanged(object sender, EventArgs e)
        {
            Filtre();
        }

        private void EmployeBs_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = EmployeBs.Current.GetType();
            ulong idE = (ulong)type.GetProperty("Id").GetValue(EmployeBs.Current, null);
            if(MessageBox.Show("Voulez-vous vraiment supprimer cet employé ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ModelEmploye.SupprEmploye(idE);
                MessageBox.Show("Employé supprimé avec succès.");
            }
        }
    }
}

