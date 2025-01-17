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
        }

        private void pnlGestionEmploye_Paint(object sender, PaintEventArgs e)
        {

        }

        private void affichageEmploye()
        {
            try
            {
                var EmployeAffiches = ModelEmploye.listeEmployes()

            .Select(x => new
            {
                Id = x.Id,
                Nom = x.Nom,
                Prenom = x.Prenom,
                Email = x.Email,
                //Cuisinier = x.Cuisinier,

            })
                .ToList();

                EmployeDgv.DataSource = EmployeAffiches;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }

        private void FormGestionEmploye_Load(object sender, EventArgs e)
        {
            affichageEmploye();
        }

        private void EmployeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

