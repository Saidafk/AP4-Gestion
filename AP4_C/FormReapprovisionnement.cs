using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using AP4_C.Entities;
using AP4_C.Model;
using static AP4_C.FormMenu;    


namespace AP4_C
{
    public partial class FormReapprovisionnement : Form
    {
        private User idAuth;
        public FormReapprovisionnement(User idAuth)
        {
            InitializeComponent();
            this.idAuth = idAuth;
        }




        private void cbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsPlat_CurrentChanged(sender, e);
        }

        private void bsPlat_CurrentChanged(object sender, EventArgs e)
        {

            if (cbPlat.SelectedIndex != -1 && cbPlat.SelectedValue != null)
            {

                int idP = Convert.ToInt32(cbPlat.SelectedValue);
                Plat P = ModelePlat.RetournePlat(idP);

                int quantity = ModelePlat.RetourneQuantite(idP);
                txtQteStock.Text = quantity.ToString();

                gbInfo.Visible = true;
            }
            else
                gbInfo.Visible = false;
        }

        public void RemplirlesPlats()
        {
            cbPlat.ValueMember = "Idplat";//permet de stocker l'identifiant
            cbPlat.DisplayMember = "Libelleplat";
            bsPlat.DataSource = (ModelePlat.listePlats()).Select(x => new { x.Idplat, x.Libelleplat });
            cbPlat.DataSource = bsPlat;
            cbPlat.SelectedIndex = -1;

        }

        private void FormReapprovisionnement_Load(object sender, EventArgs e)
        {
            RemplirlesPlats();


            gbInfo.Visible = false;
            tbQte.Visible = true;
            cbPlat.Visible = true;

        }

        private void resetForm()
        {
            cbPlat.SelectedIndex = -1;
            tbQte.Clear();
            gbInfo.Visible = false;
        }

        private void resetCb()
        {         
            tbQte.Clear();
            
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbQte.Text, out int quantity) && !tbQte.Text.Contains('.'))
            {
                if (quantity > 1000)
                {
                    MessageBox.Show("On ne peut pas commander plus de 1000 plats à la fois");
                    resetCb();
                }
                else
                {
                    ulong idper = idAuth.Id;
                    int idplat = Convert.ToInt32(cbPlat.SelectedValue);
                    ModeleReap.AjouterReap(idper, idplat, quantity);
                    ModelePlat.AjouterPlat(idplat, quantity);
                    Plat P = ModelePlat.RetournePlat(idplat);
                    string nomPlat = P.Libelleplat;
                    MessageBox.Show($"Le plat '{nomPlat}' a bien été réapprovisionné.");
                    
                    resetForm();
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre entier valide sans virgule.");
                resetCb();
            }
        }

        private void pnlReap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbInfo_Enter(object sender, EventArgs e)
        {

        }

        private void tbQte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

