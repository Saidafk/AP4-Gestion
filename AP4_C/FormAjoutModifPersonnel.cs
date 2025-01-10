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
    public partial class FormAjoutModifPersonnel : Form
    {
        private EtatGestion etat;
        public FormAjoutModifPersonnel()
        {
            InitializeComponent();
        }

        public void RemplirlesPersonnels()
        {
            cbPersonnel.ValueMember = "Idper";
            cbPersonnel.DisplayMember = "Nom";
            PersonnelBs.DataSource = (ModelePersonnel.listePersonnels()).Select(x => new { x.Idper, NomComplet = x.Nom });
            cbPersonnel.DataSource = PersonnelBs;
            cbPersonnel.SelectedIndex = -1;

        }

        private void cbPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (etat==EtatGestion.Update)
            {
                if (cbPersonnel.SelectedIndex != -1 && cbPersonnel.SelectedValue != null)
                {
                    int idPer = Convert.ToInt32(cbPersonnel.SelectedValue);
                    Plat P = ModelePlat.RetournePlat(idPer);
                    //gbInfo.Visible = true;
                }
                /*else
                {
                    //gbInfo.Visible = false;
                }

                if (cbPersonnel.SelectedValue != null)
                {
                    int idPer = cbPersonnel.SelectedValue;


                    var plat = ModelePersonnel.RetournePersonnel(idPer);

                    if (plat != null)
                    {

                        nomPlatTxt.Text = plat.Libelleplat;
                        prixTxt.Text = plat.Prixplatht.ToString();
                        cbVeggie.SelectedItem = plat.Veggie;
                        cbTypePlat.SelectedValue = plat.Idtypeplat;

                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données du plat.");
                    }
                }*/
            }
        }

        private void panelAjoutModif_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

