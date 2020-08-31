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
    public partial class frmFahrenheit : Form
    {
        double c, f;

        public frmFahrenheit()
        {
            InitializeComponent();
        }

        private void frmFahreneit_Load(object sender, EventArgs e)
        {
            btn2.Enabled = false;
            txt2.Enabled = false;
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            btn1.BackColor = Color.AliceBlue;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CalculoF_C();
            txt2.Text = Convert.ToString(Math.Round(c,2));
            btn2.Enabled = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void CalculoF_C ()
        {
            f = Convert.ToDouble(txt1.Text);
            c = (f - 32) / 1.8;
        }

        private void CalculoC_F()
        {
            c = Convert.ToDouble(txt2.Text);
            f = (c * 1.8) + 32;
        }


        private void Limpar()
        {
            txt2.Text = "";
            txt1.Clear();
        }

    }
}
