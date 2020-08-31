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
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
            label1.Text = "";
            label1.Visible = false;
            button1.Visible = false;
            this.Height = 190;
        }

        string texto;

        private void btn_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            button1.Visible = true;
            this.Height = 340;
            label1.Text = Tabuada();
        }

        private string Tabuada()
        {
            int resultado;
            for (int i = 1; i <= 10; i++)
            {
                resultado = i * Convert.ToInt32(comboBox1.Text);
                texto += i + " x " + comboBox1.Text + " = " + resultado + "\n";
            }
            return texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Visible = false;
            this.Height = 190;
            button1.Visible = false;
        }
    }
}
