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

        public void RemplirlesEmploye()
        {
            cbEmploye.ValueMember = "Idper";
            cbEmploye.DisplayMember = "Nom";
            EmployeBS.DataSource = (ModelEmploye.listeEmployes()).Select(x => new { x.Idper });
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

        private void panelAjoutModif_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAjoutModifPersonnel_Load(object sender, EventArgs e)
        {

            if (etatemploye == EtatGestionEmploye.UpdateEmploye)
            {
                RemplirlesEmploye();
            }
        }
    }
}

