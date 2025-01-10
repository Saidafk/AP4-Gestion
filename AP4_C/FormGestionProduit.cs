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
using AP4_C.Model;

namespace AP4_C
{
    public partial class FormGestionProduit : Form
    {
        public FormGestionProduit()
        {
            InitializeComponent();
        }

        private void FormGestionProduit_Load(object sender, EventArgs e)
        {
            affichagePlat();
        }

        public static List<Plat> listePlats()
        {
            return Modele.MonModel.Plats
                .Select(x => new Plat
                {
                    Idplat = x.Idplat,
                    Libelleplat = x.Libelleplat
                })
                .ToList();
        }

        private void affichagePlat()
        {
            try
            {
                var platsAffiches = Modele.MonModel.Plats
                .Select(x => new
                {
                    Id = x.Idplat,
                    Type = x.IdtypeplatNavigation.Typeplat1, 
                    Libelle = x.Libelleplat,
                    Quantité = x.Qte,
                    Prix = x.Prixplatht,
                    Végétarien = x.Veggie
                })
                .ToList();

                PlatDgv.DataSource = platsAffiches;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }

        private void PlatDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlGestionProduit_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
