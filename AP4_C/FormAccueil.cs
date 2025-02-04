using AP4_C.Controller;
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
    public partial class FormAccueil : Form
    {
        Panel panel;
        SousFormulaire SF;
        public FormAccueil(Panel panel)
        {
            this.panel = panel;
            InitializeComponent();
            SF = new SousFormulaire(panel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SF.openChildForm(new FormReserver());
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            SF.openChildForm(new FormReserver());
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            SF.openChildForm(new FormFacture());
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            SF.openChildForm(new FormGestionProduit());
        }

        private void btnEmployes_Click(object sender, EventArgs e)
        {
            SF.openChildForm(new FormGestionEmploye());
        }
    }
}
