using AP4_C.Entities;
using AP4_C.Model;
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

namespace AP4_C
{

    public enum EtatGestionEmploye
    {
        CreateEmploye,
        UpdateEmploye
    }
    public partial class FormAjoutModifPersonnel : Form
    {
        private EtatGestionEmploye etatemploye;
        public FormAjoutModifPersonnel(EtatGestionEmploye etatemploye)
        {
            InitializeComponent();
            this.etatemploye = etatemploye;
            
        }

        private void FormAjoutModifPersonnel_Load(object sender, EventArgs e)
        {

            if (etatemploye == EtatGestionEmploye.CreateEmploye) // cas etat create
            {
                //label1.Text = "Ajout d'un nouveau plat";
                //button1.Text = "AJOUTER";
                
                //nomPlatTxt.Visible = true;
                //prixTxt.Visible = true;
                cbEmploye.Visible = false;
                //cbPlat.Visible = false;
                //cbVeggie.Items.Add(true);
                //cbVeggie.Items.Add(false);

            }
            else if (etatemploye == EtatGestionEmploye.UpdateEmploye)
            {
                //label1.Text = "Modification d'un plat";
                //button1.Text = "MODIFIER";
                //gbInfo.Visible = true;
                //nomPlatTxt.Visible = true;
                //prixTxt.Visible = true;
                cbEmploye.Visible = true;
                //cbVeggie.Visible = true;
                //cbPlat.Visible = true;
                //cbVeggie.Items.Add(true);
                //cbVeggie.Items.Add(false);
                RemplirlesEmploye();
            }

            

        }

        public void RemplirlesEmploye()
        {
            
            cbEmploye.ValueMember = "Id";
            cbEmploye.DisplayMember = "NomComplet";
            EmployeBS.DataSource = (ModelEmploye.listeEmployes()).Select(x => new { x.Id, NomComplet = x.Nom+" "+x.Prenom });
            cbEmploye.DataSource = EmployeBS;
            cbEmploye.SelectedIndex = -1;

        }

        private void cbPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (etatemploye==EtatGestionEmploye.UpdateEmploye)
            {
                if (cbEmploye.SelectedIndex != -1 && cbEmploye.SelectedValue != null)
                {
                    ulong idEmploye = Convert.ToUInt64(cbEmploye.SelectedValue);
                    Employe E = ModelEmploye.RetourneEmploye(idEmploye);
                    cbEmploye.Visible = true;

                    //gbInfo.Visible = true;
                }
                /*else
                {
                    //gbInfo.Visible = false;
                }
                */
                if (cbEmploye.SelectedValue != null)
                {
                    ulong idEmp;
                    idEmp = (ulong)cbEmploye.SelectedValue;

                    var employe = ModelEmploye.RetourneEmploye(idEmp);

                    if (employe != null)
                    {

                        /*nomPlatTxt.Text = plat.Libelleplat;
                        prixTxt.Text = plat.Prixplatht.ToString();
                        cbVeggie.SelectedItem = plat.Veggie;
                        cbTypePlat.SelectedValue = plat.Idtypeplat;*/

                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données du plat.");
                    }
                }
            }
        }

        
        
    }
}

