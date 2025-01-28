using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP4_C.Entities;
using AP4_C.Model;
using Microsoft.VisualBasic.Logging;

namespace AP4_C
{
    public enum EtatGestion
    {
        Create,
        Update
    }

    public partial class FormModificationPlat : Form
    {

        private EtatGestion etat;

        public FormModificationPlat(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat;
        }

        private void ModificationPlat_Load(object sender, EventArgs e)
        {

            if (etat == EtatGestion.Create) // cas etat create
            {
                label1.Text = "Ajout d'un nouveau plat";
                button1.Text = "AJOUTER";
                ANNULER.Text = "ANNULER";
                gbInfo.Visible = true;
                nomPlatTxt.Visible = true;
                prixTxt.Visible = true;
                cbTypePlat.Visible = true;
                cbPlat.Visible = false;
                //cbVeggie.Items.Add(true);
                //cbVeggie.Items.Add(false);

            }
            else if (etat == EtatGestion.Update)
            {
                label1.Text = "Modification d'un plat";
                button1.Text = "MODIFIER";
                ANNULER.Text = "ANNULER";
                gbInfo.Visible = true;
                nomPlatTxt.Visible = true;
                prixTxt.Visible = true;
                cbTypePlat.Visible = true;
                //cbVeggie.Visible = true;
                cbPlat.Visible = true;
                //cbVeggie.Items.Add(true);
                //cbVeggie.Items.Add(false);
            }

            RemplirlesPlats();
            RemplirTypePlats();

        }

        public void RemplirlesPlats()
        {
            cbPlat.ValueMember = "Idplat";
            cbPlat.DisplayMember = "Libelleplat";
            listePlatBs.DataSource = (ModelePlat.listePlats()).Select(x => new { x.Idplat, x.Libelleplat });
            cbPlat.DataSource = listePlatBs;
            cbPlat.SelectedIndex = -1;

        }

        public void RemplirTypePlats()
        {
            cbTypePlat.ValueMember = "Idtypeplat";//permet de stocker l'identifiant
            cbTypePlat.DisplayMember = "Typeplat1";
            listeTypePlatBs.DataSource = (ModeleTypePlat.listeTypesPlats()).Select(x => new { x.Idtypeplat, x.Typeplat1 });
            cbTypePlat.DataSource = listeTypePlatBs;
            cbTypePlat.SelectedIndex = -1;
        }

        public void remplirVeggie()
        {

        }


        private void cbPlat_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (etat == EtatGestion.Update)
            {
                if (cbPlat.SelectedIndex != -1 && cbPlat.SelectedValue != null)
                {
                    int idP = Convert.ToInt32(cbPlat.SelectedValue);
                    Plat P = ModelePlat.RetournePlat(idP);
                    gbInfo.Visible = true;
                }
                else
                {
                    gbInfo.Visible = false;
                }

                if (cbPlat.SelectedValue != null)
                {
                    int idPlat = (int)cbPlat.SelectedValue;


                    var plat = ModelePlat.RetournePlat(idPlat);

                    if (plat != null)
                    {

                        nomPlatTxt.Text = plat.Libelleplat;
                        prixTxt.Text = plat.Prixplatht.ToString();
                        tbDescription.Text = plat.Description;
                        //cbVeggie.SelectedItem = plat.Veggie;
                        cbTypePlat.SelectedValue = plat.Idtypeplat;

                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données du plat.");
                    }
                }
            }
        }

        private void Annuler_Click()
        {

            nomPlatTxt.Text = "";
            prixTxt.Text = "";
            tbDescription.Text = "";
            cbTypePlat.SelectedIndex = -1;
            checkBoxVeggie.Checked = false;
            cbPlat.SelectedIndex = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbTypePlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypePlat.SelectedIndex != -1 && cbTypePlat.SelectedValue != null)
            {
                int idTP = Convert.ToInt32(cbTypePlat.SelectedValue);
                Typeplat TP = ModeleTypePlat.RetourneTypePlat(idTP);
            }
        }

        private void cbVeggie_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int idPlat;
            string Libelleplat = nomPlatTxt.Text;
            double Prixplatht = double.Parse(prixTxt.Text);
            bool Veggie = checkBoxVeggie.Checked;
            //bool Veggie = bool.Parse(cbVeggie.SelectedItem.ToString());
            string Description = tbDescription.Text;
            string? Lienimg = null;
            int Idtypeplat = (int)cbTypePlat.SelectedValue;
            int Qte = 0;
            int Idrestau = 1;

            if (etat == EtatGestion.Create)
            {
                if (string.IsNullOrEmpty(Libelleplat) || Prixplatht <= 0 || Idtypeplat <= 0)
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires");
                    return;
                }

                if (ModelePlat.AjouterNouveauPlat(Libelleplat, Idtypeplat, Qte, Prixplatht, Veggie, Lienimg, Idrestau, Description))
                {
                    MessageBox.Show("Plat ajouté");
                    RemplirlesPlats();
                    Annuler_Click();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du plat");
                }
            }

            else if (etat == EtatGestion.Update)
            {
                if (cbPlat.SelectedValue != null)
                {
                    idPlat = (int)cbPlat.SelectedValue;

                    //idPlat = Convert.ToInt32(cbPlat.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un plat à modifier.");
                    return;
                }

                if (ModelePlat.ModifierPlat(idPlat, Libelleplat, Idtypeplat, Qte, Prixplatht, Veggie, Lienimg, Idrestau))
                {
                    MessageBox.Show("Plat modifié");
                    RemplirlesPlats();
                    Annuler_Click();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ANNULER_Click(object sender, EventArgs e)
        {
            Annuler_Click();
        }
    }
}
