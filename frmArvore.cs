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
    public partial class frmArvore : Form
    {
        string texto = "";
        public frmArvore()
        {
            InitializeComponent();
            Limpar();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            button1.Visible = true;
            label1.Text = "";
            this.Height = 251;
            this.Width = 391;
            texto = "";
            label1.Text = Arvore();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            label1.Visible = false;
            button1.Visible = false;
            label1.Text = "";
            this.Height = 142;
            this.Width = 164;
            texto = "";
        }

        private string Arvore()
        {
            
            for (int linha = 0; linha < Convert.ToInt16(UpDown.Text); linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    texto += $@"*";
                }
                texto += Environment.NewLine;
            }

            texto += "||" + Environment.NewLine + "||";
            return texto;
        }
    }
}
