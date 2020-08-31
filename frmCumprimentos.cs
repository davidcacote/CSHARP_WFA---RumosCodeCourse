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
    public partial class frmCumprimentos : Form
    {
        public frmCumprimentos()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Clique();   
        }

        private void Clique()
        {
            string txtnome = txt1.Text;
            string txtsurnome = txt2.Text;

            lbl1.Text = txtnome + " " + txtsurnome;
            lbl1.Visible = true;
            btn2.Enabled = true;
        }
        private void Limpar()
        {
            txt1.Text = "";
            txt2.Text = "";
            lbl1.Visible = false;
            btn2.Enabled = false;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Limpar();       
        }

        private void frmCumprimentos_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue) == 13)
                {MessageBox.Show("Enter key pressed");
                Clique();
                }
            else if ((e.KeyValue) == 27)
                { MessageBox.Show("Campos limpos");
                Limpar();
            }
        }
    }
}
