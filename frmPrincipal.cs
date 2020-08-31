using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fahnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFahrenheit temps = new frmFahrenheit();
            temps.MdiParent = this;
            temps.Show();
        }

        private void cumprimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCumprimentos cumps = new frmCumprimentos();
            cumps.MdiParent = this;
            cumps.Show();
        }

        private void notaFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotaFinal mdiapp = new frmNotaFinal();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem a certeza que quer sair?","Sair da aplicação",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (DialogResult.Yes.Equals(true))
            {
                Application.Exit();
            }
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horzontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void nomeEEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNomeEmail mdiapp = new frmNomeEmail();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }

        private void queHorasSãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueHorasSao mdiapp = new frmQueHorasSao();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }

        private void quantoTempoPassouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuantoTempoPassou mdiapp = new frmQuantoTempoPassou();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }

        private void porRadioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioRadioButton mdiapp = new frmCambioRadioButton();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }

        private void checkedButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioCheckedBox mdiapp = new frmCambioCheckedBox();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }

        private void dropBoxButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioDropBox mdiapp = new frmCambioDropBox();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabuada mdiapp = new frmTabuada();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }

        private void arvoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArvore mdiapp = new frmArvore();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }

        private void hobbiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hobbiesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHobbies mdiapp = new frmHobbies();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }

        private void meusHobbiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMeusHobbies mdiapp = new frmMeusHobbies();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }

        private void ficheirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFicheiros mdiapp = new frmFicheiros();
            mdiapp.MdiParent = this;
            mdiapp.Show();
        }
    }
}
