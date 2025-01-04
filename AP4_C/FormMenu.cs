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
using  AP4_C.Controller;
using AP4_C.Entities;

namespace AP4_C
{
    public partial class FormMenu : Form
    {
        private User idAuth;
        public FormMenu(User idAuth)
        {
            InitializeComponent();
            this.idAuth = idAuth;
        }
        public User GetIdAuth()
        {
            return idAuth;
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FormConnexion Connexion = new FormConnexion();
            Connexion.Show();
            this.Hide();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(pnlMenu);
            SF.openChildForm(new FormReapprovisionnement(idAuth));
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(pnlMenu);
            SF.openChildForm(new FormGestionProduit());
        }

        private void modificationDesPlatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(pnlMenu);
            SF.openChildForm(new FormModificationPlat(EtatGestion.Create));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(pnlMenu);
            SF.openChildForm(new FormFacture());

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void gestionDesEmployésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(pnlMenu);
            SF.openChildForm(new FormGestionEmploye());
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void modificationDunPlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SousFormulaire SF = new SousFormulaire(pnlMenu);
            SF.openChildForm(new FormModificationPlat(EtatGestion.Update));
        }
    }
}
