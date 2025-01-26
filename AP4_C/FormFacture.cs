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
    public partial class FormFacture : Form
    {
        public FormFacture()
        {
            InitializeComponent();
        }

        public void RemplirFacture()
        {

            cbFacture.ValueMember = "Idfacture"; // permet de stocker l'identifiant
            cbFacture.DisplayMember = "Idfacture"; // affiche l'identifiant
            bsFacture.DataSource = ModeleFacture.listeFacture().Select(x => new { x.Idfacture }).ToList();
            cbFacture.DataSource = bsFacture;
            cbFacture.SelectedIndex = -1;
        }
     

        private void cbFacture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFacture.SelectedIndex != -1 && cbFacture.SelectedValue != null)
            {

                int idF = Convert.ToInt32(cbFacture.SelectedValue);
                Facture F = ModeleFacture.RetourneFacture(idF);
                gbInfoFacture.Visible = true;
            }
            else
            {
                gbInfoFacture.Visible = false;
            }

            if (cbFacture.SelectedValue != null)
            {
                int idFacture = (int)cbFacture.SelectedValue;

                var facture = ModeleFacture.RetourneFacture(idFacture);

                if (facture != null)
                {
                    cbTicket.Text = facture.Idfacture.ToString();
                    dtpDateFacture.Value = facture.Datefacture;
                    cbTable.Text = facture.IdTable.ToString();
                    //tbCommande.Text = facture.Description;
                    //tbPrix.Text = facture.Prix.ToString();
                    //tbTTC.Text = facture.Prix.ToString();
                    //tbTVA.Text = facture.Prix.ToString();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la récupération de la facture.");
                }
            }
        }

        private void FormFacture_Load(object sender, EventArgs e)
        {
            RemplirFacture();

        }
    }
}

