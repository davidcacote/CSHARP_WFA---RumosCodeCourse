using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmNomeEmail : Form
    {
        public frmNomeEmail()
        {
            InitializeComponent();
        }

        public void btn1_see_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txtbox1.Text;
                string[] nomes = nome.Split(' ');

                string primeironome = nomes[0];
                string ultimonome = nomes[(nomes.Length) - 1];

                lbl_nome.Text = Util.Classe1.NomeCurto(primeironome, ultimonome);
                lbl_email1.Text = Util.Classe1.Email1(primeironome, ultimonome);
                lbl_email2.Text = Util.Classe1.Email2(primeironome, ultimonome);
                txtbox1.Text = Util.Classe1.RetiraEspacos(txtbox1.Text);


                lbl_nome.Visible = true;
                lbl_email1.Visible = true;
                lbl_email2.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo de texto de preenchimento obrigatótio");
            }
            
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            lbl_nome.Visible = false;
            lbl_email1.Visible = false;
            lbl_email2.Visible = false;
            txtbox1.Clear();
        }
    }
}
