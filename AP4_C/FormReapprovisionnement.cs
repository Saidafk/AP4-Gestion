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
                // récupération du membre sélectionné

                int idP = Convert.ToInt32(cbPlat.SelectedValue);
                Plat P = ModelePlat.RetournePlat(idP);
                // mise à jour des champs du membre sélectionné


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


        private void btnAjouter_Click(object sender, EventArgs e)

        {
            ulong idper = idAuth.Id;
            int idplat = Convert.ToInt32(cbPlat.SelectedValue);
            int Qtereap = Convert.ToInt32(tbQte.Text);
            ModeleReap.AjouterReap(idper, idplat, Qtereap);

            resetForm();
        }

        private void pnlReap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}

